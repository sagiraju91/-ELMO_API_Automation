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
    public class APIgetLeaveTypesStep
    {

        [Given(@"the LeaveTypesAPI as")]
        public void GivenTheLeaveTypesAPIAs(Table table)
        {
           
            dynamic _endPoint = table.CreateDynamicInstance();

            //  GET REQUEST DEV API User List USING DTO
            var _listOfDepts = new APIHellperClass<LeaveTypesDTO>();
            var _client = _listOfDepts.SetUrl();
            var _request = _listOfDepts.GetRequest(_endPoint.getLeaveTypes);
            var _response = _listOfDepts.ApiResponse(_client, _request);

            HttpStatusCode _statusCode = _response.StatusCode;
            int code = (int)_statusCode;
            Console.WriteLine("API Response Code : " + code);


            dynamic _data = _listOfDepts.ApiContent<List<LeaveTypesDTO>>(_response);
            Console.WriteLine("ID : " + _data[0].id);
            Console.WriteLine("AccrualType : " + _data[0].accrualType);
            Console.WriteLine("1st Set of Data : Title : " + _data[0].title);
            Console.WriteLine("DisplayTitle : " + _data[0].displayTitle);
            Console.WriteLine("Description : " + _data[0].description);
            Console.WriteLine("Code : " + _data[0].code);
            Console.WriteLine("EntitlementType : " + _data[0].entitlementType);
            Console.WriteLine("Deleted : " + _data[0].deleted);
            
            string titleExpected = "Unpaid Carer’s Leave";
            string titleActual = _data[1].title;

            Console.WriteLine("2nd Set of Data : Actual username : " + titleActual);
            Assert.AreEqual(titleExpected, titleActual, "Not Matched", true);
        }



        [When(@"the GET Leave Types is called")]
        public void WhenTheGETLeaveTypesIsCalled()
        {
            
        }


        [Then(@"results shouls have list of LeaveTypes")]
        public void ThenResultsShoulsHaveListOfLeaveTypes()
        {
        
        }

    }
}
