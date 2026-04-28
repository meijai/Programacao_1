using System;
using System.Collections.Generic;
using System.Text;
using Model;
using Repository.VirtualDatabase;

namespace Repository.Seeds
{
    public static class CustomerSeeds
    {
        public static void Seed()
        {
            if (MyData.Customers.Count < 1)
            {
                Customer c1 = new Customer();
                c1.Id = 1;
                c1.FirstName = "Jão";
                c1.LastName = "Silva";
                c1.Email = "jao.silva@gmail.com";
                c1.Phone = "11999999999";

                Address c1Address = new Address();
                c1Address.Id = 1;
                c1Address.FederalState = "SC";
                c1Address.Street = "Rua das Flores";
                c1Address.Number = "123";
                c1Address.Country = "Brazil";
                c1Address.City = "Florianópolis";
                c1Address.PostalCode = "88000-000";

                c1.HomeAddress = c1Address;
                c1.ShippingAddress = c1Address;

                MyData.Customers.Add(c1);
            }
        }
    }
}
