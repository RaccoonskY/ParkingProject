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
    public partial class ParkingLotForm : Form
    {
        public User currentUser = new User();
        public ClientFactory clientFactory = new ClientFactory();
        public string sessionid = "";
        public UserLoginForm loginForm;
        public ParkingLotForm()
        {
            InitializeComponent();
        }

        public void InitializeParkingLots(UserLoginForm userLForm)
        {
            clientFactory.UserGetLots(currentUser);
            ParkingLotsBox.Items.Clear();
            UserLotsBox.Items.Clear();


            loginForm = userLForm;
            UserBalanceText.Text = currentUser.Balance.ToString();
            UsernameText.Text = currentUser.Username;

            if (currentUser.UserPlaces.Count() > 0)
            {
                foreach (var item in currentUser.UserPlaces)
                {
                    UserLotsBox.Items.Add(item.name + " " + item.rent_cost.ToString());
                }
            }
            if (currentUser.Places.Count() > 0)
            {
                foreach (var item in currentUser.Places)
                {
                    ParkingLotsBox.Items.Add(item.name + " " + item.rent_cost.ToString());
                }
            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ParkingLotsBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LotChoose(object sender, MouseEventArgs e)
        {
            CurrentLotForm currentLotForm = new CurrentLotForm();

            currentLotForm.currentUser = currentUser;

            currentLotForm.sessionid = currentUser.Sessionid;
            currentLotForm.clientFactory = clientFactory;
            currentLotForm.InitializeCurrentLot(ParkingLotsBox.SelectedItem.ToString().Split(' ')[0],this);
        }

        private void ParkingLotForm_Load(object sender, EventArgs e)
        {

        }


        private void ChooseLotButton_Click(object sender, EventArgs e)
        {
            CurrentLotForm currentLotForm = new CurrentLotForm();

            currentLotForm.currentUser = currentUser;

            currentLotForm.sessionid = currentUser.Sessionid;
            currentLotForm.clientFactory = clientFactory;
            currentLotForm.InitializeCurrentLot(LotSearchTextBox.Text, this);
 
        }

    }
}
