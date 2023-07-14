using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseProvider.Repositories.Abstractions
{
    public interface IClassRepository : IRepository<Class>
    {
        public List<Class> GetAll();
        public Class GetById(int id);
    }
}
