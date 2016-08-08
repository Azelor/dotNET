using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShiningStone
{
    public partial class buy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private bool AcceptedTerms
        {
            get
            {
                return true;
            }
        }

        protected void ButtonSubmitOrder_Click(object sender, EventArgs e)
        {
            string SelectedCountry = DropDownListCountry.SelectedItem.Text;
            if (
                (Page.IsValid && CheckBoxAcceptTerms.Checked)
                && 
                (SelectedCountry == "United Kingdom" || SelectedCountry == "Ireland")
                )
            {
                Response.Write("Logic succeeded");
            }
        }
    }
}