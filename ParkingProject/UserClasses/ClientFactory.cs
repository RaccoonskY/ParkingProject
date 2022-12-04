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
using System.Net.Http.Headers;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Collections.Specialized.BitVector32;
using System.ComponentModel;

namespace ParkingProject.UserClasses
{
    public class RequestUserLogin
    {
        public string username { get; set; }
        public string password { get; set; }
    }
    public class RequestAddVehicle
    {
        public string model { get; set; }
        public string license_plate { get; set; }
    }

    public class ResponseGetVehicle
    {
        public string model { get; set; }
        public string license_plate { get; set; }

        public string id { get; set; }
    }

    public class ResponseVehicles
    {
        public List<Vehicle> Vehicles { get; set; }
    }

    public class LoginSession
    {
        public string id { get; set; }
        public string expires { get; set; }
    }

    public class UserLogin
    {
        public string id { get; set; }
        public LoginSession session { get; set; }
    }
    public class UnsuccesfulResponse
    {
        public bool successful { get; set; }
        public string detail { get; set; }
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
            
            
            var request = new RequestUserLogin 
            { 
                password = _password,
                username = _username
            };
            var response = _httpClient.PostAsJsonAsync(urlDomain + "/api/v1/user", request);
            if (response.Result.IsSuccessStatusCode)
            {
                var responseRes = response.Result.EnsureSuccessStatusCode().Content.ReadFromJsonAsync<ResponseUserLogin>().Result;
                user.Id = responseRes.id;
                user.Username = responseRes.username;
                user.Balance = responseRes.balance;
                return true;
            }
            else
            {
                MessageBox.Show(response.Result.Content.ReadFromJsonAsync<UnsuccesfulResponse>().Result.detail);
                return false;
            }
            
        }

        public bool UserLogin(string _username, string _password, User user)
        {
            var request = new RequestUserLogin
            {
                password = _password,
                username = _username
            };
            var response = _httpClient.PostAsJsonAsync(urlDomain + "/api/v1/user/login", request);

            if (response.Result.IsSuccessStatusCode)
            {

                var responseRes = response.Result.EnsureSuccessStatusCode().Content.ReadFromJsonAsync<UserLogin>().Result;
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", responseRes.session.id);
                //MessageBox.Show("SESSION: " + responseRes.session.id+"\n"+responseRes.session.expires)
                var userResponse = _httpClient.GetAsync(urlDomain + "/api/v1/user");
                var userResponseRes = userResponse.Result.EnsureSuccessStatusCode().Content.ReadFromJsonAsync<ResponseUserLogin>().Result;

                user.Sessionid = responseRes.session.id;
                user.Id = userResponseRes.id;
                user.Username = userResponseRes.username;
                user.Balance = userResponseRes.balance;
                

                return true;
            }
            else
            {
                MessageBox.Show(response.Result.Content.ReadFromJsonAsync<UnsuccesfulResponse>().Result.detail);
                return false;
            }
        }

        public bool UserLogout()
        {
            var response = _httpClient.DeleteAsync(urlDomain + "/api/v1/user/logout");

            if (response.Result.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                MessageBox.Show(response.Result.Content.ReadFromJsonAsync<UnsuccesfulResponse>().Result.detail);
                return false;
            }
        }

        public bool UserAddVehicle(string _model, string _license, User user)
        {
            var request = new RequestAddVehicle
            {
                model = _model,
                license_plate = _license
            };
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",user.Sessionid );
            var response = _httpClient.PostAsJsonAsync(urlDomain + "/api/v1/vehicle", request);
            if (response.Result.IsSuccessStatusCode)
            {
                var responseRes = response.Result.EnsureSuccessStatusCode().Content.ReadFromJsonAsync<ResponseGetVehicle>().Result;
                 
                return true;
            }
            else
            {
                MessageBox.Show(response.Result.Content.ReadFromJsonAsync<UnsuccesfulResponse>().Result.detail);
                return false;
            }
        }

        public bool UserGetVehicles(User user)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", user.Sessionid);
            var response = _httpClient.GetAsync(urlDomain + "/api/v1/vehicle");
            if (response.Result.IsSuccessStatusCode)
            {
                var responseRes = response.Result.EnsureSuccessStatusCode().Content.ReadFromJsonAsync<List<Vehicle>>().Result;
                user.Vehicles = responseRes;
                
                return true;
            }
            else
            {
                MessageBox.Show(response.Result.Content.ReadFromJsonAsync<UnsuccesfulResponse>().Result.detail);
                return false;
            }

        }

        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}
