﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/6/2021 4:17:11 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

// Namespace for the Business Logic Layer
// the Business Logic Layer contains domain logic that encodes real world business rules
//  that determine how data is created, stored and changed. Typically it will also deal with
//  import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//  SOAP http services, using Windows Communication Framework
// links:
//  docLink: http://sql2x.org/documentationLink/89dc5b67-2bf9-4c88-8911-c3b6294c3a64
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // this class serves as a data access contract between c# and sql server
    // this class start with an identical representation of CrudeAddress's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/ceb39174-f927-4fd8-8396-5ec4d04ea471
    [DataContract()]
    public partial class CrudeAddressContract {
        
        [DataMember()]
        public System.Guid AddressId { get; set; }
        
        [DataMember()]
        public string AddressTypeRcd { get; set; }
        
        [DataMember()]
        public string AddressOne { get; set; }
        
        [DataMember()]
        public string AddressTwo { get; set; }
        
        [DataMember()]
        public string AddressThree { get; set; }
        
        [DataMember()]
        public string City { get; set; }
        
        [DataMember()]
        public string Street { get; set; }
        
        [DataMember()]
        public string State { get; set; }
        
        [DataMember()]
        public string District { get; set; }
        
        [DataMember()]
        public string Province { get; set; }
        
        [DataMember()]
        public string ZipCode { get; set; }
        
        [DataMember()]
        public string PoBox { get; set; }
        
        [DataMember()]
        public string Comment { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
