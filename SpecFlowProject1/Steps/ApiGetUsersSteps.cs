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
    class ApiGetUsersSteps
    {
        [Given(@"a working api as")]
        public void GivenAWorkingApi(Table table)
        {
            dynamic _endPoint = table.CreateDynamicInstance();

            //  GET REQUEST DEV API User List USING DTO
            var _listOfUsers = new APIHellperClass<GetUsersDTO>();
            var _client = _listOfUsers.SetUrl();
            var _request = _listOfUsers.GetRequest(_endPoint.getUsers);
            var _response = _listOfUsers.ApiResponse(_client, _request);

            HttpStatusCode _statusCode = _response.StatusCode;
            int code = (int)_statusCode;
            Console.WriteLine("API Response Code : " + code);


            dynamic _data = _listOfUsers.ApiContent<List<GetUsersDTO>>(_response);

            Console.WriteLine("ID : " + _data[0].id);
            Console.WriteLine("Iidentifier : " + _data[0].identifier);
            Console.WriteLine("FirstName : " + _data[0].firstName);
            Console.WriteLine("lastName : " + _data[0].lastName);
            Console.WriteLine("1st Set of Data : username : " + _data[0].username);
            Console.WriteLine("employeeNumber : " + _data[0].employeeNumber);
            Console.WriteLine("email : " + _data[0].email);
            Console.WriteLine("preferredname : " + _data[0].customData.preferredname);

            string usernameExpected = "puma.api";
            string usernameActual = _data[1].username;

            Console.WriteLine("2nd Set of Data : Actual username : " + usernameActual);
            Assert.AreEqual(usernameExpected, usernameActual, "Not Matched", true);
        }


        [When(@"the GET Request is called")]
        public void WhenTheGETRequestIsCalled()
        {
        }

        [Then(@"the result should show list of Users")]
        public void ThenTheResultShouldShowListOfUsers()
        {

        }


    }
}
