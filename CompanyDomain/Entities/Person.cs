using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyDomain.Entities
{
    public class Person : Customer
    {
        public Person()
        {
            Fullname = new FullName();
        }

        public FullName Fullname { get; set; }
        public int? Age { get; set; }
    }
}
