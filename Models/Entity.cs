using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketWorkBd
{
    class Entity
    {
        public Entity()
        {
        }

        public Entity(int id, string name, string price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
    }
}
