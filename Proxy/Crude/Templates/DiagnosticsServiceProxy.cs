﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 5:29:27 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.DotNetFrameworkBusinessToDotNetFrameworkRestProxy.ProxyMake
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System.Collections.Generic;
using System;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

// business namespace for proxy
// links:
//  docLink: http://sql2x.org/documentationLink/2595ba81-a5dc-4b5a-8bc8-2f7ca6630d9b
namespace SolutionNorSolutionPort.BusinessLogicLayer.Proxy {
    // proxy service class for dot net framework
    // links:
    //  docLink: http://sql2x.org/documentationLink/41996556-e83c-47d0-90e1-464b60264260
    public class DiagnosticsServiceClient {
        // REST interface to Business layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/794b5c09-a236-4274-9be6-f25aeaa2ab46
        public System.Int64 WorkingSet(
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/DiagnosticsService/WorkingSet?";
            string jsonString = client.DownloadString(query);

            System.Int64 reply =
                JsonConvert.DeserializeObject<System.Int64>(jsonString);

            return reply;
        }

        public System.DateTime PingTest(
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/DiagnosticsService/PingTest?";
            string jsonString = client.DownloadString(query);

            System.DateTime reply =
                JsonConvert.DeserializeObject<System.DateTime>(jsonString);

            return reply;
        }

        public System.String Database(
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/DiagnosticsService/Database?";
            string jsonString = client.DownloadString(query);

            System.String reply =
                JsonConvert.DeserializeObject<System.String>(jsonString);

            return reply;
        }

        public System.String ComputerName(
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/DiagnosticsService/ComputerName?";
            string jsonString = client.DownloadString(query);

            System.String reply =
                JsonConvert.DeserializeObject<System.String>(jsonString);

            return reply;
        }

    }
}
