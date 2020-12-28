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
    public partial class CrudeDefaultUserContract {
        
        [DataMember()]
        public System.Guid DefaultUserId { get; set; }
        
        [DataMember()]
        public string DefaultUserCode { get; set; }
        
        [DataMember()]
        public string DefaultUserName { get; set; }
        
        [DataMember()]
        public string Email { get; set; }
        
        [DataMember()]
        public string Password { get; set; }
        
        [DataMember()]
        public string DefaultStateRcd { get; set; }
        
        [DataMember()]
        public System.Guid CreatedByDefaultUserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
        
        [DataMember()]
        public System.DateTime LastActivityDateTime { get; set; }
    }
}
