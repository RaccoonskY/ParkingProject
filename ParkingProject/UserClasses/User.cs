using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingProject.UserClasses
{
    public class User
    {
        private string username;
        private float balance;
        private string id;

        public string Username { get { return username; } set { username = value; } }
        public float Balance { get { return balance; } set { balance = value; } }
        public string Id { get { return id; } set { id = value; } }
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
