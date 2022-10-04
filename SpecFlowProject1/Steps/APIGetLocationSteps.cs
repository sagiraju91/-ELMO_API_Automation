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
    public class APIgetLocationStep
    {

        [Given(@"the locationsAPI as")]
        public void GivenTheLocationsAPIAs(Table table)
        {
            dynamic _endPoint = table.CreateDynamicInstance();

            //  GET REQUEST DEV API User List USING DTO
            var _listOfDepts = new APIHellperClass<LocationsDTO>();
            var _client = _listOfDepts.SetUrl();
            var _request = _listOfDepts.GetRequest(_endPoint.getLocs);
            var _response = _listOfDepts.ApiResponse(_client, _request);

            HttpStatusCode _statusCode = _response.StatusCode;
            int code = (int)_statusCode;
            Console.WriteLine("API Response Code : " + code);


            dynamic _data = _listOfDepts.ApiContent<List<LocationsDTO>>(_response);
            Console.WriteLine("ID : " + _data[0].id);
            Console.WriteLine("Parent : " + _data[0].parent);
            Console.WriteLine("1st Set of Data Title : " + _data[0].title);
            Console.WriteLine("LocationId : " + _data[0].locationId);
            Console.WriteLine("Description : " + _data[0].description);
            Console.WriteLine("AddressLine1 : " + _data[0].addressLine1);
            Console.WriteLine("AddressLine2 : " + _data[0].addressLine2);
            Console.WriteLine("Suburb : " + _data[0].suburb);
            Console.WriteLine("State : " + _data[0].state);
            Console.WriteLine("Postcode : " + _data[0].postcode);
            Console.WriteLine("Country : " + _data[0].country);
            Console.WriteLine("Path : " + _data[0].path);
            Console.WriteLine("Deleted : " + _data[0].deleted);


            string titleExpected = "Toowoomba";
            string titleActual = _data[1].title;

            Console.WriteLine("2nd Set of Data : Actual username : " + titleActual);
            Assert.AreEqual(titleExpected, titleActual, "Not Matched", true);
        }



        [When(@"the GET Locations is called")]
        public void WhenTheGETLocationsIsCalled()
        {
            
        }


        [Then(@"results shouls have list of locations")]
        public void ThenResultsShoulsHaveListOfLocations()
        {
            
        }

    }
}
