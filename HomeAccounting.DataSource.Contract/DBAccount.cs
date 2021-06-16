using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.DataSource.Contract
{
    public class DBAccount
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public String Title { get; set; }
    }
}
