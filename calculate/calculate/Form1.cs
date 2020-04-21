using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculate
{
    public partial class Form1 : Form
    {
        string operation,value_string;
        double value=0, result_value=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            value_string = value_string + b.Text;
            textBox_Result.Text = textBox_Result.Text + b.Text;
            
        }

        private void textBox_Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculator_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Cal(value_string);
            textBox_Result.Text = result_value.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            result_value = 0;
            value_string = "";
            textBox_Result.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            value_string = "";
        }

        private void Formula(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (value_string != ""){
                Cal(value_string);
            }
            operation = b.Text;
            textBox_Result.Text = textBox_Result.Text + b.Text;
            //value_string = "";

        }

        private void Cal(string a)
        {
            double valuetest1=0;
            valuetest1 = Double.Parse(a);

            switch (operation)
            {
                case "+":
                 result_value = result_value + valuetest1;
                    break;
                case "-":
                    result_value = result_value - valuetest1;
                    break;
                case "*":
                    result_value = result_value * valuetest1;
                    break;
                case "/":
                    result_value = result_value / valuetest1;
                    break;
                default:
                    result_value = valuetest1;
                    break;
            }
            value_string = "";
        }

    }
}
