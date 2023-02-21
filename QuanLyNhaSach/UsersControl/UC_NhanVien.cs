using QuanLyNhaSach.Nhanvien;
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
    public partial class UC_NhanVien : UserControl
    {
        public UC_NhanVien()
        {
            InitializeComponent();
            Loading();
        }
        public string id;
        public void Loading()
        {
            string query = "select Nvid N'ID', Nvname N'Tên nhân viên', Nvsdt N'Số điện thoại', Nvgt N'Giới tính', Nvns N'Ngày sinh', Nvluong N'Lương' from Nhanvien1";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            DGVNhanVien.DataSource = data;
            dataS();
        }
        void dataS()
        {
            // Canh chỉnh nằm giữa tiêu đề cột
            DGVNhanVien.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Cột Id
            DGVNhanVien.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGVNhanVien.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Cột Name
            DGVNhanVien.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            // Cột Phone
            DGVNhanVien.Columns[2].Width = 130;
            DGVNhanVien.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Cột Gender
            DGVNhanVien.Columns[3].Width = 130;
            DGVNhanVien.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Cột Date of Birth (DoB)
            DGVNhanVien.Columns[4].Width = 130;
            DGVNhanVien.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Cột Salary
            DGVNhanVien.Columns[5].Width = 130;
            DGVNhanVien.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnLuuNhanVien_Click(object sender, EventArgs e)
        {
            string ten = txtTenNhanVien.Text;
            string sdt = txtSoDienThoai.Text;
            string gioitinh = cbbGioiTinh.Text;
            string ngaysinh = dTPNgaySinh.Value.ToString("yyyy-MM-dd");
            int luong = Convert.ToInt32(txtLuong.Text);

            int result = StaffDAO.Instance.InsertStaff(ten,sdt, gioitinh, ngaysinh, luong);

            Loading();
        }

        private void btnXoaRongNhanVien_Click(object sender, EventArgs e)
        {
            string ten = txtTenNhanVien.Text;
            string sdt = txtSoDienThoai.Text;
            string gioitinh = cbbGioiTinh.Text;
            string ngaysinh = dTPNgaySinh.Value.ToString("yyyy-MM-dd");
            int luong = Convert.ToInt32(txtLuong.Text);

            int result = StaffDAO.Instance.DeleteStaff(ten, sdt, gioitinh, ngaysinh, luong);

            Loading();
        }

        private void DGVNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DGVNhanVien.Rows[e.RowIndex];

                id = row.Cells[0].Value.ToString();
                txtTenNhanVien.Text = row.Cells[1].Value.ToString();
                txtSoDienThoai.Text = row.Cells[2].Value.ToString();
                cbbGioiTinh.Text = row.Cells[3].Value.ToString();
                dTPNgaySinh.Text = row.Cells[4].Value.ToString();
                txtLuong.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(id);
            string ten = txtTenNhanVien.Text;
            string sdt = txtSoDienThoai.Text;
            string gioitinh = cbbGioiTinh.Text;
            string ngaysinh = dTPNgaySinh.Value.ToString("yyyy-MM-dd");
            int luong = Convert.ToInt32(txtLuong.Text);

            int result = StaffDAO.Instance.UpdateStaff(ID, ten, sdt, gioitinh, ngaysinh, luong);

            Loading();
        }

        private void btnTimNhanVien_Click(object sender, EventArgs e)
        {
            string ten = txtTimKiemTen.Text;
            string query = "select Nvid N'ID', Nvname N'Tên nhân viên', Nvsdt N'Số điện thoại', Nvgt N'Giới tính', Nvns N'Ngày sinh', Nvluong N'Lương' from Nhanvien1 where Nvname = N'" + ten + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            DGVNhanVien.DataSource = data;
            dataS();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(id);
            string ten = txtTenNhanVien.Text;
            string sdt = txtSoDienThoai.Text;
            string gioitinh = cbbGioiTinh.Text;
            string ngaysinh = dTPNgaySinh.Value.ToString("yyyy-MM-dd");
            int luong = Convert.ToInt32(txtLuong.Text);

            int result = StaffDAO.Instance.UpdateStaff(ID, ten, sdt, gioitinh, ngaysinh, luong);

            Loading();
        }

        private void UC_NhanVien_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
