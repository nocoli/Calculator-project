using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        double? number;
        string operation;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("1");
            long temp = Convert.ToInt64(textBox1.Text);
            textBox1.Text = temp.ToString();
        }

        private void bclear_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text = "0";
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("2");
            long temp = Convert.ToInt64(textBox1.Text);
            textBox1.Text = temp.ToString();
        }

        private void bdot_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("."))
            {

            }
            else {
                textBox1.AppendText(".");
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("3");
            long temp = Convert.ToInt64(textBox1.Text);
            textBox1.Text = temp.ToString();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("4");
            long temp = Convert.ToInt64(textBox1.Text);
            textBox1.Text = temp.ToString();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("5");
            long temp = Convert.ToInt64(textBox1.Text);
            textBox1.Text = temp.ToString();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("6");
            long temp = Convert.ToInt64(textBox1.Text);
            textBox1.Text = temp.ToString();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("7");
            long temp = Convert.ToInt64(textBox1.Text);
            textBox1.Text = temp.ToString();
        }

        private void b8_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("8");
            long temp = Convert.ToInt64(textBox1.Text);
            textBox1.Text = temp.ToString();
        }

        private void b9_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("9");
            long temp = Convert.ToInt64(textBox1.Text);
            textBox1.Text = temp.ToString();
        }

        private void b0_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("0");
            long temp = Convert.ToInt64(textBox1.Text);
            textBox1.Text = temp.ToString();
        }

        private void bplus_Click(object sender, EventArgs e)
        {
            number = Convert.ToInt64(textBox1.Text);
            textBox1.Text = "0";
            operation = "plus";
        }

        private void bequals_Click(object sender, EventArgs e)
        {
            if (operation == "plus")
            {
                textBox1.Text = (number + (Convert.ToInt64(textBox1.Text))).ToString();
            }
            if (operation == "minus")
            {
                textBox1.Text = (number - (Convert.ToInt64(textBox1.Text))).ToString();
            }
            if (operation == "multiply")
            {
                textBox1.Text = (number * (Convert.ToInt64(textBox1.Text))).ToString();
            }
            if (operation == "divide")
            {
                textBox1.Text = (number / (Convert.ToInt64(textBox1.Text))).ToString();
            }
        }

        private void bminus_Click(object sender, EventArgs e)
        {
            number = Convert.ToInt64(textBox1.Text);
            textBox1.Text = "0";
            operation = "minus";
        }

        private void btimes_Click(object sender, EventArgs e)
        {
            number = Convert.ToInt64(textBox1.Text);
            textBox1.Text = "0";
            operation = "multiply";
        }

        private void bdivide_Click(object sender, EventArgs e)
        {
            number = Convert.ToInt64(textBox1.Text);
            textBox1.Text = "0";
            operation = "divide";
        }

        private void bcleareverything_Click(object sender, EventArgs e)
        {
            number = null;
            operation = null;
            textBox1.Text = "0";

        }
    }
}
