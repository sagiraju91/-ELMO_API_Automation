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
    class APIGeEmployementDetailsSteps
    {
        [Given(@"a working get employement details api as")]
        public void GivenAWorkingGetEmployementDetailsApiAs(Table table)
        {

            dynamic _endPoint = table.CreateDynamicInstance();

            //  GET REQUEST DEV API User Details USING DTO
            var _listOfEmp = new APIHellperClass<EmploymentDetailsDTO>();
            var _client = _listOfEmp.SetUrl();
            var _request = _listOfEmp.GetRequest(_endPoint.getEmployement);
            var _response = _listOfEmp.ApiResponse(_client, _request);

            HttpStatusCode _statusCode = _response.StatusCode;
            int code = (int)_statusCode;
            Console.WriteLine("API Response Code : " + code);


            dynamic _data = _listOfEmp.ApiContent<EmploymentDetailsDTO>(_response);

            Console.WriteLine("Id : " + _data.id);
            Console.WriteLine("EmploymentType : " + _data.employmentType);
            Console.WriteLine("UnitsPerWeek : " + _data.unitsPerWeek);
            Console.WriteLine("Rate : " + _data.rate);
            Console.WriteLine("RateType : " + _data.rateType);
            Console.WriteLine("TerminationDate : " + _data.terminationDate);
            Console.WriteLine("PayCycle : " + _data.payCycle);
            Console.WriteLine("TaxDetails : " + _data.taxDetails);
            Console.WriteLine("BankAccountDetails : " + _data.bankAccountDetails);
            Console.WriteLine("SuperannuationDetails : " + _data.superannuationDetails);

        }


        [When(@"the GET Request is called for an employement")]
        public void WhenTheGETRequestIsCalledForAnEmployement()
        {


        }

        [Then(@"the result should show employement details")]
        public void ThenTheResultShouldShowEmployementDetails()
        {


        }
    }
}

