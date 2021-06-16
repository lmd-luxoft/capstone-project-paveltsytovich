﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.DataSource.Contract
{
    public interface IRepository
    {
        void AddAccount(DBAccount account);

        DBAccount GetAccoutById(int id);
    }
}
