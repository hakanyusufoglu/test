using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datetimepicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime secilendeger = dateTimePicker1.Value;
            //textBox1.Text = secilendeger.ToLongDateString();
            //yada 
            textBox1.Text = dateTimePicker1.Value.ToLongDateString();
        }
    }
}
