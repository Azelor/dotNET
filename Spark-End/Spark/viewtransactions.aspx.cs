using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Spark
{
    public partial class viewtransactions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownListSelectPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownListSelectPeriod.SelectedValue == "2010")
            {
                Panel2010.Visible = true;
                Panel2011.Visible = false;
            }
            else if (DropDownListSelectPeriod.SelectedValue == "2011")
            {
                Panel2011.Visible = true;
                Panel2010.Visible = false;
            }
        }
    }
}