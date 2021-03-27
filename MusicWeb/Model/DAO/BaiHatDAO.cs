using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
   public class BaiHatDAO
    {
        MusicDBContext context;
        public BaiHatDAO()
        {
            context = new MusicDBContext();
        }
        public List<BaiHat> PhanTrang(int baihatid, ref int total, int pageIndex =1,int pageSize = 2)
        {
            total = context.BaiHats.Where(x => x.IdBaiHat == baihatid).Count();
            var model =  context.BaiHats.Where(x => x.IdBaiHat == baihatid).Skip((pageSize - 1) * pageIndex).Take(pageSize).ToList();
            return model;
        }
        public List<BaiHat> ListOf()
        {
            List<BaiHat> ListSP = new List<BaiHat>();
            ListSP = context.BaiHats.ToList();
            return ListSP;
        }
        public BaiHat Detail(int id)
        {
            var result = context.BaiHats.SingleOrDefault(x => x.IdBaiHat == id);
            return result;
        }
        public int AddNew(BaiHat obj)
        {
            var result = context.BaiHats.Add(obj);
            if (result != null)
            {
                context.SaveChanges();
                return result.IdBaiHat;
            }
            return -1;
        }
        public bool Update(BaiHat obj)
        {
            var sp = context.BaiHats.SingleOrDefault(x => x.IdBaiHat == obj.IdBaiHat);
            if (sp != null)
            {
                sp.TenBaiHat = obj.TenBaiHat;
                sp.AnhBaiHat = obj.AnhBaiHat;
                sp.LoiBaihat = obj.LoiBaihat;
                sp.NgayPhatHanh = obj.NgayPhatHanh;
                sp.Top100 = obj.Top100;
                sp.LuotNghe = obj.LuotNghe;
                sp.LuotTai = obj.LuotTai;
                sp.LuotThich = obj.LuotThich;
                sp.LinkBaiHat = obj.LinkBaiHat;
                sp.IdNgheSi = obj.IdNgheSi;
                sp.IdTheLoai = obj.IdTheLoai;
                sp.IdAlbum = obj.IdAlbum;

                context.SaveChanges();
                return true;
            }
            return false;
        }
        public void Delete(int id)
        {
            var sp = context.BaiHats.SingleOrDefault(x => x.IdBaiHat == id);
            if (sp != null)
            {
                context.BaiHats.Remove(sp);
                context.SaveChanges();
            }
        }
    }
}
