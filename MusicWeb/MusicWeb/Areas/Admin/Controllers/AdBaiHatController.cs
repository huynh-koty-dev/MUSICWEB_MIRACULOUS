using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicWeb.Areas.Admin.Controllers
{
    public class AdBaiHatController : Controller
    {
        // GET: Admin/AdBaiHat
        public ActionResult Index()
        {
            BaiHatDAO dao = new BaiHatDAO();
            var result = dao.ListOf();
            return View(result);
        }

    }
}