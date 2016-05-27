using CompanyDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CompanyGUI
{
    public partial class FormulaireCustomer : System.Web.UI.Page
    {
        CompanyService.CompanyService service = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            service = new CompanyService.CompanyService();
            FirstName.Enabled = false;
            LastName.Enabled = false;
            Age.Enabled = false;
            CompanyName.Enabled = true;
            CompanyManager.Enabled = true;
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                FirstName.Enabled = true;
                LastName.Enabled = true;
                Age.Enabled = true;
                CompanyName.Enabled = false;
                CompanyManager.Enabled = false;
            }
            else
            {
                FirstName.Enabled = false;
                LastName.Enabled = false;
                Age.Enabled = false;
                CompanyName.Enabled = true;
                CompanyManager.Enabled = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                //Button1.ValidationGroup = "VGPerson";
                Person person = new Person();
                person.DayTimePhone = DayTimePhone.Text;
                person.EmailAddress = EmailAddress.Text;

                //On utilise as pour caster deux objets qui ont une relation d'héritage
                person.Age = Convert.ToInt32(Age.Text);

                //Ou bien on instancie la classe Fullname dans le constructeur de la classe Personne

                //Ou bien on instancie la classe Fullname dans l'action du click du bouton et on l'affecte à la propriété FullName de la classe Personne, comme suite:

                //FullName f = new FullName();
                //f.FirstName = FirstName.Text;
                //f.LastName = LastName.Text;
                //person.Fullname = f;

                person.Fullname.FirstName = FirstName.Text;
                person.Fullname.LastName = LastName.Text;
                service.AddCustomer(person);
            }
            else
            {
                //Button1.ValidationGroup = "VGCompany";
                Entreprise entreprise = new Entreprise();
                entreprise.DayTimePhone = DayTimePhone.Text;
                entreprise.EmailAddress = EmailAddress.Text;
                entreprise.CompanyManager = CompanyManager.Text;
                entreprise.CompanyName = CompanyName.Text;
                service.AddCustomer(entreprise);
            }
            service.Save();
        }


    }
}