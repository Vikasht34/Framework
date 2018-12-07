using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Common.DTOS;

namespace TestApplication.Models
{
    public class EmployeeModel
    {
        public List<EmployeeDto> GetEmployeeDtos { get; set; }
    }
}