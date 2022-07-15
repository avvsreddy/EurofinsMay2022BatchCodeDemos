using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoolProductsService.Models.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string Catagory { get; set; }

    }
}