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

namespace ParkingProject
{
    public partial class CurrentLotForm : Form
    {
        public User currentUser = new User();
        public ClientFactory clientFactory = new ClientFactory();
        public string sessionid = "";
        public ParkingLotForm parkingLotForm;

        public CurrentLotForm()
        {
            InitializeComponent();
        }

        private void LotName_Click(object sender, EventArgs e)
        {

        }

        private void BuyLotButton_Click(object sender, EventArgs e)
        {
            string vehicleId = currentUser.Vehicles.Find(x => x.license_plate == UserVehsBox.Text.Split(' ')[0]).id;
            string lotId = currentUser.Places.Find(x => x.name == LotName.Text).id;
            float amount = currentUser.Places.Find(x => x.name == LotName.Text).rent_cost;
            float hours = float.Parse(RentHoursTextBox.Text);
            if (amount<=currentUser.Balance)
            {
                clientFactory.BuyParkingLot(currentUser, lotId, vehicleId, hours, amount);
                UserBalanceText.Text = currentUser.Balance.ToString();
                parkingLotForm.UserBalanceText.Text = currentUser.Balance.ToString();
                parkingLotForm.loginForm.RefreshBalanceData();
            }
            else
            {
                MessageBox.Show("Пополните счёт");
            }


        }

        public void InitializeCurrentLot(string lotSearched, ParkingLotForm parkingLot)
        {
            Place foundLot = currentUser.Places.Find(x => x.name == lotSearched);
            if (foundLot != null)
            {
                UserBalanceText.Text = currentUser.Balance.ToString();
                UsernameText.Text = currentUser.Username;

                LotName.Text = foundLot.name;
                RentCostLotText.Text = foundLot.rent_cost.ToString();
                parkingLotForm = parkingLot;

                clientFactory.UserGetVehicles(currentUser);
                UserVehsBox.Items.Clear();
                if (currentUser.Vehicles.Count() > 0)
                {
                    foreach (var item in currentUser.Vehicles)
                    {
                        UserVehsBox.Items.Add(item.license_plate + " " + item.model);
                    }
                }

                ShowDialog();
            }       

        }
    }
}
