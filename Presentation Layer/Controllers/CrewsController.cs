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
    [Route("api/Crews")]
    public class CrewsController : Controller
    {
        private readonly AirportService _service;
        private readonly IMapper _mapper;

        public CrewsController(IUnitOfWork unitOfWork, IMapper mapper)
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

        // GET api/crews
        [HttpGet]
        public IEnumerable<CrewDTO> Get()
        {
            return Mapper.Map<IEnumerable<Crew>, IEnumerable<CrewDTO>>(_service.GetAll<Crew>());
        }

        // GET api/crews/id
        [HttpGet("{id}")]
        public CrewDTO Get(int id)
        {
            return Mapper.Map<Crew, CrewDTO>(_service.GetById<Crew>(id));
        }

        // POST api/crews
        [HttpPost]
        public void Post([FromBody]CrewDTO crew)
        {
            _service.Post<Crew>(Mapper.Map<CrewDTO, Crew>(crew));
        }

        // POST api/crews/id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]CrewDTO crew)
        {
            _service.Update<Crew>(id, Mapper.Map<CrewDTO, Crew>(crew));
        }

        // DELETE api/crews/id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.Delete<Crew>(id);
        }
    }
}