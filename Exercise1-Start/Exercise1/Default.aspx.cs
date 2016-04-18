using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercise1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCalculate_Click(object sender, EventArgs e)
        {
            TableDepreciatedNumbers.Visible = true;
            double StartingValue = Convert.ToDouble(TextBoxStartingValue.Text);
            double DepreciationRate = Convert.ToDouble(TextBoxDepreciationRate.Text);
            int NumberOfYears = Convert.ToInt32(TextBoxNumberOfYear.Text);
            double YearEndValue = StartingValue;

            for (int Counter = 0; Counter <= NumberOfYears; Counter++)
            {
                //Make this tidier by moving this to a new method
                TableRow NewTableRow = new TableRow();
                TableCell YearCell = new TableCell();
                TableCell ValueCell = new TableCell();
                YearCell.Text = Counter.ToString();
                ValueCell.Text = YearEndValue.ToString("0.00");
                NewTableRow.Cells.Add(YearCell);
                NewTableRow.Cells.Add(ValueCell);
                TableDepreciatedNumbers.Rows.Add(NewTableRow);
                //***********************************************

                YearEndValue = YearEndValue * DepreciationRate;
            }
        }
    }
}