using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.DAO;

namespace QuanLyNhaSach.Sach
{
    public class SachDAO
    {
        private static SachDAO instance;
        public static SachDAO Instance
        {
            get { if (instance == null) { instance = new SachDAO(); } return instance; }
            private set => instance = value;
        }

        private SachDAO() { }

        public List<Sach> getListStaff()
        {
            string query = "select * from Staff";
            List<Sach> sachs = new List<Sach>();
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Sach sach = new Sach(item);
                sachs.Add(sach);
            }

            return sachs;
        }

        public int InsertSach(string name, string tacgia, string theloai, int soluong, int gia)
        {
            string query = "insert Sach1 values(N'" + name + "',N'" + tacgia + "',N'" + theloai + "'," + soluong + "," + gia + ")";
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result;
        }

        public int UpdateSach(int id, string ten, string tacgia, string theloai, int soluong, int gia)
        {
            string query = "update Sach1 set Sachname = N'" + ten + "', Sachtg = N'" + tacgia + "', Sachtl = N'" + theloai + "', Sachsl = " + soluong + ", Sachgia = " + gia + " where Sachid = " + id;
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result;
        }
        public int DeleteSach(string name, string tacgia, string theloai, int soluong, int gia)
        {
            string query = "delete from Sach1 where Sachname = N'" + name + "' and Sachtg = N'" + tacgia + "' and Sachtl = N'" + theloai + "' and Sachsl = " + soluong + " and Sachgia = " + gia;
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result;
        }
    }
}
