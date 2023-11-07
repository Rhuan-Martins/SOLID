using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SOLID.Interface;

namespace SOLID.Models
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> products = new List<Product>();

        public Product GetById(int id)
        {
            return products.Find(p => p.Id == id);
        }

        public void Add(Product product)
        {
            product.Id = products.Count +1;
            products.Add(product);
        }

        public void Remove(int id)
        {
            products.RemoveAll(p => p.Id == id);
        }

        public IEnumerable<Product> GetAll()
        {
            return products;
        }

    }
}