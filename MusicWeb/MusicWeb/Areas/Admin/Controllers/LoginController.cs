using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.DAO;
using MusicWeb.Areas.Admin.Data;
namespace MusicWeb.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Login login)
        {
            TaiKhoanDAO dao = new TaiKhoanDAO();
            if(login != null)
                if (dao.Login(login.Username, login.Password))
                {

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "username or password false");
                }
            return View();
        }
    }
}