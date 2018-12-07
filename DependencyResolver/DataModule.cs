using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Repository;
using DataEntity.DataModelCode;
using Ninject.Modules;
using Ninject.Web.Common;
using ServiceLayer;

namespace DependencyResolver
{
   public class DataModule : NinjectModule
    {
        public override void Load()
        {
            BindRepositories();
        }

        private void BindRepositories()
        {
            Bind<IEmployeeRepository>().To<EmployeeRepository>().InRequestScope();
            Bind<IDbModel>().To<DbModel>().InRequestScope();
            Bind<IEmployeeService>().To<EmployeeService>().InRequestScope();
        }

    }
}
