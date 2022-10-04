using NUnit.Framework;
using SpecFlowProject1.DTO;
using SpecFlowProject1.Helper;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProject1.Steps
{
   [Binding]
    class ApiGetLegalEntityDetailSteps
    {
        [Given(@"a working LegalEntityDetails api as")]
        public void GivenAWorkingLegalEntityDetailsApiAs(Table table)
        {
            
            dynamic _endPoint = table.CreateDynamicInstance();

            //  GET REQUEST DEV API User List USING DTO
            var _listOfUsers = new APIHellperClass<LegalEntityDTO>();
            var _client = _listOfUsers.SetUrl();
            var _request = _listOfUsers.GetRequest(_endPoint.getLegalEntity);
            var _response = _listOfUsers.ApiResponse(_client, _request);

            HttpStatusCode _statusCode = _response.StatusCode;
            int code = (int)_statusCode;
            Console.WriteLine("API Response Code : " + code);


            dynamic _data = _listOfUsers.ApiContent<LegalEntityDTO>(_response);

            Console.WriteLine("ID : " + _data.id);
            Console.WriteLine("Abn : " + _data.abn);
            Console.WriteLine("BusinessName : " + _data.businessName);
            Console.WriteLine("TradingName : " + _data.tradingName);
            Console.WriteLine("BranchNumber : " + _data.branchNumber);
            Console.WriteLine("ContactName : " + _data.contactName);
            Console.WriteLine("Phone : " + _data.phone);
            Console.WriteLine("Fax : " + _data.fax);
            Console.WriteLine("Email : " + _data.email);
            Console.WriteLine("Default : " + _data.Default);
            Console.WriteLine("Active : " + _data.active);
            Console.WriteLine("Jurisdiction : " + _data.jurisdiction);
            Console.WriteLine("Address : " + _data.address);
            Console.WriteLine("AddressLine1 : " + _data.address.addressLine1);
            Console.WriteLine("AddressLine2 : " + _data.address.addressLine2);
            Console.WriteLine("Suburb : " + _data.address.suburb);
            Console.WriteLine("State : " + _data.address.state);
            Console.WriteLine("Postcode : " + _data.address.postcode);
            Console.WriteLine("Country : " + _data.address.country);

        }


        [When(@"the GET Request is called for Legal Entity Details")]
        public void WhenTheGETRequestIsCalledForLegalEntityDetails()
        {
          
        }

        [Then(@"the result should show Details of Legal Entity")]
        public void ThenTheResultShouldShowDetailsOfLegalEntity()
        {
         
        }

    }
}
