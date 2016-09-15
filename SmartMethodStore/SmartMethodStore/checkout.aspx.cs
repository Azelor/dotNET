using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartMethodStore
{
    public partial class checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GetProductsFromCart();
            }
        }

        private void GetProductsFromCart()
        {
            if (Session["Cart"] != null)
            {
                using (StoreDataContext Data = new StoreDataContext())
                {
                    List<int> Cart = (List<int>)Session["Cart"];
                    var Products = Data.Products.
                        Where(Product => Cart.Contains(Product.ProductID));
                    GridViewProduct.DataSource = Products;
                    GridViewProduct.DataBind();
                } }
        }

        protected void GridViewProduct_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "RemoveFromCart")
            {
                int RowClicked = Convert.ToInt32(e.CommandArgument);
                int ProductID = Convert.ToInt32(GridViewProduct.DataKeys[RowClicked].Value);
                List<int> ProductsInCart = (List<int>)Session["Cart"];
                ProductsInCart.Remove(ProductID);
                Session["Cart"] = ProductsInCart;
                GetProductsFromCart();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/pay/pay.aspx");
        }
    }
}