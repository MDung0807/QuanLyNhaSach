﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyNhaSach.DB_Layer;

namespace QuanLyNhaSach.BS_Layer
{
    internal class Find_Pass
    {
        public DataTable Tim_MK (string MaNV, string TenNV, string SDT)
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();

            var result = from p in qlnsentity.TaiKhoans
                         where p.NhanVien.TenNV == TenNV && p.NhanVien.TenNV == TenNV && p.NhanVien.soDT == SDT
                         select new
                         {
                             MaNV = p.MaNV,
                             TenNV = p.NhanVien.TenNV,
                             tk = p.TenTK,
                             pass = p.MatKhau,
                             FlagXoa = p.FlagXoa
                         };

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaNV");
            dataTable.Columns.Add("TenNV");
            dataTable.Columns.Add("tk");
            dataTable.Columns.Add("pass");

            foreach (var item in result)
            {
                if (item.FlagXoa == false)
                    dataTable.Rows.Add(item.MaNV, item.TenNV, item.tk, item.pass);
            }    

            return dataTable;
        }
    }
}