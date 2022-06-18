using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaSach.DB_Layer;
using System.Data;

namespace QuanLyNhaSach.BS_Layer
{
    internal class Thong_Ke
    {
        public (int, int, int, DataTable) Thong_Ke_Tu_Viec_Mua_Va_Muon_Sach ()
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();

            var result_muon = from p in qlnsentity.Muons
                              where p.DaThanhToan == true
                              select p;

            var result_mua = from p in qlnsentity.Muas
                             where p.DaThanhToan == true
                             select p;

            int sum_muon = 0;
            int sum_mua = 0;
            int nop_phat = 0;
            foreach (var muon in result_muon)
            {
                sum_muon += Convert.ToInt32(muon.CuonSach.DauSach.GiaMuon);
            }    

            foreach (var mua in result_mua)
            {
                sum_mua += Convert.ToInt32(mua.CuonSach.DauSach.GiaMua);
            }

            foreach (var phat in result_muon)
            {
                nop_phat += Convert.ToInt32(phat.TienPhat);
            }

            var result_dau_sach = from p in qlnsentity.CuonSaches
                                  where p.Flag == true
                                  group p by p.DauSach into s
                                  select new
                                  {
                                      MaSach = s.Key.MaSach,
                                      TuaSach = s.Key.TuaSach,
                                      SL = s.Count()
                                  };

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("MaSach");
            dataTable.Columns.Add("TenSach");
            dataTable.Columns.Add("SL");

            foreach (var item in result_dau_sach)
            {
                dataTable.Rows.Add(item.MaSach, item.TuaSach, item.SL);
            }
            return (sum_muon, sum_mua, nop_phat, dataTable);
        }
    }
}
