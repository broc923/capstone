using System;
using System.Runtime.InteropServices;

namespace nsZBRPrinter {
    public class ZBRGraphics {
        #region Private Variables

        // Private declarations -----------------------------------------------------------------------------

        private IntPtr _hDC;

        #endregion

        #region Constructor

        // Class Initialization -----------------------------------------------------------------------------

        public ZBRGraphics() { }

        #endregion

        #region Graphic DLLImports

        // Check Print Spooler ------------------------------------------------------------------------------

        [DllImport("ZBRGraphics.dll", EntryPoint = "ZBRGDIIsPrinterReady", CharSet = CharSet.Auto,
            SetLastError = true)]
        static extern int ZBRGDIIsPrinterReady(byte[] strPrinterName, out int err);

        // SDK DLL Version ----------------------------------------------------------------------------------

        [DllImport("ZBRGraphics.dll", EntryPoint = "ZBRGDIGetSDKVer", CharSet = CharSet.Auto,
            SetLastError = true)]
        static extern void ZBRGDIGetSDKVer(out int major, out int minor, out int engLevel);

        // Initialization -----------------------------------------------------------------------------------

        [DllImport("ZBRGraphics.dll", EntryPoint = "ZBRGDIInitGraphics", CharSet = CharSet.Auto,
            SetLastError = true)]
        static extern int ZBRGDIInitGraphics(byte[] strPrinterName, out IntPtr hDC, out int err);

        [DllImport("ZBRGraphics.dll", EntryPoint = "ZBRGDICloseGraphics", CharSet = CharSet.Auto,
            SetLastError = true)]
        static extern int ZBRGDICloseGraphics(IntPtr hDC, out int err);

        [DllImport("ZBRGraphics.dll", EntryPoint = "ZBRGDIClearGraphics", CharSet = CharSet.Auto,
            SetLastError = true)]
        static extern int ZBRGDIClearGraphics(out int err);

        // Print --------------------------------------------------------------------------------------------

        [DllImport("ZBRGraphics.dll", EntryPoint = "ZBRGDIPrintGraphics", CharSet = CharSet.Auto,
            SetLastError = true)]
        static extern int ZBRGDIPrintGraphics(IntPtr hDC, out int err);

        // Draw ---------------------------------------------------------------------------------------------

        [DllImport("ZBRGraphics.dll", EntryPoint = "ZBRGDIDrawText", CharSet = CharSet.Auto,
            SetLastError = true)]
        static extern int ZBRGDIDrawText(int x, int y, byte[] text, byte[] font, int fontSize, int fontStyle,
            int color, out int err);

        [DllImport("ZBRGraphics.dll", EntryPoint = "ZBRGDIDrawLine", CharSet = CharSet.Auto,
            SetLastError = true)]
        static extern int ZBRGDIDrawLine(int x1, int y1, int x2, int y2, int color, float thickness,
                                         out int err);

        [DllImport("ZBRGraphics.dll", EntryPoint = "ZBRGDIDrawImageRect", CharSet = CharSet.Auto,
            SetLastError = true)]
        static extern int ZBRGDIDrawImageRect(byte[] fileName, int x, int y, int sizeX, int sizeY, out int err);

        [DllImport("ZBRGraphics.dll", EntryPoint = "ZBRGDIDrawBarCode", CharSet = CharSet.Auto,
            SetLastError = true)]
        static extern int ZBRGDIDrawBarCode(int x, int y, int rotation, int barcodeType, int widthRatio,
            int mutiplier, int height, int textUnder, byte[] data, out int err);

        #endregion

        #region Print Spooler

        // Checks to see if any jobs are in the print spooler -----------------------------------------------

        public int IsPrinterReady(byte[] driverName, out int errors) {
            return ZBRGDIIsPrinterReady(driverName, out errors);
        }

        #endregion

        #region SDK DLL Version

        // Gets ZBRGraphics.dll Version ---------------------------------------------------------------------

        public void GetSDKVer(out int major, out int minor, out int engLevel) {
            ZBRGDIGetSDKVer(out major, out minor, out engLevel);
        }

        #endregion

        #region Graphics Initialization

        // Creates a device context and initializes a graphic buffer ----------------------------------------

        public int InitGraphics(byte[] drvName, out int errValue) {
            return ZBRGDIInitGraphics(drvName, out _hDC, out errValue);
        }

        // Releases the device context and the graphic buffer -----------------------------------------------

        public int CloseGraphics(out int errValue) {
            return ZBRGDICloseGraphics(_hDC, out errValue);
        }

        // Clears the graphic buffer ------------------------------------------------------------------------

        public int ClearGraphics(out int errValue) {
            return ZBRGDIClearGraphics(out errValue);
        }

        #endregion

        #region Draw

        // Draws text into the graphic buffer ---------------------------------------------------------------

        public int DrawText(int x, int y, byte[] text, byte[] font, int fontSize, int fontStyle,
                                int textColor, out int errValue) {
            return ZBRGDIDrawText(x, y, text, font, fontSize, fontStyle, textColor, out errValue);
        }

        // Draws a line into the graphic buffer ---------------------------------------------------------------

        public int DrawLine(int x1, int y1, int x2, int y2, int color, float thickness,
                            out int err) {
            return ZBRGDIDrawLine(x1, y1, x2, y2, color, thickness, out err);
        }

        // Places a file image into the graphic buffer ------------------------------------------------------

        public int DrawImage(byte[] filename, int x, int y, int width, int height, out int errValue) {
            return ZBRGDIDrawImageRect(filename, x, y, width, height, out errValue);
        }

        // Draws a barcode into the monochrome buffer -------------------------------------------------------

        public int DrawBarcode(int x, int y, int rotation, int barcodeType, int widthRatio, int multiplier,
                                int height, int textUnder, byte[] barcodeData, out int errValue) {
            return ZBRGDIDrawBarCode(x, y, rotation, barcodeType, widthRatio, multiplier, height, textUnder,
                                        barcodeData, out errValue);
        }

        #endregion

        #region Print

        // Prints the graphic buffer ------------------------------------------------------------------------

        public int PrintGraphics(out int errValue) {
            return ZBRGDIPrintGraphics(_hDC, out errValue);
        }

        #endregion
    }
}
