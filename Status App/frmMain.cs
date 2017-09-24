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
        
        private void loadTT()
        {
            rtbThongTin.LoadFile("Luu thong tin.doc", RichTextBoxStreamType.RichText);
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            loadTT();
            timer1.Interval = 1000;
            timer1.Start();
            pbAvatar.ImageLocation = "Avatas\\img1.jpg";
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbGio.Text = DateTime.Now.ToString("hh");
            lbPhut.Text = DateTime.Now.ToString("mm");
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            this.Close();
            frmQuanLyNK f = new frmQuanLyNK();
            f.ShowDialog();
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
           DialogResult dlr= MessageBox.Show("Bạn có muốn sử dụng Webcam", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                frmCamera frmc = new frmCamera();
                frmc.ShowDialog();
                pbAvatar.ImageLocation = "Avatas\\img1.jpg";
            }
            else
            {
                openFileDialog1.Filter = "Image Files|*.png;*.img;*.jpg";
                DialogResult dr = openFileDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pbAvatar.ImageLocation = openFileDialog1.FileName;
                }
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLuuTT_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.FileName = "Luu thong tin.doc";
            rtbThongTin.SaveFile(sf.FileName,RichTextBoxStreamType.RichNoOleObjs);
            loadTT();
        }
    }
}
