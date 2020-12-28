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
    public partial class CrudeFinancialCurrencyContract {
        
        [DataMember()]
        public System.Guid FinancialCurrencyId { get; set; }
        
        [DataMember()]
        public string FinancialCurrencyTypeRcd { get; set; }
        
        [DataMember()]
        public string FinancialCurrencyTypeCode { get; set; }
        
        [DataMember()]
        public string FinancialCurrencyTypeName { get; set; }
        
        [DataMember()]
        public string FinancialCurrencyAgainstFinancialCurrencyTypeRcd { get; set; }
        
        [DataMember()]
        public System.DateTime ValidFromDateTime { get; set; }
        
        [DataMember()]
        public System.DateTime ValidUntilDateTime { get; set; }
        
        [DataMember()]
        public decimal Amount { get; set; }
        
        [DataMember()]
        public decimal EqualsAmount { get; set; }
        
        [DataMember()]
        public int DecimalCount { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
