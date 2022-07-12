using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsCatalogService.Entities
{
    //[Table("Suppliers")]
    public class Supplier : Person
    {
        // public int SupplierID { get; set; }
        // public string Name { get; set; }
        public int Rating { get; set; }
        virtual public List<Product> Products { get; set; } = new List<Product>();
    }
}
