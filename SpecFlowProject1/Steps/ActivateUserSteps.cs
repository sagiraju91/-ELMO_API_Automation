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
    public class ActivateUserSteps
    {

        [Given(@"activate user api as")]
        public void GivenActivateUserApiAs(Table table)
        {
            dynamic _endPoint = table.CreateDynamicInstance();

            //  GET REQUEST DEV API User Details USING DTO
            var _activateUser = new APIHellperClass<ActivateUserDTO>();
            var _client = _activateUser.SetUrl();
            var _request = _activateUser.PostRequest(_endPoint.activateUser,String.Empty);
            var _response = _activateUser.ApiResponse(_client, _request);

            HttpStatusCode statusCode = _response.StatusCode;
            int numericStatusCode = (int)statusCode;
            Console.WriteLine("API POST Response Status: " + numericStatusCode);


            dynamic _content = _activateUser.ApiContent<ActivateUserDTO>(_response);
            Console.WriteLine("ResponseCode found is: " + _content.responseCode);
            Console.WriteLine("Summary found is: " + _content.summary);
            Console.WriteLine("Id found is: " + _content.id);            
            Console.WriteLine("success logs found is: " + _content.logs.success);
            Console.WriteLine("successCount logs found is: " + _content.logs.successCount);
            Console.WriteLine("failure logs found is: " + _content.logs.failure);
            Console.WriteLine("failureCount logs found is: " + _content.logs.failureCount);
          

        }
        [When(@"the POST method is called")]
        public void WhenThePostMethodIsCalled()
        {
            
        }
        [Then(@"the user shoud be activated")]
        public void ThenTheUserShoudBeActivated()
        {
            
        }

    }
}
