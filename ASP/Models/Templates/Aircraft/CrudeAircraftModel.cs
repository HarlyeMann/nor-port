﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/6/2021 4:23:48 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
// Namespace for the Business Logic Layer
// the Business Logic Layer contains domain logic that encodes real world business rules
//  that determine how data is created, stored and changed. Typically it will also deal with
//  import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//  SOAP http services, using Windows Communication Framework
// links:
//  docLink: http://sql2x.org/documentationLink/0f3a62ca-e301-4d44-8e1a-de9198ba8967
namespace SolutionNorSolutionPort.BusinessLogicLayer.Models {

    // this class is used to carry Model POCO classes
    // links:
    //  docLink: http://sql2x.org/documentationLink/c5c604a1-5d6d-4fb3-8e70-5d7f590292a6
    public partial class CrudeAircraftModel {
        
        [Display(Name="Aircraft Id")]
        [Required()]
        public System.Guid AircraftId { get; set; }
        
        [Display(Name="Aircraft Name")]
        [Required()]
        public string AircraftName { get; set; }
        
        [Display(Name="Aircraft Type")]
        [Required()]
        public string AircraftTypeRcd { get; set; }
        
        [Display(Name="Aircraft Configuration")]
        [Required()]
        public string AircraftConfigurationRcd { get; set; }
        
        [Display(Name="Aircraft Body")]
        [Required()]
        public string AircraftBodyRcd { get; set; }
        
        [Display(Name="Aircraft Measurement Id")]
        [Required()]
        public System.Guid AircraftMeasurementId { get; set; }
        
        [Display(Name="Product Id")]
        [Required()]
        public System.Guid ProductId { get; set; }
        
        [Display(Name="Operational Date Time")]
        [Required()]
        public System.DateTime OperationalDateTime { get; set; }
        
        [Display(Name="First Flight Date Time")]
        [Required()]
        public System.DateTime FirstFlightDateTime { get; set; }
        
        [Display(Name="Engine Type")]
        [Required()]
        public string EngineType { get; set; }
        
        [Display(Name="Passenger Capacity")]
        [Required()]
        public int PassengerCapacity { get; set; }
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; }
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; }
    }
}
