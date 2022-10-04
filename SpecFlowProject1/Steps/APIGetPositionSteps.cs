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
    public class APIgetLocationsStep
    {

        [Given(@"the PositionsAPI as")]
        public void GivenThePositionsAPIAs(Table table)
        {
                        
            dynamic _endPoint = table.CreateDynamicInstance();

            //  GET REQUEST DEV API User List USING DTO
            var _listOfDepts = new APIHellperClass<PositionsDTO>();
            var _client = _listOfDepts.SetUrl();
            var _request = _listOfDepts.GetRequest(_endPoint.getPositions);
            var _response = _listOfDepts.ApiResponse(_client, _request);

            HttpStatusCode _statusCode = _response.StatusCode;
            int code = (int)_statusCode;
            Console.WriteLine("API Response Code : " + code);


            dynamic _data = _listOfDepts.ApiContent<List<PositionsDTO>>(_response);
            Console.WriteLine("ID : " + _data[0].id);
            Console.WriteLine("1st Set of Data: Title : " + _data[0].title);
            Console.WriteLine(" Parent : " + _data[0].parent);
            Console.WriteLine("Deleted : " + _data[0].deleted);
            Console.WriteLine("PositionId : " + _data[0].positionId);
            Console.WriteLine("Description : " + _data[0].description);
            Console.WriteLine("Qualifications : " + _data[0].qualifications);
           
            string titleExpected = "Wellbeing Level 2";
            string titleActual = _data[1].title;

            Console.WriteLine("2nd Set of Data : Actual username : " + titleActual);
            Assert.AreEqual(titleExpected, titleActual, "Not Matched", true);
        }



        [When(@"the GET Positions is called")]
        public void WhenTheGETPositionsIsCalled()
        {

        }


        [Then(@"results shouls have list of Positions")]
        public void ThenResultsShoulsHaveListOfPositions()
        {
           
        }

    }
}
