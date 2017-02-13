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

    protected void LoginButton_Click(object sender, EventArgs e)
    {
        Community_AssistEntities cae = new Community_AssistEntities();
        int result = cae.usp_Login(UserTextBox.Text, PasswordTextBox.Text);
        if(result != -1)
        {
            var key = (from p in cae.People
                       where p.PersonEmail.Equals(UserTextBox.Text)
                       select p.PersonKey).FirstOrDefault();
            int pKey = (int)key;
            Session["userKey"] = pKey;
            Response.Redirect("Donate.aspx");
        }

        else
        {
            ResultLabel.Text = "Invalid Login";
        }
    }
}