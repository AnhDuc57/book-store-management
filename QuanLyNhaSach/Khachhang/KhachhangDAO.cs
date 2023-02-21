using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.DAO;

namespace QuanLyNhaSach.Khachhang
{
    public class KhachhangDAO
    {
        private static KhachhangDAO instance;
        public static KhachhangDAO Instance
        {
            get { if (instance == null) { instance = new KhachhangDAO(); } return instance; }
            private set => instance = value;
        }

        private KhachhangDAO() { }

        public List<Khachhang> getListKhachhang()
        {
            string query = "select * from Khachhang1";
            List<Khachhang> khachhangs = new List<Khachhang>();
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Khachhang khachhang = new Khachhang(item);
                khachhangs.Add(khachhang);
            }

            return khachhangs;
        }
        public int InsertKhachhang(string ten, string sp, string theloai, int soluong, string ngay, int gia)
        {
            string query = "insert Khachhang1 values(N'" + ten + "',N'" + sp + "',N'" + theloai + "', " + soluong + ",'"+ngay+"',"+gia+")";
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result;
        }

        public int DeleteKhachhang(string ten, string sp, string theloai, int soluong, string ngay, int gia)
        {
            string query = "delete from Khachhang1 where Khten = N'" + ten + "' and Khsp = N'" + sp + "' and Khtl = N'" + theloai + "' and Khsl = " + soluong + " and Khngay = '"+ngay+"' and Khgia = "+gia;
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result;
        }

        public int UpdateKhachhang(int id, string ten, string sp, string theloai, int soluong, string ngay, int gia)
        {

            string query = "update Khachhang1 set Khten = N'" + ten + "', Khsp = N'" + sp + "', Khtl = N'" + theloai + "', Khsl = " + soluong + ", Khngay = '" + ngay + "', Khgia = " + gia + " where Khid = " + id;
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result;
        }
    }
}

