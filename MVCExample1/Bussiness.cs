using MVCExample1.DataLayer;
using MVCExample1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCExample1
{
    public class Bussiness
    {
       
        public List<Employee> GetAllEmployeeDetails(int ID)
        {

            var db = new DataContext();
            
              var employee = db.Employees.Where(x => x.EmployeeId == ID).ToList();
            
            return employee;
        }

        public List<Address> GetAllAddressesDetails(int ID)
        {
            var db = new DataContext();

            var address = db.Addresses.Where(x => x.EmployeeId==ID).ToList();

            return address;
        }
    }
}