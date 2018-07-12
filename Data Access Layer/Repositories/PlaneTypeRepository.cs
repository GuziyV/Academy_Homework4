using Data_Access_Layer.Interfaces;
using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repositories
{
    class PlaneTypeRepository : IRepository<PlaneType>
    {
        static private List<PlaneType> _planeTypes;
        public PlaneTypeRepository()
        {
            if (_planeTypes == null)
            {
                _planeTypes = new List<PlaneType>();
            }
        }

        public void Create(PlaneType item)
        {
            _planeTypes.Add(item);
        }

        public void Delete(int id)
        {
            _planeTypes.Remove(_planeTypes.First(p => p.Id == id));
        }

        public PlaneType Get(int id)
        {
            return _planeTypes.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<PlaneType> GetAll()
        {
            return _planeTypes;
        }

        public void Update(int id, PlaneType item)
        {
            _planeTypes[_planeTypes.FindIndex(i => i.Id == id)] = item;
        }
    }
}
