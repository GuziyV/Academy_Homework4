﻿using Data_Access_Layer.Interfaces;
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
        private List<Ticket> _tickets;

        public TicketRepository()
        {
            _tickets = new List<Ticket>();
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

        public void Update(Ticket item)
        {
            Ticket updateTicket = _tickets.First(t => t.Id == item.Id);
            updateTicket = item;
        }
    }
}
