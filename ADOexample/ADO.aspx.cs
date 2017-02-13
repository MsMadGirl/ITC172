using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ADO : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }//end page_load

    protected void LoginButton_Click(object sender, EventArgs e)
    {
        LoginClass lc = new LoginClass(UserTextBox.Text, PasswordTextBox.Text);//don't flip these
        int key = lc.ValidateLogin();

        if(key != 0)
        {
            ResultLabel.Text = "Welcome";
        
        }//end if

        else
        {
            ResultLabel.Text = "Invalid Login";
        }//end else

    }//end buttonclick

}//end ADO