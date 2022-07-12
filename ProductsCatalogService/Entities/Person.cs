using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace ProductsCatalogService.Entities
{
    abstract public class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
    }
}