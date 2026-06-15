using Model;
using Repository.VirtualDataBase;

namespace Repository
{
    public class HouseRepository : BaseRepository<House>
    {
        public House Create(House house)
        {
            house.Id = GetNextId();
            MyData.Houses.Add(house);
            return house;
        }
        public void Delete(House house)
        {
            MyData.Houses.Remove(house);
        }
        public void Update(House house)
        {
            var _house = GetById(house.Id);
            _house.Tittle = house.Tittle;
            _house.Description = house.Description;
            _house.Price = house.Price;
            _house.Room = house.Room;
            _house.BusinessType = house.BusinessType;
            _house.Address = house.Address;
        }
        public House GetById(int id)
        {
            foreach(var h in MyData.Houses)
                if(h.Id == id) 
                    return h;
            return null!;
        }
        public List<House> GetByFederalState(string federalState)
        {
            List<House> houses = new List<House>();

            foreach(var h in MyData.Houses)
            {
                if(h.Address.FederalState.ToLower() == federalState.ToLower())
                {
                    houses.Add(h);
                }
            }
            return houses;
        }
        public List<House> GetByCounty(string country)
        {
            List<House> houses = new List<House>();

            foreach(var h in MyData.Houses)
            {
                if(h.Address.Country.ToLower() == country.ToLower())
                {
                    houses.Add(h);
                }
            }
            return houses;
        }
        public List<House> GetByCity(string city)
        {
            List<House> houses = new List<House>();

            foreach (var h in MyData.Houses)
            {
                if (h.Address.City.ToLower() == city.ToLower())
                {
                    houses.Add(h);
                }
            }
            return houses;
        }

        public List<House> GetByName(string name)
        {
            List<House> houses = [];

            foreach (var c in MyData.Houses)
            {
                if (c.Tittle.ToLower().Contains(name.ToLower()))
                {
                    houses.Add(c);
                }
            }

            return houses;
        }

        public List<House> GetAll()
        {
            return MyData.Houses;
        }
    }
}
