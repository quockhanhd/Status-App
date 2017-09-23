using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            op.FileName = "New folder\\"+clbDanhSachNhatKy.Items[clbDanhSachNhatKy.SelectedIndex] + ".doc";
            rtbViet.LoadFile(op.FileName, RichTextBoxStreamType.RichText);
        }
        private void rtbViet_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            SaveFile();
            int dem = 0;
            string getDate = DateTime.Now.ToString("dd-MM-yyyy");
            for (int i=0;i<clbDanhSachNhatKy.Items.Count;i++)
            {
                if (getDate.CompareTo(clbDanhSachNhatKy.Items[i]) == 0)
                    dem++;
            }
            if(dem==0)
            {
                clbDanhSachNhatKy.Items.Add(getDate);
            }
        }

        private void btnViet_Click(object sender, EventArgs e)
        {
            rtbViet.Visible = true;
            btnLuu.Visible = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //for(int )
        }

        private void clbDanhSachNhatKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbViet.Visible = true;
            btnLuu.Visible = true;
            if (clbDanhSachNhatKy.SelectedIndex != -1)
            {
                OpenFile();
            }
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
        }

        private void frmQuanLyNK_Load(object sender, EventArgs e)
        {
            LoadDSFiles();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Sửa
            
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            frmSearch se = new frmSearch();
            se.ShowDialog();
            string ntn = se.day;
            for (int i = 0; i < clbDanhSachNhatKy.Items.Count; i++)
            {
                if (ntn.CompareTo(clbDanhSachNhatKy.Items[i]) == 0)
                {
                    clbDanhSachNhatKy.SetItemChecked(i, true);
                    clbDanhSachNhatKy.SetSelected(i,true);
                }
            }
        }
    }
}
