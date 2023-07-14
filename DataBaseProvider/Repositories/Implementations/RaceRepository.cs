using Core.Models;
using DataBaseProvider.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseProvider.Repositories.Implementations
{
    public class RaceRepository : Repository<Race>, IRaceRepository
    {
        public RaceRepository(ApplicationContext context) : base(context)
        {
        }

        List<Race> IRaceRepository.GetAll()
        {
            return Entities.ToList();
        }

        Race IRaceRepository.GetById(int id)
        {
            return Entities.Where(a => a.RaceId == id).FirstOrDefault();
        }
    }
}
