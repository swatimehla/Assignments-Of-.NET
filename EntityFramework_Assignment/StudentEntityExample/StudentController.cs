﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class StudentController : Controller
    {
        StudentContext obj = new StudentContext();
        public ViewResult Index()
        {
            return View(obj.StudentTable.ToList());
        }
        // GET: Student
        //public ActionResult Index()
        //{
        //    return View();
        //}
    }
}