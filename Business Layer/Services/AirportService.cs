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
        #region General
        public T GetById<T>(int id) where T : class
        {
            return _unitOfWork.GetRepository<T>().Get(id);
        }

        public IEnumerable<T> GetAll<T>() where T : class
        {
            return _unitOfWork.GetRepository<T>().GetAll();
        }

        public void Post<T>(T item) where T : class
        {
            _unitOfWork.GetRepository<T>().Create(item);
        }

        public void Update<T>(int id, T item) where T : class
        {
            _unitOfWork.GetRepository<T>().Update(id, item);
        }

        public void Delete<T>(int number) where T : class
        {
            _unitOfWork.GetRepository<T>().Delete(number);
        }
        #endregion


        public IEnumerable<Flight> GetFlightByRoute(string departureFrom, string destination)
        {
            return GetAll<Flight>().Where(f =>
            (f.DepartureFrom == departureFrom && f.Destination == destination));
        }

        public IEnumerable<Ticket> GetTicketsByRoute(string departureFrom, string destination)
        {
            return GetAll<Ticket>().Where(f =>
            (GetById<Flight>(f.RaceNumber).DepartureFrom == departureFrom && GetById<Flight>(f.RaceNumber).Destination == destination));
        }

        public IEnumerable<Plane> GetPlanesByModel(string model)
        {
            return GetAll<Plane>().Where(p => p.PlaneType.Model == model);
        }

        public IEnumerable<Plane> GetPlanesByNumberOfSeatsMoreThen(int numberOfSeats)
        {
            return GetAll<Plane>().Where(p => p.PlaneType.NumberOfSeats > numberOfSeats);
        }

        public IEnumerable<Plane> GetPlanesLoadCapacityMoreThen(int loadCapacity)
        {
            return GetAll<Plane>().Where(p => p.PlaneType.LoadCapacity > loadCapacity);
        }
    }
        
}

