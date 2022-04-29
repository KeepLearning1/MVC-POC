using MVCExample1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCExample1.DataLayer
{
    public class DataContext : DbContext
    {
        public DataContext() :base("name=con")
        {

        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Address> Addresses { get; set; }
    }
}