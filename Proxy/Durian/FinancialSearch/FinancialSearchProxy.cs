/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/29/2020 3:07:09 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.ProxyGenerator.ProxyForMethodNewStyle
*/
using System.Collections.Generic;
// Namespace for a Business Logic Layer in a Proxy
// the Business Logic Layer contains domain logic that encodes real world business rules
//  that determine how data is created, stored and changed. Typically it will also deal with
//  import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//  REST http services
// links:
//  business logic layer: https://en.wikipedia.org/wiki/Business_logic
// application programming interface: https://en.wikipedia.org/wiki/API
//  docLink: http://sql2x.org/documentationLink/2595ba81-a5dc-4b5a-8bc8-2f7ca6630d9b
namespace SolutionNorSolutionPort.BusinessLogicLayer {
    
    
    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  SOAP ( Simple Object Access Protocol ): https://en.wikipedia.org/wiki/SOAP
    // Interface/Protocol (object-oriented programming): https://en.wikipedia.org/wiki/Protocol_(object-oriented_programming)
    // WCF ( Windows Communication Foundation ): https://en.wikipedia.org/wiki/Windows_Communication_Foundation
    //  docLink: http://sql2x.org/documentationLink/54dd6dfa-2ac2-4032-a68d-47e4f658ece7
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IFinancialSearchService")]
    public interface IFinancialSearchService {
        // returns a list of GetAvailableCurrencies contracts from FinancialSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  financialCurrencyId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  currencyDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFinancialSearchService/GetAvailableCurrencies", ReplyAction="http://tempuri.org/IFinancialSearchService/GetAvailableCurrenciesResponse")]
        List<GetAvailableCurrenciesContract> GetAvailableCurrencies (System.Guid financialCurrencyId,System.DateTime currencyDateTime);
        // returns a list of FinancialFares contracts from FinancialSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFinancialSearchService/FinancialFares", ReplyAction="http://tempuri.org/IFinancialSearchService/FinancialFaresResponse")]
        List<FinancialFaresContract> FinancialFares ();
        // returns a list of VoucherSearchWithRemainingAmount contracts from FinancialSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  voucherValidOnDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFinancialSearchService/VoucherSearchWithRemainingAmount", ReplyAction="http://tempuri.org/IFinancialSearchService/VoucherSearchWithRemainingAmountResponse")]
        List<VoucherSearchWithRemainingAmountContract> VoucherSearchWithRemainingAmount (System.DateTime voucherValidOnDateTime);
        // returns a list of VoucherTransactions contracts from FinancialSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  financialVoucherId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFinancialSearchService/VoucherTransactions", ReplyAction="http://tempuri.org/IFinancialSearchService/VoucherTransactionsResponse")]
        List<VoucherTransactionsContract> VoucherTransactions (System.Guid financialVoucherId);
        // returns a list of FinancialServiceDetailsForBooking contracts from FinancialSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFinancialSearchService/FinancialServiceDetailsForBooking", ReplyAction="http://tempuri.org/IFinancialSearchService/FinancialServiceDetailsForBookingResponse")]
        List<FinancialServiceDetailsForBookingContract> FinancialServiceDetailsForBooking (System.Guid bookingId);
        // returns a list of ServiceFerryList contracts from FinancialSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFinancialSearchService/ServiceFerryList", ReplyAction="http://tempuri.org/IFinancialSearchService/ServiceFerryListResponse")]
        List<ServiceFerryListContract> ServiceFerryList ();
        // returns a list of ServiceCarRentalList contracts from FinancialSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFinancialSearchService/ServiceCarRentalList", ReplyAction="http://tempuri.org/IFinancialSearchService/ServiceCarRentalListResponse")]
        List<ServiceCarRentalListContract> ServiceCarRentalList ();
        // returns a list of ServiceHotelList contracts from FinancialSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFinancialSearchService/ServiceHotelList", ReplyAction="http://tempuri.org/IFinancialSearchService/ServiceHotelListResponse")]
        List<ServiceHotelListContract> ServiceHotelList ();
        // returns a list of SpecialServiceRequestList contracts from FinancialSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFinancialSearchService/SpecialServiceRequestList", ReplyAction="http://tempuri.org/IFinancialSearchService/SpecialServiceRequestListResponse")]
        List<SpecialServiceRequestListContract> SpecialServiceRequestList ();
        // returns a list of TransactionsCreditDebitBalance contracts from FinancialSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  fromDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  untilDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFinancialSearchService/TransactionsCreditDebitBalance", ReplyAction="http://tempuri.org/IFinancialSearchService/TransactionsCreditDebitBalanceResponse")]
        List<TransactionsCreditDebitBalanceContract> TransactionsCreditDebitBalance (System.DateTime fromDateTime,System.DateTime untilDateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFinancialSearchServiceChannel : IFinancialSearchService, System.ServiceModel.IClientChannel {
    }
    
    public class FinancialSearchService : System.ServiceModel.ClientBase<IFinancialSearchService>, IFinancialSearchService {
        // returns a list of GetAvailableCurrencies contracts from FinancialSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  financialCurrencyId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  currencyDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<GetAvailableCurrenciesContract> GetAvailableCurrencies (System.Guid financialCurrencyId,System.DateTime currencyDateTime) {
            return base.Channel.GetAvailableCurrencies(financialCurrencyId, currencyDateTime);
        }
        // returns a list of FinancialFares contracts from FinancialSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        public List<FinancialFaresContract> FinancialFares () {
            return base.Channel.FinancialFares();
        }
        // returns a list of VoucherSearchWithRemainingAmount contracts from FinancialSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  voucherValidOnDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<VoucherSearchWithRemainingAmountContract> VoucherSearchWithRemainingAmount (System.DateTime voucherValidOnDateTime) {
            return base.Channel.VoucherSearchWithRemainingAmount(voucherValidOnDateTime);
        }
        // returns a list of VoucherTransactions contracts from FinancialSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  financialVoucherId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<VoucherTransactionsContract> VoucherTransactions (System.Guid financialVoucherId) {
            return base.Channel.VoucherTransactions(financialVoucherId);
        }
        // returns a list of FinancialServiceDetailsForBooking contracts from FinancialSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<FinancialServiceDetailsForBookingContract> FinancialServiceDetailsForBooking (System.Guid bookingId) {
            return base.Channel.FinancialServiceDetailsForBooking(bookingId);
        }
        // returns a list of ServiceFerryList contracts from FinancialSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        public List<ServiceFerryListContract> ServiceFerryList () {
            return base.Channel.ServiceFerryList();
        }
        // returns a list of ServiceCarRentalList contracts from FinancialSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        public List<ServiceCarRentalListContract> ServiceCarRentalList () {
            return base.Channel.ServiceCarRentalList();
        }
        // returns a list of ServiceHotelList contracts from FinancialSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        public List<ServiceHotelListContract> ServiceHotelList () {
            return base.Channel.ServiceHotelList();
        }
        // returns a list of SpecialServiceRequestList contracts from FinancialSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        public List<SpecialServiceRequestListContract> SpecialServiceRequestList () {
            return base.Channel.SpecialServiceRequestList();
        }
        // returns a list of TransactionsCreditDebitBalance contracts from FinancialSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  fromDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  untilDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<TransactionsCreditDebitBalanceContract> TransactionsCreditDebitBalance (System.DateTime fromDateTime,System.DateTime untilDateTime) {
            return base.Channel.TransactionsCreditDebitBalance(fromDateTime, untilDateTime);
        }
        
        public FinancialSearchService() {
        }
        
        public FinancialSearchService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FinancialSearchService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FinancialSearchService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FinancialSearchService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
    }
}
