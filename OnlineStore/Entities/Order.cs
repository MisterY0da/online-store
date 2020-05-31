using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace OnlineStore.Entities
{
  public class Order : AuditableEntity
  {
        //Order has client, show single relationship to client
        public virtual Client Client { get; set; }

        //Order has products, relationship 1 to many
        public virtual ICollection<Product> Products { get; set; }

        public Order(Client client, DateTime createdAt)
        {
            Client = client;
            CreatedAt = createdAt;
        }

        //For EF Core
        public Order()
        {

        }
  }
}
