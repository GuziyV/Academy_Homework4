using Data_Access_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    class UnitOfWorks : IUnitOfWorks
    {

        public IRepository<T> GetRepository<T>() where T : class
        {
            return new Repositories
        }
    }
}
