using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace WebApplication4.Models
{
    public class Student
    {
        
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Branch { get; set; }

    }
}