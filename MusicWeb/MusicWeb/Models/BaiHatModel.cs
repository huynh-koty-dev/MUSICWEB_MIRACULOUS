using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicWeb.Models
{
    public class BaiHatModel
    {
        public int ID { set; get; }
        public string TenBaiHat { set; get; }
        public string AnhBaiHat { set; get; }
        public string LoiBaihat { set; get; }
        public DateTime NgayPhatHanh { set; get; }
        public bool Top100 { set; get; }
        public int LuotNghe { set; get; }
        public int LuotTai { set; get; }
        public int LuotThich { set; get; }
        public string LinkBaiHat { set; get; }
        public int IdNgheSi { set; get; }
        public int IdTheLoai { set; get; }
        public int IdAlbum { set; get; }

        public BaiHatModel(int idbaihat, string tenbaihat, string anh,string lyric,DateTime ngayphathanh,bool top,int luotnghe,int luottai,int luotthich,
            string link,int idnghesi, int idtheloai,int idalbum)
        {
            ID = idbaihat;
            TenBaiHat = tenbaihat;
            AnhBaiHat = anh;
            LoiBaihat = lyric;
            NgayPhatHanh = ngayphathanh;
            Top100 = top;
            LuotNghe = luotnghe;
            LuotTai = luottai;
            LuotThich = luotthich;
            LinkBaiHat = link;
            IdNgheSi = idnghesi;
            IdTheLoai = idtheloai;
            IdAlbum = idalbum;
        }
    }
}