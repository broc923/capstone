using System;
using System.Windows.Forms;
using nsZBRPrinter;
using System.Drawing.Printing;

namespace IDPrinter {
    public partial class FrmMain : Form {
        #region Global Variables
        private string graphicsSDKVersion, printerSDKVersion, userSelectedFilePath;
        #endregion

        #region Anything that happens on load up
        public FrmMain() {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e) {
            GetSDKVersions();
            CheckForPrinters();
            userImageBox.ImageLocation = Application.StartupPath + "\\Default User.png";
        }
        #endregion

        #region Grab Printers
        private void CheckForPrinters() {
            try {
                cbPrinters.Items.Clear();
                foreach (String printerName in PrinterSettings.InstalledPrinters)
                    cbPrinters.Items.Add(printerName);
                cbPrinters.Sorted = true;
                cbPrinters.SelectedIndex = -1;
            } catch (Exception e) {
                MessageBox.Show(e.ToString());
            }
        }
        #endregion

        #region Get SDK Info
        private void GetSDKVersions() {
            GraphicCode graphics;
            try {
                graphics = new GraphicCode();
                graphicsSDKVersion = graphics.GetSDKGraphicsVersion();
                printerSDKVersion = graphics.GetSDKPrinterVersion();
                lblGraphicsVersion.Text = "Graphics Version: " + graphicsSDKVersion;
                lblPrinterVersion.Text = "Printer Version: " + printerSDKVersion;
            } catch (Exception e) {
                MessageBox.Show(e.ToString(), "Broc Screwed up the SDK Version Grabber");
            } finally { 
                graphics = null;
            }
        }
        #endregion

        #region Printer Ready Check
        private bool PrinterReadyToStart (string driverName, int timeoutInSeconds) {
            GraphicCode graphics;
            try {
                graphics = new GraphicCode();
                return graphics.IsPrinterBusy(driverName, timeoutInSeconds); //returns true or false
            } catch (Exception e) {
                MessageBox.Show(e.ToString());
            } finally {
                graphics = null;
            }
            return false;
        }

        private bool IsPrinterAvailable (string driverName) {
            ZBRPrinter printer = null;
            try {
                printer = new ZBRPrinter();
                int error = 0;

                int result = printer.Open(driverName, out error);
                if ((result == 1) && (error == 0)) {
                    return true;
                }
            } catch (Exception e) {
                MessageBox.Show(e.ToString());
            } finally {
                printer = null;
            }
            return false;
        }
        #endregion

        #region Print is clicked
        private void btnPrintID_Click(object sender, EventArgs args) {
            string message = "";
            string disclaimer = rtbDisclaimer.Text;

            string[] disclaimerSplit = disclaimer.Split('|');

            label14.Text = disclaimer;

            GraphicCode graphics = null;

            lblStatus.Text = "";
            Refresh();
            Application.DoEvents();
            try {
                if (cbPrinters.SelectedIndex < 0) {
                    message = "No printer selected.";
                    return;
                }
                if (!IsPrinterAvailable(cbPrinters.Text)) {
                    message = "Printer is not available.";
                    return;
                }
                //need to check first if all forms are filled out
                //do later
                graphics = new GraphicCode();
                graphics.Print(cbPrinters.Text, txtFirstName.Text + " " + txtLastName.Text, "1", userSelectedFilePath, cbAdmin.Checked, false, new string[0], out message);
                graphics.Print(cbPrinters.Text, "", "1", "", cbAdmin.Checked, true, disclaimerSplit, out message);
                if (message == "") {
                    PrinterReadyToStart(cbPrinters.Text, 60);
                    lblStatus.Text = "Printing the ID";
                }
            } catch (Exception e) {
                message += e.Message;
                MessageBox.Show(e.ToString());
            } finally {
                if (message != "") {
                    lblStatus.Text = message;
                }
                graphics = null;
            }
        }
        #endregion

        #region User Picture Insert
        private void btnUserPicture_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult dr = openUserImage.ShowDialog();
            if (dr == DialogResult.OK) {
                userSelectedFilePath = openUserImage.InitialDirectory + openUserImage.FileName;
                lblImageLocation.Text = userSelectedFilePath;
                userImageBox.ImageLocation = userSelectedFilePath;
            }
        }

        private void btnPreviewID_Click(object sender, EventArgs e) {
            FrmPreview preview = new FrmPreview();
            preview.Show();
            string fullName = txtFirstName.Text + " " + txtLastName.Text;
            //preview.DisplayInfo(fullName);
        }

        /**private void txtFirstName_TextChanged(object sender, EventArgs e) {
            FrmPreview preview = null;
            string fullName = txtFirstName.Text + " " + txtLastName.Text;
            try {
                preview = new FrmPreview();
                preview.lblName.Text = fullName;
                preview.Update();

            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            } finally {
                preview = null;
            }
        }**/

        #endregion

        #region Testing 
        private void button1_Click(object sender, EventArgs e) {
            MagneticStripCode readWriter;
             try {
                 readWriter = new MagneticStripCode();
                 readWriter.SendComData();

             } catch (Exception ex) {
                 MessageBox.Show(ex.ToString(), "Broc Screwed up the card writer.");
             } finally {
                 readWriter = null;
             }
        }
        #endregion

        #region Clear form
        private void btnClear_Click(object sender, EventArgs e) {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtStreet.Clear();
            txtCity.Clear();
            txtZip.Clear();
            cbAdmin.Checked = false;
            cbState.SelectedIndex = -1;
            userImageBox.ImageLocation = Application.StartupPath + "\\Default User.png";
        }
        #endregion
    }
}
