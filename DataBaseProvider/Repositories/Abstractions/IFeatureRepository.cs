using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseProvider.Repositories.Abstractions
{
    public interface IFeatureRepository : IRepository<Feature>
    {
        public List<Feature> GetAll();
        public Feature GetById(int id);
    }
}
