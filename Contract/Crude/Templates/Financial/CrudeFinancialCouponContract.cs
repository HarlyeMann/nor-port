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
    public partial class CrudeFinancialCouponContract {
        
        [DataMember()]
        public System.Guid FinancialCouponId { get; set; }
        
        [DataMember()]
        public string FinancialCouponTypeRcd { get; set; }
        
        [DataMember()]
        public int CouponNumber { get; set; }
        
        [DataMember()]
        public decimal ValueAmount { get; set; }
        
        [DataMember()]
        public System.Guid FinancialCurrencyId { get; set; }
        
        [DataMember()]
        public System.DateTime ValidFromDateTime { get; set; }
        
        [DataMember()]
        public System.DateTime ValidUntilDateTime { get; set; }
        
        [DataMember()]
        public string CouponDescription { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
