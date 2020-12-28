/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 8:34:41 AM
  From Machine: DESKTOP-BP3OHLH
  Template: sql2x.ProxyGenerator.ProxyForMethodNewStyle
*/
using System.Collections.Generic;
namespace SolutionNorSolutionPort.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IDefaultTestSearchService")]
    public interface IDefaultTestSearchService {
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultTestSearchService/DefaultTestSearchQuery", ReplyAction="http://tempuri.org/IDefaultTestSearchService/DefaultTestSearchQueryResponse")]
        List<DefaultTestSearchQueryContract> DefaultTestSearchQuery ();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDefaultTestSearchServiceChannel : IDefaultTestSearchService, System.ServiceModel.IClientChannel {
    }
    
    public class DefaultTestSearchService : System.ServiceModel.ClientBase<IDefaultTestSearchService>, IDefaultTestSearchService {
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<DefaultTestSearchQueryContract> DefaultTestSearchQuery () {
            return base.Channel.DefaultTestSearchQuery();
        }
        
        public DefaultTestSearchService() {
        }
        
        public DefaultTestSearchService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DefaultTestSearchService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DefaultTestSearchService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DefaultTestSearchService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
    }
}
