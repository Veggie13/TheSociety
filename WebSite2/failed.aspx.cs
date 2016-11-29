using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class failed : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        object o = Session["failures"];
        int fails = (o == null) ? 0 : (int)o;
        if (fails == 0)
            Response.Redirect("Default.aspx");
        else
            failCount.Text = fails.ToString();
    }
}