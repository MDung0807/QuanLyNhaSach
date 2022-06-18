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
    class BLBorrowPay
    {
        DBMain db = null;
        public BLBorrowPay()
        {
            db = new DBMain();
        }
        public DataSet LayDuLieu()
        {
            return db.ExecuteQueryDataSet("select M.MaCuon, M.MaKH, M.NgayMuon, M.HanTra, DS.GiaMuon from Muon as M, DauSach as DS, CuonSach as CS where M.MaCuon = CS.MaCuon and CS.Masach = DS.MaSach", CommandType.Text);
        }
        public DataSet LayMaCuon()
        {
            return db.ExecuteQueryDataSet("Select MaCuon From CuonSach Where FlagXoa='False'", CommandType.Text);
        }
        public DataSet LayMaKhachHang()
        {
            return db.ExecuteQueryDataSet("Select MaKH From KhachHang Where FlagXoa='False'", CommandType.Text);
        }
        public DataSet TimKiemThanhToan(string MaCuon, string MaKhachHang, string NgayMuon)
        {
            return db.ExecuteQueryDataSet("select * from (select M.MaCuon, M.MaKH, M.NgayMuon, M.HanTra, DS.GiaMuon from Muon as M, DauSach as DS, CuonSach as CS where M.MaCuon = CS.MaCuon and CS.Masach = DS.MaSach) as B where MaCuon LIKE '%" + MaCuon + "%' and MaKH LIKE '%" + MaKhachHang + "%' and NgayMuon LIKE '%" + NgayMuon + "%'", CommandType.Text);
        }
    }
}
