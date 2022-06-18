using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyNhaSach.DB_Layer;

namespace QuanLyNhaSach.BS_Layer
{
    internal class Find_Book
    {
        public DataTable Lay_TT_Sach ()
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();
            var result = from p in qlnsentity.CuonSaches
                         select new
                         {
                             MaSach = p.Masach,
                             MaCuon = p.MaCuon,
                             Tua = p.DauSach.TuaSach,
                             TenNXB = p.DauSach.NXB.TenNXB,
                             ViTri = p.ViTri,
                             Flag = p.Flag
                         };
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaSach");
            dataTable.Columns.Add("MaCuon");
            dataTable.Columns.Add("TuaSach");
            dataTable.Columns.Add("TenNXB");
            dataTable.Columns.Add("ViTri");
            foreach (var p in result)
            {
                if (p.Flag == true)
                    dataTable.Rows.Add(p.MaSach, p.MaCuon, p.Tua, p.TenNXB, p.ViTri);
            }    
            return dataTable;
        }

        public DataTable Tim_Sach(string TenSach)
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();

            //TenSach = "%" + TenSach + "%";

            var result = from p in qlnsentity.CuonSaches
                         where p.DauSach.TuaSach == TenSach
                         select new
                         {
                             MaSach = p.Masach,
                             MaCuon = p.MaCuon,
                             Tua = p.DauSach.TuaSach,
                             TenNXB = p.DauSach.NXB.TenNXB,
                             ViTri = p.ViTri,
                             Flag = p.Flag
                         };
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaSach");
            dataTable.Columns.Add("MaCuon");
            dataTable.Columns.Add("TuaSach");
            dataTable.Columns.Add("TenNXB");
            dataTable.Columns.Add("ViTri");
            foreach (var p in result)
            {
                if (p.Flag == true)
                    dataTable.Rows.Add(p.MaSach, p.MaCuon, p.Tua, p.TenNXB, p.ViTri);
            }
            return dataTable;
        }
    }
}
