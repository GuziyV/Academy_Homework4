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
    [Route("api/PlaneTypes")]
    public class PlaneTypesController : Controller
    {
        private readonly AirportService _service;
        private readonly IMapper _mapper;

        public PlaneTypesController(IUnitOfWork unitOfWork, IMapper mapper)
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

        // GET api/planetypes
        [HttpGet]
        public IEnumerable<PlaneTypeDTO> Get()
        {
            return Mapper.Map<IEnumerable<PlaneType>, IEnumerable<PlaneTypeDTO>>(_service.GetAll<PlaneType>());
        }

        // GET api/planestype/id
        [HttpGet("{id}")]
        public PlaneTypeDTO Get(int id)
        {
            return Mapper.Map<PlaneType, PlaneTypeDTO>(_service.GetById<PlaneType>(id));
        }

        // POST api/planetypes
        [HttpPost]
        public void Post([FromBody]PlaneTypeDTO planeType)
        {
            _service.Post<PlaneType>(Mapper.Map<PlaneTypeDTO, PlaneType>(planeType));
        }

        // POST api/planettypes/id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]PlaneTypeDTO planeType)
        {
            _service.Update<PlaneType>(id, Mapper.Map<PlaneTypeDTO, PlaneType>(planeType));
        }

        // DELETE api/planettypes/id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.Delete<PlaneType>(id);
        }
    }
}