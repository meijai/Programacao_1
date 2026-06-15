using Model;
using Repository.VirtualDataBase;

namespace Repository
{
    public class ApartmentRepository : BaseRepository<Apartment>
    {
        public Apartment Create(Apartment apartment)
        {
            apartment.Id = GetNextId();
            MyData.Apartments.Add(apartment);
            return apartment;
        }
        public void Delete(Apartment apartment)
        {
            MyData.Apartments.Remove(apartment);
        }
        public void Update(Apartment apartment)
        {
            var _apartment = GetById(apartment.Id);
            _apartment.Tittle = apartment.Tittle;
            _apartment.Description = apartment.Description;
            _apartment.ApartmentNumber = apartment.ApartmentNumber;
            _apartment.ApartmentFloor = apartment.ApartmentFloor;
            _apartment.Price = apartment.Price;
            _apartment.Room = apartment.Room;
            _apartment.BusinessType = apartment.BusinessType;
            _apartment.Address = apartment.Address;
        }
        public Apartment GetById(int id)
        {
            foreach (var a in MyData.Apartments)
                if (a.Id == id)
                    return a;
            return null!;
        }
        public List<Apartment> GetByFederalState(string federalState)
        {
            List<Apartment> apartments = new List<Apartment>();

            foreach (var a in MyData.Apartments)
            {
                if (a.Address.FederalState.ToLower() == federalState.ToLower())
                {
                    apartments.Add(a);
                }
            }
            return apartments;
        }
        public List<Apartment> GetByCountry(string country)
        {
            List<Apartment> apartments = new List<Apartment>();

            foreach (var a in MyData.Apartments)
            {
                if (a.Address.Country.ToLower() == country.ToLower())
                {
                    apartments.Add(a);
                }
            }
            return apartments;
        }
        public List<Apartment> GetByCity(string city)
        {
            List<Apartment> apartments = new List<Apartment>();

            foreach (var a in MyData.Apartments)
            {
                if (a.Address.City.ToLower() == city.ToLower())
                {
                    apartments.Add(a);
                }
            }
            return apartments;
        }
        public List<Apartment> GetByName(string name)
        {
            List<Apartment> apartments = [];

            foreach (var c in MyData.Apartments)
            {
                if (c.Tittle.ToLower().Contains(name.ToLower()))
                {
                    apartments.Add(c);
                }
            }

            return apartments;
        }
        public List<Apartment> GetAll()
        {
            return MyData.Apartments;
        }
    }
}
