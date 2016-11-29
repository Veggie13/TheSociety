using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class inside : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ("kkarlsson".Equals(Session["userid"]) || "theshadow".Equals(Session["userid"]))
        {
            Session["failures"] = 0;
            Label2.Text = Session["clearance"].ToString();
            Label1.Text = Session["userid"].ToString();
            Label3.Text = "";
            Label4.Text = "";
        }
        else
        {
            object o = Session["failures"];
            int fails = (o == null) ? 1 : (int)o;
            Session["failures"] = fails + 1;
            Response.Redirect("failed.aspx");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int minClearance = -1;
        string msg = "";
        switch (TextBox1.Text)
        {
            case "AXN-376884":
                minClearance = 6;
                msg = "qsuctmmwhxhkbwcuywrezjylsrtvtasfrtrfpwfnlwbudmjunlwpgacsvjxwimswxfzkmqkyptyoivzefiajm";
                break;
            case "X374-081":
                minClearance = 1;
                msg = "We have been unable to figure out the purpose of the object.<br>" +
                    "It was blinking apparently at random but at 1am last night began<br>" +
                    "to wail and display the following:<br><img src='___images/blink.png'>";
                break;
            case "AFF-990643":
                minClearance = 6;
                msg = "After tailing MW for some time, the target was lost, but this etching was found:<br>" +
                    "wcbnnhlrqlupaedepcjswghxihbywugscjnspdqkseawvvkezmmblzgdhqfklicjbetmwfstiabhkeompurzihkrmsiqrnoovcnngscswbhetqeozqdphymzsouxemownclfusvekwoscviyacufcqinwbfcqxnmwcwbffbtqbonchbcvmzs";
                break;
            default:
                Label3.Text = "Document not found.";
                Label4.Text = "";
                return;
        }
        int clearance = (int)Session["clearance"];
        if (clearance > minClearance)
        {
            Label3.Text = "You do not have clearance for this document.";
            Label4.Text = "";
        }
        else
        {
            Label3.Text = "Document: " + TextBox1.Text;
            Label4.Text = msg;
        }
    }
}