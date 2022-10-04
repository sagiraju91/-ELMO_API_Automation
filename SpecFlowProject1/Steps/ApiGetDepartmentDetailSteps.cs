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
    class ApiGetDepartmentDetailsSteps
    {
        [Given(@"the working api as")]
        public void GivenTheWorkingApiAs(Table table)
        {
            dynamic _endPoint = table.CreateDynamicInstance();

            //  GET REQUEST DEV API User List USING DTO
            var _listOfDepts = new APIHellperClass<GetDepartmentsDTO>();
            var _client = _listOfDepts.SetUrl();
            var _request = _listOfDepts.GetRequest(_endPoint.getDepartments);
            var _response = _listOfDepts.ApiResponse(_client, _request);

            HttpStatusCode _statusCode = _response.StatusCode;
            int code = (int)_statusCode;
            Console.WriteLine("API Response Code : " + code);


            dynamic _data = _listOfDepts.ApiContent<GetDepartmentsDTO>(_response);
            Console.WriteLine("ID : " + _data.id);
            Console.WriteLine("DepartmentId : " + _data.departmentId);
            Console.WriteLine("Title : " + _data.title);
            
        }


        [When(@"the GET Request called")]
        public void WhenTheGETRequestCalled()
        {
           
        }

        [Then(@"the result should show details of Department")]
        public void ThenTheResultShouldShowDetailsOfDepartment()
        {
            
        }


    }
}
