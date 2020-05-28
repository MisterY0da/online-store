using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace OnlineStore.Entities
{
    class OrdersHistory : AuditableEntity
    {
        public virtual ICollection<Order> OrdersList { get; set; }

        public string getClientFullName()
        {
            return OrdersList.First().ClientName + " " + OrdersList.First().ClientLastName + " " + OrdersList.First().ClientPatronymic;
        }

        //Для EF Core
        public OrdersHistory()
        {

        }

    }
}
