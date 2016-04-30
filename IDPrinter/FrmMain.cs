using System; //allows direct access to the console type system
using System.Windows.Forms; //access the classes which create Windows-based applications incorporating rich user interfaces 
using nsZBRPrinter; //allows access to zebra-specific controls
using System.Drawing.Printing; //Defines a reusable object that sends output to a printer, when printing from a Windows Forms application
using System.Text.RegularExpressions;
using System.Collections;
using Excel = Microsoft.Office.Interop.Excel;


namespace IDPrinter {
    public partial class FrmMain : Form {
        #region Global Variables
        //variables to display the current graphics and printer software versions & to hold the file path location for stored user images for import
        //holds the deletion ID variable for users to be deleted
        private string graphicsSDKVersion, printerSDKVersion, userSelectedFilePath = "", deletionID;
        public static string comPort = ""; //Public com port name
        #endregion

        #region Anything that happens on load up
        public FrmMain() { //no-arg constructor
            InitializeComponent(); //handles the initialization of the forms controls on load up
        }

        private void FrmMain_Load(object sender, EventArgs e) { //parameterized load event
            GetSDKVersions(); //calls to method to retrieve current SDK software versions
            CheckForPrinters(); //calls to method to check for printers found and populate drop-down list
            userImageBox.ImageLocation = Application.StartupPath + "\\Default User.png"; //Add user page default image
            pbUserPic.ImageLocation = Application.StartupPath + "\\Default User.png"; //Delete user page default image
            //loads default 'anonymous' photo on the Add User form
            comPort = MagneticStripCode.getComPort(); //Grabs the com port that the EzWriter is connected to
            
            Console.WriteLine(comPort);
            foreach (TabPage tab in tabControl1.TabPages) { //Disables all tabs
                tab.Enabled = false;
            }
            tabControl1.TabPages[0].Enabled = true; //except the first tab by default

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
                MessageBox.Show(e.ToString(), "SDK Version Grabber had errors. Please contact an administrator."); //catches and displays resulting errors to prevent program crash
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

                string nullMessage = ""; //Holds what we return to the user

                if (txtFirstName.Text == "") { //If first name field is empty
                    nullMessage += "No data has been entered for First Name.\n";
                }
                if (txtLastName.Text == "") { //If last name field is empty
                    nullMessage += "No data has been entered for Last Name.\n";
                }
                if (txtStreet.Text == "") { //If street field is empty
                    nullMessage += "No data has been entered for Street.\n";
                }
                if (txtCity.Text == "") { //If city field is empty
                    nullMessage += "No data has been entered for City.\n";
                }
                if (cbState.Text == "") { //If state field is empty
                    nullMessage += "No State has been selected.\n";
                }
                if (txtZip.Text == "") { //If zip field is empty
                    nullMessage += "No data has been entered for Zip Code.\n";
                }
                if (txtPhone.Text == "") { //If phone field is empty
                    nullMessage += "No data has been entered for Phone Number.\n";
                }
                if (userSelectedFilePath == "") { //If user image field is empty
                    nullMessage += "No image has been selected.\n";
                }

                if (nullMessage != "") { //If null message is set
                    MessageBox.Show(nullMessage);
                } else { //If null message was not set

                    graphics = new GraphicCode(); //creates new GraphicCode object and stores in graphics 
                    //call Print method of graphics object and pass (string driverName, string name, string userID, string userPicture, bool admin, bool back, string[] disclaimerSplit, out string msg)
                    graphics.Print(cbPrinters.Text, txtFirstName.Text + " " + txtLastName.Text, (Database.newUser() + 1).ToString(), userSelectedFilePath, cbAdmin.Checked, out message);
                    if (message == "") { //if message string is empty, nothing is determined to have prevented the printer from functioning
                        PrinterReadyToStart(cbPrinters.Text, 60); //call to PrinterReadyToStart method passing user selected printer driver user selected from drop-down list on Add User tab, and 60 second timeout value
                        lblStatus.Text = "Printing the ID"; //change Status label on Add User tab to display "Printing the ID"
                    }

                    string isAdmin; //Is the user an admin format string.

                    if (cbAdmin.Checked == true) {
                        isAdmin = "1"; //Is admin
                    } else {
                        isAdmin = "0"; //Is not admin
                    }
                    //Adds the user to the database(first name, last name, street, city, state, zip, phone number, user image, is an admin)
                    Database.addUser(txtFirstName.Text, txtLastName.Text, txtStreet.Text, txtCity.Text, cbState.Text, txtZip.Text, txtPhone.Text, userSelectedFilePath, isAdmin);
                    Console.WriteLine("add query was ran");
                    //Messagebox to wait for the user to press okay before trying to write data to the card
                    DialogResult result = MessageBox.Show("Press okay and wait for the orange light on the EZWriter, then slide your card.", "Confirmation", MessageBoxButtons.OK);
                    if (result == DialogResult.OK) { //Picked ok
                        MagneticStripCode.writeCardData(Database.newUser().ToString()); //Writes card data
                    } else {
                        Database.deleteUser(Database.newUser().ToString()); //Delete user that was added
                        MessageBox.Show("User was not created. Please retry.");
                    }

                }
            } catch (Exception e) { //exception handler
                message += e.Message; //add the value of e.message to message string
                MessageBox.Show(e.ToString()); //use a message box to display the results of exception variable e as a string
            } finally { //finally block runs whether there is an exception or not
                if (message != "") { //if message string variable has changed to anything other than the initialized empty string...
                    lblStatus.Text = message; //set the Status label to display the contents of message string
                }
                graphics = null; //sets graphics object to null after it has finished being used
                FrmMain_Load(sender, args);
            }
        }
        #endregion

