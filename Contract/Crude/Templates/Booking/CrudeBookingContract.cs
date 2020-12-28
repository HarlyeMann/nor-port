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
    public partial class CrudeBookingContract {
        
        [DataMember()]
        public System.Guid BookingId { get; set; }
        
        [DataMember()]
        public string ReceivedFrom { get; set; }
        
        [DataMember()]
        public System.Guid AddressId { get; set; }
        
        [DataMember()]
        public string BookingSourceRcd { get; set; }
        
        [DataMember()]
        public System.Guid ExternalSystemId { get; set; }
        
        [DataMember()]
        public System.Guid AgencyId { get; set; }
        
        [DataMember()]
        public System.Guid FinancialCurrencyId { get; set; }
        
        [DataMember()]
        public System.Guid FinancialCostcentreId { get; set; }
        
        [DataMember()]
        public string Comment { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
