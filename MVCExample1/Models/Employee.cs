using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCExample1.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { set; get; }

        public string EmployeeName { set; get; }

        public string EmployeeRole { set; get; }

        public string EmployeeSalary { set; get; }
    }

    
}