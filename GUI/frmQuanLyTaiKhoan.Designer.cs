namespace GUI
{
    partial class frmQuanLyTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyTaiKhoan));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.colTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuyen = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTaikhoan = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtMatkhau = new MaterialSkin.Controls.MaterialTextBox2();
            this.cboQuyen = new MaterialSkin.Controls.MaterialComboBox();
            this.btnThem = new MaterialSkin.Controls.MaterialButton();
            this.btnSua = new MaterialSkin.Controls.MaterialButton();
            this.btnXoa = new MaterialSkin.Controls.MaterialButton();
            this.btnDong = new MaterialSkin.Controls.MaterialButton();
            this.btnKhongluu = new MaterialSkin.Controls.MaterialButton();
            this.btnLuu = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(352, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 35;
            this.label3.Text = "Quyền:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 34;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tài khoản:";
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AllowUserToAddRows = false;
            this.dgvTaiKhoan.AllowUserToDeleteRows = false;
            this.dgvTaiKhoan.AllowUserToResizeColumns = false;
            this.dgvTaiKhoan.AllowUserToResizeRows = false;
            this.dgvTaiKhoan.BackgroundColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTaiKhoan,
            this.colMatKhau,
            this.colQuyen});
            this.dgvTaiKhoan.Location = new System.Drawing.Point(7, 19);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.ReadOnly = true;
            this.dgvTaiKhoan.RowHeadersWidth = 51;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(595, 294);
            this.dgvTaiKhoan.TabIndex = 51;
            this.dgvTaiKhoan.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_RowEnter);
            // 
            // colTaiKhoan
            // 
            this.colTaiKhoan.DataPropertyName = "TaiKhoan";
            this.colTaiKhoan.HeaderText = "Tài khoản";
            this.colTaiKhoan.MinimumWidth = 6;
            this.colTaiKhoan.Name = "colTaiKhoan";
            this.colTaiKhoan.ReadOnly = true;
            this.colTaiKhoan.Width = 200;
            // 
            // colMatKhau
            // 
            this.colMatKhau.DataPropertyName = "MatKhau";
            this.colMatKhau.HeaderText = "Mật khẩu";
            this.colMatKhau.MinimumWidth = 6;
            this.colMatKhau.Name = "colMatKhau";
            this.colMatKhau.ReadOnly = true;
            this.colMatKhau.Width = 200;
            // 
            // colQuyen
            // 
            this.colQuyen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colQuyen.DataPropertyName = "MaQuyen";
            this.colQuyen.HeaderText = "Quyền";
            this.colQuyen.MinimumWidth = 6;
            this.colQuyen.Name = "colQuyen";
            this.colQuyen.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(146, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(447, 45);
            this.label4.TabIndex = 53;
            this.label4.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Controls.Add(this.dgvTaiKhoan);
            this.groupBox1.Location = new System.Drawing.Point(21, 411);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 319);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.AnimateReadOnly = false;
            this.txtTaikhoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTaikhoan.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTaikhoan.Depth = 0;
            this.txtTaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTaikhoan.HideSelection = true;
            this.txtTaikhoan.LeadingIcon = null;
            this.txtTaikhoan.Location = new System.Drawing.Point(117, 131);
            this.txtTaikhoan.MaxLength = 32767;
            this.txtTaikhoan.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.PasswordChar = '\0';
            this.txtTaikhoan.PrefixSuffixText = null;
            this.txtTaikhoan.ReadOnly = false;
            this.txtTaikhoan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTaikhoan.SelectedText = "";
            this.txtTaikhoan.SelectionLength = 0;
            this.txtTaikhoan.SelectionStart = 0;
            this.txtTaikhoan.ShortcutsEnabled = true;
            this.txtTaikhoan.Size = new System.Drawing.Size(174, 48);
            this.txtTaikhoan.TabIndex = 55;
            this.txtTaikhoan.TabStop = false;
            this.txtTaikhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTaikhoan.TrailingIcon = null;
            this.txtTaikhoan.UseSystemPasswordChar = false;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.AnimateReadOnly = false;
            this.txtMatkhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMatkhau.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMatkhau.Depth = 0;
            this.txtMatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMatkhau.HideSelection = true;
            this.txtMatkhau.LeadingIcon = null;
            this.txtMatkhau.Location = new System.Drawing.Point(117, 204);
            this.txtMatkhau.MaxLength = 32767;
            this.txtMatkhau.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.PasswordChar = '\0';
            this.txtMatkhau.PrefixSuffixText = null;
            this.txtMatkhau.ReadOnly = false;
            this.txtMatkhau.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMatkhau.SelectedText = "";
            this.txtMatkhau.SelectionLength = 0;
            this.txtMatkhau.SelectionStart = 0;
            this.txtMatkhau.ShortcutsEnabled = true;
            this.txtMatkhau.Size = new System.Drawing.Size(174, 48);
            this.txtMatkhau.TabIndex = 55;
            this.txtMatkhau.TabStop = false;
            this.txtMatkhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMatkhau.TrailingIcon = null;
            this.txtMatkhau.UseSystemPasswordChar = false;
            this.txtMatkhau.TextChanged += new System.EventHandler(this.txtMatkhau_TextChanged);
            // 
            // cboQuyen
            // 
            this.cboQuyen.AutoResize = false;
            this.cboQuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboQuyen.Depth = 0;
            this.cboQuyen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboQuyen.DropDownHeight = 174;
            this.cboQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuyen.DropDownWidth = 121;
            this.cboQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboQuyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboQuyen.FormattingEnabled = true;
            this.cboQuyen.IntegralHeight = false;
            this.cboQuyen.ItemHeight = 43;
            this.cboQuyen.Location = new System.Drawing.Point(422, 130);
            this.cboQuyen.MaxDropDownItems = 4;
            this.cboQuyen.MouseState = MaterialSkin.MouseState.OUT;
            this.cboQuyen.Name = "cboQuyen";
            this.cboQuyen.Size = new System.Drawing.Size(198, 49);
            this.cboQuyen.StartIndex = 0;
            this.cboQuyen.TabIndex = 56;
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
            this.btnThem.Location = new System.Drawing.Point(117, 287);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThem.Name = "btnThem";
            this.btnThem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThem.Size = new System.Drawing.Size(108, 41);
            this.btnThem.TabIndex = 52;
            this.btnThem.Text = "THÊM";
            this.btnThem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThem.UseAccentColor = false;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = false;
            this.btnSua.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSua.Depth = 0;
            this.btnSua.HighEmphasis = true;
            this.btnSua.Icon = global::GUI.Properties.Resources.icons8_update_64;
            this.btnSua.Location = new System.Drawing.Point(434, 287);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSua.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSua.Name = "btnSua";
            this.btnSua.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSua.Size = new System.Drawing.Size(122, 41);
            this.btnSua.TabIndex = 52;
            this.btnSua.Text = "SỬA";
            this.btnSua.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSua.UseAccentColor = false;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(269, 287);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoa.Size = new System.Drawing.Size(115, 41);
            this.btnXoa.TabIndex = 52;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXoa.UseAccentColor = false;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.butXoa_Click);
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
            this.btnDong.Location = new System.Drawing.Point(477, 739);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDong.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDong.Name = "btnDong";
            this.btnDong.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDong.Size = new System.Drawing.Size(146, 47);
            this.btnDong.TabIndex = 52;
            this.btnDong.Text = "THOÁT";
            this.btnDong.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDong.UseAccentColor = false;
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
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
            this.btnKhongluu.Location = new System.Drawing.Point(356, 366);
            this.btnKhongluu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnKhongluu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnKhongluu.Name = "btnKhongluu";
            this.btnKhongluu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnKhongluu.Size = new System.Drawing.Size(146, 36);
            this.btnKhongluu.TabIndex = 52;
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
            this.btnLuu.Location = new System.Drawing.Point(152, 366);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLuu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLuu.Size = new System.Drawing.Size(146, 36);
            this.btnLuu.TabIndex = 52;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLuu.UseAccentColor = false;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmQuanLyTaiKhoan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(664, 845);
            this.Controls.Add(this.btnKhongluu);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cboQuyen);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.txtTaikhoan);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmQuanLyTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tài Khoản";
            this.Load += new System.EventHandler(this.frmQuanLyTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatKhau;
        private System.Windows.Forms.DataGridViewComboBoxColumn colQuyen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton btnLuu;
        private MaterialSkin.Controls.MaterialButton btnKhongluu;
        private MaterialSkin.Controls.MaterialButton btnDong;
        private MaterialSkin.Controls.MaterialButton btnXoa;
        private MaterialSkin.Controls.MaterialButton btnSua;
        private MaterialSkin.Controls.MaterialButton btnThem;
        private MaterialSkin.Controls.MaterialTextBox2 txtTaikhoan;
        private MaterialSkin.Controls.MaterialTextBox2 txtMatkhau;
        private MaterialSkin.Controls.MaterialComboBox cboQuyen;
    }
}