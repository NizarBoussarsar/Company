using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CompanyDomain.Entities
{
    public partial class Product
    {
        public int ProductId { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        //[DataType(DataType.ImageUrl)]
        [StringLength(50)]
        public string ImagePath { get; set; }

        public decimal? UnitPrice { get; set; }

        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
