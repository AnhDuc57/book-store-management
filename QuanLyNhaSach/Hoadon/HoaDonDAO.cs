using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.DAO;

namespace QuanLyNhaSach.Hoadon
{
    public class HoadonDAO
    {
        private static HoadonDAO instance;
        public static HoadonDAO Instance
        {
            get { if (instance == null) { instance = new HoadonDAO(); } return instance; }
            private set => instance = value;
        }

        private HoadonDAO() { }

        public List<Hoadon> getListHoadon()
        {
            string query = "select * from Hoadon1";
            List<Hoadon> hoadons = new List<Hoadon>();
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Hoadon hoadon = new Hoadon(item);
                hoadons.Add(hoadon);
            }

            return hoadons;
        }

        public int InsertHoadon(string ma, string ten, string sanpham, int sl,string ngay, int gia)
        {
            string query = "insert Hoadon1 values(N'" + ma + "','" + ten + "',N'" + sanpham + "'," + sl + ",'" + ngay + "'," + gia + ")";
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result;
        }

        public int DeleteHoadon(string ma, string ten, string sanpham, int sl,string ngay, int gia)
        {
            string query = "delete from Hoadon1 where Hdma = N'" + ma + "' and Hdtenkh = N'" + ten + "' and Hdsp = N'" + sanpham + "' and Hdsl = " + sl + " and Hdngay = '" + ngay +"' and Hdgia = " + gia;
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result;
        }

        public int UpdateHoadon(int id, string ma, string ten, string sanpham, int sl, string ngay, int gia)
        {

            string query = "update Hoadon1 set Hdma = N'" + ma + "', Hdtenkh = N'" + ten + "', Hdsp = N'" + sanpham + "', Hdsl = " + sl + ", Hdngay = '" + ngay + "', Hdgia = " + gia + " where Hdid = " + id;
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result;
        }
    }
}
