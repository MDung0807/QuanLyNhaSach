//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyNhaSach.DB_Layer
{
    using System;
    using System.Collections.Generic;
    
    public partial class NhanVien
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string CongViec { get; set; }
        public string Luong { get; set; }
        public string DiaChi { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public Nullable<bool> GioiTinh { get; set; }
        public string soDT { get; set; }
        public bool FlagXoa { get; set; }
    
        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}