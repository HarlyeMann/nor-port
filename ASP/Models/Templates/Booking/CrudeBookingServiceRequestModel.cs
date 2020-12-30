﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 6:43:54 AM
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
//  business logic layer: https://en.wikipedia.org/wiki/Business_logic
// application programming interface: https://en.wikipedia.org/wiki/API
//  docLink: http://sql2x.org/documentationLink/0f3a62ca-e301-4d44-8e1a-de9198ba8967
namespace SolutionNorSolutionPort.BusinessLogicLayer.Models {

    // this class is used to carry Model POCO classes
    // links:
    //  POCO ( Plain old CLR object ): https://en.wikipedia.org/wiki/Plain_old_CLR_object
    //  docLink: http://sql2x.org/documentationLink/c5c604a1-5d6d-4fb3-8e70-5d7f590292a6
    public partial class CrudeBookingServiceRequestModel {
        
        [Display(Name="Booking Service Request Id")]
        [Required()]
        public System.Guid BookingServiceRequestId { get; set; }
        
        [Display(Name="Booking Id")]
        [Required()]
        public System.Guid BookingId { get; set; }
        
        [Display(Name="Service Type")]
        [Required()]
        public string ServiceTypeRcd { get; set; }
        
        [Display(Name="Service Special Service Request Id")]
        [Required()]
        public System.Guid ServiceSpecialServiceRequestId { get; set; }
        
        [Display(Name="Service Request Status")]
        [Required()]
        public string ServiceRequestStatusRcd { get; set; }
        
        [Display(Name="Service Hotel Id")]
        [Required()]
        public System.Guid ServiceHotelId { get; set; }
        
        [Display(Name="Service Car Rental Id")]
        [Required()]
        public System.Guid ServiceCarRentalId { get; set; }
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; }
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; }
        
        [Display(Name="Service Ferry Id")]
        [Required()]
        public System.Guid ServiceFerryId { get; set; }
    }
}
