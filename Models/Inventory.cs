using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SOLID.Interface;

namespace SOLID.Models
{
    public class Inventory
    {
        private IProductRepository productRepository;

        public Inventory(IProductRepository repository)
        {
            productRepository = repository;
        }

        public void AddProduct(Product product)
        {
            productRepository.Add(product);
        }

        public void RemoveProduct(int ProductId)
        {
            productRepository.Remove(ProductId);
        }

        public IEnumerable<Product> ListProducts()
        {
            return productRepository.GetAll();
        }
    }
}