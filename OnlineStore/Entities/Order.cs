using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace OnlineStore.Entities
{
  public class Order : AuditableEntity
  {
        //Order has goods, relationship 1 to many
        public virtual ICollection<Product> Products { get; set; }

        public virtual Client Client { get; set; }

        //For EF Core
        public Order()
        {

        }

  }
}
