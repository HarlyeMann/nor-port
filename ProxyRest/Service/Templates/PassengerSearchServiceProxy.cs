﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/31/2020 7:50:36 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.DotNetFrameworkBusinessToDotNetFrameworkRestProxy.ProxyMake
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System.Collections.Generic;
using System;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

// Namespace for a Business Logic Layer in a Proxy
// the Business Logic Layer contains domain logic that encodes real world business rules
//   that determine how data is created, stored and changed. Typically it will also deal with
//   import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//   REST http services
// links:
//  docLink: http://sql2x.org/documentationLink/2595ba81-a5dc-4b5a-8bc8-2f7ca6630d9b
namespace SolutionNorSolutionPort.BusinessLogicLayer.Proxy {
    // proxy service class for dot net framework
    // links:
    //  docLink: http://sql2x.org/documentationLink/41996556-e83c-47d0-90e1-464b60264260
    public class PassengerSearchServiceClient {
        // REST interface to Business layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/794b5c09-a236-4274-9be6-f25aeaa2ab46
        public List<PassengersOnFlightWithoutEventsContract> PassengersOnFlightWithoutEvents(
            System.Guid flightId
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/PassengerSearchService/PassengersOnFlightWithoutEvents?flightId={flightId}";
            string jsonString = client.DownloadString(query);

            List<PassengersOnFlightWithoutEventsContract> reply =
                JsonConvert.DeserializeObject<List<PassengersOnFlightWithoutEventsContract>>(jsonString);

            return reply;
        }

        public List<PassengersOnFlightCheckedInContract> PassengersOnFlightCheckedIn(
            System.Guid flightId
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/PassengerSearchService/PassengersOnFlightCheckedIn?flightId={flightId}";
            string jsonString = client.DownloadString(query);

            List<PassengersOnFlightCheckedInContract> reply =
                JsonConvert.DeserializeObject<List<PassengersOnFlightCheckedInContract>>(jsonString);

            return reply;
        }

        public List<PassengersOnFlightContract> PassengersOnFlight(
            System.Guid flightId
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/PassengerSearchService/PassengersOnFlight?flightId={flightId}";
            string jsonString = client.DownloadString(query);

            List<PassengersOnFlightContract> reply =
                JsonConvert.DeserializeObject<List<PassengersOnFlightContract>>(jsonString);

            return reply;
        }

        public List<PassengersOnBookingContract> PassengersOnBooking(
            System.Guid bookingId
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/PassengerSearchService/PassengersOnBooking?bookingId={bookingId}";
            string jsonString = client.DownloadString(query);

            List<PassengersOnBookingContract> reply =
                JsonConvert.DeserializeObject<List<PassengersOnBookingContract>>(jsonString);

            return reply;
        }

    }
}
