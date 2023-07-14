using DataBaseProvider.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseProvider.Repositories.Implementations
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public DbSet<TEntity> Entities { get; }
        private readonly ApplicationContext _context;
        public Repository(ApplicationContext context)
        {
            _context = context;
            Entities = _context.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            Entities.Add(entity);
        }

        public void Add(IEnumerable<TEntity> entities)
        {
            Entities.AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
            Entities.Remove(entity);
        }

        public void Remove(IEnumerable<TEntity> entities)
        {
            Entities.RemoveRange(entities);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
