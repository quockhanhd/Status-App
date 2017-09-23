using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Status_App
{
    public partial class Uc : UserControl
    {
        private Button btnFont;
        private Button btnColor;
        public Color curColor
        {
            get { return this.btnColor.BackColor; }
        }
        
        /// //////////
        //public Font font
        //{
        //    get { return this.btnFont. }
        //}
        
        public Uc()
        {
            InitializeComponent();
        }

    }
}
