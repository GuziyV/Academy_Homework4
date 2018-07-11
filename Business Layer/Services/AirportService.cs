using Business_Layer.Interfaces;
using Data_Access_Layer.Interfaces;
using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Services
{
    public class AirportService : IService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AirportService(IUnitOfWork unitOfWork)
        {
            
                _unitOfWork = unitOfWork;
            
        }
        //Flights
        public Flight GetFlightByNumber(int number)
        {
            return _unitOfWork.GetRepository<Flight>().Get(number);
        }
        
        public IEnumerable<Flight> GetAllFlights()
        {
            return _unitOfWork.GetRepository<Flight>().GetAll();
        }

        public IEnumerable<Flight> GetFlightByRoute(string departureFrom, string destination)
        {
            return GetAllFlights().Where(f => (f.DepartureFrom == departureFrom && f.Destination == destination));
        }

        public void PostFlight(Flight flight)
        {
            _unitOfWork.GetRepository<Flight>().Create(flight);
        }

        public void UpdateFlight(int id, Flight flight)
        {
            _unitOfWork.GetRepository<Flight>().Update(id, flight);
        }

        public void DeleteFlight(int number)
        {
            _unitOfWork.GetRepository<Flight>().Delete(number);
        }
        //
    }
}
