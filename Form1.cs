namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        int firstNumber = 0;
        string op = "";
        public Form1()
        {
            InitializeComponent();
        }


        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtInput.Text += btn.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "") return;

            firstNumber = int.Parse(txtInput.Text);
            op = "+";
            txtInput.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "") return;

            int secondNumber = int.Parse(txtInput.Text);
            int result = 0;

            if (op == "+")
            {
                result = firstNumber + secondNumber;
            }

            txtResult.Text = result.ToString();
        }
    }
}
