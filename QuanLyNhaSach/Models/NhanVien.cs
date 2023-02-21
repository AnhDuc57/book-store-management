using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Entity
{
    public class NhanVien
    {
        private int maNhanVien { get; set; }
        private string chucVu { get; set; }
        private string diaChi { get; set; }
        private Boolean gioiTinh { get; set; }
        private DateTime ngaySinh { get; set; }
        private int soDienThoai { get; set; }
        private string tenNhanVien { get; set; }
        private Boolean trangThaiLamViec { get; set; }
    }
}
