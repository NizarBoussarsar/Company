using CompanyData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyData.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private CompanyDB dataContext = null;
        public CompanyDB Get()
        {
            return dataContext ?? (dataContext = new CompanyDB());
        }
        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }

}
