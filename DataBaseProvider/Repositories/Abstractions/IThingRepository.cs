using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseProvider.Repositories.Abstractions
{
    public interface IThingRepository : IRepository<Thing>
    {
        public List<Thing> GetAll();
        public Thing GetById(int id);
        public List<Thing> GetByHeroId(int id);
    }
}
