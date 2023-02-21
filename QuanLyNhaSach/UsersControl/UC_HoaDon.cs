using QuanLyNhaSach.Hoadon;
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
    public partial class UC_HoaDon : UserControl
    {
        public UC_HoaDon()
        {
            InitializeComponent();
            Loading();
        }
        private string ma;
        public void Loading()
        {
            string query ="select Hdid 'Id', Hdma N'Mã',Hdtenkh N'Tên khách hàng',Hdsp N'Sản Phẩm',Hdsl N'Số Lượng',Hdngay N'Ngày',Hdgia N'Giá' from Hoadon1";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            DGVHoaDon.DataSource = data;
            DataS();
        }
        public void DataS()
        {
            // Canh chỉnh nằm giữa tiêu đề cột
            DGVHoaDon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // 
            DGVHoaDon.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGVHoaDon.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //
            DGVHoaDon.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGVHoaDon.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //
            DGVHoaDon.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //
            DGVHoaDon.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //
            DGVHoaDon.Columns[4].Width = 100;
            DGVHoaDon.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //
            DGVHoaDon.Columns[5].Width = 105;
            DGVHoaDon.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //
            DGVHoaDon.Columns[6].Width = 105;
            DGVHoaDon.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void DGVHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DGVHoaDon.Rows[e.RowIndex];

                ma = row.Cells[0].Value.ToString();
                txtmahd.Text = row.Cells[1].Value.ToString();
                txttenkh.Text = row.Cells[2].Value.ToString();
                txttensp.Text = row.Cells[3].Value.ToString();
                txtsoluong.Text = row.Cells[4].Value.ToString();
                datetimengaymua.Text = row.Cells[5].Value.ToString();
                txtgiamua.Text = row.Cells[6].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mahd = txtmahd.Text;
            string tenkh = txttenkh.Text;
            string tensp = txttensp.Text;
            int soluong = Convert.ToInt32(txtsoluong.Text);
            string ngay = datetimengaymua.Value.ToString("yyyy-MM-dd");
            int gia = Convert.ToInt32(txtgiamua.Text);

            int result = HoadonDAO.Instance.InsertHoadon(mahd,tenkh,tensp,soluong,ngay,gia);

            Loading();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ma);
            string mahd = txtmahd.Text;
            string tenkh = txttenkh.Text;
            string tensp = txttensp.Text;
            int soluong = Convert.ToInt32(txtsoluong.Text);
            string ngay = datetimengaymua.Value.ToString("yyyy-MM-dd");
            int gia = Convert.ToInt32(txtgiamua.Text);

            int result = HoadonDAO.Instance.UpdateHoadon(id,mahd, tenkh, tensp, soluong, ngay, gia);

            Loading();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mahd = txtmahd.Text;
            string tenkh = txttenkh.Text;
            string tensp = txttensp.Text;
            int soluong = Convert.ToInt32(txtsoluong.Text);
            string ngay = datetimengaymua.Value.ToString("yyyy-MM-dd");
            int gia = Convert.ToInt32(txtgiamua.Text);

            int result = HoadonDAO.Instance.DeleteHoadon(mahd, tenkh, tensp, soluong, ngay, gia);

            Loading();
        }

        private void btnTimKiemHoaDon_Click(object sender, EventArgs e)
        {
            string ten = txtTimKiemHoaDon.Text;
            string query = "select Hdid 'Id', Hdma N'Mã',Hdtenkh N'Tên khách hàng',Hdsp N'Sản Phẩm',Hdsl N'Số Lượng',Hdngay N'Ngày',Hdgia N'Giá' from Hoadon1 where Hdtenkh = N'" + ten + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            DGVHoaDon.DataSource = data;
            DataS();
        }
    }
}
