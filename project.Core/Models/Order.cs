﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Models
{
    public class Order
    { 
        public int Id { get; set; }
        public string Name { get; set; }
      
        public int CountProdact { get; set; }
        //public Product Product { get; set; }
        public DateTime DateOrder { get; set; }
       public List<Product> Products { get; set; }
    }
}
