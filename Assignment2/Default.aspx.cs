using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string[,] date = new string[6, 2];
    

        
    protected void Page_Load(object sender, EventArgs e)
    {

        date[0, 0] = "1/20/2017";
        date[0, 1] = "T Day";
        date[1, 0] = "2/14/2017";
        date[1, 1] = "Valentine's Day";
        date[2, 0] = "8/4/2017";
        date[2, 1] = "Gran's Birthday";
        date[3, 0] = "12/2/2017";
        date[3, 1] = "Dad's Birthday";
        date[4, 0] = "2/24/2017";
        date[4, 1] = "Mom's Birthday";
        date[5, 0] = "1/20/2017";
        date[5, 1] = "Inauguration Day";

        if (!IsPostBack)
        {
            
        }//end if



    }//end PageLoad






    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        //string birthday = "11/19/2017"; -> if (Calendar1.SelectedDate.ToShortDateString().Equals(birthday));
        
        DateTime birthday = DateTime.Parse("11/19/2017");
        DateLabel.Text = Calendar1.SelectedDate.ToLongDateString();

        if (Calendar1.SelectedDate==birthday)
        {
            DateLabel.Text += " - Happy Birthday!";
        }//end if
    }//end SelectionChanged




   

    protected void Button1_Click(object sender, EventArgs e)
    {
        for(int i = 0; i < 6; i++)
        {


            if(Calendar1.SelectedDate.ToShortDateString() == date[i,0])
            {
                EventLabel.Text += date[i, 1] + "<br>";
            }
        }
    }//end Button1_Click
}