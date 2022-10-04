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
    public class APIgetPayrollCyclesSteps
    {

        [Given(@"the PayrollCyclesAPI as")]
        public void GivenThePayrollCyclesAPIAs(Table table)
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


            dynamic _data = _listOfPays.ApiContent<List<PayrollCyclesDTO>>(_response);
            Console.WriteLine("ID : " + _data[0].id);
            Console.WriteLine("1st Set of Data: Title : " + _data[0].title);
            Console.WriteLine("Description : " + _data[0].description);
            Console.WriteLine("StartDate : " + _data[0].startDate);
            Console.WriteLine("Type : " + _data[0].type);
            Console.WriteLine("Default : " + _data[0].Default);
            Console.WriteLine("WeeksPerAnnum : " + _data[0].weeksPerAnnum);
            Console.WriteLine("Jurisdiction : " + _data[0].jurisdiction);

            string titleExpected = "Fortnightly Payroll";
            string titleActual = _data[1].title;

            Console.WriteLine("2nd Set of Data : Actual username : " + titleActual);
            Assert.AreEqual(titleExpected, titleActual, "Not Matched", true);
        }



        [When(@"the GET PayrollCycles is called")]
        public void WhenTheGETPayrollCyclesIsCalled()
        {
            
        }


        [Then(@"results should have list of PayrollCycles")]
        public void ThenResultsShouldHaveListOfPayrollCycles()
        {

        }

    }
}
