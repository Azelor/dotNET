using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.FriendlyUrls;

namespace SmartMethodStore
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            foreach (string Segment in Page.Request.GetFriendlyUrlSegments())
            {
                Response.Write(Segment + "<br />");
            }
        }
    }
}