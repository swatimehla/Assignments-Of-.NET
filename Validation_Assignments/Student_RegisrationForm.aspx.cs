using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class Validations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(RadioButtonList1.SelectedValue=="CSE")
            {
                CheckBox1.Visible = true;
                CheckBox2.Visible = true;
                CheckBox3.Visible = true;
            }
            else
            {
                CheckBox4.Visible = true;
                CheckBox5.Visible = true;
                CheckBox6.Visible = true;
            }
        }

        protected void CustomValidator1_ServerValidate1(object source, ServerValidateEventArgs args)
        {
            if (CheckBox1.Checked)
            {
                args.IsValid = true;
            }
            else if (CheckBox3.Checked)
            {
                args.IsValid = true;
            }
            else if (CheckBox3.Checked)
            {
                args.IsValid = true;
            }
            else if (CheckBox4.Checked)
            {
                args.IsValid = true;
            }
            else if (CheckBox5.Checked)
            {
                args.IsValid = true;
            }
            else if (CheckBox6.Checked)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }
        
    }
}