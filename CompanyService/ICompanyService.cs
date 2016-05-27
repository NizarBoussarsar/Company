using CompanyDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyService
{
    public interface ICompanyService
    {
        void AddCustomer(Customer customer);
        void AddProoduct(Product product);
        void AddCategory(Category category);
        void Save();
        List<Category> GetAllCategories();
        List<Product> GetAllProducts();
        List<Product> GetProductsByCategory(int idCategory);
    }
}
