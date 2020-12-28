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
    public partial class CrudeDefaultErrorContract {
        
        [DataMember()]
        public System.Guid DefaultErrorId { get; set; }
        
        [DataMember()]
        public string DefaultErrorLayerRcd { get; set; }
        
        [DataMember()]
        public string DefaultErrorTypeRcd { get; set; }
        
        [DataMember()]
        public string LayerAddress { get; set; }
        
        [DataMember()]
        public string ErrorMessage { get; set; }
        
        [DataMember()]
        public string StackTrace { get; set; }
        
        [DataMember()]
        public string MethodName { get; set; }
        
        [DataMember()]
        public string DomainName { get; set; }
        
        [DataMember()]
        public string ClassName { get; set; }
        
        [DataMember()]
        public System.Guid DefaultUserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
