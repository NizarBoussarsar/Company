using CompanyData.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyData.Infrastructuree
{
    public interface IUnitOfWork
    {
        void Commit();
        ICustomerRepository CustomerRepository { get; }
        IProductRepository ProductRepository { get; }
        ICategoryRepository CategoryRepository { get; }
    }

}
