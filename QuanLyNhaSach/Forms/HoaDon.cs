using QuanLyNhaSach.Forms;
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

namespace QuanLyNhaSach
{
    public partial class HoaDon : Form
    {
        public string taikhoan;
        public HoaDon(string user)
        {
            InitializeComponent();
            UC_HoaDon uch = new UC_HoaDon();
            addControlToPanel(uch);
            taikhoan = user;
        }

        private void moveSidePanel(Control btn)
        {
            pnSide.Top = btn.Top;
            pnSide.Height = btn.Height;
        }

        private void addControlToPanel (Control c)
        {
            c.Dock = DockStyle.Fill;
            pnControls.Controls.Clear();
            pnControls.Controls.Add(c);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHoaDon);
            UC_HoaDon uch = new UC_HoaDon();
            addControlToPanel(uch);
        }

        private void ptrLogout_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
            this.Close();
        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            TaoHoaDon taoHoaDon= new TaoHoaDon();
            taoHoaDon.Show();
            this.Hide();
        }
        
        
       
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnKhachHang);
            UC_KhachHang ukh = new UC_KhachHang();
            addControlToPanel(ukh);

        }

        private void bntSach_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSach);
            UC_Sach ucs = new UC_Sach();
            addControlToPanel(ucs);
            
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnThongKe);
            UC_ThongKe utk = new UC_ThongKe();
            addControlToPanel(utk);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnNhanVien);
            UC_NhanVien unv = new UC_NhanVien();
            addControlToPanel(unv);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            String message = "Bạn muốn thoát chứ?";
            String title = "Đóng Ứng Dụng";
            MessageBoxButtons btn = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, btn, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                this.Close();
                DangNhap dn = new DangNhap();
                dn.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnQuanly);
            UC_Quanly unv = new UC_Quanly(taikhoan);
            addControlToPanel(unv);
        }
    }
}
