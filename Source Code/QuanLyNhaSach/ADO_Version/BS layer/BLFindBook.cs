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
    class BLFindBook
    {
        DBMain db = null;
        public BLFindBook()
        {
            db = new DBMain();
        }
        public DataSet TimKiemSach(string TenSach)
        {
            return db.ExecuteQueryDataSet("SELECT * FROM DauSach Where TuaSach LIKE N'%" + TenSach + "%'", CommandType.Text);
        }
    }
}
