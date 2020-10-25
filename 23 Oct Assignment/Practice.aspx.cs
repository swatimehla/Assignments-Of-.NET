using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button1_Click(object sender, EventArgs e)
        {
            inputtext.Text =textbox1.Text;
        }

        protected void button2_Click(object sender, EventArgs e)
        {
            if(radiobutton1.Checked)
            {
                showgender.Text ="you are"+ radiobutton1.Text;
            }
            else
            {
                showgender.Text = "you are" + radiobutton2.Text;
            }
           
        }
    }
}