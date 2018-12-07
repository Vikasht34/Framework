using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClientLibrary;
using Common.DTOS;
using TestApplication.Models;
using System.Threading.Tasks;

namespace TestApplication.Controllers
{
    public class HomeController : Controller
    {

        private IApiConnection _apiConnection;

        public HomeController(IApiConnection apiConnection)
        {
            _apiConnection = apiConnection;
        }

        public async Task<ActionResult> Index()
        {
            EmployeeModel employeeModel = new EmployeeModel();
            employeeModel.GetEmployeeDtos = await _apiConnection.RequestGet<List<EmployeeDto>>("GetEmployee");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}