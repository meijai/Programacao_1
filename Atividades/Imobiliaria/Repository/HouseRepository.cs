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
            _house.Category = house.Category;
            _house.Price = house.Price;
            _house.Room = house.Room;
            _house.BusinessType = house.BusinessType;
            _house.Address = house.Address;
        }

        public House GetById(int id)
        {
            foreach(var a in MyData.Houses)
                if(a.Id == id) 
                    return a;
            return null!;
        }

        public List<House> GetAll()
        {
            return MyData.Houses;
        }

        public List<House> GetByFederalState(string federalState)
        {
            List<House> houses = new List<House>();

            foreach(var a in MyData.Houses)
            {
                if(a.Address.FederalState.ToLower() == federalState.ToLower())
                {
                    houses.Add(a);
                }
            }
            return houses;
        }

        public List<House> GetByCounty(string country)
        {
            List<House> houses = new List<House>();

            foreach(var a in MyData.Houses)
            {
                if(a.Address.Country.ToLower() == country.ToLower())
                {
                    houses.Add(a);
                }
            }
            return houses;
        }
    }
}
