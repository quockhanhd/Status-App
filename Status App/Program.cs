using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Status_App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //frmLogin frm = new frmLogin();
            //if (frm.ShowDialog()== DialogResult.OK)
            //{
            //    frm.Show();
            //}
            frmMain1 f = new frmMain1();
            // f.ShowDialog();
         frmCamera fi = new frmCamera();
            //fi.ShowDialog();
            frmMain main = new frmMain();
            main.ShowDialog();
        }
    }
}
