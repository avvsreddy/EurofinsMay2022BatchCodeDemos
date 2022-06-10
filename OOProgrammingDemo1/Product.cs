namespace OOProgrammingDemo1
{
    class Product // Entity Class
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Brand { get; set; }
        public bool InStock { get; set; }

        public Catagory TheCatagory { get; set; }
    }
}
