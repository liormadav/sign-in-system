using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SignIn2
{
    public partial class welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userName"] != null)
            {
                name.Text = "" + Session["userName"];
            }
            else
            {
                Response.Write("<a href=SignIn.aspx>sign in page </a>");
                Response.End();
            }
        }
    }
}