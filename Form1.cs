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
            txtInput.Text += " + ";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "") return;

            string expression = txtInput.Text;

            
            expression = expression.Replace("×", "*");
            expression = expression.Replace("÷", "/");

            int index = expression.IndexOf(op);

            int n1 = int.Parse(expression.Substring(0, index));
            int n2 = int.Parse(expression.Substring(index + 1));

            int result = 0;

            if (op == "+")
                result = n1 + n2;
            else if (op == "-")
                result = n1 - n2;
            else if (op == "*")
                result = n1 * n2;
            else if (op == "/")
            {
                if (n2 == 0)
                {
                    MessageBox.Show("0으로 나눌 수 없습니다");
                    return;
                }
                result = n1 / n2;
            }

          
            txtInput.Text = txtInput.Text + "=" + result.ToString();
            txtResult.Text = result.ToString();
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
            txtInput.Text += " - ";
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
            txtInput.Text += "×"; 
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
            txtInput.Text += "÷";
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
            if (string.IsNullOrEmpty(txtInput.Text)) return;

           
            string currentText = txtInput.Text;

            
            int lastOpIndex = currentText.LastIndexOfAny(new char[] { '+', '-', '*', '/', '×', '÷' });

            if (lastOpIndex != -1)
            {
                
                txtInput.Text = currentText.Substring(0, lastOpIndex + 1);

            }
            else
            {
               
                txtInput.Text = "";
            }
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
