using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseProvider.Repositories.Abstractions
{
    public interface IHeroRepository : IRepository<Hero>
    {
        public List<Hero> GetAll();
        public Hero GetById(int id);
        public List<Hero> GetByRaceId(int id);
        public List<Hero> GetByClassId(int id);
        public List<Hero> GetByFeatureId(int id);
    }
}
