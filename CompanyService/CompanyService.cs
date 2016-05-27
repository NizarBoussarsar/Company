using CompanyData.Infrastructure;
using CompanyData.Infrastructuree;
using CompanyDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyService
{
    public class CompanyService : ICompanyService
    {
        static DatabaseFactory dbFactory = new DatabaseFactory();
        IUnitOfWork utOfWork = new UnitOfWork(dbFactory);

        public void AddCustomer(Customer customer)
        {
            utOfWork.CustomerRepository.Add(customer);
        }

        public void AddProoduct(Product product)
        {
            utOfWork.ProductRepository.Add(product);
            Save();
        }

        public void AddCategory(Category category)
        {
            utOfWork.CategoryRepository.Add(category);
            // on a jouté save pour qu'on puisse tester l'ajout a partir du formulaire (1ere methode)
            Save();
        }

        public void Save()
        {
            utOfWork.Commit();
        }

        public List<Category> GetAllCategories()
        {
            return utOfWork.CategoryRepository.GetAll().ToList();
        }

        public List<Product> GetAllProducts()
        {
            return utOfWork.ProductRepository.GetAll().ToList();
        }

        public List<Product> GetProductsByCategory(int idCategory)
        {
            return utOfWork.ProductRepository.GetMany(p => p.CategoryId.Equals(idCategory)).ToList();
        }
    }
}
