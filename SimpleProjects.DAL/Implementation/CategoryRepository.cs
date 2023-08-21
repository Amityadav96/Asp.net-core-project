using SimpleProjects.DAL.Infrastructure;
using SimpleProjects.Data;
using SimpleProjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProjects.DAL.Implementation
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private AppDbContext _context;
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public void update(Category category)
        {
            _context.Categories.Update(category);
        }
    }
}
