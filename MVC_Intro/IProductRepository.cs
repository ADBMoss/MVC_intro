using System;
using System.Collections.Generic;
using MVC_Intro;

namespace MVC_Intro.Models
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);
        public void UpdateProduct(Product product);
    }
}
