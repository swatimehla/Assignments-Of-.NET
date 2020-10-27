using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class CookieCollection_prac : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button1_Click(object sender, EventArgs e)
        {
            //Create cookies
            if (checkbox1.Checked)
            {
                Response.Cookies["category"]["Jeans"] = "You have selected Jeans with trigger cookies";
            }
            if (checkbox2.Checked)
            {
                Response.Cookies["category"]["T-shirt"] = "You have selected T-shirt with trigger cookies\n";
            }
            if (checkbox3.Checked)
            {
                Response.Cookies["category"]["Shirt"] = "You have selected Shirt with trigger cookies";
            }
            if (checkbox4.Checked)
            {
                Response.Cookies["category"]["Kurta"] = "You have selected Kurta with trigger cookies";
            }
            if (checkbox5.Checked)
            {
                Response.Cookies["category"]["Top"] = "You have selected Top with trigger cookies\n";
            }

            //fetching cookies
            if (Request.Cookies["category"].Values.ToString() != null)
            {
                if (Request.Cookies["category"]["Jeans"] != null)
                {
                    label2.Text = label2.Text + Response.Cookies["category"]["Jeans"] + "  " + " ";
                }
                if (Request.Cookies["category"]["T-shirt"] != null)
                {
                    label2.Text = label2.Text + Response.Cookies["category"]["T-shirt"] + "  " + " ";
                }
                if (Request.Cookies["category"]["Shirt"] != null)
                {
                    label2.Text = label2.Text + Response.Cookies["category"]["Shirt"] + "  " + " ";
                }
                if (Request.Cookies["category"]["Kurta"] != null)
                {
                    label2.Text = label2.Text + Response.Cookies["category"]["Kurta"] + "  " + " ";
                }
                if (Request.Cookies["category"]["Top"] != null)
                {
                    label2.Text = label2.Text + Response.Cookies["category"]["Top"] + "\n " + " ";
                }
            }
            else
            {
                label2.Text = "select any choice";
            }
        }
    }
}