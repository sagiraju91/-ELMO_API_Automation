using Newtonsoft.Json.Linq;
using SpecFlowProject1.DTO;
using SpecFlowProject1.Helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProject1.Steps
{
    [Binding]
    class APIUpdateUserDetailSteps
    {
       

        [Given(@"a working update user contact details api as")]
        public void GivenAWorkingUpdateUserContactDetailsApiAs(Table table)
        {
            string jsonFile = @"C:\Users\sowjy\source\repos\SpecFlowProject1\JSONBODY\updatepersonaldetails.json";

            JObject obj = JObject.Parse(File.ReadAllText(jsonFile));

            String payload = obj.ToString();
            Console.WriteLine("Request Body: "+payload);
            Console.WriteLine("\n");

            dynamic _endPoint = table.CreateDynamicInstance();

            //  GET REQUEST DEV API User Details USING DTO
            var _updateUserData = new APIHellperClass<UpdatePersonalDetailsDTO>();
            var _client = _updateUserData.SetUrl();
            var _request = _updateUserData.PutRequest(_endPoint.putUser, payload);
            var _response = _updateUserData.ApiResponse(_client, _request);

            HttpStatusCode _statusCode = _response.StatusCode;
            int code = (int)_statusCode;
            Console.WriteLine("************** RESPONSE BODY ******************");
            Console.WriteLine("API Response Code : " + code);

            dynamic _data = _updateUserData.ApiContent<UpdatePersonalDetailsDTO>(_response);
            Console.WriteLine("************** Verifying Response Data ******************");
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


        [When(@"the PUT Request  called for an user")]
        public void WhenThePUTRequestCalledForAnUser()
        {
            
          
        }

        [Then(@"the result should show updated user contact details")]
        public void ThenTheResultShouldShowUpdatedUserContactDetails()
        {
           

        }
    }
}
