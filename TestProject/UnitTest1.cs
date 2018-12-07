using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DataAccess.Repository;
using DataEntity;
using DataEntity.DataModelCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ServiceLayer;


namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UnitTest1_Test1()
        {
            IEmployeeRepository emeEmployeeRepository = GetEmployeeRepository();

            IEnumerable<Employee> employees = emeEmployeeRepository.GetEmployees();

            Assert.AreEqual(1,employees.ToList().Count);

        }
        [TestMethod]
        public void SerVice_Test()
        {
            IEmployeeService employeeService = GetEmployeeService();

            var employee = employeeService.GetEmployeeDtos();

            Assert.AreEqual(1, employee.Count);

        }

        private IEmployeeService GetEmployeeService()
        {
            Mock<IEmployeeRepository> mock = new Mock<IEmployeeRepository>();
            mock.Setup(x => x.GetEmployees()).Returns(GetListOfEmployee());
            IEmployeeService employeeService = new EmployeeService(mock.Object);
            return employeeService;
        }

       
 
        private IEmployeeRepository GetEmployeeRepository()
        {
            Mock<DbSet<Employee>> mockDbSetEmployee = MockFactory.CreateDbSetMock(GetListOfEmployee());
            Mock<DbModel> dbMock = new Mock<DbModel>();
            dbMock.Setup(x => x.Employees).Returns(mockDbSetEmployee.Object);
            IEmployeeRepository employeeRepository = new EmployeeRepository(dbMock.Object);
            return employeeRepository;
        }

        private IEnumerable<Employee> GetListOfEmployee()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Rohan"
                }
            };
        }
    }
}
