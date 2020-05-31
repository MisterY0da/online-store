using System;
using System.Collections.Generic;
using System.Text;
using OnlineStore.Entities;

namespace Infrastructure.DataAccess
{
    public class OrderRepository : AuditableRepository<Order>, IOrderRepository
    {
        private readonly AppDbContext _dbContext;
        public OrderRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        IReadOnlyList<Order> GetAll()
        {
            return _dbContext.Orders.Include(o => o.Client).ToList();
        }

        public override Order Get(int id)
        {
            return _dbContext.Orders.Include(o => o.Client).FirstOrDefault(o => o.Id == id);
        }
    }
}
