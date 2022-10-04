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
    public class APIgetLocationSteps
    {

        [Given(@"locationsAPI as")]
        public void GivenLocationsAPIAs(Table table)
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


            dynamic _data = _listOfDepts.ApiContent<LocationsDTO>(_response);
            Console.WriteLine("ID : " + _data.id);
            Console.WriteLine("Parent : " + _data.parent);
            Console.WriteLine("1st Set of Data Title : " + _data.title);
            Console.WriteLine("LocationId : " + _data.locationId);
            Console.WriteLine("Description : " + _data.description);
            Console.WriteLine("AddressLine1 : " + _data.addressLine1);
            Console.WriteLine("AddressLine2 : " + _data.addressLine2);
            Console.WriteLine("Suburb : " + _data.suburb);
            Console.WriteLine("State : " + _data.state);
            Console.WriteLine("Postcode : " + _data.postcode);
            Console.WriteLine("Country : " + _data.country);
            Console.WriteLine("Path : " + _data.path);
            Console.WriteLine("Deleted : " + _data.deleted);

        }


        [When(@"GET LocationDetails is called")]
        public void WhenGETLocationDetailsIsCalled()
        {

        }


        [Then(@"results shouls have Details of location")]
        public void ThenResultsShoulsHaveDetailsOfLocation()
        {
            
        }

    }
}
