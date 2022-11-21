using SmartWMS.DTO.VirtualModels;
using System.Text.Json;
using System.Text;
using RestSharp;
using Microsoft.Extensions.Logging;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Net;

namespace SmartWMS.Services
{
    public class RestClientService : IRestClientService
    {
        public RestClientService() 
        {

        }

        public async Task<bool> LoginAsync(Login login)
        {
            //string jsonString = JsonSerializer.Serialize(login);
            try
            {
                Constants.Cookies = null;
                Constants.IsServerConnected = false;

                var uri = new Uri($"{Constants.RestBaseUrl}/login.jsp");
            

                var _RestClient = new RestClient(uri);

                var request = new RestRequest(uri, Method.Post);
                request.AddHeader("Content-Type", "application/json");




                request.AddParameter("application/json", login, ParameterType.RequestBody);

                

                RestResponse response = await _RestClient.ExecuteAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    Constants.Cookies = response.Cookies;
                    Constants.IsServerConnected = true;
                }
                return response.IsSuccessStatusCode;
            }
            catch (Exception e)
            {
                Log.Error(e);
                throw;
            }
        }
        public async Task<bool> LogoutAsync()
        {
            try
            {
                var uri = $"{Constants.RestBaseUrl}/logout";
                var _RestClient = new RestClient(uri);
                var request = new RestRequest(uri, Method.Get);

                request.AddHeader("Content-Type", "application/json");

                if (Constants.Cookies.Any() && Constants.IsServerConnected)
                {
                    string cookie = "";
                    Constants.Cookies.ToList().ForEach(x => cookie += $"{x.Name}={x.Value}; ");
                    request.AddHeader("Cookie", cookie);
                }
                else
                {
                    throw new Exception("The server is not connected !");
                }

                RestResponse response = await _RestClient.ExecuteAsync(request);
                return response.IsSuccessStatusCode;
            }
            catch (Exception e)
            {
                Log.Error(e);
                throw;
            }
        }

        public async Task<RootData<T>> RestServiceGetAsync<T>(string model, int offset = 0, int limit = 10)
        {
            try
            {
                var uri = $"{Constants.RestBaseUrl}/ws/rest/{model}";
                var _RestClient = new RestClient(uri);
                var request = new RestRequest(uri, Method.Get);

                request.AddHeader("Content-Type", "application/json");

                if (Constants.Cookies.Any() && Constants.IsServerConnected)
                {
                    string cookie = "";
                    Constants.Cookies.ToList().ForEach(x => cookie += $"{x.Name}={x.Value}; ");
                    request.AddHeader("Cookie", cookie);
                }
                else
                {
                    throw new Exception("The server is not connected !");
                }

                request.AddParameter("offset", offset, ParameterType.UrlSegment);
                request.AddParameter("limit", limit, ParameterType.UrlSegment);

                RestResponse response = await _RestClient.ExecuteAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    var data = new MemoryStream(Encoding.UTF8.GetBytes(response.Content));
                    var rslt = await JsonSerializer.DeserializeAsync<RootData<T>>(data);
                    return rslt;
                }
                return null;

            }
            catch (Exception e)
            {
                Log.Error(e);
                throw;
            }
        }

        public async Task<RootData<T>> RestServiceSearchAsync<T>(string model, SearchRequest search, int offset = 0, int limit = 10)
        {
            try
            {
                var uri = $"{Constants.RestBaseUrl}/ws/rest/{model}/search";
                var _RestClient = new RestClient(uri);
                var request = new RestRequest(uri, Method.Post);

                request.AddHeader("Content-Type", "application/json");

                if (Constants.Cookies.Any() && Constants.IsServerConnected)
                {
                    string cookie = "";
                    Constants.Cookies.ToList().ForEach(x => cookie += $"{x.Name}={x.Value}; ");
                    request.AddHeader("Cookie", cookie);
                }
                else
                {
                    throw new Exception("The server is not connected !");
                }

                request.AddParameter("offset", offset, ParameterType.UrlSegment);
                request.AddParameter("limit", limit, ParameterType.UrlSegment);
                request.AddJsonBody(search);

                RestResponse response = await _RestClient.ExecuteAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    var data = new MemoryStream(Encoding.UTF8.GetBytes(response.Content));
                    var rslt = await JsonSerializer.DeserializeAsync<RootData<T>>(data);
                    return rslt;
                }
                return null;

            }
            catch (Exception e)
            {
                Log.Error(e);
                throw;
            }
        }


    }
}
