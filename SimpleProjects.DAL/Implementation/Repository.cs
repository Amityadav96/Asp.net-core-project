using Microsoft.EntityFrameworkCore;
using SimpleProjects.DAL.Infrastructure;
using SimpleProjects.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProjects.DAL.Implementation
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        private DbSet<T> _dbset;

        public Repository(AppDbContext context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }

        public void Add(T entity)
        {
            _dbset.Add(entity);
        }

        public void Delete(T entity)
        {
            _dbset?.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
           
          return _dbset.ToList();
        }

       
    }
}
