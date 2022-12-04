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
            }
        }

        public void InitializeUserVehicles()
        {
            clientFactory.UserGetVehicles(currentUser);
            UserVehs.Items.Clear();
            if (currentUser.Vehicles.Count() > 0)
            {
                foreach (var item in currentUser.Vehicles)
                {
                    UserVehs.Items.Add(item.license_plate +" "+item.model);
                }
            }
         
        }
    }
}
