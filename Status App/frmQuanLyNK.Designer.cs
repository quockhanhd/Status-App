namespace Status_App
{
    partial class frmQuanLyNK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyNK));
            this.btnViet = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clbDanhSachNhatKy = new System.Windows.Forms.CheckedListBox();
            this.rtbViet = new System.Windows.Forms.RichTextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnViet
            // 
            this.btnViet.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnViet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViet.Location = new System.Drawing.Point(85, 78);
            this.btnViet.Name = "btnViet";
            this.btnViet.Size = new System.Drawing.Size(82, 43);
            this.btnViet.TabIndex = 0;
            this.btnViet.Text = "Viết";
            this.btnViet.UseVisualStyleBackColor = false;
            this.btnViet.Click += new System.EventHandler(this.btnViet_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(85, 155);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 43);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.clbDanhSachNhatKy);
            this.groupBox1.Location = new System.Drawing.Point(200, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 172);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Nhật Ký";
            // 
            // clbDanhSachNhatKy
            // 
            this.clbDanhSachNhatKy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbDanhSachNhatKy.CheckOnClick = true;
            this.clbDanhSachNhatKy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clbDanhSachNhatKy.FormattingEnabled = true;
            this.clbDanhSachNhatKy.Location = new System.Drawing.Point(3, 34);
            this.clbDanhSachNhatKy.Name = "clbDanhSachNhatKy";
            this.clbDanhSachNhatKy.Size = new System.Drawing.Size(142, 135);
            this.clbDanhSachNhatKy.TabIndex = 0;
            this.clbDanhSachNhatKy.ThreeDCheckBoxes = true;
            this.clbDanhSachNhatKy.SelectedIndexChanged += new System.EventHandler(this.clbDanhSachNhatKy_SelectedIndexChanged);
            // 
            // rtbViet
            // 
            this.rtbViet.Location = new System.Drawing.Point(419, 78);
            this.rtbViet.Name = "rtbViet";
            this.rtbViet.Size = new System.Drawing.Size(308, 282);
            this.rtbViet.TabIndex = 2;
            this.rtbViet.Text = "";
            this.rtbViet.Visible = false;
            this.rtbViet.TextChanged += new System.EventHandler(this.rtbViet_TextChanged);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(645, 366);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(82, 43);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Visible = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(85, 235);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(82, 43);
            this.btnTim.TabIndex = 0;
            this.btnTim.Text = "Tìm Kiếm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // frmQuanLyNK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(794, 454);
            this.Controls.Add(this.rtbViet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnViet);
            this.Name = "frmQuanLyNK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuanLyNK";
            this.Load += new System.EventHandler(this.frmQuanLyNK_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViet;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox clbDanhSachNhatKy;
        private System.Windows.Forms.RichTextBox rtbViet;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTim;
    }
}