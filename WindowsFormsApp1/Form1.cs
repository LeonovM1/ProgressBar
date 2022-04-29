using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((progressBar1.Value + 5 <= 100) && (textBox1.Text != ""))
            {
                progressBar1.Value += 5;
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + 5);
            }
            if (progressBar1.Value + 5 > 100) //99+5 = 100(не работает)
            {
                progressBar1.Value = 100;
                textBox1.Text = "100";
            }
            if (textBox1.Text == "")
            {
                textBox1.Text = Convert.ToString(5);
            }
        }
        private void button1_Click(object sender, EventArgs e) 
        {
            if (progressBar1.Value - 5 >= 0)
            {
                progressBar1.Value -= 5;
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) - 5);
            }
            if (progressBar1.Value - 5 < 0) 
            {
                progressBar1.Value = 0;
                textBox1.Text = "0";
            }
        }

        private void button3_Click(object sender, EventArgs e) 
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Введите значение: ";
        }

        private void textBox1_TextChanged(object sender, EventArgs e) 
        {
            if (textBox1.Text != "")
            {
                if (Convert.ToInt32(textBox1.Text) >= 0 && Convert.ToInt32(textBox1.Text) <= 100)
                {
                    progressBar1.Value = Convert.ToInt32(textBox1.Text);
                }
                if (Convert.ToInt32(textBox1.Text) > 100)
                {
                    progressBar1.Value = 100;
                }
                if (Convert.ToInt32(textBox1.Text) > 100)
                {
                    textBox1.Text = "100";
                }
            }
            if (textBox1.Text == "")
            {
                progressBar1.Value = 0;
            }


        }

    }
}
