using Model;
using Repository.Seeds;
using Repository.VirtualDatabase;
namespace Repository
{
    public class CustomerRepository : BaseRepository<Customer>
    {

        public void Create(Customer customer)
        {
            customer.Id = GetNextId();
            MyData.Customers.Add(customer);
        }

        public void Delete(Customer customer)
        { 
            MyData.Customers.Remove(customer);
        }

        public void Update(Customer customer)
        {
            var _customer = GetById(customer.Id);
            _customer.FirstName = customer.FirstName;
            _customer.LastName = customer.LastName;
            _customer.Email = customer.Email;
            _customer.Phone = customer.Phone;
            _customer.Addresses = customer.Addresses;
        }

        public Customer GetById(int id)
        {
            var customer = MyData.Customers.FirstOrDefault(x => x.Id == id);

            if (customer is null) return null!;

            return customer;
        }

        public List<Customer> GetByName(string name)
        {
            List<Customer> customers = [];

            foreach (var c in MyData.Customers)
            {
                if (c.FirstName.ToLower().Contains(name.ToLower()) || c.LastName.ToLower().Contains(name.ToLower()))
                {
                    customers.Add(c);
                }
            }

            return customers;
        }

        public List<Customer> GetAll()
        {
            return MyData.Customers;
        }
    }
}
