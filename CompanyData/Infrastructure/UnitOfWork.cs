using CompanyData.Infrastructuree;
using CompanyData.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyData.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private CompanyDB dataContext;
        DatabaseFactory dbFactory;
        public UnitOfWork(DatabaseFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }
        private ICustomerRepository CustomerRepository;
        ICustomerRepository IUnitOfWork.CustomerRepository
        {
            get { return CustomerRepository ?? (CustomerRepository = new CustomerRepository(dbFactory)); }
        }
        private ICategoryRepository categoryRepository;
        ICategoryRepository IUnitOfWork.CategoryRepository
        {
            get { return categoryRepository ?? (categoryRepository = new CategoryRepository(dbFactory)); }
        }
        private IProductRepository productRepository;
        IProductRepository IUnitOfWork.ProductRepository
        {
            get { return productRepository ?? (productRepository = new ProductRepository(dbFactory)); }
        }
        protected CompanyDB DataContext
        {
            get
            {
                return dataContext ?? (dataContext = dbFactory.Get());
            }
        }
        public void Commit()
        {
            DataContext.SaveChanges();
        }
    }

}
