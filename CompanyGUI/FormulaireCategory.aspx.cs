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
    public partial class Formulaire : System.Web.UI.Page
    {
        ICompanyService service = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            service = new CompanyService.CompanyService();
        }
        
    }
}