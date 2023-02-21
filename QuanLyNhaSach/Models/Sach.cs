using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Entity
{
    public class Sach
    {
        private int maSach { get; set; }
        private int ISBN { get; set; }
        private int giaSach { get; set; }
        private int namSanXuat { get; set; }
        private DateTime soLuong { get; set; }
        private string tenSach { get; set; }
        private int maNhaXuatBan { get; set; }
        private int maTacgia { get; set; }
        private int maTheLoai { get; set; }
    }
}
