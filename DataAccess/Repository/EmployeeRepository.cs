using System.Collections.Generic;
using System.Linq;
using DataEntity;
using DataEntity.DataModelCode;

namespace DataAccess.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IDbModel _dbModel;

        public EmployeeRepository(IDbModel dbModel)
        {
            _dbModel = dbModel;
        }
        public IEnumerable<Employee> GetEmployees()
        {
            return _dbModel.Employees.ToList();
        }
    }
}
