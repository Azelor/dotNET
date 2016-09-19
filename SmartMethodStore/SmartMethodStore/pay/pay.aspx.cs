using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartMethodStore.pay
{
    public partial class pay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonContinueToPayment_Click(object sender, EventArgs e)
        {
            using (StoreDataContext Data = new StoreDataContext())
            {
                Order NewOrder = new Order();
                NewOrder.OrderAddress1 = TextBoxOrderAddress1.Text;
                NewOrder.OrderAddress2 = TextBoxOrderAddress2.Text;
                NewOrder.OrderTown = TextBoxOrderTown.Text;
                NewOrder.OrderRegion = TextBoxOrderRegion.Text;
                NewOrder.CountryID = Convert.ToInt32(DropDownListCountry.SelectedValue);
                NewOrder.OrderPostCode = TextBoxOrderPostCode.Text;
                NewOrder.OrderPaid = false;
                NewOrder.OrderSent = false;
                NewOrder.UserName = Page.User.Identity.Name;
                NewOrder.OrderDate = DateTime.Now;
                Data.Orders.InsertOnSubmit(NewOrder);
                Data.SubmitChanges();

                List<int> Products = (List<int>)Session["Cart"];

                foreach (int ProductID in Products)
                {
                    OrderProduct NewOrderProduct = new OrderProduct();
                    NewOrderProduct.OrderID = NewOrder.OrderID;
                    NewOrderProduct.ProductID = ProductID;
                    Data.OrderProducts.InsertOnSubmit(NewOrderProduct);
                }
                Data.SubmitChanges();

                //Send user to payment system here
            }
        }
    }
}