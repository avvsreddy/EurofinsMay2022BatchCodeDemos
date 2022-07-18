using CoolProductsService.Models.Data;
using CoolProductsService.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CoolProductsService.Controllers
{
    public class CoolProductsController : ApiController
    {
        private CoolProductsDbContext db = new CoolProductsDbContext();
        
        // GET ..../api/coolproducts
        
        //[HttpGet]
        public List<Product> GetProducts()
        {
            return db.Products.ToList();
        }

        // GET ..../api/coolproducts/1
        public IHttpActionResult GetProducts(int id)
        {
            Product p =  db.Products.Find(id);
            if( p == null)
            {
                // 404
                return NotFound();
            }
            else
            {
                // data + 200
                return Ok(p);
            }
        }

        // GET .../api/coolproducts/brand/apple
        [Route("api/coolproducts/brand/{brand}")]
        public IHttpActionResult GetProductsByBrand(string brand)
        {
            var products = db.Products.Where(p => p.Brand == brand).ToList();
            if (products.Count == 0 || products == null)
                return NotFound();
            else
                return Ok(products);
        }


        //1. GET .../api/coolproducts/costliest

        //2. GET .../api/coolproducts/cheapest

        //3. GET .../api/coolproducts/costbetween/{1000}/{5000}

        //4. GET .../api/coolproducts/catagory/{Mobiles}

        //5. GET .../api/coolproducts/count

        //6. GET .../api/coolproducts/totalworth


        // DELETE .../api/coolproducts/id

        //[HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            Product productToDel = db.Products.Find(id);
            if (productToDel == null)
                return NotFound();

            db.Products.Remove(productToDel);
            db.SaveChanges();
            return Ok();
        }

        // POST .../api/coolproducts
        public IHttpActionResult Post(Product productToSave)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid Data");

            db.Products.Add(productToSave);
            db.SaveChanges();
            // 201 - location - actual data
            return Created($"api/coolproducts/{productToSave.ProductID}", productToSave);
        }

        // PUT  .../api/coolproudcts
        public IHttpActionResult Put(Product productToEdit)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid input");

            //Product p = db.Products.Find(productToEdit.ProductID);
            //if (p == null)
            //    return NotFound();

            db.Entry(productToEdit).State = System.Data.Entity.EntityState.Modified;
            int count = db.SaveChanges();
            if (count >= 1)
                return Ok();
            else
                return NotFound();

        }
    }
}
