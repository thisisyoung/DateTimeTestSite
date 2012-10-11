using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

namespace DateTimeTestSite
{
    public partial class DateTimeTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Parse("1/21/2012");
            CultureInfo currentCulture = CultureInfo.CurrentCulture;
            Response.Write("date time:" + dateTime.ToString() + "<br>");
            Response.Write("server side culture info:" + currentCulture.DisplayName + "<br>");
            Response.Write("client side language info:" + Request.UserLanguages[0] + "<br>");
            Response.Write("date time display as client side culture format:" + dateTime.ToString(new CultureInfo(Request.UserLanguages[0]).DateTimeFormat) + "<br>");
        }
    }
}