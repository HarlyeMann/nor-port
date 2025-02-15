﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/6/2021 4:51:47 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

// Data Access Layer
// the DataAccessLayer is the first layer that has access to data coming from
//  sql server after being streamed over a net or internal process
// links:
//  docLink: http://sql2x.org/documentationLink/42e5ad27-4aa5-4a5b-a42d-59f1659fcdf6
namespace SolutionNorSolutionPort.DataAccessLayer {

    // this class serves as a data access layer between c# and sql server
    // it is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of a ansi sql select statement in AirlineIdentifierIndexWithFilterData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/d360d55c-efab-4b5b-99be-9425d91ebd59
    [Serializable()]
    public partial class AirlineIdentifierIndexWithFilterData {
        
        public string AirlineName { get; set; }
        
        public string LegalName { get; set; }
        
        public string AirlineIdentifierTypeName { get; set; }
        
        public string DefaultUserName { get; set; }
        
        public System.Guid AirlineId { get; set; }
        
        public string AirlineIdentifierTypeRcd { get; set; }
        
        public string AirlineIdentifierCode { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public System.Guid AirlineIdentifierId { get; set; }
        
        // use ordinals to speed up access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/327451c3-64a8-4de8-b359-76742d634497
        // parameters:
        //  reader: IDataReader from SQLClient
        public void Populate(IDataReader reader, AirlineIdentifierIndexWithFilterDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.AirlineName)) AirlineName = reader.GetString(ordinals.AirlineName);
            if (!reader.IsDBNull(ordinals.LegalName)) LegalName = reader.GetString(ordinals.LegalName);
            if (!reader.IsDBNull(ordinals.AirlineIdentifierTypeName)) AirlineIdentifierTypeName = reader.GetString(ordinals.AirlineIdentifierTypeName);
            if (!reader.IsDBNull(ordinals.DefaultUserName)) DefaultUserName = reader.GetString(ordinals.DefaultUserName);
            if (!reader.IsDBNull(ordinals.AirlineId)) AirlineId = reader.GetGuid(ordinals.AirlineId);
            if (!reader.IsDBNull(ordinals.AirlineIdentifierTypeRcd)) AirlineIdentifierTypeRcd = reader.GetString(ordinals.AirlineIdentifierTypeRcd);
            if (!reader.IsDBNull(ordinals.AirlineIdentifierCode)) AirlineIdentifierCode = reader.GetString(ordinals.AirlineIdentifierCode);
            if (!reader.IsDBNull(ordinals.UserId)) UserId = reader.GetGuid(ordinals.UserId);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.AirlineIdentifierId)) AirlineIdentifierId = reader.GetGuid(ordinals.AirlineIdentifierId);
        }
    }
    
    // this class holds ordinals used to data access the DataReader between c# and sql server
    // this class start with an identical representation of the method in AirlineIdentifierIndexWithFilterData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )  with a number indicating the columns position in the original ansi sql select statement
    // links:
    //  docLink: http://sql2x.org/documentationLink/0d935f44-0309-4dca-a8f2-a4e8eafd2201
    public partial class AirlineIdentifierIndexWithFilterDataOrdinals {
        
        public int AirlineName;
        
        public int LegalName;
        
        public int AirlineIdentifierTypeName;
        
        public int DefaultUserName;
        
        public int AirlineId;
        
        public int AirlineIdentifierTypeRcd;
        
        public int AirlineIdentifierCode;
        
        public int UserId;
        
        public int DateTime;
        
        public int AirlineIdentifierId;
        
        // get ordinals in order to speed up subsequent access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/41a04ed0-5ed8-4d0e-bb90-ccfbfd219e82
        // parameters:
        //  reader: IDataReader from SQLClient
        public AirlineIdentifierIndexWithFilterDataOrdinals(IDataReader reader) {
            AirlineName = reader.GetOrdinal("airline_name");
            LegalName = reader.GetOrdinal("legal_name");
            AirlineIdentifierTypeName = reader.GetOrdinal("airline_identifier_type_name");
            DefaultUserName = reader.GetOrdinal("default_user_name");
            AirlineId = reader.GetOrdinal("airline_id");
            AirlineIdentifierTypeRcd = reader.GetOrdinal("airline_identifier_type_rcd");
            AirlineIdentifierCode = reader.GetOrdinal("airline_identifier_code");
            UserId = reader.GetOrdinal("user_id");
            DateTime = reader.GetOrdinal("date_time");
            AirlineIdentifierId = reader.GetOrdinal("airline_identifier_id");
        }
    }
}
