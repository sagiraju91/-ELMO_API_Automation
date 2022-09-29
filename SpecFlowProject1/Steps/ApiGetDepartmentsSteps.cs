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
    class ApiGetDepartmentsSteps
    {
        [Given(@"working api as")]
        public void GivenWorkingApiAs(Table table)
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


            dynamic _data = _listOfDepts.ApiContent<List<GetDepartmentsDTO>>(_response);
            Console.WriteLine("Parent : " + _data[0].parent);
            Console.WriteLine("ID : " + _data[0].id);
            Console.WriteLine("Description : " + _data[0].description);
            Console.WriteLine("DepartmentId : " + _data[0].departmentId);
            Console.WriteLine("1st Set of Data : Title : " + _data[0].title);
            Console.WriteLine("Path : " + _data[0].path);
            Console.WriteLine("Deleted : " + _data[0].deleted);

            //string titleExpected = "RSL Qld Marketing";
            //string titleActual = _data[1].title;

            //Console.WriteLine("2nd Set of Data : Actual username : " + titleActual);
            //Assert.AreEqual(titleExpected, titleActual, "Not Matched", true);
        }


        [When(@"GET Request called")]
        public void WhenGETRequestCalled()
        {
           
        }

        [Then(@"the result should show list of Departments")]
        public void ThenTheResultShouldShowListOfDepartments()
        {

        }


    }
}
