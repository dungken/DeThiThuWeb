//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dethithu.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MauSac
    {
        public MauSac()
        {
            this.ChiTietSanPhamMua = new HashSet<ChiTietSanPhamMua>();
            this.Sanpham = new HashSet<Sanpham>();
        }
    
        public int MauSacID { get; set; }
        public string TenMauSac { get; set; }
    
        public virtual ICollection<ChiTietSanPhamMua> ChiTietSanPhamMua { get; set; }
        public virtual ICollection<Sanpham> Sanpham { get; set; }
    }
}
