using System; //allows direct access to the console type system
using System.Windows.Forms; //access the classes which create Windows-based applications incorporating rich user interfaces 
using nsZBRPrinter; //allows access to zebra-specific controls
using System.Drawing.Printing; //Defines a reusable object that sends output to a printer, when printing from a Windows Forms application
using System.Linq;

namespace IDPrinter {
    public partial class FrmMain : Form {
        #region Global Variables
        //variables to display the current graphics and printer software versions & to hold the file path location for stored user images for import
        private string graphicsSDKVersion, printerSDKVersion, userSelectedFilePath;
        #endregion

        #region Anything that happens on load up
        public FrmMain() { //no-arg constructor
            InitializeComponent(); //handles the initialization of the forms controls on load up
            AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Directory.GetCurrentDirectory());
        }

        private void FrmMain_Load(object sender, EventArgs e) { //parameterized load event
            GetSDKVersions(); //calls to method to retrieve current SDK software versions
            CheckForPrinters(); //calls to method to check for printers found and populate drop-down list
            userImageBox.ImageLocation = Application.StartupPath + "\\Default User.png";
            //loads default 'anonymous' photo on the Add User form
        }
        #endregion

        #region Grab Printers
        private void CheckForPrinters() { //method to check for any printers available for use
            try {
                cbPrinters.Items.Clear();//clears the listed printers drop-down box
                foreach (String printerName in PrinterSettings.InstalledPrinters) //loops through all located printers, storing the retrieved information in array elements
                    cbPrinters.Items.Add(printerName); //populates the drop-down list with all available printers found
                cbPrinters.Sorted = true; //sorts the items in the drop-down menu in case-insensitive and alphabetically ascending order
                cbPrinters.SelectedIndex = -1; //The index of first item in the current selection. The default value is -1
            } catch (Exception e) { //exception handler
                MessageBox.Show(e.ToString()); //catches and displays resulting errors to prevent program crash
            }
        }
        #endregion

        #region Get SDK Info
        private void GetSDKVersions() {
            GraphicCode graphics; //creates graphics variable from the GraphicsCode.cs class
            try {
                graphics = new GraphicCode(); //creates new GraphicCode object and stores in graphics
                graphicsSDKVersion = graphics.GetSDKGraphicsVersion();
                //calls the getSDKGraphicsVersion method of graphics object to determine graphics major, minor and engine level DLL versions and stores results in graphicsSDKVersion
                printerSDKVersion = graphics.GetSDKPrinterVersion();
                //calls the getSDKPrinterVersion method of graphics object to determine printer major, minor, and engine level DLL version and stores results in printerSDKVersion
                lblGraphicsVersion.Text = "Graphics Version: " + graphicsSDKVersion; //displays the information stored in graphisSDKVersion in lblGraphicsVersion on About tab
                lblPrinterVersion.Text = "Printer Version: " + printerSDKVersion; //displays the information stored in printerSDKVersion in lblPrinterVersion on About tab
            } catch (Exception e) { //exception handler
                MessageBox.Show(e.ToString(), "Broc Screwed up the SDK Version Grabber"); //catches and displays resulting errors to prevent program crash
            } finally { //finally block runs whether there is an exception or not
                graphics = null; //sets graphics object to null after it has been used to obtain graphics and printer verion information
            }
        }
        #endregion

        #region Printer Ready Check
        private bool PrinterReadyToStart(string driverName, int timeoutInSeconds) {
            //boolean method to test whether the printer is ready to start using driverName and timeoutInSeconds parameters
            GraphicCode graphics;//creates graphics variable from the GraphicsCode.cs class
            try {
                graphics = new GraphicCode(); //creates new GraphicCode object and stores in graphics
                return graphics.IsPrinterBusy(driverName, timeoutInSeconds); //returns true or false
            } catch (Exception e) { //exception handler
                MessageBox.Show(e.ToString());//catches and displays resulting errors to prevent program crash
            } finally { //finally block runs whether there is an exception or not
                graphics = null; //sets graphics object to null after it has finished being used
            }
            return false;
        }

        private bool IsPrinterAvailable(string driverName) {
            //boolean method to test whether the printer is available using driverName parameter
            ZBRPrinter printer = null; //creates printer variable from the ZBRPrinter.cs class initialized to null
            try {
                printer = new ZBRPrinter(); //creates new ZBRPrinter object and stores in printer
                int error = 0; //initial value of errors is 0 meaning printer is available, but will change if errors are detected

                int result = printer.Open(driverName, out error); //passes IsPrinterAvailable method param as an argument to Open method of printer object and stores in result variable
                if ((result == 1) && (error == 0)) { //if the result variable is set to 1 and there are no errors...
                    return true; //return true - the printer is available
                }
            } catch (Exception e) { //exception handler
                MessageBox.Show(e.ToString()); //catches and displays resulting errors to prevent program crash
            } finally { //finally block runs whether there is an exception or not
                printer = null; //sets printer object to null after it has been used to determine if printer is available
            }
            return false; //else return false - the printer is unavailable
        }
        #endregion

