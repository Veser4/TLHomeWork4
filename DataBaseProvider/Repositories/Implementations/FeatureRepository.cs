using Core.Models;
using DataBaseProvider.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseProvider.Repositories.Implementations
{
    public class FeatureRepository : Repository<Feature>, IFeatureRepository
    {
        public FeatureRepository(ApplicationContext context) : base(context)
        {
        }

        public List<Feature> GetAll()
        {
            return Entities.ToList<Feature>();
        }

        public Feature GetById(int id)
        {
            return Entities.Where(a => a.FeatureId == id).FirstOrDefault();
        }
    }
}
