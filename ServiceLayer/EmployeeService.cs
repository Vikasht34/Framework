using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.DTOS;
using DataAccess.Repository;

namespace ServiceLayer
{

    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public List<EmployeeDto> GetEmployeeDtos()
        {
            var x = _employeeRepository.GetEmployees().ToList();
            List<EmployeeDto> outDtos = new List<EmployeeDto>();
            foreach (var y in x)
            {
                outDtos.Add(new EmployeeDto
                {
                    Id = y.Id,
                    Name = y.Name
                });
            }
            return outDtos;
        }
    }
}
