using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Jaclyn_Noga_Portfolio.Models
{
    public class Jaclyn_Noga_PortfolioContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Jaclyn_Noga_PortfolioContext() : base("name=Jaclyn_Noga_PortfolioContext")
        {
        }

        public System.Data.Entity.DbSet<Jaclyn_Noga_Portfolio.Models.Projects> Projects { get; set; }
    }
}
