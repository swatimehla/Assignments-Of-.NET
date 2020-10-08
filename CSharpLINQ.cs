using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace CsharpLINQ
{
    class CSharpLINQ
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 6, 7, 8, 12, 23, 24, 56, 77 };
            var brr = from i in arr where i > 20 orderby i ascending select i;
            foreach(var x in brr)
            {
                Console.WriteLine(x + "  ");
            }


            //List of Students
            IList<student> stu_info = new List<student>
            {
                new student(){sid=1,sname="Ram",age=20 },
                new student(){sid=2,sname="Raj",age=22 },
                new student(){sid=3,sname="Maya",age=21 },
                new student(){sid=4,sname="manju",age=20 }
            };


            //List of Employees
            IList<employee> emp_info = new List<employee>
            {
                new employee(){empid=1,ename="Ram",salary=20000,designation="HR"},
                new employee(){empid=2,ename="Mahi",salary=25000,designation="HR"},
                new employee(){empid=5,ename="Mahira",salary=30000,designation="SE"},
                new employee(){empid=6,ename="Sham",salary=28000,designation="SE"},
            };


            var employeename = emp_info.Where(s => s.salary > 26000).Select(s => s.ename); //LINQ query
            foreach(var x in employeename)
            {
                Console.WriteLine(x);
            }

            //query to find name of employee designation is SE and empid=2
            var employee_info = emp_info.Where(e => e.designation == "SE").Select(s => s).Where(e => e.empid == 2).Select(e => e.ename);
            foreach(var x in employee_info)
            {
                Console.WriteLine(x);
            }

            //query to join table employee and student on sid ==eid
            var inner_join = from s in stu_info
                            join e in emp_info
                             on s.sid equals e.empid
                             select new
                             {
                                 studentName = s.sname,
                                 empname = e.ename,
                                 id=s.sid
                             };
            foreach(var x in inner_join)
            {
                Console.WriteLine("Student_name :{0} ", x.studentName);
                Console.WriteLine("Employee_name :{0}", x.empname);
                Console.WriteLine("Id :{0}", x.id);
            }

            var employeegroupByBatch = from e in emp_info
                                       group e by e.designation into em
                                       orderby em.Key
                                       select new { em.Key, em };
            foreach(var empgroup in employeegroupByBatch)
            {
                Console.WriteLine("Designation ", empgroup.Key);
            }

            var emp = from e in emp_info
                      where (e.salary > 26000)
                      select new { ename = e.ename };
            emp.ToList().ForEach(e => Console.WriteLine(e.ename));
            Console.ReadKey();
        }
    }

    class employee
    {
        public int empid { get; set; }
        public string ename { get; set; }
        public int salary { get; set; }
        public string designation { get; set; }
    }

    class student
    {
        public int sid { get; set; }
        public string sname { get; set; }
        public int age { get; set; }
    }
}
