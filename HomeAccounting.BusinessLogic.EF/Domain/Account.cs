using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.BusinessLogic.EF.Domain
{
    public class Account : Entity
    {
        public System.DateTime CreationDate
        {
            get => default;
            set
            {
            }
        }

        public string Title
        {
            get => default;
            set
            {
            }
        }

        public decimal Balance
        {
            get => default;
            set
            {
            }
        }
    }
}