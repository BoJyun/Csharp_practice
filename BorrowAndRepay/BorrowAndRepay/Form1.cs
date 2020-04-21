using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BorrowAndRepay
{
    public partial class Form1 : Form
    {
        Person Me, Friend;

        public Form1()
        {
            InitializeComponent();
        }

        private void Borrowbtn_Click(object sender, EventArgs e)
        {
            if (Friend.Money >0)
            {
                Me.borrow(Friend, 1000);
                updateMoney();
            }
            else
            {
                MessageBox.Show(Friend.Name+"沒錢借"+Me.Name+"了");
            }
        }

        private void Repaybtn_Click(object sender, EventArgs e)
        {
            if (Me.Money > 0)
            {
                Me.repay(Friend, 1000);
                updateMoney();
            }
            else
            {
                MessageBox.Show(Me.Name+"沒錢還"+Friend.Name+"了");
            }
        }

        private void updateMoney()
        {
            MymoneyLbel.Text = Me.Money.ToString();
            FriendmoneyLabel.Text = Friend.Money.ToString();
        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            Me = new Person(Mynameinput.Text, 0);
            Friend = new Person(Friendnameinput.Text, 20000);

            mynameLabel2.Text = Me.Name;
            FriendnameLabel2.Text = Friend.Name;

            Mynameinput.Enabled = false;
            Friendnameinput.Enabled = false;
            Submitbtn.Enabled = false;  
            Borrowbtn.Enabled = true;
            Repaybtn.Enabled = true;

            Borrowbtn.Text = "跟" + Friend.Name + "借1000$";
            Repaybtn.Text = "還給" + Friend.Name + "1000$";
        }
    }
}
