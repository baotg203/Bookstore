namespace GUI
{
    partial class frmLapPhieuNhapSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLapPhieuNhapSach));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnResetText = new MaterialSkin.Controls.MaterialButton();
            this.btnBoSung = new MaterialSkin.Controls.MaterialButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnMaSach = new MaterialSkin.Controls.MaterialButton();
            this.txtMaSach = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtSoLuong = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtDonGiaNhap = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtMaPhieuNhapCT = new MaterialSkin.Controls.MaterialTextBox2();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvChiTietPhieuNhap = new System.Windows.Forms.DataGridView();
            this.colMaPNSCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new MaterialSkin.Controls.MaterialButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.colMaPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThem = new MaterialSkin.Controls.MaterialButton();
            this.btnChiTiet = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaPhieuNhap = new MaterialSkin.Controls.MaterialTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDong = new MaterialSkin.Controls.MaterialButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuNhap)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.btnResetText);
            this.groupBox5.Controls.Add(this.btnBoSung);
            this.groupBox5.Location = new System.Drawing.Point(145, 307);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(383, 100);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Các chức năng";
            // 
            // btnResetText
            // 
            this.btnResetText.AutoSize = false;
            this.btnResetText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnResetText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetText.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnResetText.Depth = 0;
            this.btnResetText.HighEmphasis = true;
            this.btnResetText.Icon = global::GUI.Properties.Resources.icons8_clear_symbol_64;
            this.btnResetText.Location = new System.Drawing.Point(228, 34);
            this.btnResetText.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnResetText.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnResetText.Name = "btnResetText";
            this.btnResetText.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnResetText.Size = new System.Drawing.Size(129, 43);
            this.btnResetText.TabIndex = 7;
            this.btnResetText.Text = "XÓA TRẮNG";
            this.btnResetText.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnResetText.UseAccentColor = false;
            this.btnResetText.UseVisualStyleBackColor = true;
            this.btnResetText.Click += new System.EventHandler(this.btnResetText_Click);
            // 
            // btnBoSung
            // 
            this.btnBoSung.AutoSize = false;
            this.btnBoSung.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBoSung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBoSung.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBoSung.Depth = 0;
            this.btnBoSung.HighEmphasis = true;
            this.btnBoSung.Icon = global::GUI.Properties.Resources.icons8_add_new_64;
            this.btnBoSung.Location = new System.Drawing.Point(13, 34);
            this.btnBoSung.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBoSung.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBoSung.Name = "btnBoSung";
            this.btnBoSung.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBoSung.Size = new System.Drawing.Size(134, 43);
            this.btnBoSung.TabIndex = 5;
            this.btnBoSung.Text = "THÊM";
            this.btnBoSung.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBoSung.UseAccentColor = false;
            this.btnBoSung.UseVisualStyleBackColor = true;
            this.btnBoSung.Click += new System.EventHandler(this.btnBoSung_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.btnMaSach);
            this.groupBox4.Controls.Add(this.txtMaSach);
            this.groupBox4.Controls.Add(this.txtSoLuong);
            this.groupBox4.Controls.Add(this.txtDonGiaNhap);
            this.groupBox4.Controls.Add(this.txtMaPhieuNhapCT);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(16, 71);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(601, 230);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin bổ sung";
            // 
            // btnMaSach
            // 
            this.btnMaSach.AutoSize = false;
            this.btnMaSach.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMaSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaSach.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMaSach.Depth = 0;
            this.btnMaSach.HighEmphasis = true;
            this.btnMaSach.Icon = global::GUI.Properties.Resources.icons8_checkmark_64;
            this.btnMaSach.Location = new System.Drawing.Point(252, 185);
            this.btnMaSach.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMaSach.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMaSach.Name = "btnMaSach";
            this.btnMaSach.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMaSach.Size = new System.Drawing.Size(124, 36);
            this.btnMaSach.TabIndex = 6;
            this.btnMaSach.Text = "CHỌN";
            this.btnMaSach.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMaSach.UseAccentColor = false;
            this.btnMaSach.UseVisualStyleBackColor = true;
            this.btnMaSach.Click += new System.EventHandler(this.btnMaSach_Click);
            // 
            // txtMaSach
            // 
            this.txtMaSach.AnimateReadOnly = false;
            this.txtMaSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMaSach.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMaSach.Depth = 0;
            this.txtMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMaSach.HideSelection = true;
            this.txtMaSach.LeadingIcon = null;
            this.txtMaSach.Location = new System.Drawing.Point(426, 25);
            this.txtMaSach.MaxLength = 32767;
            this.txtMaSach.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.PasswordChar = '\0';
            this.txtMaSach.PrefixSuffixText = null;
            this.txtMaSach.ReadOnly = false;
            this.txtMaSach.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMaSach.SelectedText = "";
            this.txtMaSach.SelectionLength = 0;
            this.txtMaSach.SelectionStart = 0;
            this.txtMaSach.ShortcutsEnabled = true;
            this.txtMaSach.Size = new System.Drawing.Size(169, 48);
            this.txtMaSach.TabIndex = 10;
            this.txtMaSach.TabStop = false;
            this.txtMaSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaSach.TrailingIcon = null;
            this.txtMaSach.UseSystemPasswordChar = false;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.AnimateReadOnly = false;
            this.txtSoLuong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSoLuong.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSoLuong.Depth = 0;
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSoLuong.HideSelection = true;
            this.txtSoLuong.LeadingIcon = null;
            this.txtSoLuong.Location = new System.Drawing.Point(426, 102);
            this.txtSoLuong.MaxLength = 32767;
            this.txtSoLuong.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.PasswordChar = '\0';
            this.txtSoLuong.PrefixSuffixText = null;
            this.txtSoLuong.ReadOnly = false;
            this.txtSoLuong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSoLuong.SelectedText = "";
            this.txtSoLuong.SelectionLength = 0;
            this.txtSoLuong.SelectionStart = 0;
            this.txtSoLuong.ShortcutsEnabled = true;
            this.txtSoLuong.Size = new System.Drawing.Size(169, 48);
            this.txtSoLuong.TabIndex = 10;
            this.txtSoLuong.TabStop = false;
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSoLuong.TrailingIcon = null;
            this.txtSoLuong.UseSystemPasswordChar = false;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.AnimateReadOnly = false;
            this.txtDonGiaNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDonGiaNhap.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDonGiaNhap.Depth = 0;
            this.txtDonGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDonGiaNhap.HideSelection = true;
            this.txtDonGiaNhap.LeadingIcon = null;
            this.txtDonGiaNhap.Location = new System.Drawing.Point(129, 102);
            this.txtDonGiaNhap.MaxLength = 32767;
            this.txtDonGiaNhap.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.PasswordChar = '\0';
            this.txtDonGiaNhap.PrefixSuffixText = null;
            this.txtDonGiaNhap.ReadOnly = false;
            this.txtDonGiaNhap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDonGiaNhap.SelectedText = "";
            this.txtDonGiaNhap.SelectionLength = 0;
            this.txtDonGiaNhap.SelectionStart = 0;
            this.txtDonGiaNhap.ShortcutsEnabled = true;
            this.txtDonGiaNhap.Size = new System.Drawing.Size(147, 48);
            this.txtDonGiaNhap.TabIndex = 10;
            this.txtDonGiaNhap.TabStop = false;
            this.txtDonGiaNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDonGiaNhap.TrailingIcon = null;
            this.txtDonGiaNhap.UseSystemPasswordChar = false;
            this.txtDonGiaNhap.TextChanged += new System.EventHandler(this.txtDonGiaNhap_TextChanged);
            // 
            // txtMaPhieuNhapCT
            // 
            this.txtMaPhieuNhapCT.AnimateReadOnly = false;
            this.txtMaPhieuNhapCT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMaPhieuNhapCT.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMaPhieuNhapCT.Depth = 0;
            this.txtMaPhieuNhapCT.Enabled = false;
            this.txtMaPhieuNhapCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMaPhieuNhapCT.HideSelection = true;
            this.txtMaPhieuNhapCT.LeadingIcon = null;
            this.txtMaPhieuNhapCT.Location = new System.Drawing.Point(129, 25);
            this.txtMaPhieuNhapCT.MaxLength = 32767;
            this.txtMaPhieuNhapCT.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaPhieuNhapCT.Name = "txtMaPhieuNhapCT";
            this.txtMaPhieuNhapCT.PasswordChar = '\0';
            this.txtMaPhieuNhapCT.PrefixSuffixText = null;
            this.txtMaPhieuNhapCT.ReadOnly = false;
            this.txtMaPhieuNhapCT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMaPhieuNhapCT.SelectedText = "";
            this.txtMaPhieuNhapCT.SelectionLength = 0;
            this.txtMaPhieuNhapCT.SelectionStart = 0;
            this.txtMaPhieuNhapCT.ShortcutsEnabled = true;
            this.txtMaPhieuNhapCT.Size = new System.Drawing.Size(147, 48);
            this.txtMaPhieuNhapCT.TabIndex = 10;
            this.txtMaPhieuNhapCT.TabStop = false;
            this.txtMaPhieuNhapCT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaPhieuNhapCT.TrailingIcon = null;
            this.txtMaPhieuNhapCT.UseSystemPasswordChar = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(282, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 19);
            this.label10.TabIndex = 5;
            this.label10.Text = "(Auto)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(353, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "Số lượng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Đơn giá nhập:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mã sách:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã phiếu nhập:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(103, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(457, 36);
            this.label8.TabIndex = 0;
            this.label8.Text = "CHI TIẾT PHIẾU NHẬP SÁCH";
            // 
            // dgvChiTietPhieuNhap
            // 
            this.dgvChiTietPhieuNhap.AllowUserToAddRows = false;
            this.dgvChiTietPhieuNhap.AllowUserToDeleteRows = false;
            this.dgvChiTietPhieuNhap.AllowUserToResizeColumns = false;
            this.dgvChiTietPhieuNhap.AllowUserToResizeRows = false;
            this.dgvChiTietPhieuNhap.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPNSCT,
            this.colMaSach,
            this.colSoLuongNhap,
            this.colDonGiaNhap,
            this.colThanhTien});
            this.dgvChiTietPhieuNhap.Location = new System.Drawing.Point(6, 26);
            this.dgvChiTietPhieuNhap.Name = "dgvChiTietPhieuNhap";
            this.dgvChiTietPhieuNhap.Size = new System.Drawing.Size(548, 266);
            this.dgvChiTietPhieuNhap.TabIndex = 0;
            this.dgvChiTietPhieuNhap.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietPhieuNhap_RowEnter);
            // 
            // colMaPNSCT
            // 
            this.colMaPNSCT.DataPropertyName = "MaPNS";
            this.colMaPNSCT.HeaderText = "Mã PN";
            this.colMaPNSCT.Name = "colMaPNSCT";
            this.colMaPNSCT.ReadOnly = true;
            // 
            // colMaSach
            // 
            this.colMaSach.DataPropertyName = "MaSach";
            this.colMaSach.HeaderText = "Mã sách";
            this.colMaSach.Name = "colMaSach";
            this.colMaSach.ReadOnly = true;
            this.colMaSach.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colSoLuongNhap
            // 
            this.colSoLuongNhap.DataPropertyName = "SoLuongNhap";
            this.colSoLuongNhap.HeaderText = "Số lượng";
            this.colSoLuongNhap.Name = "colSoLuongNhap";
            this.colSoLuongNhap.ReadOnly = true;
            // 
            // colDonGiaNhap
            // 
            this.colDonGiaNhap.DataPropertyName = "DonGiaNhap";
            this.colDonGiaNhap.HeaderText = "Đơn giá";
            this.colDonGiaNhap.Name = "colDonGiaNhap";
            this.colDonGiaNhap.ReadOnly = true;
            // 
            // colThanhTien
            // 
            this.colThanhTien.DataPropertyName = "ThanhTien";
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 797);
            this.panel1.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = false;
            this.btnThoat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThoat.Depth = 0;
            this.btnThoat.HighEmphasis = true;
            this.btnThoat.Icon = global::GUI.Properties.Resources.icons8_logout_64;
            this.btnThoat.Location = new System.Drawing.Point(388, 744);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThoat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThoat.Size = new System.Drawing.Size(137, 36);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThoat.UseAccentColor = false;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Controls.Add(this.dgvPhieuNhap);
            this.groupBox3.Location = new System.Drawing.Point(28, 348);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(497, 363);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách phiếu nhập sách";
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.AllowUserToAddRows = false;
            this.dgvPhieuNhap.AllowUserToDeleteRows = false;
            this.dgvPhieuNhap.AllowUserToResizeColumns = false;
            this.dgvPhieuNhap.AllowUserToResizeRows = false;
            this.dgvPhieuNhap.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPhieuNhap,
            this.colNgayNhap,
            this.colTongTien});
            this.dgvPhieuNhap.Location = new System.Drawing.Point(6, 26);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.Size = new System.Drawing.Size(485, 331);
            this.dgvPhieuNhap.TabIndex = 0;
            this.dgvPhieuNhap.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuNhap_RowEnter);
            // 
            // colMaPhieuNhap
            // 
            this.colMaPhieuNhap.DataPropertyName = "MaPNS";
            this.colMaPhieuNhap.HeaderText = "Mã phiếu nhập";
            this.colMaPhieuNhap.Name = "colMaPhieuNhap";
            this.colMaPhieuNhap.ReadOnly = true;
            this.colMaPhieuNhap.Width = 150;
            // 
            // colNgayNhap
            // 
            this.colNgayNhap.DataPropertyName = "NgayNhap";
            this.colNgayNhap.HeaderText = "Ngày nhập";
            this.colNgayNhap.Name = "colNgayNhap";
            this.colNgayNhap.ReadOnly = true;
            this.colNgayNhap.Width = 150;
            // 
            // colTongTien
            // 
            this.colTongTien.DataPropertyName = "TongTien";
            this.colTongTien.HeaderText = "Tổng tiền";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.ReadOnly = true;
            this.colTongTien.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnChiTiet);
            this.groupBox2.Location = new System.Drawing.Point(108, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Các chức năng";
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = false;
            this.btnThem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThem.Depth = 0;
            this.btnThem.HighEmphasis = true;
            this.btnThem.Icon = global::GUI.Properties.Resources.icons8_add_new_64;
            this.btnThem.Location = new System.Drawing.Point(16, 34);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThem.Name = "btnThem";
            this.btnThem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThem.Size = new System.Drawing.Size(121, 43);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThem.UseAccentColor = false;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.AutoSize = false;
            this.btnChiTiet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChiTiet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChiTiet.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnChiTiet.Depth = 0;
            this.btnChiTiet.HighEmphasis = true;
            this.btnChiTiet.Icon = global::GUI.Properties.Resources.icons8_more_details_64;
            this.btnChiTiet.Location = new System.Drawing.Point(200, 34);
            this.btnChiTiet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnChiTiet.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnChiTiet.Size = new System.Drawing.Size(121, 43);
            this.btnChiTiet.TabIndex = 6;
            this.btnChiTiet.Text = "CHI TIẾT";
            this.btnChiTiet.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnChiTiet.UseAccentColor = false;
            this.btnChiTiet.UseVisualStyleBackColor = true;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtMaPhieuNhap);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpNgayNhap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(28, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 165);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lập phiếu nhập";
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.AnimateReadOnly = false;
            this.txtMaPhieuNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaPhieuNhap.Depth = 0;
            this.txtMaPhieuNhap.Enabled = false;
            this.txtMaPhieuNhap.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMaPhieuNhap.LeadingIcon = null;
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(184, 25);
            this.txtMaPhieuNhap.MaxLength = 50;
            this.txtMaPhieuNhap.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaPhieuNhap.Multiline = false;
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(217, 50);
            this.txtMaPhieuNhap.TabIndex = 5;
            this.txtMaPhieuNhap.Text = "";
            this.txtMaPhieuNhap.TrailingIcon = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "(Auto)";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.CustomFormat = "";
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(185, 111);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(216, 26);
            this.dtpNgayNhap.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phiếu nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(136, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU NHẬP SÁCH";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnDong);
            this.panel2.Controls.Add(this.groupBox6);
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(569, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 797);
            this.panel2.TabIndex = 3;
            // 
            // btnDong
            // 
            this.btnDong.AutoSize = false;
            this.btnDong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDong.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDong.Depth = 0;
            this.btnDong.HighEmphasis = true;
            this.btnDong.Icon = global::GUI.Properties.Resources.icons8_close_window_64;
            this.btnDong.Location = new System.Drawing.Point(464, 744);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDong.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDong.Name = "btnDong";
            this.btnDong.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDong.Size = new System.Drawing.Size(137, 36);
            this.btnDong.TabIndex = 8;
            this.btnDong.Text = "ĐÓNG";
            this.btnDong.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDong.UseAccentColor = false;
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox6.Controls.Add(this.dgvChiTietPhieuNhap);
            this.groupBox6.Location = new System.Drawing.Point(41, 413);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(560, 298);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chi tiết phiếu nhập sách";
            // 
            // frmLapPhieuNhapSach
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1223, 884);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmLapPhieuNhapSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập Phiếu Nhập Sách";
            this.Load += new System.EventHandler(this.frmLapPhieuNhapSach_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuNhap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvChiTietPhieuNhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPNSCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private MaterialSkin.Controls.MaterialButton btnResetText;
        private MaterialSkin.Controls.MaterialButton btnBoSung;
        private MaterialSkin.Controls.MaterialButton btnMaSach;
        private MaterialSkin.Controls.MaterialTextBox2 txtMaSach;
        private MaterialSkin.Controls.MaterialTextBox2 txtSoLuong;
        private MaterialSkin.Controls.MaterialTextBox2 txtDonGiaNhap;
        private MaterialSkin.Controls.MaterialTextBox2 txtMaPhieuNhapCT;
        private MaterialSkin.Controls.MaterialButton btnThoat;
        private MaterialSkin.Controls.MaterialButton btnThem;
        private MaterialSkin.Controls.MaterialButton btnChiTiet;
        private MaterialSkin.Controls.MaterialTextBox txtMaPhieuNhap;
        private MaterialSkin.Controls.MaterialButton btnDong;
    }
}