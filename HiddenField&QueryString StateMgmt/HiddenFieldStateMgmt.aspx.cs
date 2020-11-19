using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebStateMangement
{
    public partial class WebCount : System.Web.UI.Page
    {
        int count;
        int loginCount;
        int resetCount;
        int clickme;
        int clickmealso;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            count =Convert.ToInt32( HiddenField1.Value);
            count++;
            Response.Write("Number of clicks on Button :" + count);
            HiddenField1.Value = count.ToString();
           
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            loginCount = Convert.ToInt32(HiddenField2.Value);
            loginCount++;
            Response.Write("Number of clicks on Button :" + loginCount);
            HiddenField2.Value = loginCount.ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            resetCount = Convert.ToInt32(HiddenField3.Value);
            resetCount++;
            Response.Write("Number of clicks on Button :" + resetCount);
            HiddenField3.Value = resetCount.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            clickme = Convert.ToInt32(HiddenField4.Value);
            clickme++;
            Response.Write("Number of clicks on Button :" + clickme);
            HiddenField4.Value = clickme.ToString();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            clickmealso = Convert.ToInt32(HiddenField5.Value);
            clickmealso++;
            Response.Write("Number of clicks on Button :" + clickmealso);
            HiddenField5.Value = clickmealso.ToString();
        }
    }
}