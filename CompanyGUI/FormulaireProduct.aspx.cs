using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using CompanyService;
using CompanyDomain.Entities;


namespace CompanyGUI
{
    public partial class FormulaireProduct : System.Web.UI.Page
    {

        ICompanyService service = null;
        protected System.Web.UI.HtmlControls.HtmlInputFile File1;
        protected System.Web.UI.HtmlControls.HtmlInputButton Submit1;

        protected void Page_Load(object sender, EventArgs e)
        {
            service = new CompanyService.CompanyService();
        }

        #region Web Form Designer generated code
        override protected void OnInit(EventArgs e)
        {
            // 
            // CODEGEN: This call is required by the ASP.NET Web Form Designer.
            // 
            InitializeComponent();
            base.OnInit(e);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Submit1.ServerClick += new System.EventHandler(this.Submit1_ServerClick);
            this.Load += new System.EventHandler(this.Page_Load);
        }
        #endregion

        protected void Submit1_ServerClick(object sender, EventArgs e)
        {
            Product product = new Product();
            if ((File1.PostedFile != null) && (File1.PostedFile.ContentLength > 0))
            {
                string fn = System.IO.Path.GetFileName(File1.PostedFile.FileName);
                string SaveLocation = Server.MapPath("~/Content/Upload") + "\\" + fn;
                try
                {
                    product.ProductName = ProductName.Value;
                    product.Description = Description.Value;
                    product.ImagePath = fn;
                    product.UnitPrice = decimal.Parse(UnitPrice.Value);
                    service.AddProoduct(product);
                    File1.PostedFile.SaveAs(SaveLocation);
                    Response.Write("The file has been uploaded.");
                }
                catch (Exception ex)
                {
                    Response.Write("Error: " + ex.Message);
                }
            }
            else
            {
                Response.Write("Please select a file to upload.");
            }
        }

    }
}