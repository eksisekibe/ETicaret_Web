﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret_Entity
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double? Price { get; set; }
        public string Color  { get; set; }
        public string Size { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool IsApproved { get; set; }

        
    }
}
