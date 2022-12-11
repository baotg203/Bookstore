namespace GUI
{
    partial class frmQuanLyDauSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyDauSach));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChiTietTacGia = new MaterialSkin.Controls.MaterialButton();
            this.btnKhongluu = new MaterialSkin.Controls.MaterialButton();
            this.btnLuu = new MaterialSkin.Controls.MaterialButton();
            this.btnThoat = new MaterialSkin.Controls.MaterialButton();
            this.btnCapNhat = new MaterialSkin.Controls.MaterialButton();
            this.btnThem = new MaterialSkin.Controls.MaterialButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDauSach = new System.Windows.Forms.DataGridView();
            this.colMaDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaTheLoai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTheLoai = new MaterialSkin.Controls.MaterialComboBox();
            this.txtTenDauSach = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtMaDauSach = new MaterialSkin.Controls.MaterialTextBox2();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvCT_TacGia = new System.Windows.Forms.DataGridView();
            this.colMaDauSachCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDong = new MaterialSkin.Controls.MaterialButton();
            this.btnXoaTrang = new MaterialSkin.Controls.MaterialButton();
            this.btnXoaTacGia = new MaterialSkin.Controls.MaterialButton();
            this.btnThemTacGia = new MaterialSkin.Controls.MaterialButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTacGia = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtMaSachCT = new MaterialSkin.Controls.MaterialTextBox2();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDauSach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_TacGia)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnChiTietTacGia);
            this.panel1.Controls.Add(this.btnKhongluu);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 724);
            this.panel1.TabIndex = 6;
            // 
            // btnChiTietTacGia
            // 
            this.btnChiTietTacGia.AutoSize = false;
            this.btnChiTietTacGia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChiTietTacGia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChiTietTacGia.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnChiTietTacGia.Depth = 0;
            this.btnChiTietTacGia.HighEmphasis = true;
            this.btnChiTietTacGia.Icon = global::GUI.Properties.Resources.icons8_more_details_64;
            this.btnChiTietTacGia.Location = new System.Drawing.Point(505, 290);
            this.btnChiTietTacGia.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnChiTietTacGia.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChiTietTacGia.Name = "btnChiTietTacGia";
            this.btnChiTietTacGia.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnChiTietTacGia.Size = new System.Drawing.Size(183, 67);
            this.btnChiTietTacGia.TabIndex = 55;
            this.btnChiTietTacGia.Text = "CHI TIẾT TÁC GIẢ";
            this.btnChiTietTacGia.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnChiTietTacGia.UseAccentColor = false;
            this.btnChiTietTacGia.UseVisualStyleBackColor = true;
            this.btnChiTietTacGia.Click += new System.EventHandler(this.btnChiTietTacGia_Click);
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
            this.btnKhongluu.Location = new System.Drawing.Point(323, 331);
            this.btnKhongluu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnKhongluu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnKhongluu.Name = "btnKhongluu";
            this.btnKhongluu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnKhongluu.Size = new System.Drawing.Size(143, 46);
            this.btnKhongluu.TabIndex = 55;
            this.btnKhongluu.Text = "KHÔNG LƯU";
            this.btnKhongluu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnKhongluu.UseAccentColor = false;
            this.btnKhongluu.UseVisualStyleBackColor = true;
            this.btnKhongluu.Click += new System.EventHandler(this.btnKhongluu_Click);
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
            this.btnLuu.Location = new System.Drawing.Point(131, 331);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLuu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLuu.Size = new System.Drawing.Size(143, 46);
            this.btnLuu.TabIndex = 55;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLuu.UseAccentColor = false;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
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
            this.btnThoat.Location = new System.Drawing.Point(563, 672);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThoat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThoat.Size = new System.Drawing.Size(143, 46);
            this.btnThoat.TabIndex = 55;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThoat.UseAccentColor = false;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
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
            this.btnCapNhat.Location = new System.Drawing.Point(323, 269);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCapNhat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCapNhat.Size = new System.Drawing.Size(143, 46);
            this.btnCapNhat.TabIndex = 55;
            this.btnCapNhat.Text = "CẬP NHẬT";
            this.btnCapNhat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCapNhat.UseAccentColor = false;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
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
            this.btnThem.Location = new System.Drawing.Point(131, 269);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThem.Name = "btnThem";
            this.btnThem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThem.Size = new System.Drawing.Size(143, 46);
            this.btnThem.TabIndex = 55;
            this.btnThem.Text = "THÊM";
            this.btnThem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThem.UseAccentColor = false;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Controls.Add(this.dgvDauSach);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(49, 386);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(657, 277);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin đầu sách";
            // 
            // dgvDauSach
            // 
            this.dgvDauSach.AllowUserToAddRows = false;
            this.dgvDauSach.AllowUserToResizeRows = false;
            this.dgvDauSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvDauSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDauSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDauSach,
            this.colTenDauSach,
            this.colMaTheLoai});
            this.dgvDauSach.Location = new System.Drawing.Point(6, 26);
            this.dgvDauSach.Name = "dgvDauSach";
            this.dgvDauSach.Size = new System.Drawing.Size(645, 245);
            this.dgvDauSach.TabIndex = 0;
            this.dgvDauSach.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDauSach_RowEnter);
            // 
            // colMaDauSach
            // 
            this.colMaDauSach.DataPropertyName = "MaDauSach";
            this.colMaDauSach.HeaderText = "Mã đầu sách";
            this.colMaDauSach.Name = "colMaDauSach";
            this.colMaDauSach.ReadOnly = true;
            this.colMaDauSach.Width = 120;
            // 
            // colTenDauSach
            // 
            this.colTenDauSach.DataPropertyName = "TenDauSach";
            this.colTenDauSach.HeaderText = "Tên đầu sách";
            this.colTenDauSach.Name = "colTenDauSach";
            this.colTenDauSach.ReadOnly = true;
            this.colTenDauSach.Width = 230;
            // 
            // colMaTheLoai
            // 
            this.colMaTheLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaTheLoai.DataPropertyName = "MaTheLoai";
            this.colMaTheLoai.HeaderText = "Thể loại";
            this.colMaTheLoai.Name = "colMaTheLoai";
            this.colMaTheLoai.ReadOnly = true;
            this.colMaTheLoai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaTheLoai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cboTheLoai);
            this.groupBox1.Controls.Add(this.txtTenDauSach);
            this.groupBox1.Controls.Add(this.txtMaDauSach);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(49, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 190);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đầu sách";
            // 
            // cboTheLoai
            // 
            this.cboTheLoai.AutoResize = false;
            this.cboTheLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboTheLoai.Depth = 0;
            this.cboTheLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboTheLoai.DropDownHeight = 174;
            this.cboTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTheLoai.DropDownWidth = 121;
            this.cboTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboTheLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboTheLoai.FormattingEnabled = true;
            this.cboTheLoai.IntegralHeight = false;
            this.cboTheLoai.ItemHeight = 43;
            this.cboTheLoai.Location = new System.Drawing.Point(423, 24);
            this.cboTheLoai.MaxDropDownItems = 4;
            this.cboTheLoai.MouseState = MaterialSkin.MouseState.OUT;
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Size = new System.Drawing.Size(216, 49);
            this.cboTheLoai.StartIndex = 0;
            this.cboTheLoai.TabIndex = 10;
            // 
            // txtTenDauSach
            // 
            this.txtTenDauSach.AnimateReadOnly = false;
            this.txtTenDauSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTenDauSach.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTenDauSach.Depth = 0;
            this.txtTenDauSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTenDauSach.HideSelection = true;
            this.txtTenDauSach.LeadingIcon = null;
            this.txtTenDauSach.Location = new System.Drawing.Point(121, 117);
            this.txtTenDauSach.MaxLength = 32767;
            this.txtTenDauSach.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTenDauSach.Name = "txtTenDauSach";
            this.txtTenDauSach.PasswordChar = '\0';
            this.txtTenDauSach.PrefixSuffixText = null;
            this.txtTenDauSach.ReadOnly = false;
            this.txtTenDauSach.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTenDauSach.SelectedText = "";
            this.txtTenDauSach.SelectionLength = 0;
            this.txtTenDauSach.SelectionStart = 0;
            this.txtTenDauSach.ShortcutsEnabled = true;
            this.txtTenDauSach.Size = new System.Drawing.Size(210, 48);
            this.txtTenDauSach.TabIndex = 9;
            this.txtTenDauSach.TabStop = false;
            this.txtTenDauSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTenDauSach.TrailingIcon = null;
            this.txtTenDauSach.UseSystemPasswordChar = false;
            this.txtTenDauSach.TextChanged += new System.EventHandler(this.txtTenDauSach_TextChanged);
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
            this.txtMaDauSach.Location = new System.Drawing.Point(123, 25);
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
            this.txtMaDauSach.Size = new System.Drawing.Size(153, 48);
            this.txtMaDauSach.TabIndex = 9;
            this.txtMaDauSach.TabStop = false;
            this.txtMaDauSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaDauSach.TrailingIcon = null;
            this.txtMaDauSach.UseSystemPasswordChar = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "(Auto)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thể loại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên đầu sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã đầu sách: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(219, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "QUẢN LÝ ĐẦU SÁCH";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.btnDong);
            this.panel2.Controls.Add(this.btnXoaTrang);
            this.panel2.Controls.Add(this.btnXoaTacGia);
            this.panel2.Controls.Add(this.btnThemTacGia);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Location = new System.Drawing.Point(730, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(509, 724);
            this.panel2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(112, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "CHI TIẾT TÁC GIẢ";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox4.Controls.Add(this.dgvCT_TacGia);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(37, 386);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(441, 277);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi tiết tác giả";
            // 
            // dgvCT_TacGia
            // 
            this.dgvCT_TacGia.AllowUserToAddRows = false;
            this.dgvCT_TacGia.AllowUserToDeleteRows = false;
            this.dgvCT_TacGia.AllowUserToResizeColumns = false;
            this.dgvCT_TacGia.AllowUserToResizeRows = false;
            this.dgvCT_TacGia.BackgroundColor = System.Drawing.Color.White;
            this.dgvCT_TacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT_TacGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDauSachCT,
            this.colTenTacGia});
            this.dgvCT_TacGia.Location = new System.Drawing.Point(7, 29);
            this.dgvCT_TacGia.Name = "dgvCT_TacGia";
            this.dgvCT_TacGia.Size = new System.Drawing.Size(428, 242);
            this.dgvCT_TacGia.TabIndex = 0;
            this.dgvCT_TacGia.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCT_TacGia_RowEnter);
            // 
            // colMaDauSachCT
            // 
            this.colMaDauSachCT.DataPropertyName = "MaDauSach";
            this.colMaDauSachCT.HeaderText = "Mã đầu sách";
            this.colMaDauSachCT.Name = "colMaDauSachCT";
            this.colMaDauSachCT.ReadOnly = true;
            this.colMaDauSachCT.Width = 150;
            // 
            // colTenTacGia
            // 
            this.colTenTacGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenTacGia.DataPropertyName = "TacGia";
            this.colTenTacGia.HeaderText = "Tên tác giả";
            this.colTenTacGia.Name = "colTenTacGia";
            this.colTenTacGia.ReadOnly = true;
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
            this.btnDong.Location = new System.Drawing.Point(362, 672);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDong.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDong.Name = "btnDong";
            this.btnDong.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDong.Size = new System.Drawing.Size(143, 46);
            this.btnDong.TabIndex = 55;
            this.btnDong.Text = "ĐÓNG";
            this.btnDong.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDong.UseAccentColor = false;
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.AutoSize = false;
            this.btnXoaTrang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoaTrang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaTrang.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXoaTrang.Depth = 0;
            this.btnXoaTrang.HighEmphasis = true;
            this.btnXoaTrang.Icon = global::GUI.Properties.Resources.icons8_clear_symbol_64;
            this.btnXoaTrang.Location = new System.Drawing.Point(178, 331);
            this.btnXoaTrang.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoaTrang.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoaTrang.Size = new System.Drawing.Size(135, 46);
            this.btnXoaTrang.TabIndex = 55;
            this.btnXoaTrang.Text = "XÓA TRẮNG";
            this.btnXoaTrang.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXoaTrang.UseAccentColor = false;
            this.btnXoaTrang.UseVisualStyleBackColor = true;
            this.btnXoaTrang.Click += new System.EventHandler(this.btnXoaTrang_Click);
            // 
            // btnXoaTacGia
            // 
            this.btnXoaTacGia.AutoSize = false;
            this.btnXoaTacGia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoaTacGia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaTacGia.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXoaTacGia.Depth = 0;
            this.btnXoaTacGia.HighEmphasis = true;
            this.btnXoaTacGia.Icon = global::GUI.Properties.Resources.icons8_remove_64;
            this.btnXoaTacGia.Location = new System.Drawing.Point(286, 269);
            this.btnXoaTacGia.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoaTacGia.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoaTacGia.Name = "btnXoaTacGia";
            this.btnXoaTacGia.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoaTacGia.Size = new System.Drawing.Size(151, 46);
            this.btnXoaTacGia.TabIndex = 55;
            this.btnXoaTacGia.Text = "XÓA TÁC GIẢ";
            this.btnXoaTacGia.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXoaTacGia.UseAccentColor = false;
            this.btnXoaTacGia.UseVisualStyleBackColor = true;
            this.btnXoaTacGia.Click += new System.EventHandler(this.btnXoaTacGia_Click);
            // 
            // btnThemTacGia
            // 
            this.btnThemTacGia.AutoSize = false;
            this.btnThemTacGia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemTacGia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemTacGia.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThemTacGia.Depth = 0;
            this.btnThemTacGia.HighEmphasis = true;
            this.btnThemTacGia.Icon = global::GUI.Properties.Resources.icons8_add_new_64;
            this.btnThemTacGia.Location = new System.Drawing.Point(49, 269);
            this.btnThemTacGia.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThemTacGia.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemTacGia.Name = "btnThemTacGia";
            this.btnThemTacGia.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThemTacGia.Size = new System.Drawing.Size(157, 46);
            this.btnThemTacGia.TabIndex = 55;
            this.btnThemTacGia.Text = "THÊM TÁC GIẢ";
            this.btnThemTacGia.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThemTacGia.UseAccentColor = false;
            this.btnThemTacGia.UseVisualStyleBackColor = true;
            this.btnThemTacGia.Click += new System.EventHandler(this.btnThemTacGia_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtTacGia);
            this.groupBox3.Controls.Add(this.txtMaSachCT);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(49, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(388, 165);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết tác giả";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tác giả:";
            // 
            // txtTacGia
            // 
            this.txtTacGia.AnimateReadOnly = false;
            this.txtTacGia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTacGia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTacGia.Depth = 0;
            this.txtTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTacGia.HideSelection = true;
            this.txtTacGia.LeadingIcon = null;
            this.txtTacGia.Location = new System.Drawing.Point(115, 102);
            this.txtTacGia.MaxLength = 32767;
            this.txtTacGia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.PasswordChar = '\0';
            this.txtTacGia.PrefixSuffixText = null;
            this.txtTacGia.ReadOnly = false;
            this.txtTacGia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTacGia.SelectedText = "";
            this.txtTacGia.SelectionLength = 0;
            this.txtTacGia.SelectionStart = 0;
            this.txtTacGia.ShortcutsEnabled = true;
            this.txtTacGia.Size = new System.Drawing.Size(245, 48);
            this.txtTacGia.TabIndex = 9;
            this.txtTacGia.TabStop = false;
            this.txtTacGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTacGia.TrailingIcon = null;
            this.txtTacGia.UseSystemPasswordChar = false;
            // 
            // txtMaSachCT
            // 
            this.txtMaSachCT.AnimateReadOnly = false;
            this.txtMaSachCT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMaSachCT.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMaSachCT.Depth = 0;
            this.txtMaSachCT.Enabled = false;
            this.txtMaSachCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMaSachCT.HideSelection = true;
            this.txtMaSachCT.LeadingIcon = null;
            this.txtMaSachCT.Location = new System.Drawing.Point(115, 24);
            this.txtMaSachCT.MaxLength = 32767;
            this.txtMaSachCT.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaSachCT.Name = "txtMaSachCT";
            this.txtMaSachCT.PasswordChar = '\0';
            this.txtMaSachCT.PrefixSuffixText = null;
            this.txtMaSachCT.ReadOnly = false;
            this.txtMaSachCT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMaSachCT.SelectedText = "";
            this.txtMaSachCT.SelectionLength = 0;
            this.txtMaSachCT.SelectionStart = 0;
            this.txtMaSachCT.ShortcutsEnabled = true;
            this.txtMaSachCT.Size = new System.Drawing.Size(244, 48);
            this.txtMaSachCT.TabIndex = 9;
            this.txtMaSachCT.TabStop = false;
            this.txtMaSachCT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaSachCT.TrailingIcon = null;
            this.txtMaSachCT.UseSystemPasswordChar = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mã đầu sách: ";
            // 
            // frmQuanLyDauSach
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 836);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmQuanLyDauSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Đầu Sách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLyDauSach_FormClosing);
            this.Load += new System.EventHandler(this.frmQuanLyDauSach_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDauSach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_TacGia)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDauSach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvCT_TacGia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDauSachCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDauSach;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaTheLoai;
        private MaterialSkin.Controls.MaterialButton btnChiTietTacGia;
        private MaterialSkin.Controls.MaterialButton btnKhongluu;
        private MaterialSkin.Controls.MaterialButton btnLuu;
        private MaterialSkin.Controls.MaterialButton btnCapNhat;
        private MaterialSkin.Controls.MaterialButton btnThem;
        private MaterialSkin.Controls.MaterialComboBox cboTheLoai;
        private MaterialSkin.Controls.MaterialTextBox2 txtTenDauSach;
        private MaterialSkin.Controls.MaterialTextBox2 txtMaDauSach;
        private MaterialSkin.Controls.MaterialButton btnThoat;
        private MaterialSkin.Controls.MaterialTextBox2 txtTacGia;
        private MaterialSkin.Controls.MaterialTextBox2 txtMaSachCT;
        private MaterialSkin.Controls.MaterialButton btnDong;
        private MaterialSkin.Controls.MaterialButton btnXoaTrang;
        private MaterialSkin.Controls.MaterialButton btnXoaTacGia;
        private MaterialSkin.Controls.MaterialButton btnThemTacGia;
    }
}