using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Data_Access_Layer;
using Data_Access_Layer.Interfaces;
using Data_Access_Layer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.DTOs;
using Business_Layer.Interfaces;
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

        // GET api/values
        [HttpGet]
        public IEnumerable<FlightDTO> Get()
        {
            return Mapper.Map<IEnumerable<Flight>, IEnumerable<FlightDTO>>(_service.GetAllFlights());
        }

        [HttpGet("{number}")]
        public FlightDTO Get(int number)
        {
            return Mapper.Map<Flight, FlightDTO>(_service.GetFlightByNumber(number));
        }

        // /api/flights/route?departureFrom=:departureFrom&destination=:destination
        [Route("route")]
        [HttpGet]
        public IEnumerable<FlightDTO> GetByRoute(string departureFrom, string destination)
        {
            return Mapper.Map<IEnumerable<Flight>, IEnumerable<FlightDTO>>(_service.GetFlightByRoute(departureFrom, destination));
        }

        [HttpPost]
        public void Post([FromBody]FlightDTO flight)
        {
            _service.PostFlight(Mapper.Map<FlightDTO, Flight>(flight));
        }

        [HttpPut("{number}")]
        public void Put(int number, [FromBody]FlightDTO flight)
        {
            _service.UpdateFlight(number, Mapper.Map<FlightDTO, Flight>(flight));
        }

        [HttpDelete("{number}")]
        public void Delete(int number)
        {
            _service.DeleteFlight(number);
        }
    }
}