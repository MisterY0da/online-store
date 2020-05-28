using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Entities
{
    class Order : AuditableEntity
    {
        public string ClientName { get; set; }
        public string ClientLastName { get; set; }
        public string ClientPatronymic { get; set; }
        public virtual ICollection<Goods> Goods { get; set; }
        public Order(string clientName, string clientLastName, string clientPatronymic)
        {
            ClientName = clientName;
            ClientLastName = clientLastName;
            ClientPatronymic = clientPatronymic;

        }
        public Order()
        {

        }

    }
}
