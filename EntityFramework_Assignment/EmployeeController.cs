using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeEntityMVCApplication.Models;

namespace EmployeeEntityMVCApplication.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeContext emp = new EmployeeContext();
        // GET: Employee
        public ViewResult Index()
        {
            return View(emp.EmployeeTable.ToList());
        }

        //public ActionResult Index()
        //{
        //    return View();
        //}
    }
}