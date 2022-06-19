using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using ADO_Version.DB_layer;

namespace ADO_Version.BS_layer
{
    class BLThongKe
    {
        DBMain db = null;
        public BLThongKe()
        {
            db = new DBMain();
        }
        public DataSet LayDuLieu()
        {
            return db.ExecuteQueryDataSet("select DS.MaSach, DS.TuaSach, count(DS.MaSach) as SoLuong from DauSach as DS, CuonSach as CS where DS.MaSach = CS.Masach and CS.FlagXoa='False' group by DS.MaSach, DS.TuaSach", CommandType.Text);
        }
    }
}
