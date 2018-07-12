using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business_Layer.Services;
using Data_Access_Layer.Interfaces;
using Data_Access_Layer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.DTOs;

namespace Presentation_Layer.Controllers
{
    [Produces("application/json")]
    [Route("api/Tickets")]
    public class TicketsController : Controller
    {
        private readonly AirportService _service;
        private readonly IMapper _mapper;

        public TicketsController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            if (_service == null)
            {
                _service = new AirportService(unitOfWork);
            }
            if (_mapper == null)
            {
                _mapper = mapper;
            }
        }

        // GET api/tickets
        [HttpGet]
        public IEnumerable<TicketDTO> Get()
        {
            return Mapper.Map<IEnumerable<Ticket>, IEnumerable<TicketDTO>>(_service.GetAll<Ticket>());
        }

        // GET api/tickets/id
        [HttpGet("{id}")]
        public TicketDTO Get(int id)
        {
            return Mapper.Map<Ticket, TicketDTO>(_service.GetById<Ticket>(id));
        }

        //GET /api/tickets/routes?departureFrom=:departureFrom&destination=:destination
        [Route("routes")]
        [HttpGet]
        public IEnumerable<TicketDTO> GetByRoute(string departureFrom, string destination)
        {
            return Mapper.Map<IEnumerable<Ticket>, IEnumerable<TicketDTO>>(_service.GetTicketsByRoute(departureFrom, destination));
        }

        // POST api/tickets
        [HttpPost]
        public void Post([FromBody]TicketDTO ticket)
        {
            _service.Post<Ticket>(Mapper.Map<TicketDTO, Ticket>(ticket));
        }

        // POST api/tickets/id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]TicketDTO ticket)
        {
            _service.Update<Ticket>(id, Mapper.Map<TicketDTO, Ticket>(ticket));
        }

        // DELETE api/tickets/id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.Delete<Ticket>(id);
        }
    }
}