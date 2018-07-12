# Academy_Homework4
Project Structure

### Flight: 
GET: 
/api/flights/:number

/api/flights/
         
/api/flights/routes?from=:departureFrom&to=:destination - рейси з :departureFrom в :destination

POST: /api/flights/

BODY: {

  departureFrom: string,
  
  timeOfDeparture: DateTime,
  
  destination: string,
  
  arrivalTime: DateTime
  
  tickets: List<Ticket>
         
}

PUT: /api/flights/:number

BODY: {

  departureFrom: string,
  
  timeOfDeparture: DateTime,
  
  destination: string,
  
  arrivalTime: DateTime,
  
  tickets: List<Ticket>
         
}

DELETE: /api/flights/:number

### Ticket
GET:
/api/tickets/:id

/api/tickets/
         
/api/tickets/routes?from=:departureFrom&to=:destination - квитки з :departureFrom в :destination

POST: /api/tickets/

BODY: {

  price: int,
  
  raceNumber: int
  
}

PUT: /api/tickets/:id

BODY: {

  price: int,
  
  raceNumber: int
  
}

DELETE: /api/ticket/:id

### Departures
GET: 
/api/departures/:id

/api/departures/

POST: /api/departures/

BODY: {

  raceNumber: int,
  
  timeOfDeparture: DateTime,
  
  crew: Crew
  
}

PUT: /api/departures/:id

BODY: {

  raceNumber: int,
  
  timeOfDeparture: DateTime,
  
  crew: Crew
  
}

DELETE: /api/departures/:id

### Stewardess
GET: 
/api/stewardesses/:id

/api/stewardesses/

POST: /api/stewardesses/

BODY: {

  name: string,
  
  surname: string,
  
  dateOfBirh: DateTime
  
}

PUT: /api/stewardesses/:id

BODY: {

  name: string,
  
  surname: string,
  
  dateOfBirh: DateTime
  
}
DELETE: /api/stewardesses/:id

### Pilot
GET: 
/api/pilots/:id

/api/pilots/

POST: /api/pilots/

BODY: {

  name: string,
  
  surname: string,
  
  dateOfBirh: DateTime
  
  experience: int
  
}

PUT: /api/pilots/:id

BODY: {

  name: string,
  
  surname: string,
  
  dateOfBirh: DateTime,
  
  experience: TimeSpan
  
}

DELETE: /api/pilots/:id

### Crew
GET: 
/api/crews/:id

/api/crews/

POST: /api/crews/

BODY: {

  pilot: Pilot,
  
  stewardesses: List<Stewardess>
         
}

PUT: /api/crews/:id

BODY: {

  pilot: Pilot,
  
  stewardesses: List<Stewardess>
         
}

DELETE: /api/crews/:id


### Plane
GET: 
/api/planes/:id

 /api/planes/model?planemodel=:model - літаки вказаної моделі

/api/planes/

POST: /api/planes/

BODY: {

  date: DateTime,
  
  type: PlaneType,
  
  releaseDate: DateTime,
  
  lifetime: TimeSpan
  
}

PUT: /api/planes/:id

BODY: {

  date: DateTime,
  
  type: PlaneType,
  
  releaseDate: DateTime,
  
  lifetime: TimeSpan
  
}

DELETE: /api/planes/:id

### PlaneType
GET: 
/api/planetypes/:id

/api/planetypes/

POST: /api/planetypes/

BODY: {

  model: string,
  
  numberOfSeats: int,
  
  loadCapacity: int,
  
}

PUT: /api/planetypes/:id

BODY: {

  model: string,
  
  numberOfSeats: int,
  
  loadCapacity: int,
  
}

DELETE: /api/planetypes/:id

