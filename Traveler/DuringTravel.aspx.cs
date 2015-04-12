using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Traveler
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonClick(object sender, EventArgs e)
        {
            string _web = "http://www.accuweather.com/en/in/india-weather";

            Response.Redirect(_web);
        }

    }
}