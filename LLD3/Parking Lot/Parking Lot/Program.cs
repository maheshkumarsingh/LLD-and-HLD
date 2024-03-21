/*
Notes :-

BaseModel -> id attribute is present in all the Model classes, we can
have a common class to store the id attribute i.e BaseModel, Now every model
class will extend the BaseModel class.


Requirement-1 : Operator should be able to generate the Ticket.

Model - View - Controller

TicketController -> Takes the request from the client and passes it
as it is to the corresponding Services.

Create Controller, service and repository for each model (wherever required).

TicketController. [Waiter]
TicketService.    [Chef]
TicketRepository. [Helper]
 */

// Decide order which one should be called early service, controller

using Parking_Lot.Controllers;
using Parking_Lot.Repositories;
using Parking_Lot.Services;

GateRepository gateRepository = new GateRepository();
ParkingLotRepository parkingLotRepository = new ParkingLotRepository();
TicketRepository ticketRepository = new TicketRepository();
VechileRepository vechileRepository = new VechileRepository();

TicketService ticketService = new TicketService(gateRepository, vechileRepository, parkingLotRepository, ticketRepository);

TicketController ticketController = new TicketController(ticketService);
