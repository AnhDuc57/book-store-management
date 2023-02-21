using QuanLyNhaSach.Account;
using QuanLyNhaSach.UsersControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach.Forms
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            this.txtMatKhau.PasswordChar = '•';
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void btnDangNhapNhanVien_Click(object sender, EventArgs e)
        {
            string user = txtTaiKhoan.Text;
            string pass = txtMatKhau.Text;
            Login login = new Login();
            if (login.Login_Account(user, pass) == true)
            {
                MessageBox.Show("Đăng Nhập Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HoaDon frm = new HoaDon(txtTaiKhoan.Text);
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Đăng Nhập Thất Bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui Lòng Liên Hệ Phòng IT Nhà Sách Để Cấp Lại Mật Khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
    }
}
