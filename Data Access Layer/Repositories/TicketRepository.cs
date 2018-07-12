using Data_Access_Layer.Interfaces;
using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repositories
{
    class TicketRepository : IRepository<Ticket>
    {
        static private List<Ticket> _tickets;

        public TicketRepository()
        {
            if (_tickets == null)
            {
                _tickets = new List<Ticket>();
            }
        }

        public void Create(Ticket item)
        {
            _tickets.Add(item);
        }

        public void Delete(int id)
        {
            _tickets.Remove(_tickets.First(t => t.Id == id));
        }

        public Ticket Get(int id)
        {
            return _tickets.FirstOrDefault(t => t.Id == id);
        }

        public IEnumerable<Ticket> GetAll()
        {
            return _tickets;
        }

        public void Update(int id, Ticket item)
        {
            _tickets[_tickets.FindIndex(i => i.Id == id)] = item;
        }
    }
}
