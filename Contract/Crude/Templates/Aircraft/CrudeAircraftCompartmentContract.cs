﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 4:54:55 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPort.BusinessLogicLayer {

    [DataContract()]
    public partial class CrudeAircraftCompartmentContract {
        
        [DataMember()]
        public System.Guid AircraftCompartmentId { get; set; }
        
        [DataMember()]
        public System.Guid AircraftId { get; set; }
        
        [DataMember()]
        public System.Guid AircraftCompartmentMeasurementId { get; set; }
        
        [DataMember()]
        public string AircraftCompartmentTypeRcd { get; set; }
        
        [DataMember()]
        public string AircraftCompartmentName { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
