/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/4/2021 1:48:36 PM
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
//  docLink: http://sql2x.org/documentationLink/0f3a62ca-e301-4d44-8e1a-de9198ba8967
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  docLink: http://sql2x.org/documentationLink/c8b78807-5be0-4da9-89f2-2d7f8dac1c12
    [ServiceContract()]
    public partial interface IScheduleSearchService {
        // returns a list of FlightSegmentsSchedule contracts from ScheduleSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  flightScheduleId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<FlightSegmentsScheduleContract> FlightSegmentsSchedule (System.Guid flightScheduleId);
        // returns a list of FlightScheduleHistory contracts from ScheduleSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  flightScheduleId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<FlightScheduleHistoryContract> FlightScheduleHistory (System.Guid flightScheduleId);
        
        // returns a list of FlightSchedule contracts from ScheduleSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/cdd86da0-630c-402b-b72a-8dabf924530d
        [OperationContract()]
        List<FlightScheduleContract> FlightSchedule();
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //  and transfers that data to a Contract
    // links:
    //  docLink: http://sql2x.org/documentationLink/0b3269e5-2c52-47e6-a294-51407ea7c523
    public partial class ScheduleSearchService : IScheduleSearchService {
        // returns a list of FlightSegmentsSchedule contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  flightScheduleId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<FlightSegmentsScheduleContract> FlightSegmentsSchedule (System.Guid flightScheduleId) {
            // transfer all FlightSegmentsSchedule serialized objects from ScheduleSearch as FlightSegmentsSchedule contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.ScheduleSearch();
            var businessLogicLayer = new FlightSegmentsSchedule();
            return businessLogicLayer.FlightSegmentsScheduleFromDal(dataAccessLayer.FlightSegmentsSchedule(flightScheduleId));
        }
        // returns a list of FlightScheduleHistory contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  flightScheduleId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<FlightScheduleHistoryContract> FlightScheduleHistory (System.Guid flightScheduleId) {
            // transfer all FlightScheduleHistory serialized objects from ScheduleSearch as FlightScheduleHistory contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.ScheduleSearch();
            var businessLogicLayer = new FlightScheduleHistory();
            return businessLogicLayer.FlightScheduleHistoryFromDal(dataAccessLayer.FlightScheduleHistory(flightScheduleId));
        }
        
        // returns a list of FlightSchedule contracts from ScheduleSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/0b582d9b-64df-473e-9f42-7ce7701e67f0
        public virtual List<FlightScheduleContract> FlightSchedule() {
            // transfer all FlightSchedule serialized objects from ScheduleSearch as FlightSchedule contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.ScheduleSearch();
            var businessLogicLayer = new FlightSchedule();
            return businessLogicLayer.FlightScheduleFromDal(dataAccessLayer.FlightSchedule());
        }
    }
}