        #region Print is clicked
        private void btnPrintID_Click(object sender, EventArgs args) { //click event for Print ID button on Add User tab
            string message = ""; //string variable message initialized to an empty string
            

            GraphicCode graphics = null; //creates graphics variable from the GraphicsCode.cs class initialized to null

            lblStatus.Text = ""; //on Add User tab - initializes Status label text property to an empty string
            Refresh(); //call the base class's refresh method so the control and its child controls are invalidated and redrawn
            Application.DoEvents(); //Application provides static methods and properties to manage an application. Begins running a standard application message loop on the...
                                    //...current thread, which enables the form to receive Windows messages to allow it to appear responsive and have interaction with the user
            try {
                 if (cbPrinters.SelectedIndex < 0) {//check the selected index of printers dropdown box on Add User tab, if less than 0...
                     message = "No printer selected."; //store string "No printer selected" in message variable
                     return; //return results displaying message that no printer is selected
                 }
                 if (!IsPrinterAvailable(cbPrinters.Text)) { //check text of cbPrinters drop-down, if the not of printers available...
                     message = "Printer is not available."; //store string "Printer is not available" in message variable
                     return;  //return results displaying message that no printer is available
                 }

                 //~~~~~~~(NOTE)~~~~~~~~~~~~
                 //~~~***!!!*** need to check first if all forms are filled out
                 //~~~***!!!*** do later
                 //~~~~~~~~~~~~~~~~~~~~~~~~~

                 graphics = new GraphicCode(); //creates new GraphicCode object and stores in graphics 
                 graphics.Print(cbPrinters.Text, txtFirstName.Text + " " + txtLastName.Text, "1234567890", userSelectedFilePath, cbAdmin.Checked, out message);
                 //call Print method of graphics object and pass (string driverName, string name, string userID, string userPicture, bool admin, bool back, string[] disclaimerSplit, out string msg)
                 if (message == "") { //if message string is empty, nothing is determined to have prevented the printer from functioning
                     PrinterReadyToStart(cbPrinters.Text, 60); //call to PrinterReadyToStart method passing user selected printer driver user selected from drop-down list on Add User tab, and 60 second timeout value
                     lblStatus.Text = "Printing the ID"; //change Status label on Add User tab to display "Printing the ID"
                 }
                 
                string isAdmin;

                if(cbAdmin.Checked == true) {
                    isAdmin = "1";
                } else {
                    isAdmin = "0";
                }
                Database.addUser(txtFirstName.Text, txtLastName.Text, txtStreet.Text, txtCity.Text, cbState.Text, txtZip.Text, txtPhone.Text, userSelectedFilePath, isAdmin);
                Console.WriteLine("add query was ran");
            } catch (Exception e) { //exception handler
                message += e.Message; //add the value of e.message to message string
                MessageBox.Show(e.ToString()); //use a message box to display the results of exception variable e as a string
            } finally { //finally block runs whether there is an exception or not
                if (message != "") { //if message string variable has changed to anything other than the initialized empty string...
                    lblStatus.Text = message; //set the Status label to display the contents of message string
                }
                graphics = null; //sets graphics object to null after it has finished being used
            }
        }
        #endregion

