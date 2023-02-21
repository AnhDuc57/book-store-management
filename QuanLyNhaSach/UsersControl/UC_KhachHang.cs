using QuanLyNhaSach.Khachhang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.DAO;

namespace QuanLyNhaSach.UsersControl
{
    public partial class UC_KhachHang : UserControl
    {
        public UC_KhachHang()
        {
            InitializeComponent();
            Loading();
            DataS();
        }
        private string ma;
        public void Loading()
        {
            string query = "select Khid 'ID', Khten N'Tên Khách Hàng',Khsp N'Sản Phẩm', Khtl N'Thể Loại', Khsl N'Số Lượng',Khngay N'Ngày Mua',Khgia N'Giá' from Khachhang1";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            DGVKhachHang.DataSource = data;
        }
        public void DataS()
        {
            // Canh chỉnh nằm giữa tiêu đề cột
            DGVKhachHang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // 
            DGVKhachHang.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGVKhachHang.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //
            DGVKhachHang.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGVKhachHang.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //
            DGVKhachHang.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //
            DGVKhachHang.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //
            DGVKhachHang.Columns[4].Width = 100;
            DGVKhachHang.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //
            DGVKhachHang.Columns[5].Width = 105;
            DGVKhachHang.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //
            DGVKhachHang.Columns[6].Width = 105;
            DGVKhachHang.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void DGVKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DGVKhachHang.Rows[e.RowIndex];

                ma = row.Cells[0].Value.ToString();
                txttenkh.Text = row.Cells[1].Value.ToString();
                txttensp.Text = row.Cells[2].Value.ToString();
                cbbtheloai.Text = row.Cells[3].Value.ToString();
                txtsoluong.Text = row.Cells[4].Value.ToString();
                datetimengaymuakh.Text = row.Cells[5].Value.ToString();
                txtgiamuakh.Text = row.Cells[6].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txttenkh.Text;
            string sp = txttensp.Text;
            string tl = cbbtheloai.Text;
            int soluong = Convert.ToInt32(txtsoluong.Text);
            string ngay = datetimengaymuakh.Value.ToString("yyyy-MM-dd");
            int gia = Convert.ToInt32(txtgiamuakh.Text);

            int result = KhachhangDAO.Instance.InsertKhachhang(ten,sp,tl,soluong,ngay,gia);

            Loading();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ma);
            string ten = txttenkh.Text;
            string sp = txttensp.Text;
            string tl = cbbtheloai.Text;
            int soluong = Convert.ToInt32(txtsoluong.Text);
            string ngay = datetimengaymuakh.Value.ToString("yyyy-MM-dd");
            int gia = Convert.ToInt32(txtgiamuakh.Text);

            int result = KhachhangDAO.Instance.UpdateKhachhang(id,ten, sp, tl, soluong, ngay, gia);

            Loading();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ten = txttenkh.Text;
            string sp = txttensp.Text;
            string tl = cbbtheloai.Text;
            int soluong = Convert.ToInt32(txtsoluong.Text);
            string ngay = datetimengaymuakh.Value.ToString("yyyy-MM-dd");
            int gia = Convert.ToInt32(txtgiamuakh.Text);

            int result = KhachhangDAO.Instance.DeleteKhachhang( ten, sp, tl, soluong, ngay, gia);

            Loading();
        }

        private void btnTimKiemKhachHang_Click(object sender, EventArgs e)
        {
            string ten = txtTimKiemKhachHang.Text;
            string query = "select Khid 'ID', Khten N'Tên Khách Hàng',Khsp N'Sản Phẩm', Khtl N'Thể Loại', Khsl N'Số Lượng',Khngay N'Ngày Mua',Khgia N'Giá' from Khachhang1 where Khten = N'" + ten + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            DGVKhachHang.DataSource = data;
            DataS();

        }

        private void UC_KhachHang_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txttensp_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbtheloai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
