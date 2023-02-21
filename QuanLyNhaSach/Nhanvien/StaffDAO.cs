using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.DAO;

namespace QuanLyNhaSach.Nhanvien
{
    public class StaffDAO
    {
        private static StaffDAO instance;
        public static StaffDAO Instance
        {
            get { if (instance == null) { instance = new StaffDAO(); } return instance; }
            private set => instance = value;
        }

        private StaffDAO() { }

        public List<Staff> getListStaff()
        {
            string query = "select * from Staff";
            List<Staff> staffs = new List<Staff>();
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Staff staff = new Staff(item);
                staffs.Add(staff);
            }

            return staffs;
        }

        public int InsertStaff(string ten,string sdt, string gioitinh, string ngaysinh, int luong)
        {
            string query = "insert Nhanvien1 values(N'" + ten + "','" + sdt + "',N'" + gioitinh + "','" + ngaysinh + "'," + luong + ")";
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result;
        }

        public int DeleteStaff(string ten, string sdt, string gioitinh, string ngaysinh, int luong)
        {
            string query = "delete from Nhanvien1 where Nvname = N'" + ten + "' and Nvsdt = '" + sdt + "' and Nvgt = N'" + gioitinh + "' and Nvns = '" + ngaysinh + "' and Nvluong = " + luong;
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result;
        }

        public int UpdateStaff(int id, string ten, string sdt, string gioitinh, string ngaysinh, int luong)
        {

            string query = "update Nhanvien1 set Nvname = N'" + ten + "', Nvsdt = '" + sdt + "', Nvgt = N'" + gioitinh + "', Nvns = '" + ngaysinh + "', Nvluong = " + luong + " where Nvid = " + id;
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result;
        }
    }
}
