﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/31/2020 7:50:40 AM
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
    public class ServiceSearchServiceClient {
        // REST interface to Business layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/794b5c09-a236-4274-9be6-f25aeaa2ab46
        public List<GetServicePackageContract> GetServicePackage(
            System.Guid servicePackageId
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/ServiceSearchService/GetServicePackage?servicePackageId={servicePackageId}";
            string jsonString = client.DownloadString(query);

            List<GetServicePackageContract> reply =
                JsonConvert.DeserializeObject<List<GetServicePackageContract>>(jsonString);

            return reply;
        }

        public List<FetchServiceSpecialServiceRequestWithFilterContract> FetchServiceSpecialServiceRequestWithFilter(
            System.String serviceSpecialServiceRequestGroupRcd,
            System.String serviceSpecialServiceRequestCode,
            System.String requestServiceSpecialServiceRequestRequirementRcd,
            System.String replyServiceSpecialServiceRequestRequirementRcd,
            System.String serviceSpecialServiceRequestOperationRuleRcd
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/ServiceSearchService/FetchServiceSpecialServiceRequestWithFilter?serviceSpecialServiceRequestGroupRcd={serviceSpecialServiceRequestGroupRcd}&serviceSpecialServiceRequestCode={serviceSpecialServiceRequestCode}&requestServiceSpecialServiceRequestRequirementRcd={requestServiceSpecialServiceRequestRequirementRcd}&replyServiceSpecialServiceRequestRequirementRcd={replyServiceSpecialServiceRequestRequirementRcd}&serviceSpecialServiceRequestOperationRuleRcd={serviceSpecialServiceRequestOperationRuleRcd}";
            string jsonString = client.DownloadString(query);

            List<FetchServiceSpecialServiceRequestWithFilterContract> reply =
                JsonConvert.DeserializeObject<List<FetchServiceSpecialServiceRequestWithFilterContract>>(jsonString);

            return reply;
        }

        public List<ServicePackagePromotionWithFilterContract> ServicePackagePromotionWithFilter(
            System.Guid clientId
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/ServiceSearchService/ServicePackagePromotionWithFilter?clientId={clientId}";
            string jsonString = client.DownloadString(query);

            List<ServicePackagePromotionWithFilterContract> reply =
                JsonConvert.DeserializeObject<List<ServicePackagePromotionWithFilterContract>>(jsonString);

            return reply;
        }

    }
}
