using Practice_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice_2.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(TextBoxes form)
        {
            if (ModelState.IsValid)
            {
                if (form.Password_1 == form.Password_2)
                {
                    if(Convert.ToInt32(form.Age) >= 18 && Convert.ToInt32(form.Age) <= 65)
                    {
                        Session["login"] = form.Login;
                        Session["password"] = form.Password_1;
                        return View("Session");
                    }
                    else ViewBag.Wrong = "Вы ввели некорректный возраст";
                }
                else ViewBag.Wrong = "Пароли не совпадают";
            }
            return View();
        }
    }
}