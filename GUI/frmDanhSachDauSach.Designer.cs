namespace GUI
{
    partial class frmDanhSachDauSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSachDauSach));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDauSach = new System.Windows.Forms.DataGridView();
            this.MaDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTheLoai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtThongTinSach = new MaterialSkin.Controls.MaterialTextBox2();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvCTTacGia = new System.Windows.Forms.DataGridView();
            this.colMaDauSachCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdTenSach = new MaterialSkin.Controls.MaterialRadioButton();
            this.cboTimTheLoai = new MaterialSkin.Controls.MaterialComboBox();
            this.btnHienThiTatCa = new MaterialSkin.Controls.MaterialButton();
            this.btnChon = new MaterialSkin.Controls.MaterialButton();
            this.btnThoat = new MaterialSkin.Controls.MaterialButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDauSach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTTacGia)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Controls.Add(this.dgvDauSach);
            this.groupBox2.Location = new System.Drawing.Point(14, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 327);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết về đầu sách";
            // 
            // dgvDauSach
            // 
            this.dgvDauSach.AllowUserToAddRows = false;
            this.dgvDauSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDauSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvDauSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDauSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDauSach,
            this.TenDauSach,
            this.colTheLoai});
            this.dgvDauSach.Location = new System.Drawing.Point(6, 25);
            this.dgvDauSach.MultiSelect = false;
            this.dgvDauSach.Name = "dgvDauSach";
            this.dgvDauSach.ReadOnly = true;
            this.dgvDauSach.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDauSach.Size = new System.Drawing.Size(526, 296);
            this.dgvDauSach.TabIndex = 0;
            this.dgvDauSach.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDauSach_RowEnter);
            // 
            // MaDauSach
            // 
            this.MaDauSach.DataPropertyName = "MaDauSach";
            this.MaDauSach.HeaderText = "Mã đầu sách";
            this.MaDauSach.Name = "MaDauSach";
            this.MaDauSach.ReadOnly = true;
            this.MaDauSach.Width = 130;
            // 
            // TenDauSach
            // 
            this.TenDauSach.DataPropertyName = "TenDauSach";
            this.TenDauSach.HeaderText = "Tên đầu sách";
            this.TenDauSach.Name = "TenDauSach";
            this.TenDauSach.ReadOnly = true;
            this.TenDauSach.Width = 200;
            // 
            // colTheLoai
            // 
            this.colTheLoai.DataPropertyName = "MaTheLoai";
            this.colTheLoai.HeaderText = "Thể loại";
            this.colTheLoai.Name = "colTheLoai";
            this.colTheLoai.ReadOnly = true;
            this.colTheLoai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTheLoai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colTheLoai.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtThongTinSach);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(84, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 91);
            this.groupBox1.TabIndex = 6;
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
            this.txtThongTinSach.Location = new System.Drawing.Point(131, 25);
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
            this.txtThongTinSach.Size = new System.Drawing.Size(217, 48);
            this.txtThongTinSach.TabIndex = 15;
            this.txtThongTinSach.TabStop = false;
            this.txtThongTinSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtThongTinSach.TrailingIcon = null;
            this.txtThongTinSach.UseSystemPasswordChar = false;
            this.txtThongTinSach.Click += new System.EventHandler(this.txtThongTinSach_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Từ khóa tìm kiếm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thể loại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(292, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "DANH SÁCH ĐẦU SÁCH";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Controls.Add(this.dgvCTTacGia);
            this.groupBox3.Location = new System.Drawing.Point(558, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(362, 327);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết tác giả";
            // 
            // dgvCTTacGia
            // 
            this.dgvCTTacGia.AllowUserToAddRows = false;
            this.dgvCTTacGia.AllowUserToDeleteRows = false;
            this.dgvCTTacGia.AllowUserToResizeColumns = false;
            this.dgvCTTacGia.AllowUserToResizeRows = false;
            this.dgvCTTacGia.BackgroundColor = System.Drawing.Color.White;
            this.dgvCTTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTTacGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDauSachCT,
            this.colTacGia});
            this.dgvCTTacGia.Location = new System.Drawing.Point(7, 25);
            this.dgvCTTacGia.Name = "dgvCTTacGia";
            this.dgvCTTacGia.Size = new System.Drawing.Size(349, 296);
            this.dgvCTTacGia.TabIndex = 0;
            // 
            // colMaDauSachCT
            // 
            this.colMaDauSachCT.DataPropertyName = "MaDauSach";
            this.colMaDauSachCT.HeaderText = "Mã đầu sách";
            this.colMaDauSachCT.Name = "colMaDauSachCT";
            this.colMaDauSachCT.ReadOnly = true;
            this.colMaDauSachCT.Width = 130;
            // 
            // colTacGia
            // 
            this.colTacGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTacGia.DataPropertyName = "TacGia";
            this.colTacGia.HeaderText = "Tác Giả";
            this.colTacGia.Name = "colTacGia";
            this.colTacGia.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.rdTenSach);
            this.groupBox4.Controls.Add(this.cboTimTheLoai);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(475, 170);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(439, 91);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm theo";
            // 
            // rdTenSach
            // 
            this.rdTenSach.AutoSize = true;
            this.rdTenSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdTenSach.Depth = 0;
            this.rdTenSach.Location = new System.Drawing.Point(295, 28);
            this.rdTenSach.Margin = new System.Windows.Forms.Padding(0);
            this.rdTenSach.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdTenSach.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdTenSach.Name = "rdTenSach";
            this.rdTenSach.Ripple = true;
            this.rdTenSach.Size = new System.Drawing.Size(132, 37);
            this.rdTenSach.TabIndex = 15;
            this.rdTenSach.TabStop = true;
            this.rdTenSach.Text = "Tên đầu sách";
            this.rdTenSach.UseVisualStyleBackColor = true;
            this.rdTenSach.CheckedChanged += new System.EventHandler(this.rdTenSach_CheckedChanged);
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
            this.cboTimTheLoai.Location = new System.Drawing.Point(83, 24);
            this.cboTimTheLoai.MaxDropDownItems = 4;
            this.cboTimTheLoai.MouseState = MaterialSkin.MouseState.OUT;
            this.cboTimTheLoai.Name = "cboTimTheLoai";
            this.cboTimTheLoai.Size = new System.Drawing.Size(200, 49);
            this.cboTimTheLoai.StartIndex = 0;
            this.cboTimTheLoai.TabIndex = 15;
            this.cboTimTheLoai.SelectedIndexChanged += new System.EventHandler(this.cboTimTheLoai_SelectedIndexChanged);
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
            this.btnHienThiTatCa.Location = new System.Drawing.Point(412, 632);
            this.btnHienThiTatCa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHienThiTatCa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHienThiTatCa.Name = "btnHienThiTatCa";
            this.btnHienThiTatCa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHienThiTatCa.Size = new System.Drawing.Size(183, 45);
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
            this.btnChon.Location = new System.Drawing.Point(634, 632);
            this.btnChon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnChon.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChon.Name = "btnChon";
            this.btnChon.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnChon.Size = new System.Drawing.Size(127, 45);
            this.btnChon.TabIndex = 13;
            this.btnChon.Text = "CHỌN";
            this.btnChon.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnChon.UseAccentColor = false;
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
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
            this.btnThoat.Location = new System.Drawing.Point(799, 632);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThoat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThoat.Size = new System.Drawing.Size(114, 45);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThoat.UseAccentColor = false;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmDanhSachDauSach
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(962, 725);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.btnHienThiTatCa);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDanhSachDauSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Đầu Sách";
            this.Load += new System.EventHandler(this.frmDanhSachDauSach_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDauSach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTTacGia)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDauSach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvCTTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDauSach;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDauSachCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTacGia;
        private System.Windows.Forms.GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialButton btnHienThiTatCa;
        private MaterialSkin.Controls.MaterialButton btnChon;
        private MaterialSkin.Controls.MaterialButton btnThoat;
        private MaterialSkin.Controls.MaterialTextBox2 txtThongTinSach;
        private MaterialSkin.Controls.MaterialRadioButton rdTenSach;
        private MaterialSkin.Controls.MaterialComboBox cboTimTheLoai;
    }
}