namespace GUI
{
    partial class frmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMatKhau));
            this.txtReMKmoi = new System.Windows.Forms.TextBox();
            this.txtMKmoi = new System.Windows.Forms.TextBox();
            this.txtMKcu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butDoiMK = new MaterialSkin.Controls.MaterialButton();
            this.butXoatrang = new MaterialSkin.Controls.MaterialButton();
            this.butThoat = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtReMKmoi
            // 
            this.txtReMKmoi.Location = new System.Drawing.Point(193, 318);
            this.txtReMKmoi.Name = "txtReMKmoi";
            this.txtReMKmoi.Size = new System.Drawing.Size(258, 26);
            this.txtReMKmoi.TabIndex = 11;
            this.txtReMKmoi.UseSystemPasswordChar = true;
            // 
            // txtMKmoi
            // 
            this.txtMKmoi.Location = new System.Drawing.Point(193, 260);
            this.txtMKmoi.Name = "txtMKmoi";
            this.txtMKmoi.Size = new System.Drawing.Size(258, 26);
            this.txtMKmoi.TabIndex = 8;
            this.txtMKmoi.UseSystemPasswordChar = true;
            // 
            // txtMKcu
            // 
            this.txtMKcu.Location = new System.Drawing.Point(193, 205);
            this.txtMKcu.Name = "txtMKcu";
            this.txtMKcu.Size = new System.Drawing.Size(258, 26);
            this.txtMKcu.TabIndex = 6;
            this.txtMKcu.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(37, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nhập lại mật khẩu mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(37, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(37, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // butDoiMK
            // 
            this.butDoiMK.AutoSize = false;
            this.butDoiMK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butDoiMK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butDoiMK.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.butDoiMK.Depth = 0;
            this.butDoiMK.HighEmphasis = true;
            this.butDoiMK.Icon = global::GUI.Properties.Resources.icons8_password_reset_64;
            this.butDoiMK.Location = new System.Drawing.Point(41, 390);
            this.butDoiMK.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butDoiMK.MouseState = MaterialSkin.MouseState.HOVER;
            this.butDoiMK.Name = "butDoiMK";
            this.butDoiMK.NoAccentTextColor = System.Drawing.Color.Empty;
            this.butDoiMK.Size = new System.Drawing.Size(150, 36);
            this.butDoiMK.TabIndex = 15;
            this.butDoiMK.Text = "ĐỔI MẬT KHẨU";
            this.butDoiMK.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butDoiMK.UseAccentColor = false;
            this.butDoiMK.UseVisualStyleBackColor = true;
            this.butDoiMK.Click += new System.EventHandler(this.butDoiMK_Click);
            // 
            // butXoatrang
            // 
            this.butXoatrang.AutoSize = false;
            this.butXoatrang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butXoatrang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butXoatrang.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.butXoatrang.Depth = 0;
            this.butXoatrang.HighEmphasis = true;
            this.butXoatrang.Icon = global::GUI.Properties.Resources.icons8_clear_symbol_64;
            this.butXoatrang.Location = new System.Drawing.Point(219, 390);
            this.butXoatrang.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butXoatrang.MouseState = MaterialSkin.MouseState.HOVER;
            this.butXoatrang.Name = "butXoatrang";
            this.butXoatrang.NoAccentTextColor = System.Drawing.Color.Empty;
            this.butXoatrang.Size = new System.Drawing.Size(104, 36);
            this.butXoatrang.TabIndex = 15;
            this.butXoatrang.Text = "XÓA";
            this.butXoatrang.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butXoatrang.UseAccentColor = false;
            this.butXoatrang.UseVisualStyleBackColor = true;
            this.butXoatrang.Click += new System.EventHandler(this.butXoatrang_Click);
            // 
            // butThoat
            // 
            this.butThoat.AutoSize = false;
            this.butThoat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butThoat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.butThoat.Depth = 0;
            this.butThoat.HighEmphasis = true;
            this.butThoat.Icon = global::GUI.Properties.Resources.icons8_logout_64;
            this.butThoat.Location = new System.Drawing.Point(350, 390);
            this.butThoat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butThoat.MouseState = MaterialSkin.MouseState.HOVER;
            this.butThoat.Name = "butThoat";
            this.butThoat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.butThoat.Size = new System.Drawing.Size(101, 36);
            this.butThoat.TabIndex = 15;
            this.butThoat.Text = "THOÁT";
            this.butThoat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butThoat.UseAccentColor = false;
            this.butThoat.UseVisualStyleBackColor = true;
            this.butThoat.Click += new System.EventHandler(this.butThoat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::GUI.Properties.Resources.icons8_password_reset_96;
            this.pictureBox1.Location = new System.Drawing.Point(208, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 95);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(483, 474);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butThoat);
            this.Controls.Add(this.butXoatrang);
            this.Controls.Add(this.butDoiMK);
            this.Controls.Add(this.txtReMKmoi);
            this.Controls.Add(this.txtMKmoi);
            this.Controls.Add(this.txtMKcu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Mật Khẩu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDoiMatKhau_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReMKmoi;
        private System.Windows.Forms.TextBox txtMKmoi;
        private System.Windows.Forms.TextBox txtMKcu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton butDoiMK;
        private MaterialSkin.Controls.MaterialButton butXoatrang;
        private MaterialSkin.Controls.MaterialButton butThoat;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}