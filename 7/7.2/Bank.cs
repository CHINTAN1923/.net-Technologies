using System;
namespace Bank{
   class BankCustomer
    {
        public int accno;
        public string acname;
        public double bankbalance;
        public BankCustomer(int acno,string acname,double bb)
        {
            this.accno = acno;
            this.acname=acname;
            this.bankbalance=bb;
        }
    }
    public delegate void BalanceChecker(double n);
}