        #region Delete User is Clicked
        private void btnDeleteUser_click(object sender, EventArgs e) {
            string[] data = Database.checkUser(txtDeleteUser.Text);
            DialogResult result = MessageBox.Show("Do you want to delete the user:\n" + data[0] + " - " + data[1] + " " + data[2] + "?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                if (data[0] == txtDeleteUser.Text) {
                    Database.deleteUser(txtDeleteUser.Text);
                    Refresh();
                } else {
                    MessageBox.Show("User does not exist.");
                }
            } else {
                MessageBox.Show("User deletion canceled.");
            }
        }



        #endregion

        #region User Picture Insert
        private void btnUserPicture_Click(object sender, EventArgs e) { //click event for Insert Picture button on Add User tab
            System.Windows.Forms.DialogResult dr = openUserImage.ShowDialog(); //dr variable represents the result of the form when used as a dialog box with ShowDialog method of openUserImage
            if (dr == DialogResult.OK) {//if OK button is selected
                userSelectedFilePath = openUserImage.InitialDirectory + openUserImage.FileName; //obtain and store the image filepath into userSelectedFilePath variable
                lblImageLocation.Text = userSelectedFilePath; //display the contents of userSelectedFilePath as a string in lblImagelocation label on Add User tab
                userImageBox.ImageLocation = userSelectedFilePath; //display the user selected image in the image box in place of the default 'anonymous' image
            }
        }

        private void btnPreviewID_Click(object sender, EventArgs e) { //click event for Preview ID button on Add User tab
            FrmPreview preview = new FrmPreview(); //creates new FrmPreview object and stores in FrmPreview variable preview
            preview.Show(); //displays the control to the user
            string fullName = txtFirstName.Text + " " + txtLastName.Text; //stores first name and last name user input entered on Add User tab into string variable fullName
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
        //***NOTE*** This is solely for testing purposes
        private void button1_Click(object sender, EventArgs e) { //click event for Read/Write test button on Add User tab
            MagneticStripCode readWriter; //creates readWriter variable from the MagneticStripCode.cs class
            try {
                readWriter = new MagneticStripCode(); //creates new MagneticStripcCode object and stores in readWriter
                readWriter.eraseCardData();
            } catch (Exception ex) { //exception handler
                MessageBox.Show(ex.ToString(), "Broc Screwed up the card writer."); //catches and displays resulting errors to prevent program crash
            } finally { //finally block runs whether there is an exception or not
                readWriter = null; //sets readWriter object to null after it has been used
            }
        }
        private void button3_Click(object sender, EventArgs e) { //click event for Read/Write test button on Add User tab
            MagneticStripCode readWriter; //creates readWriter variable from the MagneticStripCode.cs class
            try {
                readWriter = new MagneticStripCode(); //creates new MagneticStripcCode object and stores in readWriter
                readWriter.readCardData();
            } catch (Exception ex) { //exception handler
                MessageBox.Show(ex.ToString(), "Broc Screwed up the card writer."); //catches and displays resulting errors to prevent program crash
            } finally { //finally block runs whether there is an exception or not
                readWriter = null; //sets readWriter object to null after it has been used
            }
        }
        private void button4_Click(object sender, EventArgs e) { //click event for Read/Write test button on Add User tab
            MagneticStripCode readWriter; //creates readWriter variable from the MagneticStripCode.cs class
            try {
                readWriter = new MagneticStripCode(); //creates new MagneticStripcCode object and stores in readWriter
                readWriter.writeCardData();
            } catch (Exception ex) { //exception handler
                MessageBox.Show(ex.ToString(), "Broc Screwed up the card writer."); //catches and displays resulting errors to prevent program crash
            } finally { //finally block runs whether there is an exception or not
                readWriter = null; //sets readWriter object to null after it has been used
            }
        }
        #endregion

        #region Clear form
        private void btnClear_Click(object sender, EventArgs e) { //clear button on Add User tab
            txtFirstName.Clear(); //clears the first name textbox
            txtLastName.Clear(); //clears the last name textbox
            txtPhone.Clear(); //clears the phone number textbox
            txtStreet.Clear(); //clears the street textbox
            txtCity.Clear(); //clears the city textbox
            txtZip.Clear(); //clears the zipcode textbox
            cbAdmin.Checked = false; //unckecks the admin checkbox
            cbState.SelectedIndex = -1; //Resets the index of first item in the current selection to the default value of -1
            userImageBox.ImageLocation = Application.StartupPath + "\\Default User.png"; //resets the image to the default 'anonymous' image
            txtFirstName.Focus(); //resets the focus to the First Name textbox if she form clear button is clicked
        }


        private void btnCheckForUser_Click(object sender, EventArgs e) {
            string userID = tbCheckForUser.Text;
            try {
                //string value = Database.updateUser("1000000002", "Calebdddd", "Mann", "your moms house", "Blountville", "TN", "37617", "4234161471", "","1");
                int value = Database.updateUser("1000000002", "Broc");
                Console.WriteLine(value.ToString());
            } catch (Exception er) {
                MessageBox.Show(er.ToString());
            } finally {

            }
        }


        #endregion

        #region Set initial focus for different tabs
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) { //click events for tabControl to set focus depending upon which tab is selected
            if (tabControl1.SelectedTab == tabAddUser) { //if AddUser tab is selected, set focus to First Name textbox
                txtFirstName.Focus(); //sets focus to txtFirstName
            }
            if (tabControl1.SelectedTab == tabDeleteUser) {   //if Disclaimer tab is selected, set focus to Disclaimer textbox
                txtDeleteUser.Focus(); //sets focus to rtbDsisclaimer
            }

        }
        #endregion

    }
}