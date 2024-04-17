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
        private string operation = "";
        private double result_Value = 0;
        private bool is_operation_perfromed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        

        private void button_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0" || is_operation_perfromed)
            {
                textBox1.Clear();
            }
            Button btn = (Button)sender;
            if(btn.Text == ".")
            {
                if(!textBox1.Text.Contains("."))
                {
                    textBox1.Text = textBox1.Text + btn.Text;
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + btn.Text;
            }
           
            is_operation_perfromed = false;
        }

        private void op(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operation = btn.Text;
            result_Value = double.Parse(textBox1.Text);
            label1.Text = operation + result_Value;
            is_operation_perfromed = true;
         }

        

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                switch (operation)
                {
                    case "+":
                        textBox1.Text = (result_Value + double.Parse(textBox1.Text)).ToString();
                        break;
                    case "-":
                        textBox1.Text = (result_Value - double.Parse(textBox1.Text)).ToString();
                        break;
                    case "*":
                        textBox1.Text = (result_Value * double.Parse(textBox1.Text)).ToString();
                        break;
                    case "/":
                        double divisor = double.Parse(textBox1.Text);
                        if (divisor == 0)
                        {
                            throw new DivideByZeroException("Cannot Divide By Zero");
                        }
                        textBox1.Text = (result_Value / double.Parse(textBox1.Text)).ToString();
                        break;
                    default:
                        throw new DivideByZeroException("Unsupported operation");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input.Please enter valid numeric input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


             
                label1.Text = "";
            

        }
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
        }
    }
}
