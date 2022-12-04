using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingProject.UserClasses
{
    public class Vehicle
    {
        public string model { get; set; }
        public string license_plate { get; set; }
        public string id { get; set; }
    }
    public class User
    {
        private string username;
        private float balance;
        private string id;
        private string sessionid;
        private List<Vehicle> vehicles;
        private bool registration = false; 

        public string Username { get { return username; } set { username = value; } }
        public float Balance { get { return balance; } set { balance = value; } }
        public string Id { get { return id; } set { id = value; } }
        public string Sessionid { get { return sessionid; } set { sessionid = value; } }
        public List<Vehicle> Vehicles { get { return vehicles; } set { vehicles = value; } }
        public bool Registration { get { return registration; } set { registration = value; } }



        public User()
        {

        }

        public User(string name, float balance, string id)
        {
            username = name;
            this.balance = balance;
            this.id = id;
        }

    }
}
