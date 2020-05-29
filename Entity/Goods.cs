using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Entities
{
   public class Goods : AuditableEntity
    {
        public string Name { get; set; }
        public float Price { get; set; }

        public Goods(string name, float price)
        {
            Name = name;
            Price = price;
        }

        //Для EF Core
        public Goods()
        {

        }
    }
}
