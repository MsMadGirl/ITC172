using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        SubmitRegistration();
    }

    protected void LastNameTB_TextChanged(object sender, EventArgs e)
    {

    }

    protected void SubmitRegistration()
    {
        string lastname = LastNameTB.Text;
        string firstname = FirstNameTB.Text;
        string email = EmailTB.Text;
        string apartment = ApartmentNumberTB.Text;
        string street = StreetAddressTB.Text;
        string city = CityTB.Text;
        string state = StateTB.Text;
        string zipcode = ZipTB.Text;
        string home = HomePhoneTB.Text;
        string work = WorkPhoneTB.Text;
        string password = PasswordTB.Text;

        Community_AssistEntities cae = new Community_AssistEntities();
        int result = cae.usp_Register(lastname, firstname, email, password, apartment, street, city, state, zipcode, home, work);

        if (result != -1)
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            ResultLabel.Text = "Something is wibbly.";
        }
    }
}