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
                using (SerialPort ported = new SerialPort(port, 9600, Parity.None, 8)) {
                    byte[] comTest = new byte[] { 0x1B, 0x65 };
                    byte[] resetBuffer = new byte[] { 0x1B, 0x61 };
                    byte[] read = new byte[] { 0x1B, 0x72 };
                    byte[] write = new byte[] { 0x1B, 0x77 };
                    byte[] allLEDOff = new byte[] { 0x1B, 0x81 };
                    byte[] allLEDOn = new byte[] { 0x1B, 0x82 };
                    byte[] greenLEDOn = new byte[] { 0x1B, 0x83 };
                    byte[] yellowLEDOn = new byte[] { 0x1B, 0x84 };
                    byte[] redLEDOn = new byte[] { 0x1B, 0x85 };
                    byte[] sensorTest = new byte[] { 0x1B, 0x86 };
                    byte[] ramTest = new byte[] { 0x1B, 0x87 };
                    byte[] eraseCard = new byte[] { 0x1B, 0x63 };
                    byte[] selectTrack2 = new byte[] { 0x1B, 0x62, 0xD2 };
                    byte[] selectTrack2Alt = new byte[] { 0x1B, 0x62, 0x4B };
                    byte[] selectTrack1 = new byte[] { 0x1B, 0x66, 0xD2 };
                    byte[] selectTrack1Alt = new byte[] { 0x1B, 0x66, 0x4B };
                    byte[] selectTrack3 = new byte[] { 0x1B, 0x67, 0xD2 };
                    byte[] selectTrack3Alt = new byte[] { 0x1B, 0x67, 0x4B };
                    byte[] getDeviceData = new byte[] { 0x1B, 0x74 };
                    byte[] getFirmwareVersion = new byte[] { 0x1B, 0x75 };
                    byte[] getCompatibleFirmwareVersion = new byte[] { 0x1B, 0x76 };
                    byte[] setHiCo = new byte[] { 0x1B, 0x78 };
                    byte[] setLowCo = new byte[] { 0x1B, 0x79 };
                    byte[] getHiCoLowCo = new byte[] { 0x1B, 0x64 };
                    byte[] detectEZWriter = new byte[] { 0x39 };
                    
                    ported.Open();
                    if (ported.IsOpen) {
                        ported.Write(comTest, 0, comTest.Length);
                    }
                }
            }
        }
        #endregion
    }
}
