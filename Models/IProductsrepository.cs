using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketWorkBd.Models
{
    interface IProductsrepository
    {
        void Create(Entity user);
        void Delete(int id);
        Entity Get(int id);
        List<Entity> GetUsers();
        void Update(Entity user);
    }
}
