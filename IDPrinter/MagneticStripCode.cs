using System;
using nsZBRPrinter;
using System.Windows.Forms;
using System.IO.Ports;

namespace IDPrinter {
    class MagneticStripCode {
        public SerialPort sp = null;

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

        #region send data to com port
        public bool SendComData(object sender, EventArgs e) {
            using (SerialPort port = new SerialPort("COM3", 9600, Parity.None, 8)) {
                byte[] bytesToSend = new byte[] { 0x1B, 0x85 };

                port.Open();
                if (port.IsOpen) {
                    port.Write(bytesToSend, 0, bytesToSend.Length);
                    return true;
                }
                return false;
            }

            //return false;
        }
        #endregion
    }
}
