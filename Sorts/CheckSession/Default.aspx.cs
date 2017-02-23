using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CheckSession
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session.SessionID;
            Session["session"] = "Mysession";
            Label1.Text = Session["session"].ToString();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("About.aspx?querystring=hello world");
        }
    }
}
