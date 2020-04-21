using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int row = (int)Rowchooser.Value;    //Decimal 換用到int的地方需要經過強制轉換; 數字通常可以直接這樣用
            string result = "";

            for (int i = 1; i <= row; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    result = result + "*";
                }
                result = result + "\n";
            }

            MessageBox.Show(result);
        }
    }
}
