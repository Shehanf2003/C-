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
    public partial class Form2 : Form
    {
        public string Name { get; set; }
        public string Username {  get; set; }
        public string Email { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label4.Text = Name;
            label5.Text = Username;
            label6.Text = Email;
        }
    }
}
