using Data_Access_Layer.Interfaces;
using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repositories
{
    class DepartureRepository : IRepository<Departure>
    {
        static private List<Departure> _departures;

        public DepartureRepository()
        {
            if (_departures == null)
            {
                _departures = new List<Departure>();
            }
        }

        public void Create(Departure item)
        {
            _departures.Add(item);
        }

        public void Delete(int id)
        {
            _departures.Remove(_departures.First(d => d.Id == id));
        }

        public Departure Get(int id)
        {
            return _departures.First(d => d.Id == id);
        }

        public IEnumerable<Departure> GetAll()
        {
            return _departures;
        }

        public void Update(int id, Departure item)
        {
            _departures[_departures.FindIndex(i => i.Id == id)] = item;
        }
    }
}
