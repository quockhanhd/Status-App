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
    public partial class frmMain : Form
    {
        FileInfo[] dsFileName;
       
        public frmMain()
        {
            InitializeComponent();
        }

        //Phương thức mở File
        private void OpenFile()
        {
            OpenFileDialog s = new OpenFileDialog();
            if (listBox1.SelectedIndex != -1)
            {
                s.FileName = "C:\\FilesStatusApp\\";
                s.FileName += listBox1.SelectedItem.ToString() + ".doc";
                richTextBox1.LoadFile(s.FileName, RichTextBoxStreamType.RichText);
            }

            else
            {
                MessageBox.Show("Vui Lòng Chọn Nhật Ký Để Xem" + "\n" + "Hoặc Nhấn Nút Tạo Mới");
            }
        }

        //Phương thức Đóng File
        private void SaveFile()
        {
            SaveFileDialog s = new SaveFileDialog();
        
            //Nếu đang chọn nhật ký thì Filename không thay đổi
            if (listBox1.SelectedIndex != -1)
            {
                s.FileName = "C:\\FilesStatusApp\\" + listBox1.SelectedItem.ToString() + ".doc";
            }
            //Nếu không chọn nhật ký nào thì Filename= DateTime.Now
            s.FileName = "C:\\FilesStatusApp\\" + DateTime.Now.ToString("dd-MM-yyyy") + ".doc";

            // Lưu file
            richTextBox1.SaveFile(s.FileName, RichTextBoxStreamType.RichNoOleObjs);



        }

        //Phương thức Xóa File
        private void DeleteFile()
        {
            OpenFileDialog s = new OpenFileDialog();
            if (listBox1.SelectedIndex != -1)
            {
                MessageBox.Show("Bạn Có Muốn Xóa Nhật Ký Này Không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                s.FileName = "C:\\FilesStatusApp\\";
                s.FileName += listBox1.SelectedItems[0].ToString() + ".doc";
                File.Delete(s.FileName);
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Nhật Ký Để Xóa");
            }
            LoadDSFiles();
        }
        private void button2_Click(object sender, EventArgs e)
        {

           
            SaveFile();
            LoadDSFiles();
        }


       

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            OpenFile();
        }
        private void LoadDSFiles()
        {
            DirectoryInfo di = new DirectoryInfo("C:\\FilesStatusApp");
            dsFileName = di.GetFiles();
            string s = "";
            listBox1.Items.Clear(); //reset danh sách các Files
            for (int i = 0; i < dsFileName.Length; i++)
            {
                s = dsFileName[i].ToString();
                listBox1.Items.Add(s.Substring(0,s.Length-4));
            }
            richTextBox1.Text = "";
        }
        //Sự kiện khi Load form
        private void frmMain_Load(object sender, EventArgs e)
        {

            if (Directory.Exists("C:\\FilesStatusApp"))    //kiểm tra xem thư mục FilesStatusApp đã được tạo chưa
            {
                LoadDSFiles();
            }
            else
            {
                Directory.CreateDirectory("C:\\FilesStatusApp"); // nếu chưa thì tạo thư mục FilesStatusApp (dùng để chứa các file doc)
                LoadDSFiles();
            }
            ////


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteFile();
        }
    }
}
