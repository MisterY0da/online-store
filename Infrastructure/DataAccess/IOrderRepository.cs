using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.DataAccess
{
    public interface IOrderRepository
    {
        IReadOnlyList<Order> GetAll();
        Order Get(int id);
        void Add(Order order);
        void Update(Order order);
    }
}
