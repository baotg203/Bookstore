namespace GUI
{
    partial class frmDanhSachSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSachSach));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtThongTinSach = new MaterialSkin.Controls.MaterialTextBox2();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.colMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSach = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaTheLoai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colNhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNamXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdNhaXuatBan = new MaterialSkin.Controls.MaterialRadioButton();
            this.cboTimTheLoai = new MaterialSkin.Controls.MaterialComboBox();
            this.rdTenSach = new MaterialSkin.Controls.MaterialRadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rdTacGia = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnHienThiTatCa = new MaterialSkin.Controls.MaterialButton();
            this.btnChon = new MaterialSkin.Controls.MaterialButton();
            this.btnDong = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtThongTinSach);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(23, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 116);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // txtThongTinSach
            // 
            this.txtThongTinSach.AnimateReadOnly = false;
            this.txtThongTinSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtThongTinSach.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtThongTinSach.Depth = 0;
            this.txtThongTinSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtThongTinSach.HideSelection = true;
            this.txtThongTinSach.LeadingIcon = null;
            this.txtThongTinSach.Location = new System.Drawing.Point(143, 41);
            this.txtThongTinSach.MaxLength = 32767;
            this.txtThongTinSach.MouseState = MaterialSkin.MouseState.OUT;
            this.txtThongTinSach.Name = "txtThongTinSach";
            this.txtThongTinSach.PasswordChar = '\0';
            this.txtThongTinSach.PrefixSuffixText = null;
            this.txtThongTinSach.ReadOnly = false;
            this.txtThongTinSach.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtThongTinSach.SelectedText = "";
            this.txtThongTinSach.SelectionLength = 0;
            this.txtThongTinSach.SelectionStart = 0;
            this.txtThongTinSach.ShortcutsEnabled = true;
            this.txtThongTinSach.Size = new System.Drawing.Size(221, 48);
            this.txtThongTinSach.TabIndex = 12;
            this.txtThongTinSach.TabStop = false;
            this.txtThongTinSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtThongTinSach.TrailingIcon = null;
            this.txtThongTinSach.UseSystemPasswordChar = false;
            this.txtThongTinSach.TextChanged += new System.EventHandler(this.txtThongTinSach_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Từ khóa tìm kiếm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(380, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "DANH SÁCH SÁCH ĐƯỢC BÁN";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Controls.Add(this.dgvSach);
            this.groupBox2.Location = new System.Drawing.Point(17, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1159, 404);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sách";
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
            this.colTenSach,
            this.colTacGia,
            this.colMaTheLoai,
            this.colNhaXuatBan,
            this.colNamXuatBan,
            this.colDonGiaBan,
            this.colSoLuongTon});
            this.dgvSach.Location = new System.Drawing.Point(6, 25);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersWidth = 51;
            this.dgvSach.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSach.Size = new System.Drawing.Size(1147, 373);
            this.dgvSach.TabIndex = 2;
            this.dgvSach.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_RowEnter);
            // 
            // colMaSach
            // 
            this.colMaSach.DataPropertyName = "MaSach";
            this.colMaSach.HeaderText = "Mã sách";
            this.colMaSach.MinimumWidth = 6;
            this.colMaSach.Name = "colMaSach";
            this.colMaSach.ReadOnly = true;
            this.colMaSach.Width = 125;
            // 
            // colTenSach
            // 
            this.colTenSach.DataPropertyName = "MaDauSach";
            this.colTenSach.HeaderText = "Tên đầu sách";
            this.colTenSach.MinimumWidth = 6;
            this.colTenSach.Name = "colTenSach";
            this.colTenSach.ReadOnly = true;
            this.colTenSach.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTenSach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colTenSach.Width = 150;
            // 
            // colTacGia
            // 
            this.colTacGia.DataPropertyName = "TacGia";
            this.colTacGia.HeaderText = "Tác giả";
            this.colTacGia.MinimumWidth = 6;
            this.colTacGia.Name = "colTacGia";
            this.colTacGia.ReadOnly = true;
            this.colTacGia.Width = 150;
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
            this.colMaTheLoai.Width = 150;
            // 
            // colNhaXuatBan
            // 
            this.colNhaXuatBan.DataPropertyName = "NhaXuatBan";
            this.colNhaXuatBan.HeaderText = "Nhà xuất bản";
            this.colNhaXuatBan.MinimumWidth = 6;
            this.colNhaXuatBan.Name = "colNhaXuatBan";
            this.colNhaXuatBan.ReadOnly = true;
            this.colNhaXuatBan.Width = 130;
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
            // colDonGiaBan
            // 
            this.colDonGiaBan.DataPropertyName = "DonGiaBan";
            this.colDonGiaBan.HeaderText = "Giá bán";
            this.colDonGiaBan.MinimumWidth = 6;
            this.colDonGiaBan.Name = "colDonGiaBan";
            this.colDonGiaBan.ReadOnly = true;
            this.colDonGiaBan.Width = 150;
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
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.rdNhaXuatBan);
            this.groupBox3.Controls.Add(this.cboTimTheLoai);
            this.groupBox3.Controls.Add(this.rdTenSach);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.rdTacGia);
            this.groupBox3.Location = new System.Drawing.Point(439, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(731, 116);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm theo";
            // 
            // rdNhaXuatBan
            // 
            this.rdNhaXuatBan.AutoSize = true;
            this.rdNhaXuatBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdNhaXuatBan.Depth = 0;
            this.rdNhaXuatBan.Location = new System.Drawing.Point(582, 52);
            this.rdNhaXuatBan.Margin = new System.Windows.Forms.Padding(0);
            this.rdNhaXuatBan.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdNhaXuatBan.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdNhaXuatBan.Name = "rdNhaXuatBan";
            this.rdNhaXuatBan.Ripple = true;
            this.rdNhaXuatBan.Size = new System.Drawing.Size(130, 37);
            this.rdNhaXuatBan.TabIndex = 12;
            this.rdNhaXuatBan.TabStop = true;
            this.rdNhaXuatBan.Text = "Nhà xuất bản";
            this.rdNhaXuatBan.UseVisualStyleBackColor = true;
            this.rdNhaXuatBan.CheckedChanged += new System.EventHandler(this.rdNhaXuatBan_CheckedChanged);
            // 
            // cboTimTheLoai
            // 
            this.cboTimTheLoai.AutoResize = false;
            this.cboTimTheLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboTimTheLoai.Depth = 0;
            this.cboTimTheLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboTimTheLoai.DropDownHeight = 174;
            this.cboTimTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimTheLoai.DropDownWidth = 121;
            this.cboTimTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboTimTheLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboTimTheLoai.FormattingEnabled = true;
            this.cboTimTheLoai.IntegralHeight = false;
            this.cboTimTheLoai.ItemHeight = 43;
            this.cboTimTheLoai.Location = new System.Drawing.Point(113, 40);
            this.cboTimTheLoai.MaxDropDownItems = 4;
            this.cboTimTheLoai.MouseState = MaterialSkin.MouseState.OUT;
            this.cboTimTheLoai.Name = "cboTimTheLoai";
            this.cboTimTheLoai.Size = new System.Drawing.Size(204, 49);
            this.cboTimTheLoai.StartIndex = 0;
            this.cboTimTheLoai.TabIndex = 12;
            this.cboTimTheLoai.SelectedIndexChanged += new System.EventHandler(this.cboTimTheLoai_SelectedIndexChanged);
            // 
            // rdTenSach
            // 
            this.rdTenSach.AutoSize = true;
            this.rdTenSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdTenSach.Depth = 0;
            this.rdTenSach.Location = new System.Drawing.Point(458, 52);
            this.rdTenSach.Margin = new System.Windows.Forms.Padding(0);
            this.rdTenSach.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdTenSach.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdTenSach.Name = "rdTenSach";
            this.rdTenSach.Ripple = true;
            this.rdTenSach.Size = new System.Drawing.Size(100, 37);
            this.rdTenSach.TabIndex = 12;
            this.rdTenSach.TabStop = true;
            this.rdTenSach.Text = "Tên sách";
            this.rdTenSach.UseVisualStyleBackColor = true;
            this.rdTenSach.CheckedChanged += new System.EventHandler(this.rdTenSach_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thể loại:";
            // 
            // rdTacGia
            // 
            this.rdTacGia.AutoSize = true;
            this.rdTacGia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdTacGia.Depth = 0;
            this.rdTacGia.Location = new System.Drawing.Point(345, 52);
            this.rdTacGia.Margin = new System.Windows.Forms.Padding(0);
            this.rdTacGia.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdTacGia.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdTacGia.Name = "rdTacGia";
            this.rdTacGia.Ripple = true;
            this.rdTacGia.Size = new System.Drawing.Size(88, 37);
            this.rdTacGia.TabIndex = 12;
            this.rdTacGia.TabStop = true;
            this.rdTacGia.Text = "Tác giả";
            this.rdTacGia.UseVisualStyleBackColor = true;
            this.rdTacGia.CheckedChanged += new System.EventHandler(this.rdTacGia_CheckedChanged);
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
            this.btnHienThiTatCa.Location = new System.Drawing.Point(656, 706);
            this.btnHienThiTatCa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHienThiTatCa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHienThiTatCa.Name = "btnHienThiTatCa";
            this.btnHienThiTatCa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHienThiTatCa.Size = new System.Drawing.Size(207, 47);
            this.btnHienThiTatCa.TabIndex = 11;
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
            this.btnChon.Location = new System.Drawing.Point(886, 706);
            this.btnChon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnChon.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChon.Name = "btnChon";
            this.btnChon.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnChon.Size = new System.Drawing.Size(151, 47);
            this.btnChon.TabIndex = 11;
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
            this.btnDong.Location = new System.Drawing.Point(1054, 706);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDong.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDong.Name = "btnDong";
            this.btnDong.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDong.Size = new System.Drawing.Size(116, 47);
            this.btnDong.TabIndex = 11;
            this.btnDong.Text = "THOÁT";
            this.btnDong.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDong.UseAccentColor = false;
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmDanhSachSach
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1202, 801);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.btnHienThiTatCa);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDanhSachSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Sách";
            this.Load += new System.EventHandler(this.frmDanhSachSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSach;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTacGia;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhaXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongTon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialTextBox2 txtThongTinSach;
        private MaterialSkin.Controls.MaterialRadioButton rdNhaXuatBan;
        private MaterialSkin.Controls.MaterialComboBox cboTimTheLoai;
        private MaterialSkin.Controls.MaterialRadioButton rdTenSach;
        private MaterialSkin.Controls.MaterialRadioButton rdTacGia;
        private MaterialSkin.Controls.MaterialButton btnHienThiTatCa;
        private MaterialSkin.Controls.MaterialButton btnChon;
        private MaterialSkin.Controls.MaterialButton btnDong;
    }
}