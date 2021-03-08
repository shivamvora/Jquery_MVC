using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationWithJQuery.Models;
using Newtonsoft.Json;

namespace WebApplicationWithJQuery.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetStudent()
        {
            Student std = new Student()
            {
                Id = 1,
                Name = "shivam vora",
                Emial = "shivampatel27102001@gmail.com"
            };
            var json = JsonConvert.SerializeObject(std);
            return Json(json,JsonRequestBehavior.AllowGet);
        }
    }
}