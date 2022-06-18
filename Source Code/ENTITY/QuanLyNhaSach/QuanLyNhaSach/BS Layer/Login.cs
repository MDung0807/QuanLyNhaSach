using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyNhaSach.DB_Layer;

namespace QuanLyNhaSach.BS_Layer
{
    internal class Login
    {
        public bool Check_Login (string user, string pass, string quyen)
        {
            QLNhaSachEntities qlnsentity = new QLNhaSachEntities();
            var result = (from p in qlnsentity.TaiKhoans
                          where p.TenTK == user && p.MatKhau == pass && p.Quyen == quyen
                          select new
                          {
                              tentk = p.TenTK,
                              matkhau = p.MatKhau,
                              chucvu = p.Quyen,
                              FlagXoa = p.FlagXoa
                          });

            if (result.Count() > 0)
            {

                foreach (var item in result)
                    if (item.FlagXoa == true)
                    {
                        return false;
                    }
                return true;
            }


            return false;

        }
    }
}
