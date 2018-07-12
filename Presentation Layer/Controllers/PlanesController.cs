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
    [Route("api/Planes")]
    public class PlanesController : Controller
    {
        private readonly AirportService _service;
        private readonly IMapper _mapper;

        public PlanesController(IUnitOfWork unitOfWork, IMapper mapper)
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

        // GET api/planes
        [HttpGet]
        public IEnumerable<PlaneDTO> Get()
        {
            return Mapper.Map<IEnumerable<Plane>, IEnumerable<PlaneDTO>>(_service.GetAll<Plane>());
        }

        // GET api/planes/id
        [HttpGet("{id}")]
        public PlaneDTO Get(int id)
        {
            return Mapper.Map<Plane, PlaneDTO>(_service.GetById<Plane>(id));
        }

        //GET /api/tickets/model?planemodel=:planeModel
        [Route("model")]
        [HttpGet]
        public IEnumerable<PlaneDTO> GetByMode(string planeModel)
        {
            return Mapper.Map<IEnumerable<Plane>, IEnumerable<PlaneDTO>>(_service.GetPlanesByModel(planeModel));
        }

        //GET /api/tickets/capacity?loadcapacity=:loadcapacity
        [Route("capacity")]
        [HttpGet]
        public IEnumerable<PlaneDTO> GetByCapacity(int loadCapacity)
        {
            return Mapper.Map<IEnumerable<Plane>, IEnumerable<PlaneDTO>>(_service.GetPlanesLoadCapacityMoreThen(loadCapacity));
        }

        //GET /api/tickets/seats?planeseats=:planeseats
        [Route("seats")]
        [HttpGet]
        public IEnumerable<PlaneDTO> GetBySeats(int planeSeats)
        {
            return Mapper.Map<IEnumerable<Plane>, IEnumerable<PlaneDTO>>(_service.GetPlanesByNumberOfSeatsMoreThen(planeSeats));
        }

        // POST api/planes
        [HttpPost]
        public void Post([FromBody]PlaneDTO plane)
        {
            _service.Post<Plane>(Mapper.Map<PlaneDTO, Plane>(plane));
        }

        // POST api/planes/id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]PlaneDTO plane)
        {
            _service.Update<Plane>(id, Mapper.Map<PlaneDTO, Plane>(plane));
        }

        // DELETE api/planes/id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.Delete<Plane>(id);
        }
    }
}