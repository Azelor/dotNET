using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShiningStone
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) GetNewProducts();
        }

        private void GetNewProducts()
        {
            using (ShiningStoneDataContext Data = new ShiningStoneDataContext())
            {
                var Products = Data.Products.OrderByDescending(P => P.ProductDateAdded).Take(3);
                DataListProducts.DataSource = Products;
                DataListProducts.DataBind();
            }
        }
    }
}