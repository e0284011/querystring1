﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace querystring
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["userinfo"];
            if (cookie != null)
            {
                Label3.Text = cookie["Name"];
                Label4.Text = cookie["Email"];
            }
            
        }
    }
}