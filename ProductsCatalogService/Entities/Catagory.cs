using System.Collections.Generic;

namespace ProductsCatalogService.Entities
{
    public class Catagory
    {
        public int CatagoryID { get; set; }
        public string Name { get; set; }

        virtual public List<Product> Products { get; set; } = new List<Product>();
    }
}
