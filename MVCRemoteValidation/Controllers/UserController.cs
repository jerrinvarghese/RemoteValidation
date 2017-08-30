using MVCRemoteValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRemoteValidation.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create(User user)
        {
            return View();
        }
        public JsonResult IsValidUserName(string username)
        {
            var uname = "test123";
            bool res = username == uname ? false : true;
            return Json(res,JsonRequestBehavior.AllowGet);
        }

        public ActionResult CreateUserId()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateUserId(MVCRemoteValidationtbl remoteclass)
        {
            Step2017Entities1 entity = new Step2017Entities1();
            entity.MVCRemoteValidationtbls.Add(remoteclass);
            entity.SaveChanges();
            return View();
        }

        public JsonResult IsValidName(string UserName)
        {
            
            Step2017Entities1 entity = new Step2017Entities1();
            MVCRemoteValidationtbl user = entity.MVCRemoteValidationtbls.Where(c => c.UserName == UserName).FirstOrDefault();
            bool res = user != null ? false : true;
            return Json(res, JsonRequestBehavior.AllowGet);
        }

    }
}