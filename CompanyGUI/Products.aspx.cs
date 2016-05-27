using CompanyDomain.Entities;
using CompanyService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CompanyGUI
{
    public partial class Products : System.Web.UI.Page
    {
        ICompanyService service = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            service = new CompanyService.CompanyService();
        }

        //Control
        //Cookie
        //QueryString
        //Session
        //-> System.Web.ModelBinding
        public IQueryable<Category> GetCategories([Control] int? minProducts)
        {
            if (minProducts.HasValue)
            {
                return service.GetAllCategories().Where(c => c.Products.Count >= minProducts.Value).AsQueryable<Category>();
            }
            else
                return service.GetAllCategories().AsQueryable<Category>();
        }

        public IQueryable<Product> GetProductsByCategory([QueryString] int? id)
        {
            if (id.HasValue)
            {
                return service.GetAllProducts().Where(p => p.CategoryId == id.Value).AsQueryable<Product>();
            }
            else
                return null;
        }
    }
}