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
            if (txtInput.Text == "")
            {
                MessageBox.Show("숫자를 입력하세요");
                return;
            }

            firstNumber = int.Parse(txtInput.Text);
            op = "+";
            txtInput.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "")
            {
                MessageBox.Show("숫자를 입력하세요");
                return;
            }

            int secondNumber = int.Parse(txtInput.Text);
            int result = 0;

            if (op == "/" && secondNumber == 0)
            {
                MessageBox.Show("0으로 나눌 수 없습니다");
                return;
            }

            if (op == "+")
                result = firstNumber + secondNumber;
            else if (op == "-")
                result = firstNumber - secondNumber;
            else if (op == "*")
                result = firstNumber * secondNumber;
            else if (op == "/")
                result = firstNumber / secondNumber;



            txtResult.Text = result.ToString();
            txtInput.Text = result.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "")
            {
                MessageBox.Show("숫자를 입력하세요");
                return;
            }

            firstNumber = int.Parse(txtInput.Text);
            op = "-";
            txtInput.Clear();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "")
            {
                MessageBox.Show("숫자를 입력하세요");
                return;
            }

            firstNumber = int.Parse(txtInput.Text);
            op = "*";
            txtInput.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "")
            {
                MessageBox.Show("숫자를 입력하세요");
                return;
            }

            firstNumber = int.Parse(txtInput.Text);
            op = "/";
            txtInput.Clear();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtResult.Clear();

            firstNumber = 0;
            op = "";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length > 0)
            {
                txtInput.Text = txtInput.Text.Substring(0, txtInput.Text.Length - 1);
            }
        }


    }
}
