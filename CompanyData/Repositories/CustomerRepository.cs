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
  
   public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
   {
       public CustomerRepository(DatabaseFactory dbFactory)
           : base(dbFactory)
       {

       }
   }
   public interface ICustomerRepository : IRepository<Customer> { }
}
