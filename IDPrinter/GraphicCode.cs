using System; //allows direct access to the console type system
using System.Text; // contains classes that represent ASCII and Unicode character encoding
using System.Threading; //Creates and controls a thread, sets its priority, and gets its status
using System.Windows.Forms; //access the classes which create Windows-based applications incorporating rich user interfaces 
using nsZBRPrinter; //allows access to zebra-specific controls

namespace IDPrinter {
    class GraphicCode {
   
        #region Text Styling Constants
        const int BOLD = 0x01; //extended formatting hex stored as bold variable (used to make text bold)
        const int ITALICS = 0x02; //extended formatting hex stored as italics variable (used to italicize text)
        const int UNDERLINE = 0x04;  //extended formatting hex stored as underline variable (used to underline text)
        const int STRIKE = 0x08;  //extended formatting hex stored as strike variable (used to strike through text)
        #endregion

        #region Get SDK DLL Version for Graphics
        public string GetSDKGraphicsVersion() {// method called on FrmMain.cs in order to obtain graphics version
            ZBRGraphics graphics = null; //creates graphics variable from the ZBRGraphics.cs class initialized to null
            int major, minor, engLevel; //integers to hold major, minor, and engine level DLL values of the ZBRGraphics class
            string gVersion = ""; //creates gVersion string initialized to an empty string, used to hold final graphics version numerical data
            try {
                graphics = new ZBRGraphics();  //creates new ZBRGraphics object and stores in graphics
                graphics.GetSDKVer(out major, out minor, out engLevel); //calls to the getSDKVer method of graphics, passing major, minor, and engine level variables by reference
                if (major > 0 || minor > 0 || engLevel > 0) { //if major, minor, or engine levels have values that's greater than their default values of 0...
                    gVersion = major.ToString() + "." + minor.ToString() + "." + engLevel.ToString(); 
                    //convert all three values to string, concatenated with a period seperating each, and store the whole string value in gVersion variable - it will appear in label on About page
                }
            } catch (Exception e) { //exceotion handler
                MessageBox.Show(e.ToString()); //catches and displays resulting errors to prevent program crash
            } finally {  //finally block runs whether there is an exception or not
                graphics = null; //sets graphics object to null after it has been used
            }
            return gVersion; //return resulting graphics DLL version string
        }
        #endregion

        #region Get SDK DLL Version for Printer
        public string GetSDKPrinterVersion() { // method called on FrmMain.cs in order to obtain printer version
            ZBRPrinter printer = null;  //creates printer variable from the ZBRPrinter.cs class initialized to null
            int major, minor, engLevel;  //integers to hold major, minor, and engine level DLL values of the ZBRPrinter class
            string pVersion = "";  //creates pVersion string initialized to an empty string, used to hold final printer version numerical data
            try {
                printer = new ZBRPrinter();   //creates new ZBRPrinter object and stores in printer
                printer.GetSDKVer(out major, out minor, out engLevel); //calls to the getSDKVer method of printer, passing major, minor, and engine level variables by reference
                if (major > 0 || minor > 0 || engLevel > 0) { //if major, minor, or engine levels have values that's greater than their default values of 0...
                    pVersion = major.ToString() + "." + minor.ToString() + "." + engLevel.ToString();
                    //convert all three values to string, concatenated with a period seperating each, and store the whole string value in pVersion variable - it will appear in label on About page
                }
            } catch (Exception e) { //exception handler
                MessageBox.Show(e.ToString());
            } finally {  //finally block runs whether there is an exception or not
                printer = null; //sets printer object to null after it has been used
            }
            return pVersion; //return resulting printer DLL version string
        }
        #endregion

        #region Is the ID printer busy with something else
        public bool IsPrinterBusy(string driverName, int timeoutInSeconds) {
            bool ready = false;
            int errors = 0;

            ZBRGraphics graphics;
            ASCIIEncoding ascii;
            try {
                graphics = new ZBRGraphics();
                ascii = new ASCIIEncoding();
                for (int i = 0; i < timeoutInSeconds; i++) { //ascii.GetBytes() encodes the string to a sequence of bytes
                    if (graphics.IsPrinterReady(ascii.GetBytes(driverName), out errors) != 0) {
                        ready = true;
                        break;
                    }
                    Thread.Sleep(1000);
                }
            } catch (Exception e){
                ready = false;
                MessageBox.Show(e.ToString());
            } finally {
                graphics = null;
                ascii = null;
            }
            return ready;
        }
        #endregion

