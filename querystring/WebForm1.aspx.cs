using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace querystring
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("userinfo");
            cookie["Name"] = TextBox1.Text;
            cookie["Email"] = TextBox2.Text;

            Response.Cookies.Add(cookie);
            Response.Redirect("WebForm2.aspx");


        }                 
    }
}