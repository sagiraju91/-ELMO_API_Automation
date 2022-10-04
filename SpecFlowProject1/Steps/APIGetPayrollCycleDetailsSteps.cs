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
    public class APIgetPayrollCyclesDetailsSteps
    {

        [Given(@"the PayrollCyclesDetailsAPI as")]
        public void GivenThePayrollCyclesDetailsAPIAs(Table table)
        {

            dynamic _endPoint = table.CreateDynamicInstance();

            //  GET REQUEST DEV API User List USING DTO
            var _listOfPays = new APIHellperClass<PayrollCyclesDTO>();
            var _client = _listOfPays.SetUrl();
            var _request = _listOfPays.GetRequest(_endPoint.getPayrollCycles);
            var _response = _listOfPays.ApiResponse(_client, _request);

            HttpStatusCode _statusCode = _response.StatusCode;
            int code = (int)_statusCode;
            Console.WriteLine("API Response Code : " + code);


            dynamic _data = _listOfPays.ApiContent<PayrollCyclesDTO>(_response);
            Console.WriteLine("ID : " + _data.id);
            Console.WriteLine("Title : " + _data.title);
            Console.WriteLine("Description : " + _data.description);
            Console.WriteLine("StartDate : " + _data.startDate);
            Console.WriteLine("Type : " + _data.type);
            Console.WriteLine("Default : " + _data.Default);
            Console.WriteLine("WeeksPerAnnum : " + _data.weeksPerAnnum);
            Console.WriteLine("Jurisdiction : " + _data.jurisdiction);

        }

        [When(@"the GET PayrollCyclesDetails is called")]
        public void WhenTheGETPayrollCyclesDetailsIsCalled()
        {
            
        }


        [Then(@"results should have Details of PayrollCycles")]
        public void ThenResultsShouldHaveDetailsOfPayrollCycles()
        {
            
        }

    }
}
