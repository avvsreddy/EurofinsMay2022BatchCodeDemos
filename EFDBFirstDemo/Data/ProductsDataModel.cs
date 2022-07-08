using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EFDBFirstDemo.Data
{
    public partial class ProductsDataModel : DbContext
    {
        //public ProductsDataModel()
        //    : base("name=ProductsDataModel")
        //{
        //}

        public virtual DbSet<Product> Products { get; set; }

       
    }
}
