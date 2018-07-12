using Data_Access_Layer.Interfaces;
using Data_Access_Layer.Models;
using Data_Access_Layer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class AirportUnitOfWork : IUnitOfWork
    {
        public AirportUnitOfWork()
        {
            Seed();
        }

        public IRepository<T> GetRepository<T>() where T: class
        {
            if(typeof(T) == typeof(Flight))
            {
                return (IRepository<T>)FlightRepository;
            }
            else if (typeof(T) == typeof(Crew))
            {
                return (IRepository<T>)CrewRepository;
            }
            else if (typeof(T) == typeof(Departure))
            {
                return (IRepository<T>)DepartureRepository;
            }
            else if (typeof(T) == typeof(Pilot))
            {
                return (IRepository<T>)PilotRepository;
            }
            else if (typeof(T) == typeof(Plane))
            {
                return (IRepository<T>)PlaneRepository;
            }
            else if (typeof(T) == typeof(PlaneType))
            {
                return (IRepository<T>)PlaneTypeRepository;
            }
            else if (typeof(T) == typeof(Stewardess))
            {
                return (IRepository<T>)StewardessRepository;
            }
            else if (typeof(T) == typeof(Ticket))
            {
                return (IRepository<T>)TicketRepository;
            }
            else
            {
                throw new TypeAccessException("Wrong type of repo");
            }
        }

        private FlightRepository flightRepository;
        public IRepository<Flight> FlightRepository
        {
            get
            {
                if(flightRepository == null)
                {
                    flightRepository = new FlightRepository();
                }
                return flightRepository;
            }
        }

        private CrewRepository crewRepository;
        public IRepository<Crew> CrewRepository
        {
            get
            {
                if (crewRepository == null)
                {
                    crewRepository = new CrewRepository();
                }
                return crewRepository;
            }
        }

        private DepartureRepository departureRepository;
        public IRepository<Departure> DepartureRepository
        {
            get
            {
                if (departureRepository == null)
                {
                    departureRepository = new DepartureRepository();
                }
                return departureRepository;
            }
        }

        private PilotRepository pilotRepository;
        public IRepository<Pilot> PilotRepository
        {
            get
            {
                if (pilotRepository == null)
                {
                    pilotRepository = new PilotRepository();
                }
                return pilotRepository;
            }
        }

        private PlaneRepository planeRepository;
        public IRepository<Plane> PlaneRepository
        {
            get
            {
                if (planeRepository == null)
                {
                    planeRepository = new PlaneRepository();
                }
                return planeRepository;
            }
        }

        private PlaneTypeRepository planeTypeRepository;

        public IRepository<PlaneType> PlaneTypeRepository
        {
            get
            {
                if (planeTypeRepository == null)
                {
                    planeTypeRepository = new PlaneTypeRepository();
                }
                return planeTypeRepository;
            }
        }

        private StewardessRepository stewardessRepository;
        public IRepository<Stewardess> StewardessRepository
        {
            get
            {
                if (stewardessRepository == null)
                {
                    stewardessRepository = new StewardessRepository();
                }
                return stewardessRepository;
            }
        }

        private TicketRepository ticketRepository;
        public IRepository<Ticket> TicketRepository
        {
            get
            {
                if (ticketRepository == null)
                {
                    ticketRepository = new TicketRepository();
                }
                return ticketRepository;
            }
        }

        public void SaveChanges()  //Nothing to change because we haven't DB ¯\_(ツ)_/¯
        {
            throw new NotImplementedException();
        }

        public void Seed()
        {
            Ticket ticket1 = new Ticket
            {
                Id = 1,
                RaceNumber = 2,
                Price = 1000
            };

            Ticket ticket2 = new Ticket
            {
                Id = 2,
                RaceNumber = 1,
                Price = 1020
            };

            Ticket ticket3 = new Ticket
            {
                Id = 3,
                RaceNumber = 4,
                Price = 1040
            };

            Ticket ticket4 = new Ticket
            {
                Id = 4,
                RaceNumber = 3,
                Price = 1060
            };

            Ticket ticket5 = new Ticket
            {
                Id = 4,
                RaceNumber = 2,
                Price = 1060
            };

            TicketRepository.Create(ticket1);
            TicketRepository.Create(ticket2);
            TicketRepository.Create(ticket3);
            TicketRepository.Create(ticket4);

            FlightRepository.Create(new Flight()
            {
                Number = 1,
                ArrivalTime = new DateTime(2018, 12, 13),
                DepartureFrom = "Kyiv",
                Destination = "Tokio",
                Tickets = new List<Ticket>()
                {
                    ticket2
                },
                TimeOfDeparture = new DateTime(2018, 12, 12)
            });

            FlightRepository.Create(new Flight()
            {
                Number = 2,
                ArrivalTime = new DateTime(2018, 07, 18),
                DepartureFrom = "Paris",
                Destination = "Dublin",
                Tickets = new List<Ticket>()
                {
                    ticket1, ticket5
                },
                TimeOfDeparture = new DateTime(2018, 07, 18)
            });

            FlightRepository.Create(new Flight()
            {
                Number = 3,
                ArrivalTime = new DateTime(2018, 03, 04),
                DepartureFrom = "London",
                Destination = "Lviv",
                Tickets = new List<Ticket>()
                {
                    ticket4
                },
                TimeOfDeparture = new DateTime(2018, 03, 03)
            });

            FlightRepository.Create(new Flight()
            {
                Number = 4,
                ArrivalTime = new DateTime(2018, 08, 09),
                DepartureFrom = "Oslo",
                Destination = "Kyiv",
                Tickets = new List<Ticket>()
                {
                    ticket3
                },
                TimeOfDeparture = new DateTime(2018, 08, 07)
            });

            //
            Stewardess stewardess1 = new Stewardess()
            {
                Id = 1,
                Name = "StName1",
                Surname = "StSurname1",
                DateOfBirth = new DateTime(1993, 9, 8)
            };

            Stewardess stewardess2 = new Stewardess()
            {
                Id = 2,
                Name = "StName2",
                Surname = "StSurname2",
                DateOfBirth = new DateTime(1992, 4, 2)
            };

            Stewardess stewardess3 = new Stewardess()
            {
                Id = 3,
                Name = "StName3",
                Surname = "StSurname3",
                DateOfBirth = new DateTime(1993, 11, 30)
            };

            Stewardess stewardess4 = new Stewardess()
            {
                Id = 4,
                Name = "StName4",
                Surname = "StSurname4",
                DateOfBirth = new DateTime(1994, 10, 25)
            };

            Stewardess stewardess5 = new Stewardess()
            {
                Id = 5,
                Name = "StName5",
                Surname = "StSurname5",
                DateOfBirth = new DateTime(1989, 8, 3)
            };

            Stewardess stewardess6 = new Stewardess()
            {
                Id = 6,
                Name = "StName6",
                Surname = "StSurname6",
                DateOfBirth = new DateTime(1994, 9, 15)
            };

            Stewardess stewardess7 = new Stewardess()
            {
                Id = 7,
                Name = "StName7",
                Surname = "StSurname7",
                DateOfBirth = new DateTime(1993, 9, 12)
            };

            StewardessRepository.Create(stewardess1);
            StewardessRepository.Create(stewardess2);
            StewardessRepository.Create(stewardess3);
            StewardessRepository.Create(stewardess4);
            StewardessRepository.Create(stewardess5);
            StewardessRepository.Create(stewardess6);
            StewardessRepository.Create(stewardess7);

            Pilot pilot1 = new Pilot()
            {
                Id = 1,
                Name = "PName1",
                Surname = "PSurname1",
                Experience = 3
            };

            Pilot pilot2 = new Pilot()
            {
                Id = 2,
                Name = "PName2",
                Surname = "PSurname2",
                Experience = 1
            };

            Pilot pilot3 = new Pilot()
            {
                Id = 3,
                Name = "PName3",
                Surname = "PSurname3",
                Experience = 2
            };

            Pilot pilot4 = new Pilot()
            {
                Id = 4,
                Name = "PName4",
                Surname = "PSurname4",
                Experience = 4
            };

            PilotRepository.Create(pilot1);
            PilotRepository.Create(pilot2);
            PilotRepository.Create(pilot3);
            PilotRepository.Create(pilot4);

            Crew crew1 = new Crew()
            {
                Id = 1,
                Pilot = pilot2,
                Stewardesses = new List<Stewardess>()
                {
                    stewardess1, stewardess5
                }
            };

            Crew crew2 = new Crew()
            {
                Id = 2,
                Pilot = pilot2,
                Stewardesses = new List<Stewardess>()
                {
                    stewardess2, stewardess5, stewardess7
                }
            };

            Crew crew3 = new Crew()
            {
                Id = 3,
                Pilot = pilot3,
                Stewardesses = new List<Stewardess>()
                {
                    stewardess6
                }
            };

            Crew crew4 = new Crew()
            {
                Id = 4,
                Pilot = pilot4,
                Stewardesses = new List<Stewardess>()
                {
                    stewardess7, stewardess4
                }
            };

            CrewRepository.Create(crew1);
            CrewRepository.Create(crew2);
            CrewRepository.Create(crew3);
            CrewRepository.Create(crew4);

            Departure departure1 = new Departure()
            {
                Id = 1,
                RaceNumber = 2,
                Crew = crew4,
                TimeOfDeparture = new DateTime(2018, 07, 18)
            };

            Departure departure2 = new Departure()
            {
                Id = 2,
                RaceNumber = 1,
                Crew = crew3,
                TimeOfDeparture = new DateTime(2018, 12, 13)
            };

            Departure departure3 = new Departure()
            {
                Id = 3,
                RaceNumber = 3,
                Crew = crew2,
                TimeOfDeparture = new DateTime(2018, 03, 03)
            };

            Departure departure4 = new Departure()
            {
                Id = 4,
                RaceNumber = 2,
                Crew = crew4,
                TimeOfDeparture = new DateTime(2018, 08, 07)
            };

            DepartureRepository.Create(departure1);
            DepartureRepository.Create(departure2);
            DepartureRepository.Create(departure3);
            DepartureRepository.Create(departure4);

            PlaneType planeType1 = new PlaneType()
            {
                Id = 1,
                NumberOfSeats = 100,
                LoadCapacity = 15000,
                Model = "Model1"
            };

            PlaneType planeType2 = new PlaneType()
            {
                Id = 2,
                NumberOfSeats = 101,
                LoadCapacity = 15001,
                Model = "Model2"
            };

            PlaneType planeType3 = new PlaneType()
            {
                Id = 3,
                NumberOfSeats = 103,
                LoadCapacity = 15003,
                Model = "Model3"
            };

            PlaneType planeType4 = new PlaneType()
            {
                Id = 4,
                NumberOfSeats = 104,
                LoadCapacity = 15004,
                Model = "Model4"
            };

            PlaneTypeRepository.Create(planeType1);
            PlaneTypeRepository.Create(planeType2);
            PlaneTypeRepository.Create(planeType3);
            PlaneTypeRepository.Create(planeType4);

            Plane plane1 = new Plane()
            {
                Id = 1,
                PlaneType = planeType3,
                ReleaseDate = new DateTime(2003, 11, 9)
            };

            Plane plane2 = new Plane()
            {
                Id = 2,
                PlaneType = planeType1,
                ReleaseDate = new DateTime(2002, 10, 10)
            };

            Plane plane3 = new Plane()
            {
                Id = 3,
                PlaneType = planeType4,
                ReleaseDate = new DateTime(2004, 9, 30)
            };

            Plane plane4 = new Plane()
            {
                Id = 4,
                PlaneType = planeType2,
                ReleaseDate = new DateTime(2001, 11, 8)
            };

            PlaneRepository.Create(plane1);
            PlaneRepository.Create(plane2);
            PlaneRepository.Create(plane3);
            PlaneRepository.Create(plane4);
        }
    }
}
