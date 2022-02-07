using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Murder_Mystery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text;
            textBox1.Text = label3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text;

            
            string txt = textBox1.Text;
            char[] array = txt.ToCharArray();
            Array.Reverse(array);
            string txtResult = new string(array);
            label4.Text = txtResult;
        }
    }
}
