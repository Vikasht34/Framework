using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntity.DataModelCode
{
    public interface IDbModel : IDisposable
    {
        /// <summary>
        /// Returns the data model as a DbContext object
        /// </summary>
        /// <returns></returns>
        DbContext GetDbContext();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        int SaveChanges();

        DbSet<Employee> Employees { get; set; }

    }
}
