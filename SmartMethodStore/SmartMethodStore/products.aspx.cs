using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartMethodStore
{
    public partial class products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridViewProduct_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "AddToCart")
            {
                int RowClicked = Convert.ToInt32(e.CommandArgument);
                int ProductID = Convert.ToInt32(GridViewProduct.DataKeys[RowClicked].Value);
                List<int> ProductsInCart = (List<int>)Session["Cart"];
                if (ProductsInCart == null)
                {
                    ProductsInCart = new List<int>();
                }
                ProductsInCart.Add(ProductID);
                Session["Cart"] = ProductsInCart;
            }
        }
    }
}