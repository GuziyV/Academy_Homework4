using System.Collections.Generic;
using AutoMapper;
using Business_Layer.Services;
using Data_Access_Layer.Interfaces;
using Data_Access_Layer.Models;
using Microsoft.AspNetCore.Mvc;
using Shared.DTOs;

namespace Presentation_Layer.Controllers
{
    [Produces("application/json")]
    [Route("api/Pilots")]
    public class PilotsController : Controller
    {
        private readonly AirportService _service;
        private readonly IMapper _mapper;

        public PilotsController(IUnitOfWork unitOfWork, IMapper mapper)
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

        // GET api/pilots
        [HttpGet]
        public IEnumerable<PilotDTO> Get()
        {
            return Mapper.Map<IEnumerable<Pilot>, IEnumerable<PilotDTO>>(_service.GetAll<Pilot>());
        }

        // GET api/pilots/id
        [HttpGet("{id}")]
        public PilotDTO Get(int id)
        {
            return Mapper.Map<Pilot, PilotDTO>(_service.GetById<Pilot>(id));
        }

        // POST api/pilots
        [HttpPost]
        public void Post([FromBody]PilotDTO pilot)
        {
            _service.Post<Pilot>(Mapper.Map<PilotDTO, Pilot>(pilot));
        }

        // POST api/pilots/id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]PilotDTO pilot)
        {
            _service.Update<Pilot>(id, Mapper.Map<PilotDTO, Pilot>(pilot));
        }

        // DELETE api/pilots/id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.Delete<Pilot>(id);
        }
    }
}