using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework_Version.DB_Layer;
using System.Data;

namespace EntityFramework_Version.BS_Layer
{
    internal class Thong_Ke
    {
       
        public DataTable Thong_Ke_SL_Sach_Tren_Moi_Dau_Sach ()
        {


            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();

            var result_dau_sach = from p in qlnsentity.CuonSaches
                                  where p.FlagXoa == false
                                  group p by p.DauSach into s
                                  select new
                                  {
                                      MaSach = s.Key.MaSach,
                                      TuaSach = s.Key.TuaSach,
                                      SL = s.Count()
                                  };

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("MaSach");
            dataTable.Columns.Add("TuaSach");
            dataTable.Columns.Add("SoLuong");

            foreach (var item in result_dau_sach)
            {
                dataTable.Rows.Add(item.MaSach, item.TuaSach, item.SL);
            }

            return dataTable;
        }

        public (DataTable, int, int, int) TK_Hoat_Dong_Mua_Ban(string Lua_Chon_Thong_Ke, DateTime Thoi_Gian_Bat_Dau)
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();
            DataTable dataTable = new DataTable();
            int tong_tien_ban_duoc = 0;
            int tong_tien_cho_muon = 0;
            int tong_tien_phat = 0;


            if (Lua_Chon_Thong_Ke == "Moth")
            {
                var result_muon = from p in from m in qlnsentity.Muons
                                            where m.DaThanhToan == true && m.NgayMuon > Thoi_Gian_Bat_Dau
                                            from i in qlnsentity.Muas
                                            where i.DaThanhToan == true && i.NgayMua > Thoi_Gian_Bat_Dau
                                            select new
                                            {
                                                NgayMuon = m.NgayMuon,
                                                GiaMuon = m.CuonSach.DauSach.GiaMuon,
                                                TienPhat = m.TienPhat,
                                                GiaMua = i.CuonSach.DauSach.GiaMua
                                            }
                                  group p by p.NgayMuon.Value.Month into a
                                  select new
                                  {
                                      m = a.Key,
                                      g = a.Sum(x => x.GiaMuon),
                                      z = a.Sum(x => x.TienPhat),
                                      t = a.Sum(x => x.GiaMua)
                                  };
                dataTable.Columns.Add(Lua_Chon_Thong_Ke);
                dataTable.Columns.Add("SoTienChoMuon");
                dataTable.Columns.Add("SOTienPhat");
                dataTable.Columns.Add("SOTIenBan");


                foreach (var muon in result_muon)
                {
                    dataTable.Rows.Add(muon.m, muon.g, muon.z, muon.t);
                }

                int r = dataTable.Rows.Count;
               
                for (int i = 0; i < r; i++)
                {
                    tong_tien_ban_duoc += Convert.ToInt32(dataTable.Rows[i][3]);
                    tong_tien_cho_muon += Convert.ToInt32(dataTable.Rows[i][1]);
                    tong_tien_phat += Convert.ToInt32(dataTable.Rows[i][2]);
                }

            }
            else if (Lua_Chon_Thong_Ke == "Year")
            {
                var result_muon = from p in from m in qlnsentity.Muons
                                            where m.DaThanhToan == true && m.NgayMuon > Thoi_Gian_Bat_Dau
                                            from i in qlnsentity.Muas
                                            where i.DaThanhToan == true && i.NgayMua > Thoi_Gian_Bat_Dau
                                            select new
                                            {
                                                NgayMuon = m.NgayMuon,
                                                GiaMuon = m.CuonSach.DauSach.GiaMuon,
                                                TienPhat = m.TienPhat,
                                                GiaMua = i.CuonSach.DauSach.GiaMua
                                            }
                                  group p by p.NgayMuon.Value.Year into a
                                  select new
                                  {
                                      m = a.Key,
                                      g = a.Sum(x => x.GiaMuon),
                                      z = a.Sum(x => x.TienPhat),
                                      t = a.Sum(x => x.GiaMua)
                                  };
                dataTable.Columns.Add(Lua_Chon_Thong_Ke);
                dataTable.Columns.Add("SoTienChoMuon");
                dataTable.Columns.Add("SOTienPhat");
                dataTable.Columns.Add("SOTIenBan");


                foreach (var muon in result_muon)
                {
                    dataTable.Rows.Add(muon.m, muon.g, muon.z, muon.t);
                }

                int r = dataTable.Rows.Count;

                for (int i = 0; i < r; i++)
                {
                    tong_tien_ban_duoc += Convert.ToInt32(dataTable.Rows[i][3]);
                    tong_tien_cho_muon += Convert.ToInt32(dataTable.Rows[i][1]);
                    tong_tien_phat += Convert.ToInt32(dataTable.Rows[i][2]);
                }

            }



            return (dataTable, tong_tien_cho_muon, tong_tien_phat, tong_tien_ban_duoc);

        }

    }
}
