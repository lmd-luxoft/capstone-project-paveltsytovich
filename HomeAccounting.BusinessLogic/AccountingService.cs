using HomeAccounting.BusinessLogic.Contract;
using HomeAccounting.DataSource.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.BusinessLogic
{
    public class AccountingService : IAccounting
    {
        private IRepository _repo;
        public AccountingService(IRepository repo)
        {
            _repo = repo;
        }
        public void CreateAccount(Account account)
        {
            //Business logic for implement functions...
            DBAccount dto = MapFromEntityToDto(account);
            _repo.AddAccount(dto);
        }

        private static DBAccount MapFromEntityToDto(Account account)
        {
            DBAccount dto = new DBAccount();
            //mapping from Entity to dto
            dto.Id = account.Id;
            dto.Title = account.Title;
            dto.CreationDate = account.CreationDate;
            return dto;
        }

        public Account GetAccountById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveAccount(Account account)
        {
            throw new NotImplementedException();
        }
    }
}
