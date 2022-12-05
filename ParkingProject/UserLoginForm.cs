using ParkingProject.UserClasses;

namespace ParkingProject
{
    public partial class UserLoginForm : Form
    {
        public User currentUser = new User();
        public ClientFactory clientFactory = new ClientFactory();
        public string sessionid = "";

        public UserLoginForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();


        }
        private void  button1_Click(object sender, EventArgs e)
        {
            
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string password = textBox2.Text;

            if (clientFactory.CreateUser(name, password, currentUser))
            {
                MessageBox.Show("User is added Successfully!");
            }

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string password = textBox2.Text;
            if (clientFactory.UserLogin(name, password, currentUser))
            {
                MessageBox.Show("You logged Successfully!");
                currentUser.Registration = true;
                LoginButton.Visible = false;
                SignUpButton.Visible = false;
                UserName.Visible = false;
                Password.Visible = false; 
                textBox1.Visible = false;
                textBox2.Visible = false;
            }
            UserBalanceText.Text = currentUser.Balance.ToString();
            UsernameText.Text = currentUser.Username;
        }

        public void RefreshBalanceData()
        {
            UserBalanceText.Text = currentUser.Balance.ToString();
        }
        private void LogOut_Click(object sender, EventArgs e)
        {
            clientFactory.UserLogout();
            UserBalanceText.Text = "__";
            UsernameText.Text = "Пользователь";
            sessionid = "";
            currentUser = new();
            LoginButton.Visible = true;
            SignUpButton.Visible = true;
            UserName.Visible = true;
            Password.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
        }

        private void GoToVehiclesButton_Click(object sender, EventArgs e)
        {
            if (currentUser.Registration == true)
            {
                UserVehicleForm userVehicleForm = new UserVehicleForm();

                userVehicleForm.currentUser = currentUser;

                userVehicleForm.sessionid = currentUser.Sessionid;
                userVehicleForm.clientFactory = clientFactory;
                userVehicleForm.InitializeUserVehicles();

                userVehicleForm.ShowDialog();
            }

        }

        private void GoToLotsButton_Click(object sender, EventArgs e)
        {
            if (currentUser.Registration == true)
            {
                ParkingLotForm parkingLotForm = new ParkingLotForm();

                parkingLotForm.currentUser = currentUser;

                parkingLotForm.sessionid = currentUser.Sessionid;
                parkingLotForm.clientFactory = clientFactory;
                parkingLotForm.InitializeParkingLots(this);

                parkingLotForm.ShowDialog();
            }
        }

        private void PayBalance_Click(object sender, EventArgs e)
        {
            if (currentUser.Registration == true)
            {
                PaymentForm paymentForm = new PaymentForm();

                paymentForm.currentUser = currentUser;

                paymentForm.sessionid = currentUser.Sessionid;
                paymentForm.clientFactory = clientFactory;
                paymentForm.InitializePayment(this);
            }
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}