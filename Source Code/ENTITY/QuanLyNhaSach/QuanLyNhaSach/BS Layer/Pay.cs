using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyNhaSach.DB_Layer;

namespace QuanLyNhaSach.BS_Layer
{
    internal class Pay
    {
        public DataTable Lay_TT_Pay()
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();

            var result_muon = from p in qlnsentity.Muons
                         where p.DaThanhToan == false
                         select p;

            var result_mua = from p in qlnsentity.Muas
                              where p.DaThanhToan == false
                              select p;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaCuon");
            dataTable.Columns.Add("MaKH");
            dataTable.Columns.Add("Gia");

            foreach (var item in result_muon)
            {
                dataTable.Rows.Add(item.MaCuon, item.MaKH, item.CuonSach.DauSach.GiaMuon);
            }    

            foreach (var item in result_mua)
            {
                dataTable.Rows.Add(item.MaCuon, item.MaKH, item.CuonSach.DauSach.GiaMua);
            }

            return dataTable;
        }

        public DataTable Tim_KH (string MaKH)
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();

            var result_muon = from p in qlnsentity.Muons
                              where p.DaThanhToan == false && p.MaKH == MaKH
                              select p;

            var result_mua = from p in qlnsentity.Muas
                             where p.DaThanhToan == false && p.MaKH == MaKH
                             select p;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaCuon");
            dataTable.Columns.Add("MaKH");
            dataTable.Columns.Add("Gia");
            dataTable.Columns.Add("MaSach");

            foreach (var item in result_muon)
            {
                dataTable.Rows.Add(item.MaCuon, item.MaKH, item.CuonSach.DauSach.GiaMuon, item.CuonSach.DauSach.MaSach);
            }

            foreach (var item in result_mua)
            {
                dataTable.Rows.Add(item.MaCuon, item.MaKH, item.CuonSach.DauSach.GiaMua, item.CuonSach.DauSach.MaSach);
            }

            return dataTable;
        }

        public (string, string, int, int) Pay_Bill(string MaKH)
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();

            var result_muon = from p in qlnsentity.Muons
                              where p.DaThanhToan == false && p.MaKH == MaKH
                              select new
                              {
                                  MaKH = p.MaKH,
                                  TenKH = p.KhachHang.TenKH,
                                  MaSach = p.CuonSach.DauSach.MaSach,
                                  TenSach = p.CuonSach.DauSach.TuaSach,
                                  DonGia = p.CuonSach.DauSach.GiaMuon,
                              };

            var result_mua = from p in qlnsentity.Muas
                             where p.DaThanhToan == false && p.MaKH == MaKH
                             select new
                             {
                                 MaKH = p.MaKH,
                                 TenKH = p.KhachHang.TenKH,
                                 MaSach = p.CuonSach.DauSach.MaSach,
                                 TenSach = p.CuonSach.DauSach.TuaSach,
                                 DonGia = p.CuonSach.DauSach.GiaMua,
                             };

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaKH");
            dataTable.Columns.Add("TenKH");
            dataTable.Columns.Add("MaSach");
            dataTable.Columns.Add("Tua");
            dataTable.Columns.Add("Gia");


            foreach (var item in result_muon)
            {
                dataTable.Rows.Add(item.MaKH, item.TenKH, item.MaSach, item.TenSach, item.DonGia);
            }

            foreach (var item in result_mua)
            {
                dataTable.Rows.Add(item.MaKH, item.TenKH, item.MaSach, item.TenSach, item.DonGia);
            }

            string TenKH = dataTable.Rows[0][1].ToString();
            string MaSach = dataTable.Rows[0][2].ToString();
            string TenSach = dataTable.Rows[0][3].ToString();
            int SoLuong = dataTable.Rows.Count;
            int ThanhTien = 0;
            for (int i =0; i< SoLuong; i++)
            {
                ThanhTien += Convert.ToInt32(dataTable.Rows[i][4].ToString());
            }
            return (TenKH, MaSach, SoLuong, ThanhTien);


        }

        public void DaThanhToan(string MaKH)
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();

            var result_muon = (from p in qlnsentity.Muons
                               where p.MaKH == MaKH && p.DaThanhToan == false
                               select p);

            var result_mua = (from p in qlnsentity.Muas
                              where p.MaKH == MaKH && p.DaThanhToan == false
                              select p);

            if (result_muon != null)
            {
                foreach (var item in result_mua)
                    item.DaThanhToan = true;
            }    
            if (result_mua != null)
            {
                foreach (var item in result_mua)
                    item.DaThanhToan = true;
            }    

            qlnsentity.SaveChanges();
        }
    }
}
