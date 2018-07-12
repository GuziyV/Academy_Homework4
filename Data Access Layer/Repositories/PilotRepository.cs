using Data_Access_Layer.Interfaces;
using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repositories
{
    class PilotRepository : IRepository<Pilot>
    {
        static private List<Pilot> _pilots;

        public PilotRepository()
        {
            if (_pilots == null)
            {
                _pilots = new List<Pilot>();
            }
        }

        public void Create(Pilot item)
        {
            _pilots.Add(item);
        }

        public void Delete(int id)
        {
            _pilots.Remove(_pilots.First(p => p.Id == id));
        }

        public Pilot Get(int id)
        {
            return _pilots.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Pilot> GetAll()
        {
            return _pilots;
        }

        public void Update(int id, Pilot item)
        {
            _pilots[_pilots.FindIndex(i => i.Id == id)] = item;
        }
    }
}
