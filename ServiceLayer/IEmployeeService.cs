using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.DTOS;

namespace ServiceLayer
{
   public interface IEmployeeService
   {
       List<EmployeeDto> GetEmployeeDtos();
   }
}
