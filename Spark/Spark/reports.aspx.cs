using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Spark
{
    public partial class reports : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SparkDataContext Data = new SparkDataContext())
            {
                var Invoices = Data.Invoices
                    .OrderBy(Invoice => Invoice.InvoiceDate);
                GridViewInvoice.DataSource = Invoices;
                GridViewInvoice.DataBind();
            }
        }

        protected void GridViewInvoice_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewInvoice.PageIndex = e.NewPageIndex;
            GridViewInvoice.DataBind();
        }
    }
}