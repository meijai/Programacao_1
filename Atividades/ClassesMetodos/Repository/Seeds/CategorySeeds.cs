using Repository.VirtualDatabase;
using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace Repository.Seeds
{
    public static class CategorySeeds
    {
        public static void Seed()
        {
            MyData.Categories.AddRange(new List<Category>
            {
                new Category { Id = 1, Name = "Eletrônicos" },
                new Category { Id = 2, Name = "Roupas" },
                new Category { Id = 3, Name = "Alimentos" }
            });
        }
    }
}
