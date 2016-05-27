using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyDomain.Entities
{

    public partial class Customer
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string DayTimePhone { get; set; }

        [StringLength(50)]
        public string EmailAddress { get; set; }

    }
}
