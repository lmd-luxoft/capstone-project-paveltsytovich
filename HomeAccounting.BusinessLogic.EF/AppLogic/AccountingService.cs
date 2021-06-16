using HomeAccounting.BusinessLogic.Contract;
using HomeAccounting.BusinessLogic.Contract.dto;
using HomeAccounting.BusinessLogic.EF.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeAccounting.BusinessLogic.EF.AppLogic
{
    public class AccountingService : IAccountingService
    {
        DomainContext _ctx;
        public AccountingService(DomainContext ctx)
        {
            _ctx = ctx;
        }
        public void CreateAccount(AccountModel account)
        {
           
            switch(account.Type)
            {
                case AccountType.Simple:
                   CreateSimpleAccount(account);
                    break;
                case AccountType.Cash:
                   CreateCash(account);
                    break;
                case AccountType.Deposit:
                    CreateDeposit(account);
                    break;
                case AccountType.Property:
                    CreateProperty(account);
                    break;
                default:
                    throw new ArgumentOutOfRangeException("bad type account");
            }
            _ctx.SaveChangesAsync();
        }

        private void CreateProperty(AccountModel account)
        {
            Property p = new Property()
            {
                Balance = account.Amount,
                CreationDate = DateTime.Now,
                Location = "Saint Peterburg",
                Title = account.Title,
                Type = (PropertyType)account.Params[0]
            };
            _ctx.Properties.Add(p);
        }

        private void CreateDeposit(AccountModel account)
        {
            Bank b = _ctx.Banks.Where(p => p.BIK == (String)account.Params[0]).FirstOrDefault();
            if (b == null)
                throw new ArgumentException("no bank with BIK");
            Deposit p = new Deposit()
            {                   
                Balance = account.Amount,
                CreationDate = DateTime.Now,
                Bank = b,
                Title = account.Title,
                Percent = (decimal)account.Params[3]
            };
            _ctx.Deposites.Add(p);
        }

        private void CreateCash(AccountModel account)
        {
            throw new NotImplementedException();
        }

        private void CreateSimpleAccount(AccountModel account)
        {
            throw new NotImplementedException();
        }
    }
}
