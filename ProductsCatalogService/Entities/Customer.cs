using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace ProductsCatalogService.Entities
{
    //[Table("Customers")]
    public class Customer : Person
    {
        public int Discount { get; set; }
    }
}