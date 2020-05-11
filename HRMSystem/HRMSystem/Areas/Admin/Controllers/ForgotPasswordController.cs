using HRMSystem.Areas.Admin.Models;
using Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRMSystem.Areas.Admin.Controllers
{
    public class ForgotPasswordController : Controller
    {
        // GET: Admin/ForgotPassword
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ForgotPassword(ForgotPasswordModel model)
        {
            if (ModelState.IsValid)
            {
                
                var dao = new UserDao();
                var result = dao.ForgotPassword(model.UserName);
                if (result)
                {

                    return RedirectToAction("Index", "ResetPassword");
                }
                else
                {
                    ModelState.AddModelError("", "Mời bạn nhập lại Tài khoản hoặc Email!");
                }
            }
            return View("Index");
           
        }
    }
}