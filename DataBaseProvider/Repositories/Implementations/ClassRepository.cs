using Core.Models;
using DataBaseProvider.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseProvider.Repositories.Implementations
{
    public class ClassRepository : Repository<Class>, IClassRepository
    {
        public ClassRepository(ApplicationContext context) : base(context)
        {
        }

        public List<Class> GetAll()
        {
            return Entities.ToList();
        }

        public Class GetById(int id)
        {
            return Entities.Where(a => a.ClassId == id).FirstOrDefault();
        }
    }
}
