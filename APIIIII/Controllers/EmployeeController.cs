using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ServiceLayer;

namespace APIIIII.Controllers
{
    public class EmployeeController : ApiController
    {
        public IEmployeeService _EmployeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _EmployeeService = employeeService;
        }

        [HttpGet]
        [Route("api/GetEmployee")]
        public HttpResponseMessage GetEmployee()
        {
            var x = _EmployeeService.GetEmployeeDtos();
            return Request.CreateResponse(x);
        }
    }
}
