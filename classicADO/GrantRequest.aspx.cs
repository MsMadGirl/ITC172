using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class GrantRequest : System.Web.UI.Page
{
    GrantRequest gr = new GrantRequest();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userKey"] != null)
        {
            if (!IsPostBack)
            {
                DataTable table = bc.GetGrantType();
                DropDownList1.DataSource = table;
                DropDownList1.DataTextField = "GrantTypeName";
                DropDownList1.DataValueField = "GrantTypeKey";
                DropDownList1.DataBind();
                ListItem item = new ListItem("Choose a service");
                DropDownList1.Items.Insert(0, item);
            }
        }
        else
        {
            Response.Redirect("Default.aspx");
        }
    }
        protected void FillGrid()
    {
        if(!DropDownList1.SelectedItem.Text.Equals("Choose a service"))
        {
            int key = int.Parse(DropDownList1.SelectedValue.ToString());
            DataTable tbl = bc.GetGrant(key);
            GridView1.DataSource = tbl;
            GridView1.DataBind();
        }
        
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillGrid();
    }
}