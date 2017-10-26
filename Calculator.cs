﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Everyday
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text; 
        }
        double a = 0, b = 0, c = 0;
        char znac = '+';

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                if (textBox1.Text[0] == '-')
                    textBox1.Text = textBox1.Text.Remove(0, 1);
                else
                    textBox1.Text = '-' + textBox1.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            znac = (sender as Button).Text[0];
            textBox1.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);
            switch(znac)
            {
                case '+' : c = a + b;
                    break;
                case '-' : c = a - b;
                    break;
                case '*' : c = a * b;
                    break;
                case '/' : c = a / b;
                    break;
            }
            textBox1.Text = c.ToString();
        }


    }
}
