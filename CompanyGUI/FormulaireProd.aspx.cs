using CompanyDomain.Entities;
using CompanyService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CompanyGUI
{
    public partial class FormulaireProd : System.Web.UI.Page
    {
        ICompanyService service = null;
        protected System.Web.UI.WebControls.FileUpload FileUpload1;

        protected void Page_Load(object sender, EventArgs e)
        {
            service = new CompanyService.CompanyService();
        }

        protected void InsertButton_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
                try
                {
                    string fn = System.IO.Path.GetFileName(FileUpload1.FileName);
                    string SaveLocation = Server.MapPath("~/Content/Upload") + "\\" + fn;
                    FileUpload1.SaveAs(SaveLocation);
                    Response.Write("The file has been uploaded.");                 
                    //FileUpload1.SaveAs("C:\\Uploads\\" +
                    //     FileUpload1.FileName);
                    //Label1.Text = "File name: " +
                    //     FileUpload1.PostedFile.FileName + "<br>" +
                    //     FileUpload1.PostedFile.ContentLength + " kb<br>" +
                    //     "Content type: " +
                    //     FileUpload1.PostedFile.ContentType;
                }
                catch (Exception ex)
                {
                    Response.Write("Error: " + ex.Message);
                }
            else
            {
                Response.Write("eheeeeeeeeein");
            }
        }


        //    protected void InsertButton_Click(object sender, EventArgs e)
        //    {
        //        Product product = new Product();
        //        if ((File1.PostedFile != null) && (File1.PostedFile.ContentLength > 0))
        //        {
        //            string fn = System.IO.Path.GetFileName(File1.PostedFile.FileName);
        //            string SaveLocation = Server.MapPath("~/Content/Upload") + "\\" + fn;
        //            try
        //            {
        //                product.ProductName = ProductNameTextBox.Value;
        //                product.Description = DescriptionTextBox.Value;
        //                product.ImagePath = fn;
        //                product.UnitPrice = decimal.Parse(UnitPriceTextBox.Value);
        //                service.AddProoduct(product);
        //                File1.PostedFile.SaveAs(SaveLocation);
        //                Response.Write("The file has been uploaded.");
        //            }
        //            catch (Exception ex)
        //            {
        //                Response.Write("Error: " + ex.Message);
        //            }
        //        }
        //        else
        //        {
        //            Response.Write("Error: ");
        //        }
        //    }
        //}
    }
}