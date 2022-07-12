using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsCatalogService.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public int Cost { get; set; }
        public bool InStock { get; set; }
        virtual public Catagory Catagory { get; set; }
        virtual public List<Supplier> Suppliers { get; set; } = new List<Supplier>();
    }
}
