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
    [Route("api/Stewardesses")]
    public class StewardessesController : Controller
    {
        private readonly AirportService _service;
        private readonly IMapper _mapper;

        public StewardessesController(IUnitOfWork unitOfWork, IMapper mapper)
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

        // GET api/stewardesses
        [HttpGet]
        public IEnumerable<StewardessDTO> Get()
        {
            return Mapper.Map<IEnumerable<Stewardess>, IEnumerable<StewardessDTO>>(_service.GetAll<Stewardess>());
        }

        // GET api/stewardesses/id
        [HttpGet("{id}")]
        public StewardessDTO Get(int id)
        {
            return Mapper.Map<Stewardess, StewardessDTO>(_service.GetById<Stewardess>(id));
        }

        // POST api/stewardesses
        [HttpPost]
        public void Post([FromBody]StewardessDTO stewardess)
        {
            _service.Post<Stewardess>(Mapper.Map<StewardessDTO, Stewardess>(stewardess));
        }

        // POST api/stewardesses/id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]StewardessDTO stewardess)
        {
            _service.Update<Stewardess>(id, Mapper.Map<StewardessDTO, Stewardess>(stewardess));
        }

        // DELETE api/stewardesses/id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.Delete<Stewardess>(id);
        }
    }
}