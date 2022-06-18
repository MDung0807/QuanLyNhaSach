﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using QuanLyNhaSach.DB_layer;

namespace QuanLyNhaSach.BS_layer
{
    class BLBill
    {
        DBMain db = null;
        public BLBill()
        {
            db = new DBMain();
        }
        public DataSet LayDuLieu()
        {
            return db.ExecuteQueryDataSet("select MaKH, NgayMua, Count(MaCuon) as SoLuong, Sum(cast(GiaMua as int)) as ThanhTien from (Select M.MaCuon, DS.TuaSach, M.MaKH, KH.TenKH, DS.GiaMua, M.NgayMua From CuonSach as CS, DauSach as DS, KhachHang as KH, Mua as M Where CS.MaCuon = M.MaCuon and KH.MaKH = M.MaKH and CS.Masach = DS.MaSach and M.DaThanhToan = 'True') as Q group by MaKH, NgayMua order by MaKH", CommandType.Text);
        }
    }
}