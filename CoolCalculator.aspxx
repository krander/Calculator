using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CoolCalculator : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    double operand1, operand2, result;

    public void btnAddition_Click(object sender, EventArgs e)
    {
        operand1 = Convert.ToDouble(textOne.Text);
        operand2 = Convert.ToDouble(textTwo.Text);
        result = operand1 + operand2;
        calc_result.Text = result.ToString();
    }

    public void btnSubtraction_Click(object sender, EventArgs e)
    {
        operand1 = Convert.ToDouble(textOne.Text);
        operand2 = Convert.ToDouble(textTwo.Text);
        result = operand1 - operand2;
        calc_result.Text = result.ToString();
    }

    public void btnMultiplication_Click(object sender, EventArgs e)
    {
        operand1 = Convert.ToDouble(textOne.Text);
        operand2 = Convert.ToDouble(textTwo.Text);
        result = operand1 * operand2;
        calc_result.Text = result.ToString();
    }

    public void btnDivision_Click(object sender, EventArgs e)
    {
        operand1 = Convert.ToDouble(textOne.Text);
        operand2 = Convert.ToDouble(textTwo.Text);
        result = operand1 / operand2;
        calc_result.Text = result.ToString();
    }
}
