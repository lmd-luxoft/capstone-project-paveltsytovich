﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.BusinessLogic.EF.Domain
{
    public class Cash : Account
    {
        public int Banknotes
        {
            get => default;
            set
            {
            }
        }

        public int Monets
        {
            get => default;
            set
            {
            }
        }
    }
}