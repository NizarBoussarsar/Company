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
    
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(DatabaseFactory dbFactory)
            : base(dbFactory)
        {

        }
    }
    public interface ICategoryRepository : IRepository<Category> { }
}
