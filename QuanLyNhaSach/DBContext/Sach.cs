//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyNhaSach.DBContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sach()
        {
            this.ChiTietHoaDon = new HashSet<ChiTietHoaDon>();
        }
    
        public string maSach { get; set; }
        public string ISBN { get; set; }
        public Nullable<decimal> giaSach { get; set; }
        public int namXuatBan { get; set; }
        public int soLuong { get; set; }
        public string tenSach { get; set; }
        public string maNhaXuatBan { get; set; }
        public string maTacGia { get; set; }
        public string maTheLoai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDon { get; set; }
        public virtual NhaXuatBan NhaXuatBan { get; set; }
        public virtual TheLoai TheLoai { get; set; }
        public virtual TacGia TacGia { get; set; }
    }
}
