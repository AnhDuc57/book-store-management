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
    public partial class UC_Quanly : UserControl
    {
        public UC_Quanly(string user)
        {
            InitializeComponent();
            txtUser.Text = user;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            string query = "select password from Account where username = '" + txtUser.Text + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            string pass = data.Rows[0][0].ToString();
            if (txtCurrentpass.Text == pass)
            {
                if (txtNewpass.Text == txtConfirmpass.Text)
                {
                    MessageBox.Show("Cập nhật thành công");
                    string query1 = "update Account set password = '" + txtNewpass.Text + "' where username = '" + txtUser.Text + "'";
                    int result = DataProvider.Instance.ExcuteNonQuery(query1);
                    txtCurrentpass.Text = "";
                    txtNewpass.Text = "";
                    txtConfirmpass.Text = "";
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới không giống nhau", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Sai mật khẩu!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
