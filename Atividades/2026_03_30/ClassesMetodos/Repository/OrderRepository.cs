using System;
using System.Collections.Generic;
using System.Text;
using Model;
using Repository.VirtualDatabase;

namespace Repository
{
    public class OrderRepository
    {

        public void Create(Order order)
        {
            MyData.Orders.Add(order);
        }

        public void Delete(Order order)
        {
            MyData.Orders.Remove(order);
        }

        public void Update(Order order)
        {
            var _order = GetById(order.Id);
            _order.Customer = order.Customer;
            _order.OrderItems = order.OrderItems;
            _order.OrderDate = order.OrderDate;
            _order.OrderStatus = order.OrderStatus;
        }

        public Order GetById(int id)
        { 
            var order = MyData.Orders.FirstOrDefault(x => x.Id == id);

            if (order is null) return null!;

            return order;
        }
    }
}
