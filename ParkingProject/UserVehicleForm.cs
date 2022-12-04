using ParkingProject.UserClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ParkingProject
{
    public partial class UserVehicleForm : Form
    {
        public User currentUser = new User();
        public ClientFactory clientFactory = new ClientFactory();
        public string sessionid = "";
        public UserVehicleForm()
        {
            
            InitializeComponent();
            
        }

        private void AddVehichleButton_Click(object sender, EventArgs e)
        {
            string model = VehModelTextBox.Text;
            string lisence = GovNumberTextBox.Text;
            if (clientFactory.UserAddVehicle(model, lisence,currentUser))
            {
                MessageBox.Show("Vehicle is added Successfully!");
                InitializeUserVehicles();
            }
        }

        public void InitializeUserVehicles()
        {
            clientFactory.UserGetVehicles(currentUser);
            UserVehs.Items.Clear();

            UserBalanceText.Text = currentUser.Balance.ToString();
            UsernameText.Text = currentUser.Username;

            if (currentUser.Vehicles.Count() > 0)
            {
                foreach (var item in currentUser.Vehicles)
                {
                    UserVehs.Items.Add(item.license_plate +" "+item.model);
                }
            }
         
        }

        private void DeleteVehButton_Click(object sender, EventArgs e)
        {
            if (currentUser.Vehicles.Count()>0)
            {
                var vehicleChosen = UserVehs.Text.Split(' ');
                if (currentUser.Vehicles.Exists(x => x.license_plate == vehicleChosen[0]))
                {
                    if (clientFactory.UserDeleteVehicle(currentUser, currentUser.Vehicles.Find(x => x.license_plate == vehicleChosen[0]).id))
                    {
                        MessageBox.Show("Vehicle is deleted successfully!");
                        InitializeUserVehicles();
                    }
                }
                
            }
           
        }
    }
}
