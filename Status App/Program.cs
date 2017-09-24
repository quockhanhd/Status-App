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
            frmLogin frmLg= new frmLogin();
            frmMain frmm = new frmMain();
            if (frmLg.ShowDialog() == DialogResult.OK)
            {
                frmm.ShowDialog();
            }
            
       
            
        
        }
    }
}
