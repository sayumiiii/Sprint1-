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
            label4.Text = "";
            string txt = textBox1.Text;
            char[] array = txt.ToCharArray();
            Array.Reverse(array);
            string txtResult = new string(array);
            label4.Text = txtResult;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try 
            {
             label3.Text = "";
            int value = int.Parse(textBox1.Text);
            string binary = Convert.ToString(value, 2);
            label4.Text = binary;
            }
            catch
            {
                labelError.Text = "please enter a numeric";
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            labelError.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            textBox1.Text = textBox1.Text;
            label5.Text = textBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            textBox1.Text = textBox1.Text;
            label6.Text = textBox1.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.White;
            this.BackColor = Color.FromArgb(32, 32, 32);
            button1.ForeColor = Color.Black;
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            button4.ForeColor = Color.Black;
            button5.ForeColor = Color.Black;
            groupBox1.ForeColor = Color.White;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.Black;
            this.BackColor = Color.White;
            button1.ForeColor = Color.Black;
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            button4.ForeColor = Color.Black;
            button5.ForeColor = Color.Black;
            groupBox1.ForeColor = Color.Black;
        }
    }
}
