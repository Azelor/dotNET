using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace My_Project
{
    public partial class circlecalculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Circle MyCircle = new Circle(50);
            double MyCircleDiameter = Circle.CalculateDiameter(7.95);
            Response.Write(MyCircleDiameter);
        }
    }
}