using BUS;
using DTO;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmQuanLyKhachHang : MaterialForm
    {
        public frmQuanLyKhachHang()
        {
            InitializeComponent();           
        }
        public void Enable(bool a)
        {
            txtDiaChi.ReadOnly = !a;
            txtDienThoai.ReadOnly = !a;
            txtEmail.ReadOnly = !a;
            txtTenKhachHang.ReadOnly = !a;

            btnLuu.Enabled = a;
            btnKhongluu.Enabled = a;
        }
        public void HienThiDanhSach()
        {
            Enable(false);
            btnThem.Enabled = true;
            btnCapNhat.Enabled = true;
            dgvKhachHang.DataSource = KhachHang_BUS.GetKhachHangAll();
        }
        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            Enable(true);
            btnCapNhat.Enabled = false;
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
            txtMaKhachHang.Text = "";
            txtSoTienNo.Text = "";
            txtTenKhachHang.Text = "";
            txtTenKhachHang.Focus();
        }
        private void dgvKhachHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaKhachHang.Text = dgvKhachHang.Rows[dong].Cells[0].Value.ToString();
            txtTenKhachHang.Text = dgvKhachHang.Rows[dong].Cells[1].Value.ToString();
            txtDienThoai.Text = dgvKhachHang.Rows[dong].Cells[3].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.Rows[dong].Cells[2].Value.ToString();
            txtEmail.Text = dgvKhachHang.Rows[dong].Cells[4].Value.ToString();
            txtSoTienNo.Text = dgvKhachHang.Rows[dong].Cells[5].Value.ToString();
        }
        
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Enable(true);
            btnThem.Enabled = false;
            txtDiaChi.Text = "";
            txtDienThoai.Text = "0";
            txtEmail.Text = "";
            txtSoTienNo.Text = "";
            txtTenKhachHang.Text = "";
            txtTenKhachHang.Focus();
        }                       
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKhongluu_Click(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }
        public void Them()
        {
            KhachHang_DTO kh = new KhachHang_DTO();
            if (txtTenKhachHang.Text != "")
            {
                kh.TenKhachHang = txtTenKhachHang.Text;
            }
            else
            {
                MessageBox.Show("Tên khách hàng không được để trống", "Thông báo");
                return;
            }
            if (txtDienThoai.Text != "")
            {
                kh.SDT = txtDienThoai.Text;
                try
                {
                    Int64 sdt = Int64.Parse(txtDienThoai.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Điện thoại phải là số");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Điện thoại không được để trống", "Thông báo");
                return;
            }
            if (txtDiaChi.Text != "")
            {
                kh.DiaChi = txtDiaChi.Text;
            }
            else
            {
                MessageBox.Show("Địa chỉ không được để trống", "Thông báo");
                return;
            }
            if (txtEmail.Text != "")
            {
                kh.Email = txtEmail.Text;
            }
            else
            {
                MessageBox.Show("Email không được để trống", "Thông báo");
                return;
            }
            kh.SoTienNo = 0;
            string ketQua = KhachHang_BUS.ThemKhachHang(kh);
            if (ketQua != "Success")
            {
                MessageBox.Show(ketQua,"Lỗi");
                return;
            }
            MessageBox.Show("Thêm thành công");
            HienThiDanhSach();
        }
        public void CapNhat()
        {
            KhachHang_DTO kh = new KhachHang_DTO();
            try
            {
                kh.MaKhachHang = int.Parse(txtMaKhachHang.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Mã khách hàng phải là số và không được để trống!");
                return;
            }
            if (txtTenKhachHang.Text != "")
            {
                kh.TenKhachHang = txtTenKhachHang.Text;
            }
            else
            {
                MessageBox.Show("Tên khách hàng không được để trống");
                txtTenKhachHang.Focus();
                return;
            }
            if (txtDienThoai.Text != "")
            {
                kh.SDT = txtDienThoai.Text;
                try
                {
                    int sdt = int.Parse(txtDienThoai.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Điện thoại phải là số");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Số điện thoại không được để trống");
                txtDienThoai.Focus();
                return;
            }
            if (txtDiaChi.Text != "")
            {
                kh.DiaChi = txtDiaChi.Text;
            }
            else
            {
                MessageBox.Show("Địa chỉ không được để trống");
                txtDiaChi.Focus();
                return;
            }
            if (txtEmail.Text != "")
            {
                kh.Email = txtEmail.Text;
            }
            else
            {
                MessageBox.Show("Email không được để trống");
                txtEmail.Focus();
                return;
            }
            string ketQua = KhachHang_BUS.SuaKhachHang(kh);
            if (ketQua != "Success")
            {
                MessageBox.Show(ketQua,"Lỗi");
                return;
            }
            MessageBox.Show("Cập nhật thành công");
            HienThiDanhSach();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnCapNhat.Enabled == false)
            {                
                Them();
            }
            if (btnThem.Enabled == false)
            {
                CapNhat();
            }
        }
        bool isNum(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {
            try
            {
                UInt64 tem = UInt64.Parse(txtDienThoai.Text);
            }
            catch (FormatException)
            {
                if (!isNum(txtDienThoai.Text))
                {
                    MessageBox.Show("Số điện thoại không chứa ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDienThoai.Text = "0";
                    txtDienThoai.Focus();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtMaKhachHang.Text == "")
            {
                MessageBox.Show("Không được để trống mã khách hàng", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                
                KhachHang_DTO kh = new KhachHang_DTO();
                kh.MaKhachHang = int.Parse(txtMaKhachHang.Text);
                KhachHang_BUS.XoaKhachHang(kh);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                foreach(DataGridViewCell item in this.dgvKhachHang.SelectedCells)
                {
                    if (item.Selected)
                    {
                        dgvKhachHang.Rows.RemoveAt(item.RowIndex);
                    }
                }
            }
        }
    }
}
