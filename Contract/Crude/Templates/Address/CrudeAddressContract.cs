﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 12:01:45 AM
  From Machine: DESKTOP-BP3OHLH
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPort.BusinessLogicLayer {

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
