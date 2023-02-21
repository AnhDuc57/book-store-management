using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.DAO;

namespace QuanLyNhaSach.Account
{
    public class Login
    {
        public bool Login_Account(string userName, string passWord)
        {

            string query = "select * from Account where username = '" + userName + "' and password = '" + passWord + "'";
            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[] { userName, passWord });
            return result.Rows.Count > 0;
        }
    }
}
