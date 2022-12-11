namespace GUI
{
    partial class frmBaoCaoTon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoTon));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTon = new System.Windows.Forms.DataGridView();
            this.colThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTonDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhatSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTonCuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThang = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtNam = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnBaoCao = new MaterialSkin.Controls.MaterialButton();
            this.btnThoat = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tháng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Năm:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Controls.Add(this.dgvTon);
            this.groupBox1.Location = new System.Drawing.Point(23, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(901, 384);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tồn";
            // 
            // dgvTon
            // 
            this.dgvTon.AllowUserToAddRows = false;
            this.dgvTon.AllowUserToDeleteRows = false;
            this.dgvTon.AllowUserToResizeColumns = false;
            this.dgvTon.AllowUserToResizeRows = false;
            this.dgvTon.BackgroundColor = System.Drawing.Color.White;
            this.dgvTon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colThang,
            this.colNam,
            this.colMaSach,
            this.colTonDau,
            this.colPhatSinh,
            this.colTonCuoi});
            this.dgvTon.GridColor = System.Drawing.Color.Black;
            this.dgvTon.Location = new System.Drawing.Point(6, 26);
            this.dgvTon.Name = "dgvTon";
            this.dgvTon.Size = new System.Drawing.Size(890, 352);
            this.dgvTon.TabIndex = 0;
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
            // colMaSach
            // 
            this.colMaSach.DataPropertyName = "MaSach";
            this.colMaSach.HeaderText = "Mã sách";
            this.colMaSach.Name = "colMaSach";
            this.colMaSach.ReadOnly = true;
            this.colMaSach.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaSach.Width = 200;
            // 
            // colTonDau
            // 
            this.colTonDau.DataPropertyName = "TonDau";
            this.colTonDau.HeaderText = "Tồn đầu";
            this.colTonDau.Name = "colTonDau";
            this.colTonDau.ReadOnly = true;
            this.colTonDau.Width = 150;
            // 
            // colPhatSinh
            // 
            this.colPhatSinh.DataPropertyName = "PhatSinh";
            this.colPhatSinh.HeaderText = "Phát sinh";
            this.colPhatSinh.Name = "colPhatSinh";
            this.colPhatSinh.ReadOnly = true;
            this.colPhatSinh.Width = 150;
            // 
            // colTonCuoi
            // 
            this.colTonCuoi.DataPropertyName = "TonCuoi";
            this.colTonCuoi.HeaderText = "Tồn cuối";
            this.colTonCuoi.Name = "colTonCuoi";
            this.colTonCuoi.ReadOnly = true;
            this.colTonCuoi.Width = 150;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(348, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "BÁO CÁO TỒN";
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
            this.txtThang.Location = new System.Drawing.Point(291, 144);
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
            this.txtThang.Size = new System.Drawing.Size(148, 48);
            this.txtThang.TabIndex = 9;
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
            this.txtNam.Location = new System.Drawing.Point(530, 144);
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
            this.txtNam.Size = new System.Drawing.Size(148, 48);
            this.txtNam.TabIndex = 9;
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
            this.btnBaoCao.Location = new System.Drawing.Point(382, 218);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBaoCao.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBaoCao.Size = new System.Drawing.Size(163, 36);
            this.btnBaoCao.TabIndex = 10;
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
            this.btnThoat.Location = new System.Drawing.Point(761, 674);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThoat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThoat.Size = new System.Drawing.Size(163, 36);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThoat.UseAccentColor = false;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmBaoCaoTon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(959, 758);
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
            this.Name = "frmBaoCaoTon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Tồn";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTonDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhatSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTonCuoi;
        private MaterialSkin.Controls.MaterialTextBox2 txtThang;
        private MaterialSkin.Controls.MaterialTextBox2 txtNam;
        private MaterialSkin.Controls.MaterialButton btnBaoCao;
        private MaterialSkin.Controls.MaterialButton btnThoat;
    }
}