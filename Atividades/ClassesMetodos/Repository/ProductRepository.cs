using System;
using System.Collections.Generic;
using System.Text;
using Model;
using Repository.VirtualDatabase;

namespace Repository
{
    public class ProductRepository
    {

        public void Create(Product product)
        {
            MyData.Products.Add(product);
        }

        public void Delete(Product product)
        {
            MyData.Products.Remove(product);
        }

        public void Update(Product product)
        {
            var _product = GetById(product.Id);
            _product.Name = product.Name;
            _product.Price = product.Price;
        }

        public Product GetById(int id)
        {
            var product = MyData.Products.FirstOrDefault(x => x.Id == id);

            if (product is null) return null!;

            return product;
        }

        public List<Product> GetByName(string name)
        {
            List<Product> products = [];

            foreach (var c in MyData.Products)
            {
                if (c.Name.ToLower().Contains(name.ToLower()))
                { 
                    products.Add(c);
                }
            }

            return products;
        }
    }
}
