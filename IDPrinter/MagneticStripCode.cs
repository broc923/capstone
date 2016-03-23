using System;
using System.Windows.Forms;
using System.Text;
using System.IO.Ports;
using System.Threading;

namespace IDPrinter {
    class MagneticStripCode {
        public static AutoResetEvent signalEvent = new AutoResetEvent(false);
        public static SerialPort sp = new SerialPort("COM4", 9600, Parity.None, 8);
        public static byte[] comTest = new byte[] { 0x1B, 0x65 };
        public static byte[] resetBuffer = new byte[] { 0x1B, 0x61 };
        public static byte[] read = new byte[] { 0x1B, 0x72 };
        public static byte[] write = new byte[] { 0x1B, 0x77 };
        public static byte[] allLEDOff = new byte[] { 0x1B, 0x81 };
        public static byte[] allLEDOn = new byte[] { 0x1B, 0x82 };
        public static byte[] greenLEDOn = new byte[] { 0x1B, 0x83 };
        public static byte[] yellowLEDOn = new byte[] { 0x1B, 0x84 };
        public static byte[] redLEDOn = new byte[] { 0x1B, 0x85 };
        public static byte[] sensorTest = new byte[] { 0x1B, 0x86 };
        public static byte[] ramTest = new byte[] { 0x1B, 0x87 };
        public static byte[] eraseCard = new byte[] { 0x1B, 0x63 };
        public static byte[] selectTrack2 = new byte[] { 0x1B, 0x62, 0xD2 };
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
        #region read card data
        public void readCardData() {
            sp.ReadTimeout = 5000;
            sp.WriteTimeout = 500;
            sp.DataReceived += readDataReceived;

            sp.Open();
            if (sp.IsOpen) {
                sp.Write(read, 0, read.Length);
                Console.Write("Slide Card Please\n");
                signalEvent.WaitOne();
                sp.Close();
                sp.Dispose();
            }
        }
        static void readDataReceived(object sender, SerialDataReceivedEventArgs e) {
            var sp = (SerialPort)sender;
            var data = "";
            try {
                data = sp.ReadTo("?");
            } catch (Exception error) {
                Console.WriteLine(error);
            }
            Console.WriteLine(data);
            sp.Close();
            sp.Dispose();
            signalEvent.Set();
        }
        #endregion

        #region write card data
        public void writeCardData() {
            byte[] userIDCode = Encoding.ASCII.GetBytes("Testing12345");
            byte[] fullCommand = new byte[write.Length + userIDCode.Length];
            Buffer.BlockCopy(write, 0, fullCommand, 0, write.Length);
            Buffer.BlockCopy(userIDCode, 0, fullCommand, write.Length, userIDCode.Length);

            sp.ReadTimeout = 500;
            sp.WriteTimeout = 5000;
            sp.DataReceived += writeDataReceived;

            sp.Open();
            if (sp.IsOpen) {
                sp.Write(selectTrack1, 0, selectTrack1.Length);
                sp.Write(fullCommand, 0, fullCommand.Length);
                Console.Write("Slide Card Please\n");
                signalEvent.WaitOne();
                sp.Close();
                sp.Dispose();
            }
        }
        static void writeDataReceived(object sender, SerialDataReceivedEventArgs e) {
            sp.Close();
            sp.Dispose();
            signalEvent.Set();
        }
        #endregion

        #region erase card data
        public void eraseCardData() {
            sp.ReadTimeout = 500;
            sp.WriteTimeout = 5000;
            sp.DataReceived += clearDataHandler;
            sp.Open();
            if (sp.IsOpen) {
                Console.WriteLine("Clear started\n");
                sp.Write(selectTrack1, 0, selectTrack1.Length);
                sp.Write(eraseCard, 0, eraseCard.Length);
                signalEvent.WaitOne();
                Console.WriteLine("Clear finished\n");
                sp.Close();
                sp.Dispose();
            }
        }
        static void clearDataHandler(object sender, SerialDataReceivedEventArgs e) {
            sp.Close();
            sp.Dispose();
            signalEvent.Set();
        }
        #endregion
    }
}
