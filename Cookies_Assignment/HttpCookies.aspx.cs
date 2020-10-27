using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class CookiesDOTNET : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //create cookies 
            HttpCookie sname = new HttpCookie("Student Name");
            HttpCookie lname = new HttpCookie("Last Name");
            HttpCookie eid = new HttpCookie("Emp_id");
            HttpCookie tech = new HttpCookie("Technology");
            HttpCookie batch= new HttpCookie("Batch");

            //assign values to the cookies
            sname.Value = "Swati";
            lname.Value = "Mehla";
            eid.Value = "5";
            tech.Value = "DotNet";
            batch.Value = "3";

            //Add the cookies 
            Response.Cookies.Add(sname);
            Response.Cookies.Add(lname);
            Response.Cookies.Add(eid);
            Response.Cookies.Add(tech);
            Response.Cookies.Add(batch);

            //Fetching values of Cookies

            Studentname.Text =sname.Name+" : "+ sname.Value;
            LastName.Text =lname.Name+" : "+ lname.Value;
            EmployeeId.Text =eid.Name+" : "+ eid.Value;
            Technology.Text =tech.Name+" : "+ tech.Value;
            Batch.Text =batch.Name+" : "+ batch.Value;

        }
    }
}