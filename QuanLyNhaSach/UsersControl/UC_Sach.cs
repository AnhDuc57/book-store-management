using QuanLyNhaSach.Sach;
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
    public partial class UC_Sach : UserControl
    {
        public UC_Sach()
        {
            InitializeComponent();
            Loading();
        }
        public string id;
        public void Loading()
        {
            string query = "select Sachid N'ID', Sachname N'Tên Sách', Sachtg N'Tác Giả', Sachtl N'Thể Loại', Sachsl N'Số Lượng', Sachgia N'Giá' from Sach1";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            DGVSach.DataSource = data;
            dataS();
        }
        void dataS()
        {
            // Canh chỉnh nằm giữa tiêu đề cột
            DGVSach.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Cột Id
            DGVSach.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGVSach.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Cột Name
            DGVSach.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            // Cột Phone
            DGVSach.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGVSach.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Cột Gender
            DGVSach.Columns[3].Width = 130;
            DGVSach.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Cột Date of Birth (DoB)
            DGVSach.Columns[4].Width = 130;
            DGVSach.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Cột Salary
            DGVSach.Columns[5].Width = 130;
            DGVSach.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void DGVSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DGVSach.Rows[e.RowIndex];

                id = row.Cells[0].Value.ToString();
                txtTenSach.Text = row.Cells[1].Value.ToString();
                txtTacGia.Text = row.Cells[2].Value.ToString();
                cbbTheLoai.Text = row.Cells[3].Value.ToString();
                txtSoLuong.Text = row.Cells[4].Value.ToString();
                txtGia.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(id);
            string ten = txtTenSach.Text;
            string tacgia = txtTacGia.Text;
            string theloai = cbbTheLoai.Text;
            int soluong = Convert.ToInt32(txtSoLuong.Text);
            int gia = Convert.ToInt32(txtGia.Text);

            int result = SachDAO.Instance.UpdateSach(ID, ten, tacgia, theloai, soluong, gia);

            Loading();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTenSach.Text;
            string tacgia = txtTacGia.Text;
            string theloai = cbbTheLoai.Text;
            int soluong = Convert.ToInt32(txtSoLuong.Text);
            int gia = Convert.ToInt32(txtGia.Text);

            int result = SachDAO.Instance.InsertSach( ten, tacgia, theloai, soluong, gia);

            Loading();
        }

        private void btnXoaRong_Click(object sender, EventArgs e)
        {
            string ten = txtTenSach.Text;
            string tacgia = txtTacGia.Text;
            string theloai = cbbTheLoai.Text;
            int soluong = Convert.ToInt32(txtSoLuong.Text);
            int gia = Convert.ToInt32(txtGia.Text);

            int result = SachDAO.Instance.DeleteSach(ten, tacgia, theloai, soluong, gia);

            Loading();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string ten = txtTimKiemSach.Text;
            string query = "select Sachid N'ID', Sachname N'Tên Sách', Sachtg N'Tác Giả', Sachtl N'Thể Loại', Sachsl N'Số Lượng', Sachgia N'Giá' from Sach1 where Sachname = N'" + ten + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            DGVSach.DataSource = data;
            dataS();
        }
    }
}
