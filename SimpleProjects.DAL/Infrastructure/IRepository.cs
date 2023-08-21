using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProjects.DAL.Infrastructure
{
    public interface IRepository <T> where T : class
    {
        IEnumerable<T> GetAll();

        void Add(T entity);
        
        void Delete(T entity);

    }
}
