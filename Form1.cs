using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        string operation = "";
        double result = 0;
        bool isoperation = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button zero = (Button)sender;
            if (textBox1.Text == "0" || isoperation == true ) { textBox1.Clear(); }
            if (zero.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text = textBox1.Text + zero.Text;
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + zero.Text;  
            }
            isoperation = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button zero = (Button)sender;
            operation = zero.Text;
            result=double.Parse (textBox1.Text);
            isoperation = true;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "+":
                    textBox1.Text = (result + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (result * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    if (double.Parse(textBox1.Text).ToString() == "0")
                    {
                        textBox1.Text = (result / double.Parse(textBox1.Text)).ToString();
                        MessageBox.Show("Math Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Text = "Math Error";
                        result = 0;
                    }
                    else
                        textBox1.Text = (result / double.Parse(textBox1.Text)).ToString();
                        break;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            result = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
