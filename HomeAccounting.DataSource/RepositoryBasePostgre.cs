using Dapper;
using HomeAccounting.DataSource.Contract;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace HomeAccounting.DataSource
{
    public class RepositoryBasePostgre : IRepository
    {
        private readonly String _connectionString = "Host=localhost; Username=postgres; Password=qwerty; Database=postgres";

        public void AddAccount(DBAccount account)
        {
            using(Npgsql.NpgsqlConnection db = new Npgsql.NpgsqlConnection(_connectionString) )
            {
                db.Execute("INSERT INTO accounts (creationdate,title) VALUES(@CreationDate,@Title)", account);
            }
        }

        public DBAccount GetAccoutById(int id)
        {
            using (Npgsql.NpgsqlConnection db = new Npgsql.NpgsqlConnection(_connectionString))
            {
                DBAccount account = db.Query<DBAccount>($"SELECT * FROM accounts WHERE id = {id}").FirstOrDefault();
                return account;
            }
        }
    }
}
