using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WangBowen0227WebApplication.lecture13
{
    public partial class DataBing : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack)
            {
                var towns = new[]
                {
                    new {ID = 1, Name ="Sofia"},
                    new {ID = 2, Name ="Plovid"},
                    new {ID = 3, Name ="Varna"},
                };
                this.ListBoxTowns.DataSource = towns;
                this.ListBoxTowns.DataBind();
            }

        }

        protected void List(object sender, EventArgs e)
        {
            
        }

        protected void ListBoxTowns_(object sender, EventArgs e)
        {

        }

        protected void ListBoxTowns_Select(object sender, EventArgs e)
        {

        }

        protected void ListBoxTowns_Selected(object sender, EventArgs e)
        {

        }
        protected void DropDownYesNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = DropDownListYesNo.SelectedValue;
        }

        protected void ListBoxTowns_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label2.Text = ListBoxTowns.SelectedValue;
        }


    }
}