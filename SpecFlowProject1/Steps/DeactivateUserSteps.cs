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
    public class DeactivateUserSteps
    {

        [Given(@"deactivate user api as")]
        public void GivenDeactivateUserApiAs(Table table)
        {
            dynamic _endPoint = table.CreateDynamicInstance();

            //  GET REQUEST DEV API User Details USING DTO
            var _deactivateUser = new APIHellperClass<ActivateUserDTO>();
            var _client = _deactivateUser.SetUrl();
            var _request = _deactivateUser.PostRequest(_endPoint.deactivateUser,String.Empty);
            var _response = _deactivateUser.ApiResponse(_client, _request);

            HttpStatusCode statusCode = _response.StatusCode;
            int numericStatusCode = (int)statusCode;
            Console.WriteLine("API POST Response Status: " + numericStatusCode);


            dynamic _content = _deactivateUser.ApiContent<ActivateUserDTO>(_response);
            Console.WriteLine("ResponseCode found is: " + _content.responseCode);
            Console.WriteLine("Summary found is: " + _content.summary);
            Console.WriteLine("Id found is: " + _content.id);            
            Console.WriteLine("success logs found is: " + _content.logs.success);
            Console.WriteLine("successCount logs found is: " + _content.logs.successCount);
            Console.WriteLine("failure logs found is: " + _content.logs.failure);
            Console.WriteLine("failureCount logs found is: " + _content.logs.failureCount);
          

        }
        [When(@"the POST method called")]
        public void WhenThePOSTMethodCalled()
        {

        }
        [Then(@"the user shoud be deactivated")]
        public void ThenTheUserShoudBeDeactivated()
        {
            
        }

    }
}
