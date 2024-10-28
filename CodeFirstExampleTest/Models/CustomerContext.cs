using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
namespace CodeFirstExampleTest.Models
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(): base("DbConn")
        {
                
        }
        public DbSet<Customer> customers { get; set; }
    }
}