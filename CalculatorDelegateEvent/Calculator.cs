namespace CalculatorDelegateEvent
{
    public partial class Calculator : Form
    {
        public delegate void CalculateTotal(double num1, double num2);
        public static event CalculateTotal EventTotal;
        public Calculator()
        {
            InitializeComponent();

            cmbArithmetic.Items.Add('+');
            cmbArithmetic.Items.Add('-');
            cmbArithmetic.Items.Add('*');
            cmbArithmetic.Items.Add('/');
            cmbArithmetic.SelectedIndex = 0;
            cmbArithmetic.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double getNum1, getNum2;
            getNum1 = Int32.Parse(txtFirstNum.Text);
            getNum2 = Int32.Parse(txtSecondNum.Text);

            EventTotal = new CalculateTotal(Arithmetic.GetAddition);
            EventTotal += new CalculateTotal(Arithmetic.GetSubtraction);
            EventTotal += new CalculateTotal(Arithmetic.GetMultiplicaction);
            EventTotal += new CalculateTotal(Arithmetic.GetDivision);
            EventTotal(getNum1, getNum2);
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            String input1 = txtFirstNum.Text;
            String input2 = txtSecondNum.Text;
            double num1, num2;
            double.TryParse(input1, out num1);
            double.TryParse(input2, out num2);

            EventAccessorClass eventAccessor = new EventAccessorClass();
            if (string.IsNullOrEmpty(input1))
            {
                MessageBox.Show("Please input first number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(input1,"^[0-9]"))
            {
                MessageBox.Show("Numeric only!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(input2))
            {
                MessageBox.Show("Please input second number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(input2, "^[0-9]"))
            {
                MessageBox.Show("Numeric only!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmbArithmetic.SelectedIndex == -1)
            {
                MessageBox.Show("Please select operator", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmbArithmetic.SelectedItem?.ToString() == "+")
            {
                lbResult.Items.Add("Addition: " + num1 + " + " + num2 + " = " + eventAccessor.AddNumbers(num1, num2).ToString());
            }
            else if (cmbArithmetic.SelectedItem?.ToString() == "-")
            {
                lbResult.Items.Add("Subtract: " + num1 + " - " + num2 + " = " + eventAccessor.SubtractNumbers(num1, num2).ToString());
            }
            else if (cmbArithmetic.SelectedItem?.ToString() == "*")
            {
                lbResult.Items.Add("Multiply: " + num1 + " * " + num2 + " = " + eventAccessor.MultiplyNumbers(num1, num2).ToString());
            }
            else if (cmbArithmetic.SelectedItem?.ToString() == "/")
            {
                lbResult.Items.Add("Divide: " + num1 + " / " + num2 + " = " + eventAccessor.DivideNumbers(num1, num2).ToString());
            }
            else
            {
                MessageBox.Show("Congrats", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public class EventAccessorClass
        {
            public double AddNumbers(double x, double y)
            {
                return x + y;
            }
            public double SubtractNumbers(double x, double y)
            {
                return x - y;
            }
            public double MultiplyNumbers(double x, double y)
            {
                return x * y;
            }
            public double DivideNumbers(double x, double y)
            {
                return x / y;
            }
        }

        class Arithmetic
        {
            private static double total;
            public static void GetAddition(double num1, double num2)
            {
                total = num1 + num2;
                MessageBox.Show("Add: " + total.ToString());
            }
            public static void GetSubtraction(double num1, double num2)
            {
                total = num1 - num2;
                MessageBox.Show("Subtract: " + total.ToString());
            }
            public static void GetMultiplicaction(double num1, double num2)
            {
                total = num1 * num2;
                MessageBox.Show("Multiply: " + total.ToString());
            }
            public static void GetDivision(double num1, double num2)
            {
                total = num1 / num2;
                MessageBox.Show("Divide: " + total.ToString());
            }
        }
    }
}