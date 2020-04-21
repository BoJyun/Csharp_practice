using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Order
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 填入銷售項目到菜單中
            DataGridViewRowCollection rows = dataGridViewMenu.Rows;
            rows.Add(new Object[] { "紅茶", 25 });
            rows.Add(new Object[] { "綠茶", 25 });
            rows.Add(new Object[] { "奶茶", 30 });
            rows.Add(new Object[] { "珍珠奶茶", 35 });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 選取某項目，將該項目的品名價格放入待購項目中。
            if (dataGridViewMenu.Rows[e.RowIndex].Cells[0].Value == null)
                return;
            buttonName.Text = dataGridViewMenu.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxPrice.Text = dataGridViewMenu.Rows[e.RowIndex].Cells[1].Value.ToString();
            numericUpDownNumber.Value = 1;
            //textBoxTotal.Text = null;
        }

        private void numericUpDownNumber_ValueChanged(object sender, EventArgs e)
        {
            calculate();
        }

        String name;
        double price;
        double number;
        double sumtotal;
    
        private void calculate()
        {
             name = buttonName.Text;
             price = double.Parse(textBoxPrice.Text);
             number = (double)numericUpDownNumber.Value;
             sumtotal = price * number;
             textBoxTotal.Text = sumtotal.ToString();
        }

        private void textBoxTotal_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            calculate();
            dataGridViewOrder.Rows.Add(new Object[] {name, price, number, sumtotal });
            //textBoxTotal.Text = null;
            //numericUpDownNumber.Value = 1;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void calculatetotal()
        {
            double sum = 0.0;
            for (int i = 0; i < dataGridViewOrder.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridViewOrder.Rows[i]; //和前面 DataGridViewRow使用不一樣
                if (row.Cells[0].Value != null)
                    sum = sum + (double)row.Cells[3].Value;
            }
            textBox3Total.Text = sum.ToString();
        }

        private void button3Total_Click(object sender, EventArgs e)
        {
            calculatetotal();
        }
    }
}
