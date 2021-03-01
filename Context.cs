using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace CodeFirst
{
    public class Context: DbContext
    {
        public Context(): base("AdventureWorks2017")
        {
           
        }
        public DbSet<ADO.Zachot4.SalesOrderHeader> SalesOrderHeaders { get; set; }
    }
}
