using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.BusinessLogic.Contract
{
    public interface IAccounting
    {
        void CreateAccount(Account account);
        Account GetAccountById(int id);
        void SaveAccount(Account account);
    }
}
