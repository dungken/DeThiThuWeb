//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietDonHang
    {
        public ChiTietDonHang()
        {
            this.ChiTietSanPhamMuas = new HashSet<ChiTietSanPhamMua>();
        }
    
        public int ChiTietDonHangID { get; set; }
        public Nullable<int> DonHangID { get; set; }
        public Nullable<int> SanphamID { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
    
        public virtual DonHang DonHang { get; set; }
        public virtual Sanpham Sanpham { get; set; }
        public virtual ICollection<ChiTietSanPhamMua> ChiTietSanPhamMuas { get; set; }
    }
}
