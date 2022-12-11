namespace GUI
{
    partial class frmBaoCaoCongNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoCongNo));
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCongNo = new System.Windows.Forms.DataGridView();
            this.colThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhatSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoCuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThang = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtNam = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnBaoCao = new MaterialSkin.Controls.MaterialButton();
            this.btnThoat = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongNo)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(298, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 36);
            this.label3.TabIndex = 15;
            this.label3.Text = "BÁO CÁO CÔNG NỢ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Controls.Add(this.dgvCongNo);
            this.groupBox1.Location = new System.Drawing.Point(10, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(901, 351);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin công nợ";
            // 
            // dgvCongNo
            // 
            this.dgvCongNo.AllowUserToAddRows = false;
            this.dgvCongNo.AllowUserToDeleteRows = false;
            this.dgvCongNo.AllowUserToResizeColumns = false;
            this.dgvCongNo.AllowUserToResizeRows = false;
            this.dgvCongNo.BackgroundColor = System.Drawing.Color.White;
            this.dgvCongNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCongNo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colThang,
            this.colNam,
            this.colMaKhachHang,
            this.colNoDau,
            this.colPhatSinh,
            this.colNoCuoi});
            this.dgvCongNo.Location = new System.Drawing.Point(6, 26);
            this.dgvCongNo.Name = "dgvCongNo";
            this.dgvCongNo.ReadOnly = true;
            this.dgvCongNo.Size = new System.Drawing.Size(890, 319);
            this.dgvCongNo.TabIndex = 0;
            // 
            // colThang
            // 
            this.colThang.DataPropertyName = "Thang";
            this.colThang.HeaderText = "Tháng";
            this.colThang.Name = "colThang";
            this.colThang.ReadOnly = true;
            // 
            // colNam
            // 
            this.colNam.DataPropertyName = "Nam";
            this.colNam.HeaderText = "Năm";
            this.colNam.Name = "colNam";
            this.colNam.ReadOnly = true;
            // 
            // colMaKhachHang
            // 
            this.colMaKhachHang.DataPropertyName = "MaKhachHang";
            this.colMaKhachHang.HeaderText = "Mã khách hàng";
            this.colMaKhachHang.Name = "colMaKhachHang";
            this.colMaKhachHang.ReadOnly = true;
            this.colMaKhachHang.Width = 200;
            // 
            // colNoDau
            // 
            this.colNoDau.DataPropertyName = "NoDau";
            this.colNoDau.HeaderText = "Nợ đầu";
            this.colNoDau.Name = "colNoDau";
            this.colNoDau.ReadOnly = true;
            this.colNoDau.Width = 150;
            // 
            // colPhatSinh
            // 
            this.colPhatSinh.DataPropertyName = "PhatSinh";
            this.colPhatSinh.HeaderText = "Phát sinh";
            this.colPhatSinh.Name = "colPhatSinh";
            this.colPhatSinh.ReadOnly = true;
            this.colPhatSinh.Width = 150;
            // 
            // colNoCuoi
            // 
            this.colNoCuoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNoCuoi.DataPropertyName = "NoCuoi";
            this.colNoCuoi.HeaderText = "Nợ cuối";
            this.colNoCuoi.Name = "colNoCuoi";
            this.colNoCuoi.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Năm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tháng:";
            // 
            // txtThang
            // 
            this.txtThang.AnimateReadOnly = false;
            this.txtThang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtThang.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtThang.Depth = 0;
            this.txtThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtThang.HideSelection = true;
            this.txtThang.LeadingIcon = null;
            this.txtThang.Location = new System.Drawing.Point(219, 142);
            this.txtThang.MaxLength = 32767;
            this.txtThang.MouseState = MaterialSkin.MouseState.OUT;
            this.txtThang.Name = "txtThang";
            this.txtThang.PasswordChar = '\0';
            this.txtThang.PrefixSuffixText = null;
            this.txtThang.ReadOnly = false;
            this.txtThang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtThang.SelectedText = "";
            this.txtThang.SelectionLength = 0;
            this.txtThang.SelectionStart = 0;
            this.txtThang.ShortcutsEnabled = true;
            this.txtThang.Size = new System.Drawing.Size(173, 48);
            this.txtThang.TabIndex = 17;
            this.txtThang.TabStop = false;
            this.txtThang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtThang.TrailingIcon = null;
            this.txtThang.UseSystemPasswordChar = false;
            // 
            // txtNam
            // 
            this.txtNam.AnimateReadOnly = false;
            this.txtNam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNam.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNam.Depth = 0;
            this.txtNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNam.HideSelection = true;
            this.txtNam.LeadingIcon = null;
            this.txtNam.Location = new System.Drawing.Point(522, 142);
            this.txtNam.MaxLength = 32767;
            this.txtNam.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNam.Name = "txtNam";
            this.txtNam.PasswordChar = '\0';
            this.txtNam.PrefixSuffixText = null;
            this.txtNam.ReadOnly = false;
            this.txtNam.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNam.SelectedText = "";
            this.txtNam.SelectionLength = 0;
            this.txtNam.SelectionStart = 0;
            this.txtNam.ShortcutsEnabled = true;
            this.txtNam.Size = new System.Drawing.Size(173, 48);
            this.txtNam.TabIndex = 17;
            this.txtNam.TabStop = false;
            this.txtNam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNam.TrailingIcon = null;
            this.txtNam.UseSystemPasswordChar = false;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.AutoSize = false;
            this.btnBaoCao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaoCao.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBaoCao.Depth = 0;
            this.btnBaoCao.HighEmphasis = true;
            this.btnBaoCao.Icon = global::GUI.Properties.Resources.icons8_book_and_pencil_64;
            this.btnBaoCao.Location = new System.Drawing.Point(364, 215);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBaoCao.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBaoCao.Size = new System.Drawing.Size(175, 42);
            this.btnBaoCao.TabIndex = 18;
            this.btnBaoCao.Text = "BÁO CÁO";
            this.btnBaoCao.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBaoCao.UseAccentColor = false;
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
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
            this.btnThoat.Location = new System.Drawing.Point(773, 650);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThoat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThoat.Size = new System.Drawing.Size(133, 49);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThoat.UseAccentColor = false;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmBaoCaoCongNo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(954, 747);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmBaoCaoCongNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Công Nợ";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCongNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhatSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoCuoi;
        private MaterialSkin.Controls.MaterialTextBox2 txtThang;
        private MaterialSkin.Controls.MaterialTextBox2 txtNam;
        private MaterialSkin.Controls.MaterialButton btnBaoCao;
        private MaterialSkin.Controls.MaterialButton btnThoat;
    }
}