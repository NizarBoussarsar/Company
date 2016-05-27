using CompanyData.Infrastructure;
using CompanyDomain;
using CompanyDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyData.Repositories
{
    
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(DatabaseFactory dbFactory)
            : base(dbFactory)
        {

        }
    }
    public interface IProductRepository : IRepository<Product> { }
}
