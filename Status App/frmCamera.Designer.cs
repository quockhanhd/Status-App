namespace Status_App
{
    partial class frmCamera
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cameraControl1 = new DevExpress.XtraEditors.Camera.CameraControl();
            this.btnChup = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cameraControl1
            // 
            this.cameraControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.cameraControl1.Location = new System.Drawing.Point(-2, -1);
            this.cameraControl1.Name = "cameraControl1";
            this.cameraControl1.Size = new System.Drawing.Size(349, 213);
            this.cameraControl1.TabIndex = 0;
            this.cameraControl1.Text = "cameraControl1";
            // 
            // btnChup
            // 
            this.btnChup.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnChup.ForeColor = System.Drawing.Color.Black;
            this.btnChup.Location = new System.Drawing.Point(12, 217);
            this.btnChup.Name = "btnChup";
            this.btnChup.Size = new System.Drawing.Size(75, 23);
            this.btnChup.TabIndex = 2;
            this.btnChup.Text = "Chụp";
            this.btnChup.UseVisualStyleBackColor = false;
            this.btnChup.Click += new System.EventHandler(this.btnChup_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSalmon;
            this.button3.Location = new System.Drawing.Point(259, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(346, 246);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnChup);
            this.Controls.Add(this.cameraControl1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmInfo";
            this.Text = "Camera";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Camera.CameraControl cameraControl1;
        private System.Windows.Forms.Button btnChup;
        private System.Windows.Forms.Button button3;
    }
}