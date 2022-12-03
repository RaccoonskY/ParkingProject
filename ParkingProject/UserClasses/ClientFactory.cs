using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json.Nodes;
using Newtonsoft.Json;
using System.Net.Http.Json;
using ParkingProject.UserClasses;

namespace ParkingProject.UserClasses
{
    public class RequestUserLogin
    {
        public string username { get; set; }
        public string password { get; set; }
    }

    public class ResponseUserLogin
    {
        public string username { get; set; }
        public float balance { get; set; }
        public string id { get; set; }

    }
    public class ClientFactory
    {
        private static HttpClient _httpClient;
        private string urlDomain = "http://194.67.74.174:8000";
        public ClientFactory()
        {
            _httpClient = new HttpClient(); 
        }

        public void CreateClient()
        {
            if (_httpClient == null)
            {
                HttpClient client = new HttpClient();
            }
               
        }

        public bool CreateUser(string _username, string _password, User user)
        {
            
            
            JsonContent content = JsonContent.Create(new RequestUserLogin { username = _username, password = _password });
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, urlDomain + "/api/v1/user");
            var response = _httpClient.PostAsync(urlDomain + "  /api/v1/user", content);
            var responseRes = response.Result.EnsureSuccessStatusCode().Content.ReadFromJsonAsync<ResponseUserLogin>().Result;
            user.Id = responseRes.id;
            user.Username = responseRes.username;
            user.Balance = responseRes.balance;
            return true;
        }


        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}
