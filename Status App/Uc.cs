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
    
        private Button btnColor;
        public Color curColor
        {
            get { return btnColor.BackColor; }
  
        }

        public Uc()
        {
            InitializeComponent();
        }

       

        private void button_Click(object sender, EventArgs e)
        {
            this.btnColor = sender as Button;
           
        }

        private void buttonChonMau_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.btnColor.BackColor = colorDialog1.Color;
                
            }
           
        }
    }
}
