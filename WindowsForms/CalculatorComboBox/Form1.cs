namespace CalculatorComboBox
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool isFirstNumberValid = double.TryParse(txtFirstNum.Text, out double first);
            bool isSecondNumberValid = double.TryParse(txtSecondNum.Text, out double second);
            double result = 0;
            string symbol = cboSymbol.Text;
            string error = string.Empty;
            if (!isFirstNumberValid || !isSecondNumberValid)
            {
                if (!isFirstNumberValid)
                {
                    error = "Problem with first number";
                }
                if (!isSecondNumberValid)
                {
                    error = "Problem with second number";
                }
                MessageBox.Show(
                    error,
                    "System error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            else
            {
                if (symbol == "+")
                {
                    result = first + second;
                }
                else if (symbol == "-")
                {
                    result = first - second;
                }
                else if (symbol == "*")
                {
                    result = first * second;
                }

                else if (symbol == "*")
                {
                    result = first * second;
                }
                else if (symbol == "/")
                {
                    result = first / second;
                    
                }


            }
           
            txtResult.Text = result.ToString();
            
        }
    }
}
