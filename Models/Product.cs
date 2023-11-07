using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SOLID.Interface;

namespace SOLID.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }   
        public decimal Price { get; set; }
        public int QuantityinStock { get; set; }
    }
}
