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
    class APIGetUserDetailSteps
    {
        [Given(@"a working get user contact details api as")]
        public void GivenAWorkingGetUserContactDetailsApiAs(Table table)
        {
                       dynamic _endPoint = table.CreateDynamicInstance();

            //  GET REQUEST DEV API User Details USING DTO
            var _listOfUsers = new APIHellperClass<GetUsersContactDetailsDTO>();
            var _client = _listOfUsers.SetUrl();
            var _request = _listOfUsers.GetRequest(_endPoint.getUser);
            var _response = _listOfUsers.ApiResponse(_client, _request);

            HttpStatusCode _statusCode = _response.StatusCode;
            int code = (int)_statusCode;
            Console.WriteLine("API Response Code : " + code);


            dynamic _data = _listOfUsers.ApiContent<GetUsersContactDetailsDTO>(_response);

            Console.WriteLine("PersonalEmail : " + _data.personalEmail);
            Console.WriteLine("HomePhone : " + _data.homePhone);
            Console.WriteLine("WorkPhone : " + _data.workPhone);
            Console.WriteLine("PersonalMobile : " + _data.personalMobile);
            Console.WriteLine("AddressLine1 : " + _data.addressLine1);
            Console.WriteLine("AddressLine2 : " + _data.addressLine2);
            Console.WriteLine("Suburb : " + _data.suburb);
            Console.WriteLine("State : " + _data.state);
            Console.WriteLine("PostCode : " + _data.postCode);
            Console.WriteLine("Country : " + _data.country);
           
        }


        [When(@"the GET Request  called for an user")]
        public void WhenTheGETRequestCalledForAnUser()
        {
                      
        }

        [Then(@"the result should show user contact details")]
        public void ThenTheResultShouldShowUserContactDetails()
        {
                        
        }
    }
}
