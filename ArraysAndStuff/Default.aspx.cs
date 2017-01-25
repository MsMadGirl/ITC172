using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string[,] product = new string[6, 2];
    

        
    protected void Page_Load(object sender, EventArgs e)
    {

        product[0, 0] = "Lettuce";
        product[0, 1] = ".99";
        product[1, 0] = "Carrots";
        product[1, 1] = "2.99";
        product[2, 0] = "Tomato";
        product[2, 1] = ".99";
        product[3, 0] = "Eggplant";
        product[3, 1] = "6.99";
        product[4, 0] = "Onion";
        product[4, 1] = ".49";

        if (!IsPostBack)
        {
            GetProduce();
        }//end if



    }//end PageLoad

    protected void GetProduce()
    {
        for(int i = 0; i<5; i++)
        {
            ListItem item = new ListItem();
            item.Text = product[i, 0];
            ProduceCheckBoxList.Items.Add(item);
        }
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        //string birthday = "5/9/2017"; -> if (Calendar1.SelectedDate.ToShortDateString().Equals(birthday));
        DateTime birthday = DateTime.Parse("5/9/2017");
        DateLabel.Text = Calendar1.SelectedDate.ToLongDateString();

        if (Calendar1.SelectedDate==birthday);
        {
            DateLabel.Text += " - Happy Birthday!";
        }//end if
    }

    protected void ProduceButton_Click(object sender, EventArgs e)
    {
        int counter = 0;
        double total = 0;

        foreach(ListItem item in ProduceCheckBoxList.Items)
        {
            if (item.Selected)
            {
                if (item.Text.Equals(product[counter, 0]))
                {
                    total += double.Parse(product[counter, 1]);
                }//end inner if
            }//end outer if

            counter++;
        }//end foreach

        TotalLabel.Text = "Your total is " + total.ToString("C");
    }//end produce button



    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}