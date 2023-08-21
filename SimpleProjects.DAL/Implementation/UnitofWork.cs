using SimpleProjects.DAL.Infrastructure;
using SimpleProjects.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProjects.DAL.Implementation
{
    public class UnitofWork : IUnitofWork
    {
        private AppDbContext _context;
        public ICategoryRepository Category { get;private set; }

        public ICategoryRepository CategoryRepository => throw new NotImplementedException();

        public UnitofWork(AppDbContext context, ICategoryRepository category)
        {
            _context = context;
            Category = category;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