        #region Print graphics
        public void Print(string driverName, string name, string userID, string userPicture, bool admin, bool back, string[] disclaimerSplit, out string msg) {
            int error;
            ZBRGraphics graphics = null;
            ASCIIEncoding ascii;
            msg = "";
            try {
                int fontStyle = BOLD;
                graphics = new ZBRGraphics();
                ascii = new ASCIIEncoding();
                //Initialize Graphics
                if (graphics.InitGraphics(ascii.GetBytes(driverName), out error) == 0) {
                    msg = "InitGraphics method error code: " + error.ToString();
                    return;
                }
                if (!back) {
                    //DrawImage(location of image, X coordinate, Y coordinate, length, width, out error)
                    if (admin == false) { //Does the user have admin? No
                        if (graphics.DrawImage(ascii.GetBytes(Application.StartupPath + "\\Student.png"), 370, 30, 325, 50, out error) == 0) {
                            msg = "DrawImage method error code: " + error.ToString();
                            return;
                        }
                    } else { //They do have admin
                        if (graphics.DrawImage(ascii.GetBytes(Application.StartupPath + "\\Admin.png"), 350, 30, 400, 50, out error) == 0) {
                            msg = "DrawImage method error code: " + error.ToString();
                            return;
                        }
                    }
                    //DrawImage(location of image, X coordinate, Y coordinate, length, width, out error)
                    if (graphics.DrawImage(ascii.GetBytes(userPicture), 30, 30, 275, 350, out error) == 0) {
                        msg = "DrawImage method error code: " + error.ToString();
                        return;
                    }
                    //DrawText(X Coordinate, Y Coordinate, String, Font type, font size, fontStyle, color, out error)
                    if (graphics.DrawText(35, 380, ascii.GetBytes(name), ascii.GetBytes("Arial"), 12, fontStyle, 0x009973, out error) == 0) {
                        msg = "DrawText method error code: " + error.ToString();
                        return;
                    }
                    //DrawBarcode(X Coordinate, Y Coordinate, rotation, barcode type, width ratio, multiplier, height, text under, barcode data, out error)
                    if (graphics.DrawBarcode(365, 570, 0, 0, 2, 4, 85, 0, ascii.GetBytes(userID), out error) == 0) {
                        msg = "DrawBarcode method error code: " + error.ToString();
                        return;
                    }
                    //DrawImage(location of image, X coordinate, Y coordinate, length, width, out error)
                    if (graphics.DrawImage(ascii.GetBytes(Application.StartupPath + "\\logo.png"), 400, 70, 450, 320, out error) == 0) {
                        msg = "DrawImage method error code: " + error.ToString();
                        return;
                    }
                } else {
                    string test = ""; //
                    int x = 35;
                 
                    foreach (string disclaimer in disclaimerSplit)
                    {
                        if (graphics.DrawText(x, 35, ascii.GetBytes(disclaimer), ascii.GetBytes("Arial"), 12, fontStyle, 0x009973, out error) == 0)
                        {
                            msg = "DrawText method error code: " + error.ToString();
                            return;
                        }
                        x += 10;
                        test += disclaimer + "\n"; //
                    }
                    MessageBox.Show(test);//
                    
                }
                if (graphics.PrintGraphics(out error) == 0) {
                    msg = "PrintGraphics Error: " + error.ToString();
                    return;
                }
            } catch (Exception e) {
                MessageBox.Show(e.ToString());
            } finally {
                ascii = null;
                if (graphics != null) {
                    if (graphics.CloseGraphics(out error) == 0) {
                        msg = "CloseGraphics method error code: " + error.ToString();
                    }
                    graphics = null;
                }
            }
        }
        #endregion

    }
}