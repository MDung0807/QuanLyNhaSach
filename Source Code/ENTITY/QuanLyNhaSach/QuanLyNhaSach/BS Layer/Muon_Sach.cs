using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyNhaSach.DB_Layer;

namespace QuanLyNhaSach.BS_Layer
{
    internal class Muon_Sach
    {
        public DataTable Lay_TT()
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();

            var result = from p in qlnsentity.Muons
                         select new
                         {
                             MaKH = p.MaKH,
                             TenKH = p.KhachHang.TenKH,
                             MaCuon = p.MaCuon,
                             SoTien = p.CuonSach.DauSach.GiaMuon,
                             NgayMuon = p.NgayMuon,
                             NgayTra = p.NgayTra,
                             DangMuon = p.DangMuon,
                             DaThanhToan = p.DaThanhToan
                         };
            
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaKH");
            dataTable.Columns.Add("TenKH");
            dataTable.Columns.Add("MaCuon");
            dataTable.Columns.Add("SoTien");
            dataTable.Columns.Add("NgayMuon");
            dataTable.Columns.Add("NgayTra");
            dataTable.Columns.Add("DangMuon");
            dataTable.Columns.Add("DaThanhToan");

            foreach (var item in result)
            {   
                if (item.DangMuon == true)
                    dataTable.Rows.Add(item.MaKH, item.TenKH, item.MaCuon, item.SoTien, item.NgayMuon, item.NgayTra, item.DangMuon, item.DaThanhToan);
            }

            return dataTable;
        }

        public void KH_Muon_Sach (string MaKH, string MaCuon, DateTime NgMuon, ref string result)
        {
            if (check_KH_Is_FlagXoa(MaKH) == true)
            {
                result = "Khách hàng không tồn tại";
                return;

            }
            if (check_CuonSach_FlagXoa(MaCuon) == true)
            {
                result = "Cuốn sách không tồn tại";
                return;

            }
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();
          
            Muon muon = new Muon();
            muon.MaKH = MaKH;
            muon.MaCuon = MaCuon;
            muon.NgayMuon = NgMuon;
            muon.NgayTra = null;
            muon.DangMuon = true;
            muon.HanTra = NgMuon.AddMonths(1);
            muon.TienPhat = "0";
            muon.DaThanhToan = false;

            qlnsentity.Muons.Add(muon);
            qlnsentity.SaveChanges();

            result = "Đã thêm vảo giỏ hàng thành công";
            string option = "Muon";
            Set_Flag_Cuon_Sach(MaKH, MaCuon, option);
        }
        public void KH_Tra_Sach(string MaKH, string MaCuon)
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();

            var result = (from p in qlnsentity.Muons
                          where p.MaKH == MaKH && p.MaCuon == MaCuon
                          select p).SingleOrDefault();

            //result.TrangThai = true;
            result.DangMuon = false;
            result.NgayTra = DateTime.Now;
            qlnsentity.SaveChanges();

            string option = "Tra";
            Set_Flag_Cuon_Sach(MaKH, MaCuon, option);
        }

        void Set_Flag_Cuon_Sach (string MaKH, string MaCuon, string option)
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();
            
            var result = (from p in qlnsentity.Muons
                          where p.MaKH == MaKH && p.MaCuon == MaCuon
                          select p).SingleOrDefault();

            if (option == "Muon")
            { 
                result.CuonSach.Flag = false; 
            }
            else if (option == "Tra")
            {
                result.CuonSach.Flag = true;
            }

            qlnsentity.SaveChanges();
        }

        bool check_KH_Is_FlagXoa(string MaKH)
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();

            var result = (from p in qlnsentity.KhachHangs
                          where p.MaKH == MaKH
                          select p).SingleOrDefault();
            if (result.FlagXoa == true)
                return true;
            return false;
        }

        bool check_CuonSach_FlagXoa(string MaCuon)
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();

            var result = (from p in qlnsentity.CuonSaches
                          where p.MaCuon == MaCuon
                          select p).SingleOrDefault();
            if (result.Flag == false)
                return true;
            return false;
        }
    }
}
