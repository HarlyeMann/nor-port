﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 7:51:26 AM
  From Machine: DESKTOP-BP3OHLH
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPort.BusinessLogicLayer {

    [DataContract()]
    public partial class CrudeBookingFlightSegmentContract {
        
        [DataMember()]
        public System.Guid BookingFlightSegmentId { get; set; }
        
        [DataMember()]
        public System.Guid BecameBookingFlightSegmentId { get; set; }
        
        [DataMember()]
        public System.Guid BindingBookingFlightSegmentId { get; set; }
        
        [DataMember()]
        public System.Guid BookingId { get; set; }
        
        [DataMember()]
        public System.Guid FlightSegmentId { get; set; }
        
        [DataMember()]
        public string DefaultStateRcd { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
