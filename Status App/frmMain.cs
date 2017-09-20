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
        private void mo()
        {
            richTextBox1.Visible = true;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = ".doc|*.doc";
            open.RestoreDirectory = true;
            open.FilterIndex = 2;
            if (open.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(open.FileName);
            }
        }
        private void save()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = ".doc|*.doc";
            save.RestoreDirectory = true;
            save.FilterIndex = 2;
            save.FileName = DateTime.Now.ToString("dd-MM-yyyy");
            if (save.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.RichNoOleObjs);
            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.FileName = "E:\\C#\\TaiLieu\\Môi Trường và Công Cụ Lập Trình\\Status App\\Status App\\bin\\Debug\\";
            s.FileName += listBox1.SelectedItems[0].ToString() + ".doc";
            richTextBox1.SaveFile(s.FileName);
            string ss = "";
            ss = s.FileName.ToString().Substring(s.FileName.Length - 4);
            listBox1.Items.Add(ss);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OpenFileDialog s = new OpenFileDialog();
            if (listBox1.SelectedIndex != -1)
            {
                s.FileName = "E:\\C#\\TaiLieu\\Môi Trường và Công Cụ Lập Trình\\Status App\\Status App\\bin\\Debug\\";
                s.FileName += listBox1.SelectedItems[0].ToString() + ".doc";

            }
            ///"E:\\C#\\TaiLieu\\Môi Trường và Công Cụ Lập Trình\\Status App\\Status App\\bin\\Debug\\20-09-2017.doc"
            //   "E:\\C#\\TaiLieu\\Môi Trường và Công Cụ Lập Trình\\Status App\\Status App\\bin\\Debug\\20-9-2017.doc"
            richTextBox1.LoadFile(s.FileName);
            // mo();
        }
    }
}
