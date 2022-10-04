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
    public class APIgetLeaveTypesDetailsStep
    {

        [Given(@"the LeaveTypesDetailsAPI as")]
        public void GivenTheLeaveTypesDetailsAPIAs(Table table)
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


            dynamic _data = _listOfDepts.ApiContent<LeaveTypesDTO>(_response);
            Console.WriteLine("ID : " + _data.id);
            Console.WriteLine("AccrualType : " + _data.accrualType);
            Console.WriteLine("1st Set of Data : Title : " + _data.title);
            Console.WriteLine("DisplayTitle : " + _data.displayTitle);
            Console.WriteLine("Description : " + _data.description);
            Console.WriteLine("Code : " + _data.code);
            Console.WriteLine("EntitlementType : " + _data.entitlementType);
            Console.WriteLine("Deleted : " + _data.deleted);
            
        }



        [When(@"the GET Leave Types Details is called")]
        public void WhenTheGETLeaveTypesDetailsIsCalled()
        {
           
        }


        [Then(@"results shoulds have Details of LeaveTypes")]
        public void ThenResultsShouldsHaveDetailsOfLeaveTypes()
        {
            
        }

    }
}
