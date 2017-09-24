using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Status_App
{
    public partial class frmQuanLyNK : Form
    {
        FileInfo[] dsFileName;
        public frmQuanLyNK()
        {
            InitializeComponent();
        }
        private void SaveFile()
        {
            SaveFileDialog s = new SaveFileDialog();
            //Sửa
            if (clbDanhSachNhatKy.SelectedIndex != -1)
            {
                s.FileName = "New folder\\" + clbDanhSachNhatKy.SelectedItem.ToString() + ".doc";
            }
            else
            {
                //Nếu không chọn nhật ký nào thì Filename = DateTime.Now
                s.FileName = "New folder\\" + DateTime.Now.ToString("dd-MM-yyyy") + ".doc";
            }
            // Lưu file
            rtbViet.SaveFile(s.FileName, RichTextBoxStreamType.RichNoOleObjs);
        }
        private void OpenFile()
        {
            OpenFileDialog op = new OpenFileDialog();
            op.FileName = "New folder\\" + clbDanhSachNhatKy.Items[clbDanhSachNhatKy.SelectedIndex] + ".doc";
            rtbViet.LoadFile(op.FileName, RichTextBoxStreamType.RichText);
           

        }


        private void btnLuu_Click(object sender, EventArgs e)
        {

            SaveFile();
            int dem = 0;
            string getDate = DateTime.Now.ToString("dd-MM-yyyy");
            for (int i = 0; i < clbDanhSachNhatKy.Items.Count; i++)
            {
                if (getDate.CompareTo(clbDanhSachNhatKy.Items[i]) == 0)
                    dem++;
            }
            if (dem == 0)
            {
                clbDanhSachNhatKy.Items.Add(getDate);
            }
        }

        private void btnViet_Click(object sender, EventArgs e)
        {
            groupBoxWrite.Visible = true;
            btnLuu.Visible = true;
            for (int i = 0; i < clbDanhSachNhatKy.Items.Count; i++)
            {
                string getDate = DateTime.Now.ToString("dd-MM-yyyy");
                if (getDate.CompareTo(clbDanhSachNhatKy.Items[i].ToString()) == 0)
                    rtbViet.LoadFile("New folder\\" + getDate + ".doc");
            }

        }

        //private void DeleteFile()
        //{
        //    string s = "";
        //    if (clbDanhSachNhatKy.SelectedIndex != -1)
        //    {
        //        DialogResult dl = MessageBox.Show("Bạn Có Muốn Xóa Nhật Ký Này Không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        //        if (dl == DialogResult.Yes)
        //        {
        //            s = "New folder\\" + clbDanhSachNhatKy.SelectedItem.ToString() + ".doc";
        //            File.Delete(s);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui Lòng Chọn Nhật Ký Để Xóa");
        //    }
        //    LoadDSFiles();
        //}
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string s = "";

            DialogResult dl = MessageBox.Show("Bạn Có Muốn Xóa Nhật Ký Này Không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dl == DialogResult.Yes)
            {
                for (int j = 0; j < clbDanhSachNhatKy.CheckedItems.Count; j++)
                {
                    s = "New folder\\" + clbDanhSachNhatKy.CheckedItems[j].ToString() + ".doc";
                    File.Delete(s);
                }
            }
           
            LoadDSFiles();
        }

        private void clbDanhSachNhatKy_SelectedIndexChanged(object sender, EventArgs e)
        {

            groupBoxWrite.Visible = true;
            lblTenNK.Text = clbDanhSachNhatKy.SelectedItem.ToString();
            if (clbDanhSachNhatKy.SelectedIndex != -1)
            {
                OpenFile();
            }
            else
                MessageBox.Show("Bạn phải chọn nhật ký");
        }
        private void LoadDSFiles()
        {
            DirectoryInfo di = new DirectoryInfo("New folder\\");
            dsFileName = di.GetFiles();
            string s = "";
            clbDanhSachNhatKy.Items.Clear(); //reset danh sách các Files
            for (int i = 0; i < dsFileName.Length; i++)
            {
                s = dsFileName[i].ToString();
                clbDanhSachNhatKy.Items.Add(s.Substring(0, s.Length - 4));
            }
            lblSoNK.Text = dsFileName.Length.ToString();


        }
        private void ThemFontSize()
        {
            for (int i = 3; i <= 40; i++)
            {
                cbsize.Items.Add(i);
            }
            //FontFamily fa = new FontFamily();
            InstalledFontCollection listfont = new InstalledFontCollection();
            foreach (FontFamily font in listfont.Families)
            {
                cbfont.Items.Add(font.Name);
            }
        }

        private void frmQuanLyNK_Load(object sender, EventArgs e)
        {
            LoadDSFiles();

            timer1.Interval = 1000;
            timer1.Start();

            groupBoxWrite.Visible = false;
            ThemFontSize();
            
        }



        private void btnTim_Click(object sender, EventArgs e)
        {
            frmSearch se = new frmSearch();
            se.ShowDialog();
            string ntn = se.day;
            int count = 0;
            for (int i = 0; i < clbDanhSachNhatKy.Items.Count; i++)
            {
                if (ntn.CompareTo(clbDanhSachNhatKy.Items[i]) == 0)
                {
                    clbDanhSachNhatKy.SetItemChecked(i, true);
                    clbDanhSachNhatKy.SetSelected(i, true);
                    count++;
                }
            }
            if (count == 0)
            {
                MessageBox.Show("Không tìm thấy nhật ký: " + ntn);
            }

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain frm = new frmMain();
            frm.ShowDialog();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            lbGio.Text = DateTime.Now.ToString("hh");
            lbPhut.Text = DateTime.Now.ToString("mm");
        }

        private void toolStripButtonLeft_Click(object sender, EventArgs e)
        {
            rtbViet.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButtonCenter_Click(object sender, EventArgs e)
        {
            rtbViet.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripButtonRight_Click(object sender, EventArgs e)
        {
            rtbViet.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripButtonBold_Click(object sender, EventArgs e)
        {

            FontStyle style = rtbViet.SelectionFont.Style;
            if (rtbViet.SelectionFont.Bold)
            {
                style = style & ~FontStyle.Bold;
            }
            else
            {
                style = style | FontStyle.Bold;
            }
            rtbViet.SelectionFont = new Font(rtbViet.SelectionFont, style);

        }

        private void toolStripButtonIlatic_Click(object sender, EventArgs e)
        {

            FontStyle style = rtbViet.SelectionFont.Style;
            if (rtbViet.SelectionFont.Italic)
            {
                style = style & ~FontStyle.Italic;
            }
            else
            {
                style = style | FontStyle.Italic;
            }
            rtbViet.SelectionFont = new Font(rtbViet.SelectionFont, style);

        }

        private void toolStripButtonUnderline_Click(object sender, EventArgs e)
        {

            FontStyle style = rtbViet.SelectionFont.Style;
            if (rtbViet.SelectionFont.Underline)
            {
                style = style & ~FontStyle.Underline;
            }
            else
            {
                style = style | FontStyle.Underline;
            }
            rtbViet.SelectionFont = new Font(rtbViet.SelectionFont, style);

        }

        private void cbfont_SelectedIndexChanged(object sender, EventArgs e)
        {

            FontStyle style = rtbViet.SelectionFont.Style;
            rtbViet.SelectionFont = new Font(cbfont.Text, float.Parse(cbsize.Text), style);

        }

        private void cbsize_SelectedIndexChanged(object sender, EventArgs e)
        {

            FontStyle style = rtbViet.SelectionFont.Style;
            rtbViet.SelectionFont = new Font(cbfont.Text, float.Parse(cbsize.Text), style);
        }


        private void uc1_Click(object sender, EventArgs e)
        {
            rtbViet.SelectionColor = uc1.curColor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbViet.SelectionColor = colorDialog1.Color;
            }
            OnClick(e);

        }

        //những hàm dùng để phát nhạc
        playSound ps = new playSound();
        string fileName = "";
        private void btnPhatNhac_Click(object sender, EventArgs e)
        {
            btnDung.Visible = true;
            DialogResult dr = MessageBox.Show("Bạn muốn tự phát nhạc không", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                lblTenNhac.Visible = true;
                ps.OpenMediaFile("Nhac\\kisstherain.mp3");//duong dan +ten bai hat.đinh dang bai hat
                ps.PlayMediaFile(true);
                fileName = "kisstherain";
            }
            else
            {
                ps.ClosePlayer();
                OpenFileDialog open = new OpenFileDialog();
                open.ShowDialog();
                int vt = open.FileName.LastIndexOf("\\");
                fileName = open.FileName.Substring(vt - 4);
                ps.OpenMediaFile(fileName);//ten bai hat.đinh dang bai hat
                ps.PlayMediaFile(true);
                lblTenNhac.Visible = true;
            }
            lblTenNhac.Text = fileName;
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            ps.ClosePlayer();
        }
    }
}
