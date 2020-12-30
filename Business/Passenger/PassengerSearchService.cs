/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 7:06:42 AM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPort.BusinessLogicLayer;

// Namespace for the Business Logic Layer
// the Business Logic Layer contains domain logic that encodes real world business rules
//  that determine how data is created, stored and changed. Typically it will also deal with
//  import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//  SOAP http services, using Windows Communication Framework
// links:
//  business logic layer: https://en.wikipedia.org/wiki/Business_logic
// application programming interface: https://en.wikipedia.org/wiki/API
//  docLink: http://sql2x.org/documentationLink/0f3a62ca-e301-4d44-8e1a-de9198ba8967
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  SOAP ( Simple Object Access Protocol ): https://en.wikipedia.org/wiki/SOAP
    // Interface/Protocol (object-oriented programming): https://en.wikipedia.org/wiki/Protocol_(object-oriented_programming)
    // WCF ( Windows Communication Foundation ): https://en.wikipedia.org/wiki/Windows_Communication_Foundation
    //  docLink: http://sql2x.org/documentationLink/54dd6dfa-2ac2-4032-a68d-47e4f658ece7
    [ServiceContract()]
    public partial interface IPassengerSearchService {
        // returns a list of PassengersOnFlightWithoutEvents contracts from PassengerSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  flightId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<PassengersOnFlightWithoutEventsContract> PassengersOnFlightWithoutEvents (System.Guid flightId);
        // returns a list of PassengersOnFlightCheckedIn contracts from PassengerSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  flightId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<PassengersOnFlightCheckedInContract> PassengersOnFlightCheckedIn (System.Guid flightId);
        // returns a list of PassengersOnFlight contracts from PassengerSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  flightId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<PassengersOnFlightContract> PassengersOnFlight (System.Guid flightId);
        
        // returns a list of PassengersOnBooking contracts from PassengerSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/cdd86da0-630c-402b-b72a-8dabf924530d
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<PassengersOnBookingContract> PassengersOnBooking(System.Guid bookingId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //  and transfers that data to a Contract
    // links:
    //  docLink: http://sql2x.org/documentationLink/0b3269e5-2c52-47e6-a294-51407ea7c523
    public partial class PassengerSearchService : IPassengerSearchService {
        // returns a list of PassengersOnFlightWithoutEvents contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  flightId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<PassengersOnFlightWithoutEventsContract> PassengersOnFlightWithoutEvents (System.Guid flightId) {
            // transfer all PassengersOnFlightWithoutEvents serialized objects from PassengerSearch as PassengersOnFlightWithoutEvents contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.PassengerSearch();
            var businessLogicLayer = new PassengersOnFlightWithoutEvents();
            return businessLogicLayer.PassengersOnFlightWithoutEventsFromDal(dataAccessLayer.PassengersOnFlightWithoutEvents(flightId));
        }
        // returns a list of PassengersOnFlightCheckedIn contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  flightId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<PassengersOnFlightCheckedInContract> PassengersOnFlightCheckedIn (System.Guid flightId) {
            // transfer all PassengersOnFlightCheckedIn serialized objects from PassengerSearch as PassengersOnFlightCheckedIn contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.PassengerSearch();
            var businessLogicLayer = new PassengersOnFlightCheckedIn();
            return businessLogicLayer.PassengersOnFlightCheckedInFromDal(dataAccessLayer.PassengersOnFlightCheckedIn(flightId));
        }
        // returns a list of PassengersOnFlight contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  flightId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<PassengersOnFlightContract> PassengersOnFlight (System.Guid flightId) {
            // transfer all PassengersOnFlight serialized objects from PassengerSearch as PassengersOnFlight contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.PassengerSearch();
            var businessLogicLayer = new PassengersOnFlight();
            return businessLogicLayer.PassengersOnFlightFromDal(dataAccessLayer.PassengersOnFlight(flightId));
        }
        
        // returns a list of PassengersOnBooking contracts from PassengerSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/0b582d9b-64df-473e-9f42-7ce7701e67f0
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public virtual List<PassengersOnBookingContract> PassengersOnBooking(System.Guid bookingId) {
            // transfer all PassengersOnBooking serialized objects from PassengerSearch as PassengersOnBooking contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.PassengerSearch();
            var businessLogicLayer = new PassengersOnBooking();
            return businessLogicLayer.PassengersOnBookingFromDal(dataAccessLayer.PassengersOnBooking(bookingId));
        }
    }
}
