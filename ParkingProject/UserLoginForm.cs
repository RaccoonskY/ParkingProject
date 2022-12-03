using ParkingProject.UserClasses;

namespace ParkingProject
{
    public partial class UserLoginForm : Form
    {
        public User currentUser;
        public ClientFactory clientFactory;

        public UserLoginForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();


        }
        private void  button1_Click(object sender, EventArgs e)
        {
            
            string name = textBox1.Text;
            string password = textBox2.Text;
            MessageBox.Show("CHECK1");

            if (clientFactory.CreateUser(name, password, currentUser))
            {
                MessageBox.Show("User is added Successfully!");
            }
            else
            {
                MessageBox.Show("Something is wrong....");
            }
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
    }
}