using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using nsZBRPrinter;

namespace IDPrinter {
    class GraphicCode {

        #region Text Styling Constants
        const int BOLD = 0x01;
        const int ITALICS = 0x02;
        const int UNDERLINE = 0x04;
        const int STRIKE = 0x08;
        #endregion

        #region Get SDK DLL Version for Graphics
        public string GetSDKGraphicsVersion() {
            ZBRGraphics graphics = null;
            int major, minor, engLevel;
            string gVersion = "";
            try {
                graphics = new ZBRGraphics();
                graphics.GetSDKVer(out major, out minor, out engLevel);
                if (major > 0 || minor > 0 || engLevel > 0) {
                    gVersion = major.ToString() + "." + minor.ToString() + "." + engLevel.ToString();
                }
            } catch (Exception e) {
                MessageBox.Show(e.ToString());
            } finally {
                graphics = null;
            }
            return gVersion;
        }
        #endregion

        #region Get SDK DLL Version for Printer
        public string GetSDKPrinterVersion() {
            ZBRPrinter printer = null;
            int major, minor, engLevel;
            string pVersion = "";
            try {
                printer = new ZBRPrinter();
                printer.GetSDKVer(out major, out minor, out engLevel);
                if (major > 0 || minor > 0 || engLevel > 0) {
                    pVersion = major.ToString() + "." + minor.ToString() + "." + engLevel.ToString();
                }
            } catch (Exception e) {
                MessageBox.Show(e.ToString());
            } finally {
                printer = null;
            }
            return pVersion;
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
            } catch (Exception e) {
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
        public void Print(string driverName, string name, string userID, string userPicture, bool admin, bool back, string disclaimer, out string msg) {
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
                    //print back
                    if (graphics.DrawText(35, 380, ascii.GetBytes(disclaimer), ascii.GetBytes("Arial"), 12, fontStyle, 0x009973, out error) == 0) {
                        msg = "DrawText method error code: " + error.ToString();
                        return;
                    }
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