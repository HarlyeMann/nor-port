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
    public partial class CrudeDefaultVersionContract {
        
        [DataMember()]
        public System.Guid DefaultVersionId { get; set; }
        
        [DataMember()]
        public string FunVersion { get; set; }
        
        [DataMember()]
        public string Number { get; set; }
        
        [DataMember()]
        public int MajorNumber { get; set; }
        
        [DataMember()]
        public int MinorNumber { get; set; }
        
        [DataMember()]
        public int SequenceNumber { get; set; }
        
        [DataMember()]
        public System.Guid DefaultUserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
