namespace GUI
{
    partial class frmDanhSachKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSachKhachHang));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new MaterialSkin.Controls.MaterialTextBox2();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdTenKhachHang = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdDiaChi = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdDienThoai = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdEmail = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnHienThiTatCa = new MaterialSkin.Controls.MaterialButton();
            this.btnChon = new MaterialSkin.Controls.MaterialButton();
            this.btnDong = new MaterialSkin.Controls.MaterialButton();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Controls.Add(this.dgvKhachHang);
            this.groupBox3.Location = new System.Drawing.Point(32, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1011, 375);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bảng thông tin Khách Hàng";
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AllowUserToDeleteRows = false;
            this.dgvKhachHang.AllowUserToResizeColumns = false;
            this.dgvKhachHang.AllowUserToResizeRows = false;
            this.dgvKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhachHang,
            this.TenKhachHang,
            this.DienThoai,
            this.DiaChi,
            this.Email,
            this.TienNo});
            this.dgvKhachHang.Location = new System.Drawing.Point(7, 26);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.Size = new System.Drawing.Size(998, 343);
            this.dgvKhachHang.TabIndex = 0;
            this.dgvKhachHang.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_RowEnter);
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.DataPropertyName = "MaKhachHang";
            this.MaKhachHang.HeaderText = "Mã KH";
            this.MaKhachHang.Name = "MaKhachHang";
            this.MaKhachHang.ReadOnly = true;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.DataPropertyName = "TenKhachHang";
            this.TenKhachHang.HeaderText = "Tên khách hàng";
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.ReadOnly = true;
            this.TenKhachHang.Width = 200;
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "SDT";
            this.DienThoai.HeaderText = "Điện thoại";
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.ReadOnly = true;
            this.DienThoai.Width = 150;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 150;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 200;
            // 
            // TienNo
            // 
            this.TienNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TienNo.DataPropertyName = "SoTienNo";
            this.TienNo.HeaderText = "Tiền nợ";
            this.TienNo.Name = "TienNo";
            this.TienNo.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(32, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 94);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.AnimateReadOnly = false;
            this.txtTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTimKiem.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTimKiem.Depth = 0;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTimKiem.HideSelection = true;
            this.txtTimKiem.LeadingIcon = null;
            this.txtTimKiem.Location = new System.Drawing.Point(86, 25);
            this.txtTimKiem.MaxLength = 32767;
            this.txtTimKiem.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PrefixSuffixText = null;
            this.txtTimKiem.ReadOnly = false;
            this.txtTimKiem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.SelectionLength = 0;
            this.txtTimKiem.SelectionStart = 0;
            this.txtTimKiem.ShortcutsEnabled = true;
            this.txtTimKiem.Size = new System.Drawing.Size(226, 48);
            this.txtTimKiem.TabIndex = 13;
            this.txtTimKiem.TabStop = false;
            this.txtTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTimKiem.TrailingIcon = null;
            this.txtTimKiem.UseSystemPasswordChar = false;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Từ khóa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(331, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.rdTenKhachHang);
            this.groupBox2.Controls.Add(this.rdDiaChi);
            this.groupBox2.Controls.Add(this.rdDienThoai);
            this.groupBox2.Controls.Add(this.rdEmail);
            this.groupBox2.Location = new System.Drawing.Point(398, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(639, 94);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm theo";
            // 
            // rdTenKhachHang
            // 
            this.rdTenKhachHang.AutoSize = true;
            this.rdTenKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdTenKhachHang.Depth = 0;
            this.rdTenKhachHang.Location = new System.Drawing.Point(463, 36);
            this.rdTenKhachHang.Margin = new System.Windows.Forms.Padding(0);
            this.rdTenKhachHang.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdTenKhachHang.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdTenKhachHang.Name = "rdTenKhachHang";
            this.rdTenKhachHang.Ripple = true;
            this.rdTenKhachHang.Size = new System.Drawing.Size(149, 37);
            this.rdTenKhachHang.TabIndex = 13;
            this.rdTenKhachHang.TabStop = true;
            this.rdTenKhachHang.Text = "Tên khách hàng";
            this.rdTenKhachHang.UseVisualStyleBackColor = true;
            this.rdTenKhachHang.CheckedChanged += new System.EventHandler(this.rdTenKhachHang_CheckedChanged);
            // 
            // rdDiaChi
            // 
            this.rdDiaChi.AutoSize = true;
            this.rdDiaChi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdDiaChi.Depth = 0;
            this.rdDiaChi.Location = new System.Drawing.Point(33, 36);
            this.rdDiaChi.Margin = new System.Windows.Forms.Padding(0);
            this.rdDiaChi.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdDiaChi.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdDiaChi.Name = "rdDiaChi";
            this.rdDiaChi.Ripple = true;
            this.rdDiaChi.Size = new System.Drawing.Size(84, 37);
            this.rdDiaChi.TabIndex = 13;
            this.rdDiaChi.TabStop = true;
            this.rdDiaChi.Text = "Địa chỉ";
            this.rdDiaChi.UseVisualStyleBackColor = true;
            this.rdDiaChi.CheckedChanged += new System.EventHandler(this.rdDiaChi_CheckedChanged);
            // 
            // rdDienThoai
            // 
            this.rdDienThoai.AutoSize = true;
            this.rdDienThoai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdDienThoai.Depth = 0;
            this.rdDienThoai.Location = new System.Drawing.Point(313, 36);
            this.rdDienThoai.Margin = new System.Windows.Forms.Padding(0);
            this.rdDienThoai.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdDienThoai.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdDienThoai.Name = "rdDienThoai";
            this.rdDienThoai.Ripple = true;
            this.rdDienThoai.Size = new System.Drawing.Size(107, 37);
            this.rdDienThoai.TabIndex = 13;
            this.rdDienThoai.TabStop = true;
            this.rdDienThoai.Text = "Điện thoại";
            this.rdDienThoai.UseVisualStyleBackColor = true;
            this.rdDienThoai.CheckedChanged += new System.EventHandler(this.rdDienThoai_CheckedChanged);
            // 
            // rdEmail
            // 
            this.rdEmail.AutoSize = true;
            this.rdEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdEmail.Depth = 0;
            this.rdEmail.Location = new System.Drawing.Point(176, 36);
            this.rdEmail.Margin = new System.Windows.Forms.Padding(0);
            this.rdEmail.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdEmail.Name = "rdEmail";
            this.rdEmail.Ripple = true;
            this.rdEmail.Size = new System.Drawing.Size(75, 37);
            this.rdEmail.TabIndex = 13;
            this.rdEmail.TabStop = true;
            this.rdEmail.Text = "Email";
            this.rdEmail.UseVisualStyleBackColor = true;
            this.rdEmail.CheckedChanged += new System.EventHandler(this.rdEmail_CheckedChanged);
            // 
            // btnHienThiTatCa
            // 
            this.btnHienThiTatCa.AutoSize = false;
            this.btnHienThiTatCa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHienThiTatCa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHienThiTatCa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHienThiTatCa.Depth = 0;
            this.btnHienThiTatCa.HighEmphasis = true;
            this.btnHienThiTatCa.Icon = global::GUI.Properties.Resources.icons8_list_view_64;
            this.btnHienThiTatCa.Location = new System.Drawing.Point(489, 667);
            this.btnHienThiTatCa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHienThiTatCa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHienThiTatCa.Name = "btnHienThiTatCa";
            this.btnHienThiTatCa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHienThiTatCa.Size = new System.Drawing.Size(236, 48);
            this.btnHienThiTatCa.TabIndex = 12;
            this.btnHienThiTatCa.Text = "HIỂN THỊ TẤT CẢ";
            this.btnHienThiTatCa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHienThiTatCa.UseAccentColor = false;
            this.btnHienThiTatCa.UseVisualStyleBackColor = true;
            this.btnHienThiTatCa.Click += new System.EventHandler(this.btnHienThiTatCa_Click);
            // 
            // btnChon
            // 
            this.btnChon.AutoSize = false;
            this.btnChon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChon.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnChon.Depth = 0;
            this.btnChon.HighEmphasis = true;
            this.btnChon.Icon = global::GUI.Properties.Resources.icons8_checkmark_64;
            this.btnChon.Location = new System.Drawing.Point(752, 667);
            this.btnChon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnChon.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChon.Name = "btnChon";
            this.btnChon.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnChon.Size = new System.Drawing.Size(138, 48);
            this.btnChon.TabIndex = 12;
            this.btnChon.Text = "CHỌN";
            this.btnChon.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnChon.UseAccentColor = false;
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnDong
            // 
            this.btnDong.AutoSize = false;
            this.btnDong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDong.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDong.Depth = 0;
            this.btnDong.HighEmphasis = true;
            this.btnDong.Icon = global::GUI.Properties.Resources.icons8_logout_64;
            this.btnDong.Location = new System.Drawing.Point(917, 667);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDong.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDong.Name = "btnDong";
            this.btnDong.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDong.Size = new System.Drawing.Size(119, 48);
            this.btnDong.TabIndex = 12;
            this.btnDong.Text = "THOÁT";
            this.btnDong.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDong.UseAccentColor = false;
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmDanhSachKhachHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1083, 763);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.btnHienThiTatCa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDanhSachKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Khách Hàng";
            this.Load += new System.EventHandler(this.frmDanhSachKhachHang_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialButton btnHienThiTatCa;
        private MaterialSkin.Controls.MaterialButton btnChon;
        private MaterialSkin.Controls.MaterialButton btnDong;
        private MaterialSkin.Controls.MaterialTextBox2 txtTimKiem;
        private MaterialSkin.Controls.MaterialRadioButton rdTenKhachHang;
        private MaterialSkin.Controls.MaterialRadioButton rdDiaChi;
        private MaterialSkin.Controls.MaterialRadioButton rdDienThoai;
        private MaterialSkin.Controls.MaterialRadioButton rdEmail;
    }
}