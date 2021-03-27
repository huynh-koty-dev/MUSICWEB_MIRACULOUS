using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class TaiKhoanDAO
    {
        MusicDBContext context;
        public TaiKhoanDAO()
        {
            context = new MusicDBContext();

        }
        public bool Login(string username, string password)
        {
            try
            {
                var listAcc = context.TaiKhoans.ToList();
                var acc = listAcc.SingleOrDefault(x => x.TaiKhoan1 == username && x.MatKhau == password);
                if(acc != null)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
