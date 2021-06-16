using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.BusinessLogic.EF.Domain
{
    public class Deposit : Account
    {
        public string NumberOfBankAccount
        {
            get => default;
            set
            {
            }
        }

        public decimal Percent
        {
            get => default;
            set
            {
            }
        }

        public PercentType Type
        {
            get => default;
            set
            {
            }
        }

        public Bank Bank
        {
            get => default;
            set
            {
            }
        }

        public static implicit operator Deposit(Deposit v)
        {
            throw new NotImplementedException();
        }
    }
}