using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServiceLayer;

namespace WebApi.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeService _employeeService;

        public HomeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public ActionResult Index()
        {
          var x =  _employeeService.GetEmployeeDtos();

            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
