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
    class ApiGetLegalEntitySteps
    {
        [Given(@"a working LegalEntity api as")]
        public void GivenAWorkingLegalEntityApiAs(Table table)
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


            dynamic _data = _listOfUsers.ApiContent<List<LegalEntityDTO>>(_response);

            Console.WriteLine("ID : " + _data[0].id);
            Console.WriteLine("Abn : " + _data[0].abn);
            Console.WriteLine("BusinessName : " + _data[0].businessName);
            Console.WriteLine("TradingName : " + _data[0].tradingName);
            Console.WriteLine("BranchNumber : " + _data[0].branchNumber);
            Console.WriteLine("ContactName : " + _data[0].contactName);
            Console.WriteLine("Phone : " + _data[0].phone);
            Console.WriteLine("Fax : " + _data[0].fax);
            Console.WriteLine("Email : " + _data[0].email);
            Console.WriteLine("Default : " + _data[0].Default);
            Console.WriteLine("Active : " + _data[0].active);
            Console.WriteLine("Jurisdiction : " + _data[0].jurisdiction);
            Console.WriteLine("Address : " + _data[0].address);
            Console.WriteLine("AddressLine1 : " + _data[0].address.addressLine1);
            Console.WriteLine("AddressLine2 : " + _data[0].address.addressLine2);
            Console.WriteLine("Suburb : " + _data[0].address.suburb);
            Console.WriteLine("State : " + _data[0].address.state);
            Console.WriteLine("Postcode : " + _data[0].address.postcode);
            Console.WriteLine("Country : " + _data[0].address.country);

            //string usernameExpected = "puma.api";
            //string usernameActual = _data[1].username;

            //Console.WriteLine("2nd Set of Data : Actual username : " + usernameActual);
            //Assert.AreEqual(usernameExpected, usernameActual, "Not Matched", true);
        }


        [When(@"the GET Request is called for Legal Entity")]
        public void WhenTheGETRequestIsCalledForLegalEntity()
        {
            
        }

        [Then(@"the result should show list of Legal Entities")]
        public void ThenTheResultShouldShowListOfLegalEntities()
        {
            
        }


    }
}
