using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Web;

namespace ContosoUniversity.DAL
{
    
    public class SchoolConfiguration : DbConfiguration
    {
        //All you have to do to enable connection resiliency is create a class in your assembly that derives from the DbConfiguration class, and in that class set the SQL Database execution strategy, which in EF is another term for retry policy.

        public SchoolConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
        }
    }
}