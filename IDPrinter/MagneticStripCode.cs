using System;
using nsZBRPrinter;
using System.Windows.Forms;
using System.IO.Ports;

namespace IDPrinter {
    class MagneticStripCode {
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
