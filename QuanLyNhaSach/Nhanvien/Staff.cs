using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Nhanvien
{
    public class Staff
    {
        private int nvid;
        private string nvname;
        private string nvgt;
        private DateTime nvns;
        private string nvsdt;
        private int nvluong;


        public Staff(DataRow row)
        {
            this.Nvid = (int)row["Nvid"];
            this.Nvname = row["Nvname"].ToString();
            this.Nvgt = row["Nvgt"].ToString();
            this.Nvns = (DateTime)row["Nvns"];
            this.Nvsdt = row["Nvsdt"].ToString();
            this.Nvluong = (int)row["Nvluong"];
        }

        public int Nvid { get => nvid; set => nvid = value; }
        public string Nvname { get => nvname; set => nvname = value; }
        public string Nvgt { get => nvgt; set => nvgt = value; }
        public DateTime Nvns { get => nvns; set => nvns = value; }
        public string Nvsdt { get => nvsdt; set => nvsdt = value; }
        public int Nvluong { get => nvluong; set => nvluong = value; }
    }
}
