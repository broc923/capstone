using System;
using System.Text;
using System.Runtime.InteropServices;

namespace nsZBRPrinter {
    public class ZBRPrinter {
        #region Private Variables

        private IntPtr _handle;    // device context
        private int _prnType;
        private ASCIIEncoding _asciiEncoder = null;

        #endregion

        #region Constructor

        public ZBRPrinter() {
            _prnType = 0;
            _asciiEncoder = new ASCIIEncoding();
        }

        ~ZBRPrinter() {
            _prnType = 0;
            _asciiEncoder = null;
        }

        #endregion

        #region Printer DLLImports

        // SDK DLL Version

        [DllImport("ZBRPrinter.dll", EntryPoint = "ZBRPRNGetSDKVer", CharSet = CharSet.Auto, SetLastError = true)]
        static extern void ZBRPRNGetSDKVer(out int major, out int minor, out int engLevel);

        // Handle

        [DllImport("ZBRPrinter.dll", EntryPoint = "ZBRGetHandle", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int ZBRGetHandle(out IntPtr _handle, byte[] drvName, out int prn_type, out int err);

        [DllImport("ZBRPrinter.dll", EntryPoint = "ZBRCloseHandle", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int ZBRCloseHandle(IntPtr _handle, out int err);

        // Card Movement

        [DllImport("ZBRPrinter.dll", EntryPoint = "ZBRPRNEjectCard", CharSet = CharSet.Auto,
            SetLastError = true)]
        static extern int ZBRPRNEjectCard(IntPtr _handle, int prn_type, out int err);

        // Magnetic Encoding

        [DllImport("ZBRPrinter.dll", EntryPoint = "ZBRPRNReadMag", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int ZBRPRNReadMag(IntPtr _handle, int prn_type, int trksToRead, byte[] trk1Buf,
            out int trk1BytesNeeded, byte[] trk2Buf, out int trk2BytesNeeded, byte[] trk3Buf,
            out int trk3BytesNeeded, out int err);

        [DllImport("ZBRPrinter.dll", EntryPoint = "ZBRPRNWriteMag", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int ZBRPRNWriteMag(IntPtr _handle, int prn_type, int trksToWrite, byte[] trk1Data,
            byte[] trk2Data, byte[] trk3Data, out int err);

        #endregion

        #region SDK Information

        // Get ZBRPrinter.dll Version -----------------------------------------------------------------------

        public void GetSDKVer(out int major, out int minor, out int engLevel) {
            ZBRPRNGetSDKVer(out major, out minor, out engLevel);
        }

        #endregion

        #region Handle

        // Opens a connection to a printer driver -----------------------------------------------------------

        private int Open(byte[] drvName, out int errValue) {
            return ZBRGetHandle(out _handle, drvName, out _prnType, out errValue);
        }

        public int Open(string drvName, out int errValue) {
            byte[] name = null;
            try {
                name = _asciiEncoder.GetBytes(drvName);
                return Open(name, out errValue);

            } catch (Exception ex) {
                throw ex;
            } finally {
                name = null;
            }
        }

        // Closes the connection to a printer driver --------------------------------------------------------

        public int Close(out int errValue) {
            _prnType = 0;
            return ZBRCloseHandle(_handle, out errValue);
        }

        #endregion

        #region Card Movement

        // Ejects a card from a printer ---------------------------------------------------------------------

        public int EjectCard(out int errValue) {
            return ZBRPRNEjectCard(_handle, _prnType, out errValue);
        }

        #endregion

        #region Magnetic Encoding

        // Reads all three magnetic strip tracks ------------------------------------------------------------

        public int ReadMag(int trksToRead, byte[] trkBuf1, byte[] trkBuf2, byte[] trkBuf3, out int errValue) {
            int size1, size2, size3;
            return ZBRPRNReadMag(_handle, _prnType, trksToRead, trkBuf1, out size1, trkBuf2, out size2,
                                    trkBuf3, out size3, out errValue);
        }

        // Writes to the magnetic strip tracks
        //     if data is null or "", the track is not written ----------------------------------------------

        public int WriteMag(int trksToWrite, byte[] trkBuf1, byte[] trkBuf2, byte[] trkBuf3, out int errValue) {
            return ZBRPRNWriteMag(_handle, _prnType, trksToWrite, trkBuf1, trkBuf2, trkBuf3, out errValue);
        }

        #endregion
    }
}
