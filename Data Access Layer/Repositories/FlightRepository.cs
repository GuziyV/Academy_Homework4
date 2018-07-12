using Data_Access_Layer.Interfaces;
using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repositories
{
    class FlightRepository : IRepository<Flight>
    {
        static private List<Flight> _flights;

        public FlightRepository()
        {
            if (_flights == null)
            {
                _flights = new List<Flight>();
            }
        }

        public void Create(Flight item)
        {
            _flights.Add(item);
        }

        public void Delete(int id)
        {
            _flights.Remove(_flights.First(f => f.Number == id));
        }

        public Flight Get(int id)
        {
            return _flights.FirstOrDefault(f => f.Number == id);
        }

        public IEnumerable<Flight> GetAll()
        {
            return _flights;
        }

        public void Update(int id, Flight item)
        {
            _flights[_flights.FindIndex(f => f.Number == id)] = item;
        }
    }
}
