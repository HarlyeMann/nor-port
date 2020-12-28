﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 4:54:56 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPort.BusinessLogicLayer {

    [DataContract()]
    public partial class CrudeFinancialPaymentCardContract {
        
        [DataMember()]
        public System.Guid FinancialPaymentCardId { get; set; }
        
        [DataMember()]
        public string FinancialCardTypeRcd { get; set; }
        
        [DataMember()]
        public string NameOnCard { get; set; }
        
        [DataMember()]
        public string CardNumber { get; set; }
        
        [DataMember()]
        public int CardVerificationValue { get; set; }
        
        [DataMember()]
        public string AddressVerificationCode { get; set; }
        
        [DataMember()]
        public int IssuedYear { get; set; }
        
        [DataMember()]
        public int IssuedMonth { get; set; }
        
        [DataMember()]
        public int ExpiryYear { get; set; }
        
        [DataMember()]
        public int ExpiryMonth { get; set; }
        
        [DataMember()]
        public decimal Amount { get; set; }
        
        [DataMember()]
        public System.Guid FinancialCurrencyId { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
