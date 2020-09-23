using MyHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyHR.Library.ActionFilter;

namespace MyHR.Controllers
{
    //[Authorize]
    public class EmployeeController : Controller
    {
        // GET: Employee
        [ActionName("Main")]
        [ActionLogFilter]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [ActionLogFilter]
        public ActionResult Edit()
        {
            var employee = new Employee();

            employee.firstName = "Hareesh";
            employee.lastName = "Akula";
            employee.title = "Jr Developer";
            employee.DOB = new DateTime(1994, 01, 23);
            employee.salary = "300000";

            return View(employee);
        }

        [HttpPost]
        [ActionLogFilter]
        public ActionResult Edit(Employee model)
        {
            //Do something such as Employee model into a database
            return View(model);
        }
    }
}