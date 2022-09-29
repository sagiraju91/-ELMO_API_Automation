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
    class APIGetUserDetailsSteps
    {
        [Given(@"a working get user api as")]
        public void GivenAWorkingGetUserApiAs(Table table)
        {
            dynamic _endPoint = table.CreateDynamicInstance();

            //  GET REQUEST DEV API User Details USING DTO
            var _listOfUsers = new APIHellperClass<GetUsersDTO>();
            var _client = _listOfUsers.SetUrl();
            var _request = _listOfUsers.GetRequest(_endPoint.getUser);
            var _response = _listOfUsers.ApiResponse(_client, _request);

            HttpStatusCode _statusCode = _response.StatusCode;
            int code = (int)_statusCode;
            Console.WriteLine("API Response Code : " + code);


            dynamic _data = _listOfUsers.ApiContent<GetUsersDTO>(_response);

            Console.WriteLine("firstName : " + _data.firstName);
            Console.WriteLine("lastName : " + _data.lastName);           

        }


        [When(@"the GET Request is called for an user")]
        public void WhenTheGETRequestIsCalledForAnUser()
        {

        }

        [Then(@"the result should show user details")]
        public void ThenTheResultShouldShowUserDetails()
        {

        }
    }
}
