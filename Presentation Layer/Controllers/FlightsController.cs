using System.Collections.Generic;
using AutoMapper;
using Data_Access_Layer.Interfaces;
using Data_Access_Layer.Models;
using Microsoft.AspNetCore.Mvc;
using Shared.DTOs;
using Business_Layer.Services;

namespace Presentation_Layer.Controllers
{
    [Produces("application/json")]
    [Route("api/Flights")]
    public class FlightsController : Controller
    { 
        private readonly AirportService _service;
        private readonly IMapper _mapper;

        public FlightsController(IUnitOfWork unitOfWork, IMapper mapper)
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

        // GET api/flights
        [HttpGet]
        public IEnumerable<FlightDTO> Get()
        {
            return Mapper.Map<IEnumerable<Flight>, IEnumerable<FlightDTO>>(_service.GetAll<Flight>());
        }

        // GET api/flights/id
        [HttpGet("{number}")]
        public FlightDTO Get(int number)
        {
            return Mapper.Map<Flight, FlightDTO>(_service.GetById<Flight>(number));
        }

        //GET /api/flights/routes?departureFrom=:departureFrom&destination=:destination
        [Route("routes")]
        [HttpGet]
        public IEnumerable<FlightDTO> GetByRoute(string departureFrom, string destination)
        {
            return Mapper.Map<IEnumerable<Flight>, IEnumerable<FlightDTO>>(_service.GetFlightByRoute(departureFrom, destination));
        }

        // POST api/flights
        [HttpPost]
        public void Post([FromBody]FlightDTO flight)
        {
            _service.Post<Flight>(Mapper.Map<FlightDTO, Flight>(flight));
        }

        // POST api/flights/number
        [HttpPut("{number}")]
        public void Put(int number, [FromBody]FlightDTO flight)
        {
            _service.Update<Flight>(number, Mapper.Map<FlightDTO, Flight>(flight));
        }

        // DELETE api/flights/number
        [HttpDelete("{number}")]
        public void Delete(int number)
        {
            _service.Delete<Flight>(number);
        }
    }
}