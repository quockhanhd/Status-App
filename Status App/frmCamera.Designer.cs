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
            this.btnChup.Location = new System.Drawing.Point(117, 218);
            this.btnChup.Name = "btnChup";
            this.btnChup.Size = new System.Drawing.Size(75, 23);
            this.btnChup.TabIndex = 2;
            this.btnChup.Text = "Chụp";
            this.btnChup.UseVisualStyleBackColor = false;
            this.btnChup.Click += new System.EventHandler(this.btnChup_Click);
            // 
            // frmCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(346, 246);
            this.Controls.Add(this.btnChup);
            this.Controls.Add(this.cameraControl1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmCamera";
            this.Text = "Camera";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Camera.CameraControl cameraControl1;
        private System.Windows.Forms.Button btnChup;
    }
}