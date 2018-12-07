using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess.Repository;
using ServiceLayer;
using Unity;


namespace WebApi.App_Start
{
    public static class UnityContainer
    {
        public static void ConfigureIocUnityContainer()
        {
            IUnityContainer container = new Unity.UnityContainer();

            RegisterService(container);

            DependencyResolver.SetResolver(new UnityResolver(container));

        }

        private static void RegisterService(IUnityContainer container)
        {
            container.RegisterType<IEmployeeService, EmployeeService>();
            container.RegisterType<IEmployeeRepository, EmployeeRepository>();
        }
    }
}