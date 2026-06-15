using Model;
using Repository.VirtualDataBase;

namespace Repository.Seeds
{
    public static class HouseSeeds
    {
        public static void Seed()
        {
            MyData.Houses.AddRange(new List<House>
            {
                new House { Id = 1, Tittle = "Casa Bonita", Description = "Casa bonita localizada na praia", Price = 150000.00, BusinessType = BusinessType.Sell },
                new House { Id = 2, Tittle = "Casa Bonita", Description = "Casa bonita localizada na praia", Price = 150000.00, BusinessType = BusinessType.Sell },
                new House { Id = 3, Tittle = "Casa Bonita", Description = "Casa bonita localizada na praia", Price = 150000.00, BusinessType = BusinessType.Sell }
            });
        }
    }
}
