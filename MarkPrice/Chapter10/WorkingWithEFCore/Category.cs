﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace   Packt.Shared
{
    // Category entity model class
    public class Category
    {
        // these properties map to columns in the database
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }

        [Column(TypeName = "ntext")]
        public string? Description { get; set; }


        // defines a navigation property for related rows
        public virtual ICollection<Product> Products { get; set; }

        public Category()
        {
            // to enable developers to add products to a Category we must
            // initialize the navigation property to an empty collection
            Products = new HashSet<Product>();
        }
    }
}
