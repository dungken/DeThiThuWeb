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
    
    public partial class PhanLoaiSanPham
    {
        public PhanLoaiSanPham()
        {
            this.Sanphams = new HashSet<Sanpham>();
        }
    
        public int PhanLoaiSanPhamID { get; set; }
        public string TenPhanLoai { get; set; }
    
        public virtual ICollection<Sanpham> Sanphams { get; set; }
    }
}
