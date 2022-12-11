namespace GUI
{
    partial class frmQuanLySach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLySach));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.colMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDauSach = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colMaTheLoai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colNhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNamXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThem = new MaterialSkin.Controls.MaterialButton();
            this.btnKhongDuocBan = new MaterialSkin.Controls.MaterialButton();
            this.btnCapNhat = new MaterialSkin.Controls.MaterialButton();
            this.btnDuocBan = new MaterialSkin.Controls.MaterialButton();
            this.btnLuu = new MaterialSkin.Controls.MaterialButton();
            this.btnKhongluu = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNamXuatBan = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnMaDauSach = new MaterialSkin.Controls.MaterialButton();
            this.txtDuocBan = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtMaDauSach = new MaterialSkin.Controls.MaterialTextBox2();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNhaXuatBan = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtSoLuongTon = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtGiaBan = new MaterialSkin.Controls.MaterialTextBox2();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaSach = new MaterialSkin.Controls.MaterialTextBox2();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDong = new MaterialSkin.Controls.MaterialButton();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox4.Controls.Add(this.dgvSach);
            this.groupBox4.Location = new System.Drawing.Point(32, 416);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1043, 372);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin chi tiết về cuốn sách";
            // 
            // dgvSach
            // 
            this.dgvSach.AllowUserToAddRows = false;
            this.dgvSach.AllowUserToDeleteRows = false;
            this.dgvSach.AllowUserToResizeColumns = false;
            this.dgvSach.AllowUserToResizeRows = false;
            this.dgvSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSach,
            this.colTenDauSach,
            this.colMaTheLoai,
            this.colNhaXuatBan,
            this.colNamXuatBan,
            this.colSoLuongTon,
            this.colDonGiaBan});
            this.dgvSach.Location = new System.Drawing.Point(6, 25);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersWidth = 51;
            this.dgvSach.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSach.Size = new System.Drawing.Size(1031, 341);
            this.dgvSach.TabIndex = 0;
            this.dgvSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellContentClick);
            this.dgvSach.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_RowEnter);
            // 
            // colMaSach
            // 
            this.colMaSach.DataPropertyName = "MaSach";
            this.colMaSach.HeaderText = "Mã sách";
            this.colMaSach.MinimumWidth = 6;
            this.colMaSach.Name = "colMaSach";
            this.colMaSach.ReadOnly = true;
            // 
            // colTenDauSach
            // 
            this.colTenDauSach.DataPropertyName = "MaDauSach";
            this.colTenDauSach.HeaderText = "Tên đầu sách";
            this.colTenDauSach.MinimumWidth = 6;
            this.colTenDauSach.Name = "colTenDauSach";
            this.colTenDauSach.ReadOnly = true;
            this.colTenDauSach.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTenDauSach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colTenDauSach.Width = 200;
            // 
            // colMaTheLoai
            // 
            this.colMaTheLoai.DataPropertyName = "MaTheLoai";
            this.colMaTheLoai.HeaderText = "Thể loại";
            this.colMaTheLoai.MinimumWidth = 6;
            this.colMaTheLoai.Name = "colMaTheLoai";
            this.colMaTheLoai.ReadOnly = true;
            this.colMaTheLoai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaTheLoai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colMaTheLoai.Width = 170;
            // 
            // colNhaXuatBan
            // 
            this.colNhaXuatBan.DataPropertyName = "NhaXuatBan";
            this.colNhaXuatBan.HeaderText = "Nhà xuất bản";
            this.colNhaXuatBan.MinimumWidth = 6;
            this.colNhaXuatBan.Name = "colNhaXuatBan";
            this.colNhaXuatBan.ReadOnly = true;
            this.colNhaXuatBan.Width = 170;
            // 
            // colNamXuatBan
            // 
            this.colNamXuatBan.DataPropertyName = "NamXuatBan";
            this.colNamXuatBan.HeaderText = "Năm xuất bản";
            this.colNamXuatBan.MinimumWidth = 6;
            this.colNamXuatBan.Name = "colNamXuatBan";
            this.colNamXuatBan.ReadOnly = true;
            this.colNamXuatBan.Width = 130;
            // 
            // colSoLuongTon
            // 
            this.colSoLuongTon.DataPropertyName = "SoLuongTon";
            this.colSoLuongTon.HeaderText = "Số lượng tồn";
            this.colSoLuongTon.MinimumWidth = 6;
            this.colSoLuongTon.Name = "colSoLuongTon";
            this.colSoLuongTon.ReadOnly = true;
            this.colSoLuongTon.Width = 150;
            // 
            // colDonGiaBan
            // 
            this.colDonGiaBan.DataPropertyName = "DonGiaBan";
            this.colDonGiaBan.HeaderText = "Giá bán";
            this.colDonGiaBan.MinimumWidth = 6;
            this.colDonGiaBan.Name = "colDonGiaBan";
            this.colDonGiaBan.ReadOnly = true;
            this.colDonGiaBan.Width = 63;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnKhongDuocBan);
            this.groupBox2.Controls.Add(this.btnCapNhat);
            this.groupBox2.Controls.Add(this.btnDuocBan);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnKhongluu);
            this.groupBox2.Location = new System.Drawing.Point(731, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 281);
            this.groupBox2.TabIndex = 8;
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
            this.btnThem.Location = new System.Drawing.Point(7, 37);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThem.Name = "btnThem";
            this.btnThem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThem.Size = new System.Drawing.Size(156, 51);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "THÊM";
            this.btnThem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThem.UseAccentColor = false;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnKhongDuocBan
            // 
            this.btnKhongDuocBan.AutoSize = false;
            this.btnKhongDuocBan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKhongDuocBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhongDuocBan.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnKhongDuocBan.Depth = 0;
            this.btnKhongDuocBan.HighEmphasis = true;
            this.btnKhongDuocBan.Icon = global::GUI.Properties.Resources.icons8_close_window_64;
            this.btnKhongDuocBan.Location = new System.Drawing.Point(188, 203);
            this.btnKhongDuocBan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnKhongDuocBan.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnKhongDuocBan.Name = "btnKhongDuocBan";
            this.btnKhongDuocBan.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnKhongDuocBan.Size = new System.Drawing.Size(167, 49);
            this.btnKhongDuocBan.TabIndex = 1;
            this.btnKhongDuocBan.Text = "KHÔNG ĐƯỢC BÁN";
            this.btnKhongDuocBan.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnKhongDuocBan.UseAccentColor = false;
            this.btnKhongDuocBan.UseVisualStyleBackColor = true;
            this.btnKhongDuocBan.Click += new System.EventHandler(this.btnKhongDuocBan_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.AutoSize = false;
            this.btnCapNhat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCapNhat.Depth = 0;
            this.btnCapNhat.HighEmphasis = true;
            this.btnCapNhat.Icon = global::GUI.Properties.Resources.icons8_update_64;
            this.btnCapNhat.Location = new System.Drawing.Point(188, 37);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCapNhat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCapNhat.Size = new System.Drawing.Size(167, 51);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "CẬP NHẬT";
            this.btnCapNhat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCapNhat.UseAccentColor = false;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDuocBan
            // 
            this.btnDuocBan.AutoSize = false;
            this.btnDuocBan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDuocBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDuocBan.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDuocBan.Depth = 0;
            this.btnDuocBan.HighEmphasis = true;
            this.btnDuocBan.Icon = global::GUI.Properties.Resources.icons8_get_cash_64;
            this.btnDuocBan.Location = new System.Drawing.Point(7, 203);
            this.btnDuocBan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDuocBan.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDuocBan.Name = "btnDuocBan";
            this.btnDuocBan.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDuocBan.Size = new System.Drawing.Size(156, 49);
            this.btnDuocBan.TabIndex = 1;
            this.btnDuocBan.Text = "ĐƯỢC BÁN";
            this.btnDuocBan.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDuocBan.UseAccentColor = false;
            this.btnDuocBan.UseVisualStyleBackColor = true;
            this.btnDuocBan.Click += new System.EventHandler(this.btnDuocBan_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSize = false;
            this.btnLuu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLuu.Depth = 0;
            this.btnLuu.HighEmphasis = true;
            this.btnLuu.Icon = global::GUI.Properties.Resources.icons8_save_64;
            this.btnLuu.Location = new System.Drawing.Point(7, 120);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLuu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLuu.Size = new System.Drawing.Size(156, 45);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLuu.UseAccentColor = false;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnKhongluu
            // 
            this.btnKhongluu.AutoSize = false;
            this.btnKhongluu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKhongluu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhongluu.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnKhongluu.Depth = 0;
            this.btnKhongluu.HighEmphasis = true;
            this.btnKhongluu.Icon = global::GUI.Properties.Resources.icons8_close_window_64;
            this.btnKhongluu.Location = new System.Drawing.Point(188, 120);
            this.btnKhongluu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnKhongluu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnKhongluu.Name = "btnKhongluu";
            this.btnKhongluu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnKhongluu.Size = new System.Drawing.Size(167, 45);
            this.btnKhongluu.TabIndex = 1;
            this.btnKhongluu.Text = "KHÔNG LƯU";
            this.btnKhongluu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnKhongluu.UseAccentColor = false;
            this.btnKhongluu.UseVisualStyleBackColor = true;
            this.btnKhongluu.Click += new System.EventHandler(this.btnKhongluu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtNamXuatBan);
            this.groupBox1.Controls.Add(this.btnMaDauSach);
            this.groupBox1.Controls.Add(this.txtDuocBan);
            this.groupBox1.Controls.Add(this.txtMaDauSach);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtNhaXuatBan);
            this.groupBox1.Controls.Add(this.txtSoLuongTon);
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtMaSach);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(18, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 281);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết sách";
            // 
            // txtNamXuatBan
            // 
            this.txtNamXuatBan.AnimateReadOnly = false;
            this.txtNamXuatBan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNamXuatBan.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNamXuatBan.Depth = 0;
            this.txtNamXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNamXuatBan.HideSelection = true;
            this.txtNamXuatBan.LeadingIcon = null;
            this.txtNamXuatBan.Location = new System.Drawing.Point(476, 164);
            this.txtNamXuatBan.MaxLength = 32767;
            this.txtNamXuatBan.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNamXuatBan.Name = "txtNamXuatBan";
            this.txtNamXuatBan.PasswordChar = '\0';
            this.txtNamXuatBan.PrefixSuffixText = null;
            this.txtNamXuatBan.ReadOnly = false;
            this.txtNamXuatBan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNamXuatBan.SelectedText = "";
            this.txtNamXuatBan.SelectionLength = 0;
            this.txtNamXuatBan.SelectionStart = 0;
            this.txtNamXuatBan.ShortcutsEnabled = true;
            this.txtNamXuatBan.Size = new System.Drawing.Size(213, 48);
            this.txtNamXuatBan.TabIndex = 1;
            this.txtNamXuatBan.TabStop = false;
            this.txtNamXuatBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNamXuatBan.TrailingIcon = null;
            this.txtNamXuatBan.UseSystemPasswordChar = false;
            // 
            // btnMaDauSach
            // 
            this.btnMaDauSach.AutoSize = false;
            this.btnMaDauSach.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMaDauSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaDauSach.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMaDauSach.Depth = 0;
            this.btnMaDauSach.HighEmphasis = true;
            this.btnMaDauSach.Icon = global::GUI.Properties.Resources.icons8_checkmark_64;
            this.btnMaDauSach.Location = new System.Drawing.Point(476, 236);
            this.btnMaDauSach.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMaDauSach.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMaDauSach.Name = "btnMaDauSach";
            this.btnMaDauSach.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMaDauSach.Size = new System.Drawing.Size(156, 36);
            this.btnMaDauSach.TabIndex = 1;
            this.btnMaDauSach.Text = "CHỌN";
            this.btnMaDauSach.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMaDauSach.UseAccentColor = false;
            this.btnMaDauSach.UseVisualStyleBackColor = true;
            this.btnMaDauSach.Click += new System.EventHandler(this.btnMaDauSach_Click);
            // 
            // txtDuocBan
            // 
            this.txtDuocBan.AnimateReadOnly = false;
            this.txtDuocBan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDuocBan.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDuocBan.Depth = 0;
            this.txtDuocBan.Enabled = false;
            this.txtDuocBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDuocBan.HideSelection = true;
            this.txtDuocBan.LeadingIcon = null;
            this.txtDuocBan.Location = new System.Drawing.Point(120, 227);
            this.txtDuocBan.MaxLength = 32767;
            this.txtDuocBan.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDuocBan.Name = "txtDuocBan";
            this.txtDuocBan.PasswordChar = '\0';
            this.txtDuocBan.PrefixSuffixText = null;
            this.txtDuocBan.ReadOnly = false;
            this.txtDuocBan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDuocBan.SelectedText = "";
            this.txtDuocBan.SelectionLength = 0;
            this.txtDuocBan.SelectionStart = 0;
            this.txtDuocBan.ShortcutsEnabled = true;
            this.txtDuocBan.Size = new System.Drawing.Size(202, 48);
            this.txtDuocBan.TabIndex = 1;
            this.txtDuocBan.TabStop = false;
            this.txtDuocBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDuocBan.TrailingIcon = null;
            this.txtDuocBan.UseSystemPasswordChar = false;
            // 
            // txtMaDauSach
            // 
            this.txtMaDauSach.AnimateReadOnly = false;
            this.txtMaDauSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMaDauSach.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMaDauSach.Depth = 0;
            this.txtMaDauSach.Enabled = false;
            this.txtMaDauSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMaDauSach.HideSelection = true;
            this.txtMaDauSach.LeadingIcon = null;
            this.txtMaDauSach.Location = new System.Drawing.Point(120, 96);
            this.txtMaDauSach.MaxLength = 32767;
            this.txtMaDauSach.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaDauSach.Name = "txtMaDauSach";
            this.txtMaDauSach.PasswordChar = '\0';
            this.txtMaDauSach.PrefixSuffixText = null;
            this.txtMaDauSach.ReadOnly = false;
            this.txtMaDauSach.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMaDauSach.SelectedText = "";
            this.txtMaDauSach.SelectionLength = 0;
            this.txtMaDauSach.SelectionStart = 0;
            this.txtMaDauSach.ShortcutsEnabled = true;
            this.txtMaDauSach.Size = new System.Drawing.Size(202, 48);
            this.txtMaDauSach.TabIndex = 1;
            this.txtMaDauSach.TabStop = false;
            this.txtMaDauSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaDauSach.TrailingIcon = null;
            this.txtMaDauSach.UseSystemPasswordChar = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 19);
            this.label9.TabIndex = 26;
            this.label9.Text = "Được bán:";
            // 
            // txtNhaXuatBan
            // 
            this.txtNhaXuatBan.AnimateReadOnly = false;
            this.txtNhaXuatBan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNhaXuatBan.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNhaXuatBan.Depth = 0;
            this.txtNhaXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNhaXuatBan.HideSelection = true;
            this.txtNhaXuatBan.LeadingIcon = null;
            this.txtNhaXuatBan.Location = new System.Drawing.Point(120, 164);
            this.txtNhaXuatBan.MaxLength = 32767;
            this.txtNhaXuatBan.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNhaXuatBan.Name = "txtNhaXuatBan";
            this.txtNhaXuatBan.PasswordChar = '\0';
            this.txtNhaXuatBan.PrefixSuffixText = null;
            this.txtNhaXuatBan.ReadOnly = false;
            this.txtNhaXuatBan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNhaXuatBan.SelectedText = "";
            this.txtNhaXuatBan.SelectionLength = 0;
            this.txtNhaXuatBan.SelectionStart = 0;
            this.txtNhaXuatBan.ShortcutsEnabled = true;
            this.txtNhaXuatBan.Size = new System.Drawing.Size(202, 48);
            this.txtNhaXuatBan.TabIndex = 1;
            this.txtNhaXuatBan.TabStop = false;
            this.txtNhaXuatBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNhaXuatBan.TrailingIcon = null;
            this.txtNhaXuatBan.UseSystemPasswordChar = false;
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.AnimateReadOnly = false;
            this.txtSoLuongTon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSoLuongTon.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSoLuongTon.Depth = 0;
            this.txtSoLuongTon.Enabled = false;
            this.txtSoLuongTon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSoLuongTon.HideSelection = true;
            this.txtSoLuongTon.LeadingIcon = null;
            this.txtSoLuongTon.Location = new System.Drawing.Point(476, 96);
            this.txtSoLuongTon.MaxLength = 32767;
            this.txtSoLuongTon.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.PasswordChar = '\0';
            this.txtSoLuongTon.PrefixSuffixText = null;
            this.txtSoLuongTon.ReadOnly = false;
            this.txtSoLuongTon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSoLuongTon.SelectedText = "";
            this.txtSoLuongTon.SelectionLength = 0;
            this.txtSoLuongTon.SelectionStart = 0;
            this.txtSoLuongTon.ShortcutsEnabled = true;
            this.txtSoLuongTon.Size = new System.Drawing.Size(213, 48);
            this.txtSoLuongTon.TabIndex = 1;
            this.txtSoLuongTon.TabStop = false;
            this.txtSoLuongTon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSoLuongTon.TrailingIcon = null;
            this.txtSoLuongTon.UseSystemPasswordChar = false;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.AnimateReadOnly = false;
            this.txtGiaBan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtGiaBan.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtGiaBan.Depth = 0;
            this.txtGiaBan.Enabled = false;
            this.txtGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtGiaBan.HideSelection = true;
            this.txtGiaBan.LeadingIcon = null;
            this.txtGiaBan.Location = new System.Drawing.Point(476, 25);
            this.txtGiaBan.MaxLength = 32767;
            this.txtGiaBan.MouseState = MaterialSkin.MouseState.OUT;
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.PasswordChar = '\0';
            this.txtGiaBan.PrefixSuffixText = null;
            this.txtGiaBan.ReadOnly = false;
            this.txtGiaBan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGiaBan.SelectedText = "";
            this.txtGiaBan.SelectionLength = 0;
            this.txtGiaBan.SelectionStart = 0;
            this.txtGiaBan.ShortcutsEnabled = true;
            this.txtGiaBan.Size = new System.Drawing.Size(213, 48);
            this.txtGiaBan.TabIndex = 1;
            this.txtGiaBan.TabStop = false;
            this.txtGiaBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtGiaBan.TrailingIcon = null;
            this.txtGiaBan.UseSystemPasswordChar = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(373, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Năm xuất bản:";
            // 
            // txtMaSach
            // 
            this.txtMaSach.AnimateReadOnly = false;
            this.txtMaSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMaSach.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMaSach.Depth = 0;
            this.txtMaSach.Enabled = false;
            this.txtMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMaSach.HideSelection = true;
            this.txtMaSach.LeadingIcon = null;
            this.txtMaSach.Location = new System.Drawing.Point(120, 25);
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
            this.txtMaSach.Size = new System.Drawing.Size(202, 48);
            this.txtMaSach.TabIndex = 1;
            this.txtMaSach.TabStop = false;
            this.txtMaSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaSach.TrailingIcon = null;
            this.txtMaSach.UseSystemPasswordChar = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Nhà xuất bản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = " (Auto)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Số lượng tồn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Giá bán:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã đầu sách:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mã sách:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(455, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "QUẢN LÝ SÁCH";
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
            this.btnDong.Location = new System.Drawing.Point(919, 797);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDong.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDong.Name = "btnDong";
            this.btnDong.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDong.Size = new System.Drawing.Size(156, 49);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "THOÁT";
            this.btnDong.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDong.UseAccentColor = false;
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmQuanLySach
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1115, 884);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmQuanLySach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLySach_FormClosing);
            this.Load += new System.EventHandler(this.frmQuanLySach_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSach;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTenDauSach;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhaXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGiaBan;
        private MaterialSkin.Controls.MaterialTextBox2 txtMaDauSach;
        private MaterialSkin.Controls.MaterialTextBox2 txtDuocBan;
        private MaterialSkin.Controls.MaterialTextBox2 txtNamXuatBan;
        private MaterialSkin.Controls.MaterialTextBox2 txtNhaXuatBan;
        private MaterialSkin.Controls.MaterialTextBox2 txtSoLuongTon;
        private MaterialSkin.Controls.MaterialTextBox2 txtGiaBan;
        private MaterialSkin.Controls.MaterialTextBox2 txtMaSach;
        private MaterialSkin.Controls.MaterialButton btnDong;
        private MaterialSkin.Controls.MaterialButton btnKhongDuocBan;
        private MaterialSkin.Controls.MaterialButton btnDuocBan;
        private MaterialSkin.Controls.MaterialButton btnKhongluu;
        private MaterialSkin.Controls.MaterialButton btnLuu;
        private MaterialSkin.Controls.MaterialButton btnCapNhat;
        private MaterialSkin.Controls.MaterialButton btnThem;
        private MaterialSkin.Controls.MaterialButton btnMaDauSach;
    }
}