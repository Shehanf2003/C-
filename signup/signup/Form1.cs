using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace signup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox4.Text != textBox5.Text)
            {
                MessageBox.Show("Password and Confirm Password do not match.");
                return;
            }
            if(
                string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(textBox4.Text) ||
                string.IsNullOrEmpty(textBox5.Text) ||
                string.IsNullOrEmpty(dateTimePicker1.Text))
            {
                MessageBox.Show("Please fill the all fild ");
                return;
            }
            if(
                !IsString(textBox1.Text)||
                !IsString(textBox2.Text)||
                !IsString(textBox3.Text))
            {
                MessageBox.Show("Please enter the string valus");
                return;
            }
            var form2 = new Form2()
            {
                Name = textBox1.Text,
                Username = textBox3.Text,
                Email = textBox4.Text


            };
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            
        }

        private bool IsString (string text)
        {
          foreach (char c in text)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                } 
            }
          return true;
        }
    }
}
