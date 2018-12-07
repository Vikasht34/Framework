using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataEntity.DataModelCode
{
   public class DbModel : MSTestEntities, IDbModel 
    {
        public DbModel()
        {
            Database.SetInitializer<MSTestEntities>(null);
        }

        public DbContext GetDbContext()
        {
            return (DbContext) this;
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

        }
        
    }
}
