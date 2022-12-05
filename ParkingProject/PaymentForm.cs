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
    public partial class PaymentForm : Form
    {
        public User currentUser = new User();
        public ClientFactory clientFactory = new ClientFactory();
        public string sessionid = "";
        public UserLoginForm loginForm;
        public PaymentForm()
        {
            InitializeComponent();
        }

        public void InitializePayment(UserLoginForm userLoginForm)
        {
            UserBalanceText.Text = currentUser.Balance.ToString();
            UsernameText.Text = currentUser.Username;
            loginForm = userLoginForm;
            ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                float amount = float.Parse(textBox1.Text);
                clientFactory.PayBalance(currentUser, amount);
                loginForm.RefreshBalanceData();
                

            }
    
        }
    }
}
