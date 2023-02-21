using QuanLyNhaSach.Forms;
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
    public partial class TaoHoaDon : Form
    {
        public TaoHoaDon()
        {
            InitializeComponent();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            String message = "Xác nhận in hóa đơn?";
            String title = "In Hóa Đơn";
            MessageBoxButtons btn = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, btn, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemVaoHoaDon_Click(object sender, EventArgs e)
        {
            SoLuong sl = new SoLuong();
            sl.Show();
        }

        private void txtTimKiemSach_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiemSach.Text = "";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            txtTimKiemSach.Text = "Nhập tên sách để tìm";
        }
    }
}
