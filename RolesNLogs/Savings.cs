﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolesNLogs
{
    class Savings : Client
    {
        //fields
        private int interestSavings;
        private int minBalance;
        private int timesWithdrawn;

        //properties
        public int Interest2
        {
            get { return this.interestSavings; }
        }
        private int TimesWithdrawn
        {
            get { return this.timesWithdrawn; }
        }
        //constructors
        public Savings(double balance) : base()
        {
            interestSavings = 10;
            this.balance = balance;
            accountType = "Savings Account";

        }
    }
}
