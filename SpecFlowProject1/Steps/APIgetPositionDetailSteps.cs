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
    public class APIgetLocationDetailsStep
    {

        [Given(@"the PositionDetailsAPI as")]
        public void GivenThePositionDetailsAPIAs(Table table)
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


            dynamic _data = _listOfDepts.ApiContent<PositionsDTO>(_response);
            Console.WriteLine("ID : " + _data.id);
            Console.WriteLine("1st Set of Data: Title : " + _data.title);
            Console.WriteLine(" Parent : " + _data.parent);
            Console.WriteLine("Deleted : " + _data.deleted);
            Console.WriteLine("PositionId : " + _data.positionId);
            Console.WriteLine("Description : " + _data.description);
            Console.WriteLine("Qualifications : " + _data.qualifications);
           
        }



        [When(@"the GET PositionDetails is called")]
        public void WhenTheGETPositionDetailsIsCalled()
        {
            
        }


        [Then(@"results shouls have Details of Position")]
        public void ThenResultsShoulsHaveDetailsOfPosition()
        {
         
        }

    }
}
