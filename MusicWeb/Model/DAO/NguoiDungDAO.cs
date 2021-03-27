using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class NguoiDungDAO
    {
        MusicDBContext context;
        public NguoiDungDAO()
        {
            context = new MusicDBContext();
        }
        public List<NguoiDung> ListOf()
        {
            List<NguoiDung> ListND = new List<NguoiDung>();
            ListND = context.NguoiDungs.ToList();
            return ListND;
        }
        public NguoiDung Detail(int id)
        {
            var result = context.NguoiDungs.SingleOrDefault(x => x.IdNguoiDung == id);
            return result;
        }
        public int AddNew(NguoiDung obj)
        {
            var result = context.NguoiDungs.Add(obj);
            if (result != null)
            {
                context.SaveChanges();
                return result.IdNguoiDung;
            }
            return -1;
        }
        public bool Update(NguoiDung obj)
        {
            var sp = context.NguoiDungs.SingleOrDefault(x => x.IdNguoiDung == obj.IdNguoiDung);
            if (sp != null)
            {
                sp.TaiKhoan = obj.TaiKhoan;
                sp.MatKhau = obj.MatKhau;
                sp.TenNguoiDung = obj.TenNguoiDung;
                sp.AnhDaiDien = obj.AnhDaiDien;
                sp.DiaChi = obj.DiaChi;
                sp.Email = obj.Email;
               
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public void Delete(int id)
        {
            var sp = context.NguoiDungs.SingleOrDefault(x => x.IdNguoiDung == id);
            if (sp != null)
            {
                context.NguoiDungs.Remove(sp);
                context.SaveChanges();
            }
        }
    }
}
