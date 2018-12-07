using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Common.DTOS;
using ServiceLayer;

namespace WebApi.Controllers
{
    public class ValuesController : ApiController
    {

        private IEmployeeService _employeeService;

        public ValuesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        [Route("api/GetEmployee")]
        public HttpResponseMessage GetEmployee()
        {
            List<EmployeeDto> employee = _employeeService.GetEmployeeDtos();
            return Request.CreateResponse(employee);
        }
        

        //// GET api/values
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/values/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //public void Delete(int id)
        //{
        //}
    }
}
