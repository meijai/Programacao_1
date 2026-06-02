using System;
using System.Collections.Generic;
using System.Text;
using Model;
using Repository.VirtualDatabase;

namespace Repository.Seeds
{
    public static class ProductSeeds
    {
        public static void Seed()
        {
            MyData.Products.AddRange(new List<Product>
            {
                new Product { Id = 1, Name = "Smartphone", Price = 699.99, CategoryId = 1 },
                new Product { Id = 2, Name = "Notebook", Price = 1299.99, CategoryId = 2 },
                new Product { Id = 3, Name = "Camiseta", Price = 29.99, CategoryId = 3 }
            });
        }
    }
}
