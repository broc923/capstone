using System;
using System.Windows.Forms;

namespace IDPrinter {
    static class Program {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();//enables visual elements that form an operating system such as fonts and colors
            Application.SetCompatibleTextRenderingDefault(false); //the default value for new controls. New controls use the GDI based TextRenderer class since param is sent to false
            Application.Run(new FrmMain()); //Begins running a standard application message loop on the current thread, and makes the frmMain visible
        }
    }
}
