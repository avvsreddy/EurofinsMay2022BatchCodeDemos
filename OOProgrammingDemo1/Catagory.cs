using System.Collections.Generic;

namespace OOProgrammingDemo1
{
    class Catagory
    {
        public int CatagoryId { get; set; }
        public string Name { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();
    }
}
