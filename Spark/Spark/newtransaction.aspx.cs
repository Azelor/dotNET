using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Spark
{
    public partial class newtransaction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Calculate VAT for the specified Amount
        /// </summary>
        /// <param name="Amount">Amount to calculate VAT for</param>
        /// <returns></returns>
        private decimal CalculateVAT(decimal Amount)
        {
            // VAT or Value Added Tax is a sales tax levied in Europe
            decimal VATAmount = Amount * 0.2m;
            VATAmount = Math.Round(VATAmount, 2);
            return VATAmount;
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (DropDownListCustomer.SelectedValue == "6"
                    || DropDownListCustomer.SelectedValue == "9"
                    || DropDownListCustomer.SelectedValue == "11")
                {
                    LabelError.Text = "That customer is currently out of use";
                }
                else
                {
                }
            }
            catch (Exception Ex)
            {
                LabelError.Text = Ex.Message;
            }
        }
    }
}