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
        if (!IsPostBack)
        {
            string[] tipPercent = { "Ten Percent", "Fifteen Percent", "Twenty Percent", "Other" };
            TipPercents.DataSource = tipPercent;
            TipPercents.DataBind();
        }
    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        GetInfo();
    }

    protected void GetInfo()
    {
        Tip tip = new Tip();
        tip.MealAmount =  double.Parse(MealTextBox.Text);
        if (OtherTextBox.Text == "")
        {
            foreach (ListItem item in TipPercents.Items)
            {
                tip.TipPercent = 0;

                if (item.Selected)
                {

                    if (item.Text.Equals("Ten Percent"))
                    {
                        tip.TipPercent = .1;
                    }//end if ten

                    else if (item.Text.Equals("Fifteen Percent"))
                    {
                        tip.TipPercent = .15;
                    }//end else if fifteen

                    else if (item.Text.Equals("Twenty Percent"))
                    {
                        tip.TipPercent = .20;
                    }//end else if twenty

                }//end inner if selected

                else
                {
                    tip.TipPercent = 0;
                }//end else
            }//end foreach

        } //end outer if

        else
        {
            tip.TipPercent = double.Parse(OtherTextBox.Text);
        }//end else other text box

            ResultsLabel.Text = ("Amount: " + tip.MealAmount.ToString() + "<br/>" +  "Tip: " + tip.CalculateTip().ToString("$#,##0.00") + "<br/>" +  "Tax: " + tip.CalculateTax().ToString"$#,##0.00"() + "<br/>" +  "Total: " + tip.CalculateTotal().ToString("$#,##0.00"));

        
    }//end GetInfo

}