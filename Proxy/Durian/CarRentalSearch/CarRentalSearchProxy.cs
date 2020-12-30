/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 9:24:22 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.ProxyGenerator.ProxyForMethodNewStyle
*/
using System.Collections.Generic;
// Namespace for a Business Logic Layer in a Proxy
// Namespace for a Business Logic Layer in a Proxy
// the Business Logic Layer contains domain logic that encodes real world business rules
//  that determine how data is created, stored and changed. Typically it will also deal with
//  import and export of data and integration with API's from other parts of the system or other systems
// Namespace for a Business Logic Layer in a Proxy
// the Business Logic Layer contains domain logic that encodes real world business rules
//  that determine how data is created, stored and changed. Typically it will also deal with
//  import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//  REST http services
// links:
//  docLink: http://sql2x.org/documentationLink/2595ba81-a5dc-4b5a-8bc8-2f7ca6630d9b
namespace SolutionNorSolutionPort.BusinessLogicLayer {
    
    
    // Interface class for an WCF Service contract
    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  docLink: http://sql2x.org/documentationLink/54dd6dfa-2ac2-4032-a68d-47e4f658ece7
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICarRentalSearchService")]
    public interface ICarRentalSearchService {
        // returns a list of GetCarRentalIndexWithFilter contracts from CarRentalSearchService
        // returns a list of GetCarRentalIndexWithFilter contracts from CarRentalSearchService
        // returns a list of GetCarRentalIndexWithFilter contracts from CarRentalSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarRentalSearchService/GetCarRentalIndexWithFilter", ReplyAction="http://tempuri.org/ICarRentalSearchService/GetCarRentalIndexWithFilterResponse")]
        List<GetCarRentalIndexWithFilterContract> GetCarRentalIndexWithFilter ();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICarRentalSearchServiceChannel : ICarRentalSearchService, System.ServiceModel.IClientChannel {
    }
    
    public class CarRentalSearchService : System.ServiceModel.ClientBase<ICarRentalSearchService>, ICarRentalSearchService {
        // returns a list of GetCarRentalIndexWithFilter contracts from CarRentalSearchService
        // returns a list of GetCarRentalIndexWithFilter contracts from CarRentalSearchService
        // returns a list of GetCarRentalIndexWithFilter contracts from CarRentalSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        public List<GetCarRentalIndexWithFilterContract> GetCarRentalIndexWithFilter () {
            return base.Channel.GetCarRentalIndexWithFilter();
        }
        
        public CarRentalSearchService() {
        }
        
        public CarRentalSearchService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CarRentalSearchService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CarRentalSearchService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CarRentalSearchService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
    }
}
