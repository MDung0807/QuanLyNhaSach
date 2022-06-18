using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using QuanLyNhaSach.DB_layer;

namespace QuanLyNhaSach.BS_layer
{
    class BLBuyPay
    {
        DBMain db = null;
        public BLBuyPay()
        {
            db = new DBMain();
        }
        public DataSet LayDuLieu()
        {
            return db.ExecuteQueryDataSet("select MaKH, NgayMua, Count(MaCuon) as SoLuong, Sum(cast(GiaMua as int)) as ThanhTien from (Select M.MaCuon, DS.TuaSach, M.MaKH, KH.TenKH, DS.GiaMua, M.NgayMua From CuonSach as CS, DauSach as DS, KhachHang as KH, Mua as M Where CS.MaCuon = M.MaCuon and KH.MaKH = M.MaKH and CS.Masach = DS.MaSach and M.DaThanhToan = 'True') as Q group by MaKH, NgayMua order by MaKH", CommandType.Text);
        }
        public DataSet LayMaCuon()
        {
            return db.ExecuteQueryDataSet("Select MaCuon From CuonSach Where Flag='False'", CommandType.Text);
        }
        public DataSet LayMaKhachHang()
        {
            return db.ExecuteQueryDataSet("Select MaKH From KhachHang", CommandType.Text);
        }
        public DataSet TimKiemThanhToan(string MaKhachHang, string NgayMua)
        {
            return db.ExecuteQueryDataSet("select * from (select MaKH, NgayMua, Count(MaCuon) as SoLuong, Sum(cast(GiaMua as int)) as ThanhTien from (Select M.MaCuon, DS.TuaSach, M.MaKH, KH.TenKH, DS.GiaMua, M.NgayMua From CuonSach as CS, DauSach as DS, KhachHang as KH, Mua as M Where CS.MaCuon = M.MaCuon and KH.MaKH = M.MaKH and CS.Masach = DS.MaSach and M.DaThanhToan = 'True') as Q group by MaKH, NgayMua) as P where MaKH LIKE '%" + MaKhachHang + "%' and NgayMua LIKE '%" + NgayMua + "%'", CommandType.Text);
        }
    }
}
