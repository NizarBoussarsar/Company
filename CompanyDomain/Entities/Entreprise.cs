﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyDomain.Entities
{
    public class Entreprise : Customer
    {
        [StringLength(50)]
        public string CompanyName { get; set; }

        [StringLength(50)]
        public string CompanyManager { get; set; }
    }
}
