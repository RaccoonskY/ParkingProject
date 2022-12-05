﻿using System;
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

    public class RequestAmount
    {
        public float amount { get; set; }
    }
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

    public class RequestBuyLot
    {
        public string place_id { get; set; }
        public string vehicle_id { get; set; }
        public float hours { get; set; }
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

        public bool UserDeleteVehicle (User user, string vehicleid)
        {
          
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", user.Sessionid);
            var response = _httpClient.DeleteAsync(urlDomain + "/api/v1/vehicle/"+vehicleid);
            if (response.Result.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool UserGetLots(User user)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", user.Sessionid);
            var response1 = _httpClient.GetAsync(urlDomain + "/api/v1/place?available=true");
            var response2 = _httpClient.GetAsync(urlDomain + "/api/v1/place/my");
            if (response1.Result.IsSuccessStatusCode && response2.Result.IsSuccessStatusCode)
            {
                var response1Res = response1.Result.EnsureSuccessStatusCode().Content.ReadFromJsonAsync<List<Place>>().Result;
                var response2Res = response2.Result.EnsureSuccessStatusCode().Content.ReadFromJsonAsync<List<Place>>().Result;
                user.Places = response1Res;
                user.UserPlaces = response2Res;

                return true;
            }
            else
            {
                return false;
            }

        }
        
        public bool BuyParkingLot(User user,string placeId, string vehicleId, float hours,float amount)
        { 
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", user.Sessionid);
            var request = new RequestBuyLot
            {
                place_id = placeId,
                vehicle_id = vehicleId,
                hours = hours
            };
            var response = _httpClient.PostAsJsonAsync(urlDomain + "/api/v1/place", request);
            if (response.Result.IsSuccessStatusCode)
            {
                user.Balance -= amount;
                return true;
            }
            else
            {
                return false;
            }



        }

        public bool PayBalance(User user, float _amount)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", user.Sessionid);
            var request = new RequestAmount
            { 
                amount = _amount
            };
            var response = _httpClient.PostAsJsonAsync(urlDomain + "/api/v1/payment",request);
            if (response.Result.IsSuccessStatusCode)
            {
                user.Balance += _amount;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
