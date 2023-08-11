namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string calTotal = "";
        int num1;
        int num2;
        string option = "";
        int result;


        private void button1_Click_1(object sender, EventArgs e)
        {
            lbl.Text = lbl.Text + "1";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            lbl.Text = lbl.Text + "2";
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            lbl.Text = lbl.Text + "3";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            lbl.Text = lbl.Text + "4";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            lbl.Text = lbl.Text + "5";
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            lbl.Text = lbl.Text + "6";
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            lbl.Text = lbl.Text + "7";
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            lbl.Text = lbl.Text + "8";
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            lbl.Text = lbl.Text + "9";
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            lbl.Text = lbl.Text + "0";

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(lbl.Text);
            label1.Text = lbl.Text + option;
            lbl.Clear();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(lbl.Text);
            label1.Text = lbl.Text + option;
            lbl.Clear();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(lbl.Text);
            label1.Text = lbl.Text + option;
            lbl.Clear();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(lbl.Text);
            label1.Text = lbl.Text + option;
            lbl.Clear();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            lbl.Clear();
            label1.Text = "";
            label2.Text = "";
            num1 = 0;
            num2 = 0;
            result = 0;
        }
        private void button16_Click_1(object sender, EventArgs e)
        {
            label2.Text = lbl.Text;
            if (int.TryParse(lbl.Text, out num2))
            {
                if (option.Equals("+"))
                {
                    result = num1 + num2;
                }
                else if (option.Equals("-"))
                {
                    result = num1 - num2;
                }
                else if (option.Equals("*"))
                {
                    result = num1 * num2;
                }
                else if (option.Equals("/"))
                {
                    if (num2 != 0)  // Check for division by zero
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        lbl.Text = "Error: Division by zero";
                        return;  // Exit the method to avoid further processing
                    }
                }

                lbl.Text = result.ToString();
            }
            else
            {
                lbl.Text = "Invalid input";  // Or handle the error message appropriately
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}