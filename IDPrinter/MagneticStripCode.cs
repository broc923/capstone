using System;
using System.Windows.Forms;
using System.Text;
using System.IO.Ports;
using System.Threading;

namespace IDPrinter {
    class MagneticStripCode {
        public static AutoResetEvent signalEvent = new AutoResetEvent(false);
        public static SerialPort sp = new SerialPort();
        public static byte[] comTest = new byte[] { 0x1B, 0x65 };
        public static byte[] resetBuffer = new byte[] { 0x1B, 0x61 };
        public static byte[] read = new byte[] { 0x1B, 0x72 };
        public static byte[] write = new byte[] { 0x1B, 0x77, 0x1B, 0x73, 0x1B, 0x01 };
        public static byte[] endWrite = new byte[] { 0x3F, 0x1C };
        public static byte[] selectTrack1 = new byte[] { 0x1B, 0x66, 0xD2 };
        public static byte[] setHiCo = new byte[] { 0x1B, 0x78 };
        public static string returnString = "";
        static SerialPort serialPort;

        #region read card data
        public string readCardData() {
            if (!sp.IsOpen) {
                sp.PortName = FrmMain.comPort;
                sp.BaudRate = 9600;
                sp.Parity = 0;
                sp.DataBits = 8;
                sp.ReadTimeout = 5000;
                sp.WriteTimeout = 500;
                sp.DataReceived += readDataReceived;
                sp.Open();
            }
            if (sp.IsOpen) {
                sp.Write(read, 0, read.Length);
                Console.Write("Slide Card Please\n");
                signalEvent.WaitOne();
                Console.Write("Finished\n");
            }
            return returnString;
        }
        static void readDataReceived(object sender, SerialDataReceivedEventArgs e) {
            var sp = (SerialPort)sender;
            if (!sp.IsOpen) {
                sp.PortName = FrmMain.comPort;
                sp.BaudRate = 9600;
                sp.Parity = 0;
                sp.DataBits = 8;
                sp.ReadTimeout = 5000;
                sp.WriteTimeout = 500;
                sp.Open();
            }
            if (sp.IsOpen) { 
                var data = "";
                try {
                    data = sp.ReadTo("?");
                    returnString = data;
                } catch (Exception error) {
                    Console.WriteLine(error);
                }
                sp.Close();
                sp.Dispose();
                signalEvent.Set();
            }

        }
        #endregion

        #region write card data
        public static void writeCardData(string userID) {
            byte[] data = Encoding.ASCII.GetBytes(userID);
            if (!sp.IsOpen) {
                sp.PortName = FrmMain.comPort;
                sp.BaudRate = 9600;
                sp.Parity = 0;
                sp.DataBits = 8;
                sp.ReadTimeout = 5000;
                sp.WriteTimeout = 500;
                sp.DataReceived += writeDataReceived;
                sp.Open();
            }
            if (sp.IsOpen) {
                Console.WriteLine("Sending Hi-Co setting");
                sp.Write(setHiCo, 0, setHiCo.Length);
                Console.WriteLine("Sending write command");
                sp.Write(write, 0, write.Length);
                sp.Write(data, 0, data.Length);
                sp.Write(endWrite, 0, endWrite.Length);
                Console.WriteLine("Write Command sent");
                signalEvent.WaitOne();
                Console.WriteLine("Waiting on a respsonse");
            }
        }
        static void writeDataReceived(object sender, SerialDataReceivedEventArgs e) {
            sp.Close();
            sp.Dispose();
            signalEvent.Set();
        }
        #endregion

        public static string getComPort() {
            try {
                string[] str = SerialPort.GetPortNames();
                string recieved = "";
                string com = "";
                serialPort = new SerialPort();
                foreach (string value in str) {
                    Console.WriteLine(value);
                    serialPort.PortName = value;
                    serialPort.BaudRate = 9600;
                    serialPort.Parity = 0;
                    serialPort.DataBits = 8;
                    serialPort.ReadTimeout = 5000;
                    serialPort.WriteTimeout = 500;
                    serialPort.Open();
                    serialPort.Write(comTest, 0, comTest.Length);
                    Thread.Sleep(100);
                    recieved = serialPort.ReadExisting();
                    if (recieved.Equals("\u001by")) {
                        Console.WriteLine(value);
                        com = value;
                    }
                    serialPort.Close();
                }
                return com;
            } catch(Exception e) {
                Console.WriteLine(e);
                return "";
            }
        }

        public static void clearBuffer() {
            if (!sp.IsOpen) {
                sp.PortName = FrmMain.comPort;
                sp.BaudRate = 9600;
                sp.Parity = 0;
                sp.DataBits = 8;
                sp.ReadTimeout = 500;
                sp.WriteTimeout = 5000;
                sp.Open();
            }
            if (sp.IsOpen) {
                sp.Write(resetBuffer, 0, resetBuffer.Length);
                Console.WriteLine("Ready\n");
                sp.Close();
                sp.Dispose();
            }
        }
    }
}
