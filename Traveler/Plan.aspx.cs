using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Traveler
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        private void DropDown_List1(object sender, EventArgs e)
        {
            

        }

        protected void Button_Click(object sender, EventArgs e)
        {
            if (DropDown_List.SelectedValue == "TRAIN")
            {
                Response.Redirect("https://www.irctc.co.in/eticketing/loginHome.jsf");
            }

           
        }

    }
}