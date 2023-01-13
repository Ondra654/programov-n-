namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double number1 = 0;
        double number2 = 0;
        char operation = ' ';

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
                if (operation == ' ')
                {
                    number1 = 1;
                }
                else
                {
                    number2 = 1;
                }
            }
            else
            {
                textBox1.Text += "1";
                if (operation == ' ')
                {
                    number1 = number1 * 10 + 1;
                }
                else
                {
                    number2 = number2 * 10 + 1;
                }
            }
            this.textBox1.Text = ("{0}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
                if (operation == ' ')
                {
                    number1 = 2;
                }
                else
                {
                    number2 = 2;
                }
            }
            else
            {
                textBox1.Text += "2";
                if (operation == ' ')
                {
                    number1 = number1 * 10 + 2;
                }
                else
                {
                    number2 = number2 * 10 + 2;
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
                if (operation == ' ')
                {
                    number1 = 3;
                }
                else
                {
                    number2 = 3;
                }
            }
            else
            {
                textBox1.Text += "3";
                if (operation == ' ')
                {
                    number1 = number1 * 10 + 3;
                }
                else
                {
                    number2 = number2 * 10 + 3;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
                if (operation == ' ')
                {
                    number1 = 4;
                }
                else
                {
                    number2 = 4;
                }
            }
            else
            {
                textBox1.Text += "4";
                if (operation == ' ')
                {
                    number1 = number1 * 10 + 4;
                }
                else
                {
                    number2 = number2 * 10 + 4;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
                if (operation == ' ')
                {
                    number1 = 5;
                }
                else
                {
                    number2 = 5;
                }
            }
            else
            {
                textBox1.Text += "5";
                if (operation == ' ')
                {
                    number1 = number1 * 10 + 5;
                }
                else
                {
                    number2 = number2 * 10 + 5;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
                if (operation == ' ')
                {
                    number1 = 6;
                }
                else
                {
                    number2 = 6;
                }
            }
            else
            {
                textBox1.Text += "6";
                if (operation == ' ')
                {
                    number1 = number1 * 10 + 6;
                }
                else
                {
                    number2 = number2 * 10 + 6;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
                if (operation == ' ')
                {
                    number1 = 7;
                }
                else
                {
                    number2 = 7;
                }
            }
            else
            {
                textBox1.Text += "7";
                if (operation == ' ')
                {
                    number1 = number1 * 10 + 7;
                }
                else
                {
                    number2 = number2 * 10 + 7;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
                if (operation == ' ')
                {
                    number1 = 8;
                }
                else
                {
                    number2 = 8;
                }
            }
            else
            {
                textBox1.Text += "8";
                if (operation == ' ')
                {
                    number1 = number1 * 10 + 8;
                }
                else
                {
                    number2 = number2 * 10 + 8;
                }
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
                if (operation == ' ')
                {
                    number1 = 9;
                }
                else
                {
                    number2 = 9;
                }
            }
            else
            {
                textBox1.Text += "9";
                if (operation == ' ')
                {
                    number1 = number1 * 10 + 9;
                }
                else
                {
                    number2 = number2 * 10 + 9;
                }
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
                if (operation == ' ')
                {
                    number1 = 0;
                }
                else
                {
                    number2 = 0;
                }
            }
            else
            {
                textBox1.Text += "0";
                if (operation == ' ')
                {
                    number1 = number1 * 10 + 0;
                }
                else
                {
                    number2 = number2 * 10 + 0;
                }
            }
        }

    }
}