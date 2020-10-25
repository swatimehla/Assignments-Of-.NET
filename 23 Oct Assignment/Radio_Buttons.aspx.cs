using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Radio_Buttons : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Label3.Text = "This is Green Color";
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
                Label1.Text = "This is Red color";
        }


        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Label2.Text = "This is Blue Color";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "";
            Label2.Text = "";
            Label3.Text = "";
            if(RadioButton1.Checked)
            {
                Label1.Text = "This is Red color Button";
            }
            else if(RadioButton2.Checked)
            {
                Label2.Text = "This is Blue Color";
            }
            else
            {
                Label3.Text = "This is Green color";
            }
        }
    }
}