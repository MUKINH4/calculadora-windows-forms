using System.Reflection.Metadata;

namespace cp1_winforms
{
    public partial class Form1 : Form
    {

        private string operation = "";
        private double firstNumber = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void cleanBtn_Click(object sender, EventArgs e)
        {
            lbResult.Text = "";
            firstNumber = 0;
            operation = "";
        }

        private void cubeRootBtn_Click(object sender, EventArgs e)
        {
            calculateAndShow(Math.Cbrt);
        }

        private void squareRootBtn_Click(object sender, EventArgs e)
        {
            calculateAndShow(Math.Sqrt);
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            defineOperation("*");
        }



        private void LbResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && ((TextBox)sender).Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void numberBtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                lbResult.Text += btn.Text;
            }
        }
        private void equalBtn_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lbResult.Text, out double secondNumber))
            {
                double result = 0;

                switch (operation)
                {
                    case "*":
                        result = firstNumber * secondNumber; break;
                    case "+":
                        result = firstNumber + secondNumber; break;
                    case "-":
                        result = firstNumber - secondNumber; break;
                    case "/":
                        result = secondNumber != 0 ? firstNumber / secondNumber : 0; break;
                }
                if (result % 1 == 0)
                {
                    lbResult.Text = ((int)result).ToString();
                }
                else
                {
                    lbResult.Text = result.ToString("F2");
                }
                lbResult.Text = result.ToString();
                operation = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void subtractionBtn_Click(object sender, EventArgs e)
        {
            defineOperation("-");
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            defineOperation("/");
        }

        private void sumBtn_Click(object sender, EventArgs e)
        {
            defineOperation("+");
        }
        private void calculateAndShow(Func<double, double> operacao)
        {
            if (double.TryParse(lbResult.Text, out double numero))
            {
                double result = operacao(numero);

                if (result % 1 == 0)
                {
                    lbResult.Text = ((int)result).ToString();
                }
                else
                {
                    lbResult.Text = result.ToString("F2");
                }
            }
        }
        private void defineOperation(string op)
        {
            if (double.TryParse(lbResult.Text, out firstNumber))
            {
                operation = op;
                lbResult.Text = "";
            }
        }

        private void gabrielJablonskiRMToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void renatoDavidToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void resumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form resume = new ResumeWindow();
            resume.Show();
        }
    }
}