        #region Delete User page
        private void btnLookup_Click(object sender, EventArgs e) { //Click to lookup a user
            deletionID = txtDeleteUser.Text; //Sets deletion ID
            if (deletionID != "") {
                string[] data = Database.checkUser(deletionID); //All user's data database check
                txtName.Text = data[1] + " " + data[2]; //Name
                lblID.Text = "User ID: " + data[0]; //User's ID
                txtAddress.Text = data[3] + " " + data[4] + ", " + data[5] + " " + data[6]; //address
                txtNumber.Text = data[7]; //Phone number
                pbUserPic.ImageLocation = data[8]; //Picture
            }

        }

        private void btnDeleteUser_click(object sender, EventArgs e) {
            if (deletionID != "") {
                string[] data = Database.checkUser(deletionID); //All user's data for the ID being deleted
                //Make sure you want to delete the user
                DialogResult result = MessageBox.Show("Do you want to delete the user shown?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) {
                    if (data[0] == txtDeleteUser.Text) {
                        Database.deleteUser(deletionID); //Delete user
                        Refresh();
                    } else {
                        MessageBox.Show("User does not exist.");
                    }
                } else {
                    MessageBox.Show("User deletion canceled.");
                }
            }
        }



        #endregion

        #region User Picture Insert
        private void btnUserPicture_Click(object sender, EventArgs e) { //click event for Insert Picture button on Add User tab
            System.Windows.Forms.DialogResult dr = openUserImage.ShowDialog(); //dr variable represents the result of the form when used as a dialog box with ShowDialog method of openUserImage
            if (dr == DialogResult.OK) {//if OK button is selected
                userSelectedFilePath = openUserImage.InitialDirectory + openUserImage.FileName; //obtain and store the image filepath into userSelectedFilePath variable
                //lblImageLocation.Text = userSelectedFilePath; //display the contents of userSelectedFilePath as a string in lblImagelocation label on Add User tab
                userImageBox.ImageLocation = userSelectedFilePath; //display the user selected image in the image box in place of the default 'anonymous' image
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

        private void btnReport_Click(object sender, EventArgs e) {
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            if (xlApp == null) {
                MessageBox.Show("Excel is not installed!!");
                return;
            }


            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            xlWorkSheet.Cells[1, 1] = "Student ID";
            xlWorkSheet.Cells[1, 2] = "Time Logged";
            xlWorkSheet.Cells[1, 3] = "Login = 1 / Logout = 0";
            xlWorkSheet.Cells[1, 4] = "Total Time";
            Excel.Range er = xlWorkSheet.get_Range("A:D", System.Type.Missing);

            er.EntireColumn.ColumnWidth = 35;
            //Dynamic
            ArrayList userData = Database.selectUser();
            int rowCount = 2;
            int colCount = 1;
            int userCount = 0;
            //Console.WriteLine(userData[0]);
            foreach (var value in userData) {
                Console.WriteLine(userCount);
                if (userCount < 3) {
                    xlWorkSheet.Cells[rowCount, colCount] = value;
                    colCount++;
                    userCount++;
                }
                Console.WriteLine(userCount);
                if (userCount == 3) {
                    int temp = rowCount + 1;
                    //xlWorkSheet.Cells[rowCount, colCount] = value;
                    xlWorkSheet.Cells[rowCount, colCount].NumberFormat = "hh:mm:ss";
                    xlWorkSheet.Cells[rowCount, colCount] = "=IF($C" + rowCount + "=1,$B" + temp + "-$B" + rowCount + ",0)";
                    rowCount++;
                    colCount = 1;
                    userCount = 0;
                }
            }

            xlWorkBook.SaveAs(Application.StartupPath + "\\report\\DBReport.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlShared, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show("Excel file created , you can find the file in " + Application.StartupPath + "\\report\\DBReport.xls");
        }
        private void releaseObject(object obj) {
            try {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            } catch (Exception ex) {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            } finally {
                GC.Collect();
            }
        }

        private void btnClearLogs_Click(object sender, EventArgs e) {
            Database.clearTimeTable();
        }

        private void btnClearDelete_Click(object sender, EventArgs e) {
            txtName.Text = "";
            txtNumber.Text = "";
            txtAddress.Text = "";
            txtDeleteUser.Text = "";
            pbUserPic.ImageLocation = Application.StartupPath + "\\Default User.png";
            lblID.Text = "User ID: 0000";
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

        #region login/out
        private void btnLogin_Click(object sender, EventArgs e) {
            MagneticStripCode readWriter; //creates readWriter variable from the MagneticStripCode.cs class
            try {
                readWriter = new MagneticStripCode(); //creates new MagneticStripcCode object and stores in readWriter
                string cardID = readWriter.readCardData().ToString(); //Card ID set to string of whatever is read
                Console.WriteLine(cardID);
                //string last = cardID.Substring(cardID.LastIndexOf('%') + 1);
                string last = Regex.Replace(cardID, "[^0-9]", ""); //Formatted card data without any special characters
                Console.WriteLine("Fixed String: " + last);
                if (last.Equals(null) || last.Equals("")) {
                    MessageBox.Show("Error reading card. Press Okay and try again?");
                    MagneticStripCode.clearBuffer();
                    cardID = readWriter.readCardData().ToString(); //Card ID set to string of whatever is read
                    last = Regex.Replace(cardID, "[^0-9]", ""); //Only grab numbers nos pecial characters
                    string dbID = Database.checkUser(last)[0]; //Grabs ID from database using the formatted card ID
                    Console.WriteLine("DB ID: " + dbID);
                    if (last == dbID) { //User does exist
                                        //login
                        Console.WriteLine("User exists");
                        //call method to add to database
                        Database.data(last, true); //Inputs timeclock data to DB
                        string isAdmin = Database.checkUser(last)[9]; //Returns if the user is admin or not
                        if (isAdmin.Equals("1")) { //Is admin
                            foreach (TabPage tab in tabControl1.TabPages) { //Enable all pages
                                tab.Enabled = true;
                            }
                        }
                        lbUserLog.Items.Add("User " + last + " logged in.");
                    } else { //User doesn't exist
                        lbUserLog.Items.Add("User " + last + " not found. Contact an administrator.");
                    }
                } else {
                    string dbID = Database.checkUser(last)[0]; //Grabs ID from database using the formatted card ID
                    Console.WriteLine("DB ID: " + dbID);
                    if (last == dbID) { //User does exist
                                        //login
                        Console.WriteLine("User exists");
                        //call method to add to database
                        Database.data(last, true);  //Inputs timeclock data to DB
                        string isAdmin = Database.checkUser(last)[9]; //Returns if the user is admin or not
                        if (isAdmin.Equals("1")) {
                            foreach (TabPage tab in tabControl1.TabPages) { //Enable all pages
                                tab.Enabled = true;
                            }
                        }
                        lbUserLog.Items.Add("User " + last + " logged in.");
                    } else { //User doesn't exist
                        lbUserLog.Items.Add("User " + last + " not found. Contact an administrator.");
                    }
                }
            } catch (Exception ex) { //exception handler
                MessageBox.Show(ex.ToString(), "Something broke in the login. Please contact an administrator."); //catches and displays resulting errors to prevent program crash
            } finally { //finally block runs whether there is an exception or not
                readWriter = null; //sets readWriter object to null after it has been used
                //MagneticStripCode.clearBuffer();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e) {
            MagneticStripCode readWriter; //creates readWriter variable from the MagneticStripCode.cs class
            try {
                readWriter = new MagneticStripCode(); //creates new MagneticStripcCode object and stores in readWriter
                string cardID = readWriter.readCardData().ToString();
                Console.WriteLine(cardID);
                //string last = cardID.Substring(cardID.LastIndexOf('%') + 1);
                string last = Regex.Replace(cardID, "[^0-9]", ""); //Only grab numbers no special characters
                Console.WriteLine("Fixed String: " + last);
                if (last.Equals(null) || last.Equals("")) {
                    MessageBox.Show("Error reading card. Press Okay and try again?");
                    MagneticStripCode.clearBuffer();
                    cardID = readWriter.readCardData().ToString();
                    last = Regex.Replace(cardID, "[^0-9]", ""); //Only grab numbers no special characters
                    string dbID = Database.checkUser(last)[0]; //Grabs ID from database using the formatted card ID
                    Console.WriteLine("DB ID: " + dbID);
                    if (last == dbID) { //User does exist
                                        //login
                        Console.WriteLine("User exists");
                        //call method to add to database
                        string isAdmin = Database.checkUser(last)[9]; //Returns if the user is admin or not
                        if (isAdmin.Equals("1")) {
                            foreach (TabPage tab in tabControl1.TabPages) { //disable all pages
                                tab.Enabled = false;
                            }
                            tabControl1.TabPages[0].Enabled = true; //except page 1
                        }
                        Database.data(last, false); //Inputs timeclock data to DB
                        lbUserLog.Items.Add("User " + last + " logged out.");
                    } else { //User doesn't exist
                        lbUserLog.Items.Add("User " + last + " not found. Contact an administrator.");
                    }
                } else {
                    string dbID = Database.checkUser(last)[0]; //Grabs ID from database using the formatted card ID
                    Console.WriteLine("DB ID: " + dbID);
                    if (last == dbID) { //User does exist
                                        //login
                        Console.WriteLine("User exists");
                        //call method to add to database
                        string isAdmin = Database.checkUser(last)[9]; //Returns if the user is admin or not
                        if (isAdmin.Equals("1")) {
                            foreach (TabPage tab in tabControl1.TabPages) { //disable all pages
                                tab.Enabled = false;
                            }
                            tabControl1.TabPages[0].Enabled = true; //except page1
                        }
                        Database.data(last, false); //Inputs timeclock data to DB
                        lbUserLog.Items.Add("User " + last + " logged out.");
                    } else { //User doesn't exist
                        lbUserLog.Items.Add("User " + last + " not found. Contact an administrator.");
                    }
                }
            } catch (Exception ex) { //exception handler
                MessageBox.Show(ex.ToString(), "Something broke in the logout. Please contact an administrator."); //catches and displays resulting errors to prevent program crash
            } finally { //finally block runs whether there is an exception or not
                readWriter = null; //sets readWriter object to null after it has been used
                //MagneticStripCode.clearBuffer();
            }
        }
        #endregion
    }
}