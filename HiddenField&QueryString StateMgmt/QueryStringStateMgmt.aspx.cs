using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMangementWebDemo
{
    public partial class webForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                TextBox1.Focus();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "Admin" && TextBox2.Text == "Admin")
            {
                Response.Redirect("Homepage.aspx?Name=" + TextBox1.Text + "&pwd=" + TextBox2.Text);
                Response.Write("Login Successful");
            }

            else if (TextBox1.Text == "Swati" && TextBox2.Text == "12345")
            {
                Response.Redirect("Homepage.aspx?Name=" + TextBox1.Text + "&pwd=" + TextBox2.Text);
                Response.Write("Login Successful");
            }

            else if (TextBox1.Text == "sweta" && TextBox2.Text == "1212")
            {
                Response.Redirect("Homepage.aspx?Name=" + TextBox1.Text + "&pwd=" + TextBox2.Text);
                Response.Write("Login Successful");
            }

            else
            {
                Label1.Text = "Username or Password is invalid";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
             
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (TextBox3.Text != "" && TextBox4.Text != "" && TextBox5.Text != "" && TextBox6.Text !="")
            {
                Response.Redirect("Homepage.aspx?Name=" + TextBox3.Text + "&email=" + TextBox4.Text+"&pwd="+TextBox5.Text+"&branch="+TextBox6.Text);
                Response.Write("Register Suc Successful");
            }

            else
            {
                Label2.Text = "some field is Blank";
            }
        }
    }
}