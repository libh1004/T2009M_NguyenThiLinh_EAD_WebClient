using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace T2009M_NguyenThiLinh_EAD_WebClient.Controllers
{
    public class EmployeeController : Controller
    {
        private WCFService.Service1Client serviceClient = new WCFService.Service1Client();
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            serviceClient.Save(employee);
            return View("Search");
        }
        public ActionResult SearchEmployee(string keyword)
        {
            var result = serviceClient.SearchEmployee(keyword);
            return View(result);
        }
    }
}