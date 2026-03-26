using System.Data;

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

            txtInput.Text += "+";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text)) return;

            try
            {
                string expression = txtInput.Text;

                
                expression = expression.Replace("×", "*");
                expression = expression.Replace("÷", "/");

              
                expression = System.Text.RegularExpressions.Regex.Replace(
                    expression, @"(\d+)\((.+?)\)", "($1*($2))"
                );

                
                DataTable table = new DataTable();
                var result = table.Compute("1 * " + expression, "");

                
                txtResult.Text = result.ToString();

            }
            catch
            {
                MessageBox.Show("수식을 확인해주세요.");
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "")
            {
                MessageBox.Show("숫자를 입력하세요");
                return;
            }

            txtInput.Text += "-";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "")
            {
                MessageBox.Show("숫자를 입력하세요");
                return;
            }

            txtInput.Text += "×";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "")
            {
                MessageBox.Show("숫자를 입력하세요");
                return;
            }

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

        private void btnOpen_Click(object sender, EventArgs e)
        {
            txtInput.Text += "(";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            txtInput.Text += ")";
        }
    }
}
