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
            if (MyData.Products.Count < 1)
            {
                Product c1 = new Product();
                c1.Id = 1;
                c1.Name = "Coca-Cola";
                c1.Price = 1.5;

                MyData.Products.Add(c1);
            }
        }
    }
}
