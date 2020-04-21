using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Count
{
    public partial class Form1 : Form
    {
        int times = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            times += 1;
            TimesLabel.Text = "您已經按了..." + times.ToString() + "下";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            times = 0;
            TimesLabel.Text = "您已經按了..." + times.ToString() + "下";
        }
    }
}
