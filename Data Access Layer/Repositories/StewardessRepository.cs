using Data_Access_Layer.Interfaces;
using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repositories
{
    class StewardessRepository : IRepository<Stewardess>
    {
        private List<Stewardess> _stewardesses;

        public StewardessRepository()
        {
            _stewardesses = new List<Stewardess>();
        }

        public void Create(Stewardess item)
        {
            _stewardesses.Add(item);
        }

        public void Delete(int id)
        {
            _stewardesses.Remove(_stewardesses.First(s => s.Id == id));
        }

        public Stewardess Get(int id)
        {
            return _stewardesses.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Stewardess> GetAll()
        {
            return _stewardesses;
        }

        public void Update(Stewardess item)
        {sdsada
            Stewardess updateItem = _stewardesses.First(s => s.Id == item.Id);
            updateItem = item;
        }
    }
}
