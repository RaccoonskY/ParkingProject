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
            if (clientFactory.UserLogin(name, password, currentUser, sessionid))
            {
                MessageBox.Show("You logged Successfully!");
            }
            UserBalanceText.Text = currentUser.Balance.ToString();
            UsernameText.Text = currentUser.Username;
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            clientFactory.UserLogout();
            UserBalanceText.Text = "__";
            UsernameText.Text = "Пользователь";
            sessionid = "";
            currentUser = new();
        }

        private void GoToVehiclesButton_Click(object sender, EventArgs e)
        {
            UserVehicleForm userVehicleForm = new UserVehicleForm();
            userVehicleForm.ShowDialog();
        }

        private void GoToLotsButton_Click(object sender, EventArgs e)
        {
            ParkingLotForm parkingLotForm = new ParkingLotForm();
            parkingLotForm.ShowDialog();
        }
    }
}