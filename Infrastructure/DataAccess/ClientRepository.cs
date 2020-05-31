using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using OnlineStore.Entities;

namespace Infrastructure.DataAccess
{
    class ClientRepository
    {
        public class ClientRepository : AuditableRepository<Client>, IClientRepository
        {
            private readonly AppDbContext _dbContext;
            public ClientRepository(AppDbContext dbContext) : base(dbContext)
            {
                _dbContext = dbContext;
            }

            public override Client Get(int id)
            {
                return _dbContext.Clients.FirstOrDefault(c => c.Id == id);
            }

            public IReadOnlyList<Client> GetClientByFirstName(string firstName)
            {
                return _dbContext.Clients.Where(x => x.FirstName.ToLower().Contains(firstName.ToLower())).ToList();
            }

            public IReadOnlyList<Client> GetClientByLastName(string lastName)
            {
                return _dbContext.Clients.Where(x => x.LastName.ToLower().Contains(lastName.ToLower())).ToList();
            }
        }
    }
}
