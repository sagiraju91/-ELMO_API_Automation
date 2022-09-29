using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowProject1.Helper
{
    class APIHellperClass<T>
    {
        public RestClient restClient;
        public RestRequest restRequest;
        public RestResponse restResponse;
        string BASE_URL = "https://api.sandbox.elmotalent.com.au/core/v1";

        public RestClient SetUrl()
        {
            //New Code

            Uri baseURL = new Uri(BASE_URL);
            var restClient = new RestClient(baseURL);
            restClient.Authenticator = new HttpBasicAuthenticator("puma.api", "7be5f14b8342c4433acdb51e16b7a027");
            return restClient;
        }

        public RestRequest GetRequest(string _endPoint)
        {
            var restRequest = new RestRequest(_endPoint, Method.Get);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddHeader("x-api-key", "dwfWbV16CE1Oxcohga21l5MIHJocUyRv4lZIgwAp");
            //restRequest.AddHeader("Authorization", "Basi--------");
            restRequest.RequestFormat = DataFormat.Json;

            return restRequest;
        }

        public RestRequest PostRequest(string _endPoint, string _payLoad)
        {
            var restRequest = new RestRequest(_endPoint, Method.Post);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddHeader("x-api-key", "dwfWbV16CE1Oxcohga21l5MIHJocUyRv4lZIgwAp");
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.AddParameter("application/json", _payLoad, ParameterType.RequestBody);
            return restRequest;
        }

        public RestRequest PutRequest(string _endPoint, string _payLoad)
        {
            var restRequest = new RestRequest(_endPoint, Method.Put);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddHeader("x-api-key", "dwfWbV16CE1Oxcohga21l5MIHJocUyRv4lZIgwAp");
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.AddParameter("application/json", _payLoad, ParameterType.RequestBody);
            return restRequest;
        }

        public RestRequest DeleteRequest(string _endPoint)
        {
            var restRequest = new RestRequest(_endPoint, Method.Delete);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddHeader("x-api-key", "dwfWbV16CE1Oxcohga21l5MIHJocUyRv4lZIgwAp");
            restRequest.RequestFormat = DataFormat.Json;
            return restRequest;
        }


        public RestResponse ApiResponse(RestClient _client, RestRequest _request)
        {

            return _client.Execute(_request);
        }

        public DTO ApiContent<DTO>(RestResponse _response)
        {
            var cont = _response.Content;
            DTO resJSON = JsonConvert.DeserializeObject<DTO>(cont);
            
            return resJSON;
        }


    }
}
