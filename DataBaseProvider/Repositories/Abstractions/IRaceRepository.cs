using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseProvider.Repositories.Abstractions
{
    public interface IRaceRepository : IRepository<Race>
    {
        public List<Race> GetAll();
        public Race GetById(int id);
    }
}
