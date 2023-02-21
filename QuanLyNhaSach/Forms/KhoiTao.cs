using QuanLyNhaSach.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        int startpos =0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 5;
            progressBar1.Value = startpos;
            lblPhanTram.Text = startpos+ "%";
            if ( progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                DangNhap dangNhap = new DangNhap();
                dangNhap.Show();
                this.Hide();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
