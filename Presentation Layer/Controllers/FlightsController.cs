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

namespace Presentation_Layer.Controllers
{
    [Produces("application/json")]
    [Route("api/Flights")]
    public class FlightsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public FlightsController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
    }

        // GET api/values
        [HttpGet]
        public IEnumerable<FlightDTO> Get()
        {
            var fligths = _mapper.Map<IEnumerable<Flight>, IEnumerable<FlightDTO>>
                   (_unitOfWork.GetRepository<Flight>().GetAll());
            return fligths;
        }

    }
}