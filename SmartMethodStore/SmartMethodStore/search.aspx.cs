using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartMethodStore
{
    public partial class search : System.Web.UI.Page
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

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            using (StoreDataContext Data = new StoreDataContext())
            {
                string ProductName = TextBoxProductName.Text;
                decimal? PriceBelow = null;
                if(TextBoxPriceBelow.Text.Length > 0)
                {
                    PriceBelow = Convert.ToDecimal(TextBoxPriceBelow.Text);
                }
                var SearchResults = Data.Products.Where
                    (Product => 
                    (Product.ProductName.Contains(ProductName) 
                    || ProductName.Length == 0) 
                    && 
                    (Product.ProductPrice <= PriceBelow 
                    || PriceBelow == null));
                GridViewProduct.DataSource = SearchResults;
                GridViewProduct.DataBind();
            }
        }
    }
}