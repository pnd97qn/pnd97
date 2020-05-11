using HRMSystem.Areas.Admin.Models;
using Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRMSystem.Areas.Admin.Controllers
{
    public class ResetPasswordController : Controller
    {
        // GET: Admin/ResetPassword
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ResetPassword(ResetPasswordModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var result = dao.ResetPassword(model.PassWord, model.ConfirmPassword);
                if (result)
                {
                    
                    return RedirectToAction("Index", "Login");
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