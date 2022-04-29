using MVCExample1.DataLayer;
using MVCExample1.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExample1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        [HttpGet]
        public ActionResult Details(int Id)
        {
            Bussiness bussiness = new Bussiness();
            dynamic mymodel = new ExpandoObject();
            mymodel.Employee = bussiness.GetAllEmployeeDetails(Id);
            mymodel.Address = bussiness.GetAllAddressesDetails(Id);

            return View(mymodel);

        }
    }
}