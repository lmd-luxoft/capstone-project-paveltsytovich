using HomeAccounting.BusinessLogic;
using HomeAccounting.BusinessLogic.Contract;
using HomeAccounting.BusinessLogic.EF.AppLogic;
using HomeAccounting.DataSource;
using HomeAccounting.DataSource.Contract;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.CompositionRoot
{
    public class AspNetApplicationBuilder : AbstractApplicationBuilder
    {
        public AspNetApplicationBuilder(IServiceCollection service) : base(service)
        {

        }
        protected override void RegisterBusinessLogic()
        {
            _services.AddTransient<IAccounting, AccountingService>();
        }

        protected override void RegisterDataSource()
        {
            _services.AddTransient<IRepository, RepositoryBasePostgre>();
            _services.AddDbContext<DomainContext>();
        }

        protected override void RegisterInfrastructure()
        {
            
        }
    }
}
