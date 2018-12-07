using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClientLibrary;
using Common.DTOS;
using System.Threading.Tasks;

namespace ClientTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly IApiConnection _apiConnection;

        public HomeController(IApiConnection apiConnection)
        {
            _apiConnection = apiConnection;
        }
        public async Task<ActionResult> Index()
        {
            var x = await _apiConnection.RequestGet<List<EmployeeDto>>("GetEmployee");
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