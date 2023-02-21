using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Khachhang
{
    public class Khachhang
    {
        private int khid;
        private string khten;
        private string khsp;
        private string khtl;
        private int khsl;
        private DateTime khngay;
        private int khgia;

        public int Khid { get => khid; set => khid = value; }
        public string Khten { get => khten; set => khten = value; }
        public string Khsp { get => khsp; set => khsp = value; }
        public string Khtl { get => khtl; set => khtl = value; }
        public int Khsl { get => khsl; set => khsl = value; }
        public DateTime Khngay { get => khngay; set => khngay = value; }
        public int Khgia { get => khgia; set => khgia = value; }

        public Khachhang(DataRow row)
        {
            this.Khid = (int)row["Khid"];
            this.Khten = row["Khten"].ToString();
            this.Khsp = row["Khsp"].ToString();
            this.Khtl = row["Khtl"].ToString();
            this.Khsl = (int)row["Khsl"];
            this.khngay = (DateTime)row["Khngay"];
            this.Khgia = (int)row["Khgia"];
        }
    }
}
