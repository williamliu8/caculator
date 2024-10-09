using System.Data;

namespace calculator
{
    public partial class Form1 : Form
    {
        private string currentExpression = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            currentExpression += "1";
            tb_display.Text = currentExpression;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            currentExpression += "2";
            tb_display.Text = currentExpression;
        }

        private void btn_sign_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentExpression) && !currentExpression.StartsWith("-"))
            {
                currentExpression = "-" + currentExpression;
            }
            else if (currentExpression.StartsWith("-"))
            {
                currentExpression = currentExpression.Substring(1);
            }
            tb_display.Text = currentExpression;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            currentExpression += "0";
            tb_display.Text = currentExpression;
        }

        private void btn_point_Click(object sender, EventArgs e)
        {
            currentExpression += ".";
            tb_display.Text = currentExpression;
        }

        private void btn_equals_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new DataTable().Compute(currentExpression, null);
                tb_display.Text = result.ToString();
                currentExpression = result.ToString();
            }
            catch
            {
                tb_display.Text = "Error"; 
                currentExpression = "";
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            currentExpression += "3";
            tb_display.Text = currentExpression;
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            currentExpression += "+";
            tb_display.Text = currentExpression;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            currentExpression += "4";
            tb_display.Text = currentExpression;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            currentExpression += "5";
            tb_display.Text = currentExpression;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            currentExpression += "6";
            tb_display.Text = currentExpression;
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            currentExpression += "-";
            tb_display.Text = currentExpression;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            currentExpression += "7";
            tb_display.Text = currentExpression;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            currentExpression += "8";
            tb_display.Text = currentExpression;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            currentExpression += "9";
            tb_display.Text = currentExpression;
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            currentExpression += "*";
            tb_display.Text = currentExpression;
        }

        private void btn_percentage_Click(object sender, EventArgs e)
        {
            try
            {
                var result = Convert.ToDouble(currentExpression) / 100;
                currentExpression = result.ToString();
                tb_display.Text = currentExpression;
            }
            catch
            {
                tb_display.Text = "Error";
                currentExpression = "";
            }
        }

        private void btn_ce_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentExpression))
            {
                currentExpression = currentExpression.Substring(0, currentExpression.Length - 1);
                tb_display.Text = currentExpression;
            }
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            currentExpression = "";
            tb_display.Text = "";
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            currentExpression += "÷";
            tb_display.Text = currentExpression;
        }

        private void btn_l_parentheses_Click(object sender, EventArgs e)
        {
            currentExpression += "(";
            tb_display.Text = currentExpression;
        }

        private void btn_r_parentheses_Click(object sender, EventArgs e)
        {
            currentExpression += ")";
            tb_display.Text = currentExpression;
        }
    }
}
