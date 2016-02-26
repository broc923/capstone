using System;
using nsZBRPrinter;
using System.Windows.Forms;
using System.IO.Ports;

namespace IDPrinter {
    class MagneticStripCode {
        #region send data to com port
        public void SendComData() {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports) {
                Console.WriteLine(port);
                using (SerialPort ported = new SerialPort(port, 9600, Parity.None, 8))
                {
                    byte[] comTest = new byte[] { 0x1B, 0x65 };
                    ported.Open();
                    if (ported.IsOpen)
                    {
                        ported.Write(comTest, 0, comTest.Length);
                    }
                }
            }
        }
        #endregion
    }
}
