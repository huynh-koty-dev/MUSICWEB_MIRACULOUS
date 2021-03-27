using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public  class TintucDAO
    {
        MusicDBContext context;
        public TintucDAO()
        {
            context = new MusicDBContext();
        }
        public List<Tintuc> ListOf()
        {
            List<Tintuc> Listtt = new List<Tintuc>();
            Listtt = context.Tintucs.ToList();
            return Listtt;
        }
        public Tintuc Detail(int id)
        {
            var result = context.Tintucs.SingleOrDefault(x => x.IdTinTuc == id);
            return result;
        }
        public int AddNew(Tintuc obj)
        {
            var result = context.Tintucs.Add(obj);
            if (result != null)
            {
                context.SaveChanges();
                return result.IdTinTuc;
            }
            return -1;
        }
        public bool Update(Tintuc obj)
        {
            var sp = context.Tintucs.SingleOrDefault(x => x.IdTinTuc == obj.IdTinTuc);
            if (sp != null)
            {
                sp.TieuDeTinTuc = obj.TieuDeTinTuc;
                sp.NoiDung = obj.NoiDung;
                sp.ThoiGian = obj.ThoiGian;
                sp.IdTaiKhoan = obj.IdTaiKhoan;
               
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public void Delete(int id)
        {
            var sp = context.Tintucs.SingleOrDefault(x => x.IdTinTuc == id);
            if (sp != null)
            {
                context.Tintucs.Remove(sp);
                context.SaveChanges();
            }
        }
    }
}
