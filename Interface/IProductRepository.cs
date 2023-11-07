using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using SOLID.Models;

namespace SOLID.Interface
{
    public interface IProductRepository
    {
        Product GetById(int id);
        void Add(Product product);
        void Remove(int id);
        IEnumerable<Product> GetAll();
    }
}

