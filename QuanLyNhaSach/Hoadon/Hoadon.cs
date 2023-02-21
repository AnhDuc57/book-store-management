using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Hoadon
{
    public class Hoadon
    {
        private int hdid;
        private int hdma;
        private string hdtenkh;
        private string hdsp;
        private int hdsl;
        private DateTime hdngay;
        private int hdgia;

        public int Hdid { get => hdid; set => hdid = value; }
        public int Hdma { get => hdma; set => hdma = value; }
        public string Hdtenkh { get => hdtenkh; set => hdtenkh = value; }
        public string Hdsp { get => hdsp; set => hdsp = value; }
        public int Hdsl { get => hdsl; set => hdsl = value; }
        public DateTime Hdngay { get => hdngay; set => hdngay = value; }
        public int Hdgia { get => hdgia; set => hdgia = value; }
        public Hoadon(DataRow row)
        {
            this.Hdid = (int)row["Hdid"];
            this.Hdma = (int)row["Hdma"];
            this.Hdtenkh = row["Hdtenkh"].ToString();
            this.Hdsp = row["Hdsp"].ToString();
            this.Hdsl = (int)row["Hdsl"];
            this.Hdngay = (DateTime)row["Hdngay"];
            this.Hdgia = (int)row["Hdgia"];
        }
    }
}
