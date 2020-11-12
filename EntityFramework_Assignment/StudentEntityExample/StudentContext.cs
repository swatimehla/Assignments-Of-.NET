﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication4.Models
{
    public class StudentContext :DbContext
    {
        public StudentContext() : base("StudentConnection")
        {

        }
        public DbSet<Student> StudentTable { get; set; }
    }
}