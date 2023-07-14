using Core.Models;
using DataBaseProvider.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseProvider.Repositories.Implementations
{
    public class HeroRepository : Repository<Hero>, IHeroRepository
    {
        public HeroRepository(ApplicationContext context) : base(context)
        {
        }

        public List<Hero> GetAll()
        {
            return Entities.ToList();
        }

        public List<Hero> GetByClassId(int id)
        {
            return Entities.Include(b => b.Class).Where(b => b.ClassId == id).ToList();
        }

        public List<Hero> GetByFeatureId(int id)
        {
            return Entities.Include(b => b.Feature).Where(b => b.FeatureId == id).ToList();
        }

        public Hero GetById(int id)
        {
            return Entities.Where(b => b.HeroId == id).FirstOrDefault();
        }

        public List<Hero> GetByRaceId(int id)
        {
            return Entities.Include(b => b.Race).Where(b => b.RaceId == id).ToList();
        }
    }
}
