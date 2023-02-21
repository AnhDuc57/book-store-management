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
    public partial class UC_ThongKe : UserControl
    {
        public UC_ThongKe()
        {
            InitializeComponent();
            string query = "select MaHD N'Mã', TenKH N'Tên KH', Ngaymua N'Ngày', Thanhtien N'Thành tiền' from Bill";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dtHoadon.DataSource = data;
            format_Bill();

            dtHoadon.RowHeadersVisible = false;
            dtChitiet.RowHeadersVisible = false;
        }

        public void format_Bill()
        {
            // Canh chỉnh nằm giữa tiêu đề cột
            dtHoadon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Cột Mã hóa đơn
            dtHoadon.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtHoadon.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Cột Tên khách hàng
            dtHoadon.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            // Cột Ngày mua
            dtHoadon.Columns[2].Width = 80;
            dtHoadon.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Cột Thành tiền
            dtHoadon.Columns[3].Width = 103;
            dtHoadon.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        public void format_InfoBill()
        {
            // Canh chỉnh nằm giữa tiêu đề cột
            dtChitiet.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Cột Loại sản phẩm
            dtChitiet.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            // Cột Tên sản phẩm
            dtChitiet.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            // Cột Số lượng
            dtChitiet.Columns[2].Width = 90;
            dtChitiet.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Cột Thành tiền
            dtChitiet.Columns[3].Width = 103;
            dtChitiet.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        public void searchInfo(int code)
        {
            string query = "select ib.LoaiSP N'Loại', ib.TenSP N'Tên sản phẩm', ib.Soluong N'Số lượng', ib.Thanhtien N'Thành tiền' from Bill bl, InfoBill ib where bl.MaHD = ib.MaHD and ib.MaHD = " + code;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dtChitiet.DataSource = data;
        }

        private void dtHoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtHoadon.Rows[e.RowIndex];

                string id = row.Cells[0].Value.ToString();
                searchInfo(Convert.ToInt32(id));
                format_InfoBill();
            }
        }

        private void btnKiemtra_Click(object sender, EventArgs e)
        {
            string begin = dtBegin.Value.ToString("yyyy-MM-dd");
            string end = dtEnd.Value.ToString("yyyy-MM-dd");
            string query = "select SUM(ib.Thanhtien) from Bill bl, InfoBill ib where bl.MaHD = ib.MaHD and (bl.Ngaymua between '" + begin + "' and '" + end + "')";
            DataTable ans = DataProvider.Instance.ExcuteQuery(query);
            lb_Tong.Text = "▶ Doanh thu = " + ans.Rows[0][0].ToString() + " VND ◀";
        }

      
    }
}
