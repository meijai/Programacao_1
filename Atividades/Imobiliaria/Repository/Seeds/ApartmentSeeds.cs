using Model;
using Repository.VirtualDataBase;

namespace Repository.Seeds
{
    public static class ApartmentSeeds
    {
        public static void Seed()
        {
            MyData.Apartments.AddRange(new List<Apartment>
            {
                new Apartment { Id = 1, Tittle = "Apartamento Bonito", Description = "Apartamento bonito localizado na cidade", ApartmentNumber = 11, ApartmentFloor = ApartmentFloor.First, Price = 200000.00, BusinessType = BusinessType.Sell },
                new Apartment { Id = 2, Tittle = "Apartamento Bonito", Description = "Apartamento bonito localizado na cidade", ApartmentNumber = 22, ApartmentFloor = ApartmentFloor.Second, Price = 200000.00, BusinessType = BusinessType.Sell },
                new Apartment { Id = 3, Tittle = "Apartamento Bonito", Description = "Apartamento bonito localizado na cidade", ApartmentNumber = 33, ApartmentFloor = ApartmentFloor.Third,  Price = 200000.00, BusinessType = BusinessType.Sell }
            });
        }
    }
}
