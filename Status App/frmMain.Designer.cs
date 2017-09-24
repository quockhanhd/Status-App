namespace Status_App
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbGio = new System.Windows.Forms.Label();
            this.lbPhut = new System.Windows.Forms.Label();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnQuanLy = new System.Windows.Forms.Button();
            this.rtbThongTin = new System.Windows.Forms.RichTextBox();
            this.lblTuBach = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnChonHinh = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuuTT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.Red;
            this.monthCalendar1.Location = new System.Drawing.Point(77, 327);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbGio
            // 
            this.lbGio.AutoSize = true;
            this.lbGio.BackColor = System.Drawing.Color.NavajoWhite;
            this.lbGio.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGio.Location = new System.Drawing.Point(531, 3);
            this.lbGio.Name = "lbGio";
            this.lbGio.Size = new System.Drawing.Size(34, 21);
            this.lbGio.TabIndex = 2;
            this.lbGio.Text = "hh";
            // 
            // lbPhut
            // 
            this.lbPhut.AutoSize = true;
            this.lbPhut.BackColor = System.Drawing.Color.NavajoWhite;
            this.lbPhut.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhut.Location = new System.Drawing.Point(567, 3);
            this.lbPhut.Name = "lbPhut";
            this.lbPhut.Size = new System.Drawing.Size(40, 21);
            this.lbPhut.TabIndex = 3;
            this.lbPhut.Text = "mm";
            // 
            // pbAvatar
            // 
            this.pbAvatar.BackColor = System.Drawing.Color.NavajoWhite;
            this.pbAvatar.Location = new System.Drawing.Point(77, 23);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(167, 124);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatar.TabIndex = 4;
            this.pbAvatar.TabStop = false;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(634, -1);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 32);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnQuanLy
            // 
            this.btnQuanLy.BackColor = System.Drawing.Color.Beige;
            this.btnQuanLy.Font = new System.Drawing.Font("UVF A Charming Font Expanded", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLy.Location = new System.Drawing.Point(77, 223);
            this.btnQuanLy.Name = "btnQuanLy";
            this.btnQuanLy.Size = new System.Drawing.Size(227, 82);
            this.btnQuanLy.TabIndex = 0;
            this.btnQuanLy.Text = "Quản Lý Nhật ký";
            this.btnQuanLy.UseVisualStyleBackColor = false;
            this.btnQuanLy.Click += new System.EventHandler(this.btnQuanLy_Click);
            // 
            // rtbThongTin
            // 
            this.rtbThongTin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbThongTin.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rtbThongTin.Location = new System.Drawing.Point(368, 107);
            this.rtbThongTin.Name = "rtbThongTin";
            this.rtbThongTin.Size = new System.Drawing.Size(285, 342);
            this.rtbThongTin.TabIndex = 6;
            this.rtbThongTin.Text = "\nHọ và Tên:  \n\nNgày Sinh:  \n\nSở Thích:    ";
            // 
            // lblTuBach
            // 
            this.lblTuBach.AutoSize = true;
            this.lblTuBach.BackColor = System.Drawing.Color.White;
            this.lblTuBach.Font = new System.Drawing.Font("UVF Slim Tony", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuBach.Location = new System.Drawing.Point(368, 61);
            this.lblTuBach.Name = "lblTuBach";
            this.lblTuBach.Padding = new System.Windows.Forms.Padding(20, 0, 58, 0);
            this.lblTuBach.Size = new System.Drawing.Size(285, 48);
            this.lblTuBach.TabIndex = 7;
            this.lblTuBach.Text = "Thông tin cá nhân";
            this.lblTuBach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChonHinh
            // 
            this.btnChonHinh.BackColor = System.Drawing.Color.Beige;
            this.btnChonHinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonHinh.ForeColor = System.Drawing.Color.Black;
            this.btnChonHinh.Location = new System.Drawing.Point(77, 171);
            this.btnChonHinh.Name = "btnChonHinh";
            this.btnChonHinh.Size = new System.Drawing.Size(91, 27);
            this.btnChonHinh.TabIndex = 0;
            this.btnChonHinh.Text = "Chọn Hình";
            this.btnChonHinh.UseVisualStyleBackColor = false;
            this.btnChonHinh.Click += new System.EventHandler(this.btnChonHinh_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.NavajoWhite;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(559, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = ":";
            // 
            // btnLuuTT
            // 
            this.btnLuuTT.BackColor = System.Drawing.Color.Beige;
            this.btnLuuTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuTT.ForeColor = System.Drawing.Color.Black;
            this.btnLuuTT.Location = new System.Drawing.Point(563, 467);
            this.btnLuuTT.Name = "btnLuuTT";
            this.btnLuuTT.Size = new System.Drawing.Size(91, 22);
            this.btnLuuTT.TabIndex = 0;
            this.btnLuuTT.Text = "Lưu";
            this.btnLuuTT.UseVisualStyleBackColor = false;
            this.btnLuuTT.Click += new System.EventHandler(this.btnLuuTT_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(702, 501);
            this.Controls.Add(this.lblTuBach);
            this.Controls.Add(this.rtbThongTin);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.lbPhut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbGio);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnLuuTT);
            this.Controls.Add(this.btnChonHinh);
            this.Controls.Add(this.btnQuanLy);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbGio;
        private System.Windows.Forms.Label lbPhut;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnQuanLy;
        private System.Windows.Forms.RichTextBox rtbThongTin;
        private System.Windows.Forms.Label lblTuBach;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnChonHinh;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuuTT;
    }
}