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
    public partial class frmCamera : Form
    {
        public frmCamera()
        {
            InitializeComponent();
        }
        

        private void btnChup_Click(object sender, EventArgs e)
        {   
            Image capturedImage = cameraControl1.TakeSnapshot();
            UpdateImg(capturedImage);
            MessageBox.Show("Chụp Thành Công! " + "\n" + "Đường dẫn file lưu ở :C:\\FilesStatusApp ");
        }
        private void UpdateImg(Image image)
        {
            using (var stream = new System.IO.MemoryStream())
            {
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                image.Save("C:\\FilesStatusApp\\img1.jpg");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
