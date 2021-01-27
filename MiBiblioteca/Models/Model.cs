using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MiBiblioteca.Models
{
    public class Model
    {
    }
   public class MyDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}