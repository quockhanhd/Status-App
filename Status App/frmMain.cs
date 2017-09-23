using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Status_App
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbGio.Text = DateTime.Now.ToString("hh");
            lbPhut.Text = DateTime.Now.ToString("MM");
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            frmQuanLyNK f = new frmQuanLyNK();
            f.ShowDialog();
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.png;*.img;*.jpg";
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr==DialogResult.OK)
            {
                pbAvatar.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
