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

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        DateTime myDate;
        string name;
        myDate = Calendar1.SelectedDate;
        name = tbName.Text;
        lblResult.Text = "Hello, " + name + ". The date you selected is " + myDate.ToShortDateString() + ".";
    }
}