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

            // set this to true so we can read key press inputs
            this.KeyPreview = true;
            SetStyle(ControlStyles.Selectable, false);

            this.Select();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Select();
        }

        // MOUSE click

        private void MouseClick(object sender, EventArgs e)
        {
            this.Select();
            textBox1.AppendText("99");
            this.Focus();
            this.Form1_Load(sender, e);
            //b1.Select();
            //b1.Focus();
        }

        private void MouseUpUp(object sender, MouseEventArgs e)
        {
            this.Select();
            textBox1.AppendText("99");
            this.Focus();
            this.Form1_Load(sender, e);
            b1.Select();
            b1.Focus();
            //Calculator.Form1.ActiveForm.Focus();
            //Calculator.Form1.ActiveForm.Select();
            //textBox1.Focus();
            //textBox1.Select();
        }

        // NUMBER Buttons press

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("1");
            long temp = Convert.ToInt64(textBox1.Text);
            textBox1.Text = temp.ToString();
            distraction.Select();
        }

        private void bclear_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text = "0";
            }
            distraction.Select();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("2");
            long temp = Convert.ToInt64(textBox1.Text);
            textBox1.Text = temp.ToString();
            //b1.Select();
            //b1.Focus();
            //textBox1.Select();
            distraction.Select();
        }


        private void b3_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("3");
            long temp = Convert.ToInt64(textBox1.Text);
            textBox1.Text = temp.ToString();
            //b1.Select();
            //b1.Focus();
            //textBox1.Focus();
            distraction.Select();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("4");
            long temp = Convert.ToInt64(textBox1.Text);
            textBox1.Text = temp.ToString();
            distraction.Select();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("5");
            long temp = Convert.ToInt64(textBox1.Text);
            textBox1.Text = temp.ToString();
            distraction.Select();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("6");
            long temp = Convert.ToInt64(textBox1.Text);
            textBox1.Text = temp.ToString();
            distraction.Select();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            
            textBox1.AppendText("7");
            long temp = Convert.ToInt64(textBox1.Text);
            textBox1.Text = temp.ToString();
            distraction.Select();
        }

        private void b8_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("8");
            long temp = Convert.ToInt64(textBox1.Text);
            textBox1.Text = temp.ToString();
            distraction.Select();
        }

        private void b9_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("9");
            long temp = Convert.ToInt64(textBox1.Text);
            textBox1.Text = temp.ToString();
            distraction.Select();
        }

        private void b0_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("0");
            long temp = Convert.ToInt64(textBox1.Text);
            textBox1.Text = temp.ToString();
            distraction.Select();
        }

        // OPERATOR Buttons press

        private void bdot_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("."))
            {

            }
            else {
                textBox1.AppendText(".");
            }

            distraction.Select();
        }

        private void bplus_Click(object sender, EventArgs e)
        {
            number = Convert.ToInt64(textBox1.Text);
            textBox1.Text = "0";
            operation = "plus";
            distraction.Select();
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

            distraction.Select();
        }

        private void bminus_Click(object sender, EventArgs e)
        {
            number = Convert.ToInt64(textBox1.Text);
            textBox1.Text = "0";
            operation = "minus";

            distraction.Select();
        }

        private void btimes_Click(object sender, EventArgs e)
        {
            number = Convert.ToInt64(textBox1.Text);
            textBox1.Text = "0";
            operation = "multiply";

            distraction.Select();
        }

        private void bdivide_Click(object sender, EventArgs e)
        {
            number = Convert.ToInt64(textBox1.Text);
            textBox1.Text = "0";
            operation = "divide";

            distraction.Select();
        }

        private void bcleareverything_Click(object sender, EventArgs e)
        {
            number = null;
            operation = null;
            textBox1.Text = "0";

            distraction.Select();

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            


            // test to get buttons working
            MessageBox.Show("Form.KeyPress: '" +
                    e.KeyChar.ToString() + "' pressed.");
                    

            switch(e.KeyChar.ToString())
            {
                // NUMBERS //
                case "1":
                    button7_Click(sender, e);
                    //b1.Focus();
                    this.Form1_Load(sender, e);
                    break;
                case "2":
                    b2_Click(sender, e);
                    break;
                case "3":
                    b3_Click(sender, e);
                    break;
                case "4":
                    b4_Click(sender, e);
                    break;
                case "5":
                    b5_Click(sender, e);
                    break;
                case "6":
                    b6_Click(sender, e);
                    break;
                case "7":
                    //b7_Click(sender, e);
                    break;
                case "8":
                    b8_Click(sender, e);
                    break;
                case "9":
                    b9_Click(sender, e);
                    break;
                case "0":
                    b0_Click(sender, e);
                    break;

                // OPERATORS //
                case "/":
                    bdivide_Click(sender, e);
                    break;
                case "*":
                    btimes_Click(sender, e);
                    break;
                case "-":
                    bminus_Click(sender, e);
                    break;
                case "+":
                    bplus_Click(sender, e);
                    break;
                case ".":
                    bdot_Click(sender, e);
                    break;
            }

            distraction.Select();

        }

        private void setFocusAway()
        {
            distraction.Select();
        }

        private void setFocusAway(object sender, KeyEventArgs e)
        {
            distraction.Select();
        }
    }
}
