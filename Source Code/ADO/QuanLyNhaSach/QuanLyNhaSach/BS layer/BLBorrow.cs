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
    class BLBorrow
    {
        DBMain db = null;
        public BLBorrow()
        {
            db = new DBMain();
        }
        public DataSet LayDuLieu()
        {
            return db.ExecuteQueryDataSet("SELECT * FROM Muon", CommandType.Text);
        }
        public DataSet LayMaKhachHang()
        {
            return db.ExecuteQueryDataSet("Select MaKH From KhachHang where FlagXoa='False'", CommandType.Text);
        }
        public DataSet LayMaCuon()
        {
            return db.ExecuteQueryDataSet("Select MaCuon From CuonSach where FlagXoa='False'", CommandType.Text);
        }
        public bool MuonSach(string MaCuon, string MaKhachHang, string NgayMuon, string HanTra, string DangMuon, ref string err)
        {
            string sqlString = "Insert Into Muon Values('" +
                MaCuon + "','" +
                MaKhachHang + "','" +
                NgayMuon + "',NULL,'" +
                HanTra + "','0','" +
                DangMuon + "', 'False')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatTraSach(string MaCuon, string MaKhachHang, string NgayTra, string TienPhat, string DangMuon, ref string err)
        {
            string sqlString = "Update Muon Set NgayTra='" +
                NgayTra + "',TienPhat='" + 
                TienPhat + "',DangMuon='" +
                DangMuon +
                "', DaThanhToan='True' Where MaCuon='" +
                MaCuon + "' and MaKH='" +
                MaKhachHang + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatMuonSach(string MaCuon, string MaKhachHang, string NgayMuon, string HanTra, string DangMuon, ref string err)
        {
            string sqlString = "Update Muon Set NgayMuon='" +
                NgayMuon + "',NgayTra=NULL,HanTra='" +
                HanTra + "',TienPhat=0,DangMuon='" +
                DangMuon +
                "', DaThanhToan='False' Where MaCuon='" +
                MaCuon + "' and MaKH='" +
                MaKhachHang + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatCuonSach(string MaCuon, string flag, ref string err)
        {
            string sqlString = "Update CuonSach Set FlagXoa='" +
                flag +
                "'Where MaCuon='" +
                MaCuon + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
