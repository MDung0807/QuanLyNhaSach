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
