using System;
using System.Collections.Generic;
using System.Text;
using Model;
using Repository.VirtualDataBase;

namespace Repository
{
    public class BaseRepository<T>
    {
        public int GetNextId()
        {
            switch (typeof(T))
            {
                case Type t when t == typeof(Address): return GetNextAddressId();
                case Type t when t == typeof(Apartment): return GetNextApartmentId();
                case Type t when t == typeof(House): return GetNextHouseId();
                default: throw new ArgumentException("Invalid Type");
            }
        }

        private int GetNextAddressId()
        {
            int maxId = 0;
            foreach (var address in MyData.Addresses)
            {
                if (address.Id > maxId)
                    maxId = address.Id;
            }
            return ++maxId;
        }

        private int GetNextApartmentId()
        {
            int maxId = 0;
            foreach (var apartment in MyData.Apartments)
            {
                if (apartment.Id > maxId)
                    maxId = apartment.Id;
            }
            return ++maxId;
        }

        private int GetNextHouseId()
        {
            int maxId = 0;
            foreach(var house in MyData.Houses)
            {
                if (house.Id > maxId)
                    maxId = house.Id;
            }
            return ++maxId;
        }
    }
}
