using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Sach
{
    public class Sach
    {
        private int sachid;
        private string sachname;
        private string sachtg;
        private string sachtl;
        private int sachsl;
        private int sachgia;

        public int Sachid { get => sachid; set => sachid = value; }
        public string Sachname { get => sachname; set => sachname = value; }
        public string Sachtg { get => sachtg; set => sachtg = value; }
        public string Sachtl { get => sachtl; set => sachtl = value; }
        public int Sachsl { get => sachsl; set => sachsl = value; }
        public int Sachgia { get => sachgia; set => sachgia = value; }

        public Sach(DataRow row)
        {
            this.Sachid = (int)row["Sachid"];
            this.Sachname = row["Sachname"].ToString();
            this.Sachtg = row["Sachtg"].ToString();
            this.Sachtl = row["Sachtl"].ToString();
            this.Sachsl = (int)row["Sachsl"];
            this.Sachgia = (int)row["Sachgia"];
        }
    }
}
