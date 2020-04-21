using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BorrowAndRepay
{
    class Person
    {
        public string Name;
        public int Money;

        public Person(string inputname,int inputmoney)
        {
            this.Name = inputname;
            this.Money = inputmoney;
        }

        public void borrow(Person lender,int money)
        {
                lender.Money -= money;
                this.Money += money;
        }

        public void repay(Person lender,int money)
        {

            lender.Money += money;
            this.Money -= money;
        }
    }
}
