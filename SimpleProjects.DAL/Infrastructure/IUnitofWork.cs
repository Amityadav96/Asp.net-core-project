using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProjects.DAL.Infrastructure
{
    public interface IUnitofWork
    {
        ICategoryRepository CategoryRepository { get;  }

        void Save();
    }
}
