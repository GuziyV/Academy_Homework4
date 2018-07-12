using Data_Access_Layer.Interfaces;
using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repositories
{
    class PlaneRepository : IRepository<Plane>
    {
        static private List<Plane> _planes;
        public PlaneRepository()
        {
            if (_planes == null)
            {
                _planes = new List<Plane>();
            }
        }

        public void Create(Plane item)
        {
            _planes.Add(item);
        }

        public void Delete(int id)
        {
            _planes.Remove(_planes.First(p => p.Id == id));
        }

        public Plane Get(int id)
        {
            return _planes.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Plane> GetAll()
        {
            return _planes;
        }

        public void Update(int id, Plane item)
        {
            _planes[_planes.FindIndex(i => i.Id == id)] = item;
        }
    }
}
