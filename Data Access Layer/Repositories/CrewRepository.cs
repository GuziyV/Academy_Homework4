using Data_Access_Layer.Interfaces;
using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repositories
{
    class CrewRepository : IRepository<Crew>
    {
        static private List<Crew> _crews;

        public CrewRepository()
        {
            if (_crews == null)
            {
                _crews = new List<Crew>();
            }
        }

        public void Create(Crew item)
        {
            _crews.Add(item);
        }

        public void Delete(int id)
        {
            _crews.Remove(_crews.First(c => c.Id == id));
        }

        public Crew Get(int id)
        {
            return _crews.First(c => c.Id == id);
        }

        public IEnumerable<Crew> GetAll()
        {
            return _crews;
        }

        public void Update(int id, Crew item)
        {
            _crews[_crews.FindIndex(i => i.Id == id)] = item;
        }
    }
    }