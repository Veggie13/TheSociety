using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ("kkarlsson".Equals(Session["userid"]))
            Response.Redirect("inside.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string user = TextBox1.Text, pw = TextBox2.Text;
        if (user.Equals("kkarlsson") && pw.Equals("rosenberg"))
        {
            Session["userid"] = "kkarlsson";
            Session["clearance"] = 6;
            Response.Redirect("inside.aspx");
        }
        else if (user.Equals("theshadow") && pw.Equals("bisette"))
        {
            Session["userid"] = "theshadow";
            Session["clearance"] = 1;
            Response.Redirect("inside.aspx");
        }
        else
        {
            object o = Session["failures"];
            int fails = (o == null) ? 1 : (int)o;
            Session["failures"] = fails + 1;
            Response.Redirect("failed.aspx");
        }
    }
}