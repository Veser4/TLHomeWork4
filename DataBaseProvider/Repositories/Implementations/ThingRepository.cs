using Core.Models;
using DataBaseProvider.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseProvider.Repositories.Implementations
{
    public class ThingRepository : Repository<Thing>, IThingRepository
    {
        public ThingRepository(ApplicationContext context) : base(context)
        {
        }

        public List<Thing> GetAll()
        {
            return Entities.ToList();
        }

        public List<Thing> GetByHeroId(int id)
        {
            throw new NotImplementedException();
        }

        public Thing GetById(int id)
        {
            return Entities.Where(a => a.ThingId == id).FirstOrDefault();
        }
    }
}
