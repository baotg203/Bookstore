namespace GUI
{
    partial class frmLapPhieuThuTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLapPhieuThuTien));
            this.dtpNgayThuTien = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.la = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPhieuThuTien = new System.Windows.Forms.DataGridView();
            this.colMaPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKhachHang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colNgayThuTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoTienThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnKhongluu = new MaterialSkin.Controls.MaterialButton();
            this.btnLuu = new MaterialSkin.Controls.MaterialButton();
            this.btnCapNhat = new MaterialSkin.Controls.MaterialButton();
            this.btnXoa = new MaterialSkin.Controls.MaterialButton();
            this.btnThem = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMaKhachHang = new MaterialSkin.Controls.MaterialButton();
            this.txtSoTien = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtSoTienNo = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtMaKhachHang = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtMaPhieuThu = new MaterialSkin.Controls.MaterialTextBox2();
            this.label3 = new System.Windows.Forms.Label();
            this.btnthoat = new MaterialSkin.Controls.MaterialButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuThuTien)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpNgayThuTien
            // 
            this.dtpNgayThuTien.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayThuTien.Location = new System.Drawing.Point(175, 157);
            this.dtpNgayThuTien.Name = "dtpNgayThuTien";
            this.dtpNgayThuTien.Size = new System.Drawing.Size(162, 26);
            this.dtpNgayThuTien.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số tiền thu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày thu tiền:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã phiếu thu(auto):";
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Location = new System.Drawing.Point(42, 102);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(105, 19);
            this.la.TabIndex = 2;
            this.la.Text = "Mã khách hàng:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Controls.Add(this.dgvPhieuThuTien);
            this.groupBox2.Location = new System.Drawing.Point(21, 501);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(726, 231);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phiếu thu tiền";
            // 
            // dgvPhieuThuTien
            // 
            this.dgvPhieuThuTien.AllowUserToAddRows = false;
            this.dgvPhieuThuTien.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuThuTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuThuTien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPT,
            this.colMaKhachHang,
            this.colNgayThuTien,
            this.colSoTienThu});
            this.dgvPhieuThuTien.Location = new System.Drawing.Point(6, 25);
            this.dgvPhieuThuTien.Name = "dgvPhieuThuTien";
            this.dgvPhieuThuTien.RowHeadersWidth = 51;
            this.dgvPhieuThuTien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuThuTien.Size = new System.Drawing.Size(714, 200);
            this.dgvPhieuThuTien.TabIndex = 10;
            this.dgvPhieuThuTien.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuThuTien_RowEnter);
            // 
            // colMaPT
            // 
            this.colMaPT.DataPropertyName = "MaPT";
            this.colMaPT.HeaderText = "Mã phiếu thu";
            this.colMaPT.MinimumWidth = 6;
            this.colMaPT.Name = "colMaPT";
            this.colMaPT.Width = 130;
            // 
            // colMaKhachHang
            // 
            this.colMaKhachHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaKhachHang.DataPropertyName = "MaKhachHang";
            this.colMaKhachHang.HeaderText = "Khách hàng";
            this.colMaKhachHang.MinimumWidth = 6;
            this.colMaKhachHang.Name = "colMaKhachHang";
            this.colMaKhachHang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaKhachHang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colNgayThuTien
            // 
            this.colNgayThuTien.DataPropertyName = "NgayLap";
            this.colNgayThuTien.HeaderText = "Ngày thu";
            this.colNgayThuTien.MinimumWidth = 6;
            this.colNgayThuTien.Name = "colNgayThuTien";
            this.colNgayThuTien.Width = 150;
            // 
            // colSoTienThu
            // 
            this.colSoTienThu.DataPropertyName = "SoTienThu";
            this.colSoTienThu.HeaderText = "Số tiền thu";
            this.colSoTienThu.MinimumWidth = 6;
            this.colSoTienThu.Name = "colSoTienThu";
            this.colSoTienThu.Width = 200;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(262, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(274, 36);
            this.label6.TabIndex = 20;
            this.label6.Text = "PHIẾU THU TIỀN";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.btnKhongluu);
            this.groupBox3.Controls.Add(this.btnLuu);
            this.groupBox3.Controls.Add(this.btnCapNhat);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Location = new System.Drawing.Point(496, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 353);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Các chức năng";
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
            this.btnKhongluu.Location = new System.Drawing.Point(52, 296);
            this.btnKhongluu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnKhongluu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnKhongluu.Name = "btnKhongluu";
            this.btnKhongluu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnKhongluu.Size = new System.Drawing.Size(149, 48);
            this.btnKhongluu.TabIndex = 57;
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
            this.btnLuu.Location = new System.Drawing.Point(52, 226);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLuu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLuu.Size = new System.Drawing.Size(149, 48);
            this.btnLuu.TabIndex = 57;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLuu.UseAccentColor = false;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
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
            this.btnCapNhat.Location = new System.Drawing.Point(52, 157);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCapNhat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCapNhat.Size = new System.Drawing.Size(149, 48);
            this.btnCapNhat.TabIndex = 57;
            this.btnCapNhat.Text = "CẬP NHẬT";
            this.btnCapNhat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCapNhat.UseAccentColor = false;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = false;
            this.btnXoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXoa.Depth = 0;
            this.btnXoa.HighEmphasis = true;
            this.btnXoa.Icon = global::GUI.Properties.Resources.icons8_remove_64;
            this.btnXoa.Location = new System.Drawing.Point(52, 89);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoa.Size = new System.Drawing.Size(149, 48);
            this.btnXoa.TabIndex = 57;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXoa.UseAccentColor = false;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = false;
            this.btnThem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThem.Depth = 0;
            this.btnThem.HighEmphasis = true;
            this.btnThem.Icon = global::GUI.Properties.Resources.icons8_checkmark_64;
            this.btnThem.Location = new System.Drawing.Point(52, 29);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThem.Name = "btnThem";
            this.btnThem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThem.Size = new System.Drawing.Size(149, 48);
            this.btnThem.TabIndex = 57;
            this.btnThem.Text = "THÊM";
            this.btnThem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThem.UseAccentColor = false;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnMaKhachHang);
            this.groupBox1.Controls.Add(this.txtSoTien);
            this.groupBox1.Controls.Add(this.txtSoTienNo);
            this.groupBox1.Controls.Add(this.txtMaKhachHang);
            this.groupBox1.Controls.Add(this.txtMaPhieuThu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpNgayThuTien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.la);
            this.groupBox1.Location = new System.Drawing.Point(21, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 353);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin phiếu thu";
            // 
            // btnMaKhachHang
            // 
            this.btnMaKhachHang.AutoSize = false;
            this.btnMaKhachHang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMaKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaKhachHang.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMaKhachHang.Depth = 0;
            this.btnMaKhachHang.HighEmphasis = true;
            this.btnMaKhachHang.Icon = global::GUI.Properties.Resources.icons8_checkmark_64;
            this.btnMaKhachHang.Location = new System.Drawing.Point(373, 146);
            this.btnMaKhachHang.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMaKhachHang.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMaKhachHang.Name = "btnMaKhachHang";
            this.btnMaKhachHang.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMaKhachHang.Size = new System.Drawing.Size(89, 53);
            this.btnMaKhachHang.TabIndex = 57;
            this.btnMaKhachHang.Text = "CHỌN";
            this.btnMaKhachHang.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMaKhachHang.UseAccentColor = false;
            this.btnMaKhachHang.UseVisualStyleBackColor = true;
            this.btnMaKhachHang.Click += new System.EventHandler(this.btnMaKhachHang_Click);
            // 
            // txtSoTien
            // 
            this.txtSoTien.AnimateReadOnly = false;
            this.txtSoTien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSoTien.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSoTien.Depth = 0;
            this.txtSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSoTien.HideSelection = true;
            this.txtSoTien.LeadingIcon = null;
            this.txtSoTien.Location = new System.Drawing.Point(175, 262);
            this.txtSoTien.MaxLength = 32767;
            this.txtSoTien.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.PasswordChar = '\0';
            this.txtSoTien.PrefixSuffixText = null;
            this.txtSoTien.ReadOnly = false;
            this.txtSoTien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSoTien.SelectedText = "";
            this.txtSoTien.SelectionLength = 0;
            this.txtSoTien.SelectionStart = 0;
            this.txtSoTien.ShortcutsEnabled = true;
            this.txtSoTien.Size = new System.Drawing.Size(180, 48);
            this.txtSoTien.TabIndex = 57;
            this.txtSoTien.TabStop = false;
            this.txtSoTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSoTien.TrailingIcon = null;
            this.txtSoTien.UseSystemPasswordChar = false;
            // 
            // txtSoTienNo
            // 
            this.txtSoTienNo.AnimateReadOnly = false;
            this.txtSoTienNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSoTienNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSoTienNo.Depth = 0;
            this.txtSoTienNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSoTienNo.HideSelection = true;
            this.txtSoTienNo.LeadingIcon = null;
            this.txtSoTienNo.Location = new System.Drawing.Point(175, 199);
            this.txtSoTienNo.MaxLength = 32767;
            this.txtSoTienNo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSoTienNo.Name = "txtSoTienNo";
            this.txtSoTienNo.PasswordChar = '\0';
            this.txtSoTienNo.PrefixSuffixText = null;
            this.txtSoTienNo.ReadOnly = false;
            this.txtSoTienNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSoTienNo.SelectedText = "";
            this.txtSoTienNo.SelectionLength = 0;
            this.txtSoTienNo.SelectionStart = 0;
            this.txtSoTienNo.ShortcutsEnabled = true;
            this.txtSoTienNo.Size = new System.Drawing.Size(180, 48);
            this.txtSoTienNo.TabIndex = 57;
            this.txtSoTienNo.TabStop = false;
            this.txtSoTienNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSoTienNo.TrailingIcon = null;
            this.txtSoTienNo.UseSystemPasswordChar = false;
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.AnimateReadOnly = false;
            this.txtMaKhachHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMaKhachHang.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMaKhachHang.Depth = 0;
            this.txtMaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMaKhachHang.HideSelection = true;
            this.txtMaKhachHang.LeadingIcon = null;
            this.txtMaKhachHang.Location = new System.Drawing.Point(175, 87);
            this.txtMaKhachHang.MaxLength = 32767;
            this.txtMaKhachHang.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.PasswordChar = '\0';
            this.txtMaKhachHang.PrefixSuffixText = null;
            this.txtMaKhachHang.ReadOnly = false;
            this.txtMaKhachHang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMaKhachHang.SelectedText = "";
            this.txtMaKhachHang.SelectionLength = 0;
            this.txtMaKhachHang.SelectionStart = 0;
            this.txtMaKhachHang.ShortcutsEnabled = true;
            this.txtMaKhachHang.Size = new System.Drawing.Size(180, 48);
            this.txtMaKhachHang.TabIndex = 57;
            this.txtMaKhachHang.TabStop = false;
            this.txtMaKhachHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaKhachHang.TrailingIcon = null;
            this.txtMaKhachHang.UseSystemPasswordChar = false;
            // 
            // txtMaPhieuThu
            // 
            this.txtMaPhieuThu.AnimateReadOnly = false;
            this.txtMaPhieuThu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMaPhieuThu.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMaPhieuThu.Depth = 0;
            this.txtMaPhieuThu.Enabled = false;
            this.txtMaPhieuThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMaPhieuThu.HideSelection = true;
            this.txtMaPhieuThu.LeadingIcon = null;
            this.txtMaPhieuThu.Location = new System.Drawing.Point(175, 16);
            this.txtMaPhieuThu.MaxLength = 32767;
            this.txtMaPhieuThu.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaPhieuThu.Name = "txtMaPhieuThu";
            this.txtMaPhieuThu.PasswordChar = '\0';
            this.txtMaPhieuThu.PrefixSuffixText = null;
            this.txtMaPhieuThu.ReadOnly = false;
            this.txtMaPhieuThu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMaPhieuThu.SelectedText = "";
            this.txtMaPhieuThu.SelectionLength = 0;
            this.txtMaPhieuThu.SelectionStart = 0;
            this.txtMaPhieuThu.ShortcutsEnabled = true;
            this.txtMaPhieuThu.Size = new System.Drawing.Size(180, 48);
            this.txtMaPhieuThu.TabIndex = 57;
            this.txtMaPhieuThu.TabStop = false;
            this.txtMaPhieuThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaPhieuThu.TrailingIcon = null;
            this.txtMaPhieuThu.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số tiền nợ:";
            // 
            // btnthoat
            // 
            this.btnthoat.AutoSize = false;
            this.btnthoat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnthoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthoat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnthoat.Depth = 0;
            this.btnthoat.HighEmphasis = true;
            this.btnthoat.Icon = global::GUI.Properties.Resources.icons8_logout_64;
            this.btnthoat.Location = new System.Drawing.Point(624, 748);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnthoat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnthoat.Size = new System.Drawing.Size(117, 42);
            this.btnthoat.TabIndex = 57;
            this.btnthoat.Text = "THOÁT";
            this.btnthoat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnthoat.UseAccentColor = false;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // frmLapPhieuThuTien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(798, 877);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmLapPhieuThuTien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập Phiếu Thu Tiền";
            this.Load += new System.EventHandler(this.frmLapPhieuThuTien_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuThuTien)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpNgayThuTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPhieuThuTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPT;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayThuTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoTienThu;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialTextBox2 txtMaPhieuThu;
        private MaterialSkin.Controls.MaterialButton btnKhongluu;
        private MaterialSkin.Controls.MaterialButton btnLuu;
        private MaterialSkin.Controls.MaterialButton btnCapNhat;
        private MaterialSkin.Controls.MaterialButton btnXoa;
        private MaterialSkin.Controls.MaterialButton btnThem;
        private MaterialSkin.Controls.MaterialButton btnMaKhachHang;
        private MaterialSkin.Controls.MaterialTextBox2 txtSoTien;
        private MaterialSkin.Controls.MaterialTextBox2 txtSoTienNo;
        private MaterialSkin.Controls.MaterialTextBox2 txtMaKhachHang;
        private MaterialSkin.Controls.MaterialButton btnthoat;
    }
}