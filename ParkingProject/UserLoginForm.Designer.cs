using ParkingProject.UserClasses;

namespace ParkingProject
{
    partial class UserLoginForm
    {
       
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.GoToVehiclesButton = new System.Windows.Forms.Button();
            this.GoToLotsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.UserBalanceText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameText = new System.Windows.Forms.Label();
            this.PayBalance = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 192);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 27);
            this.textBox1.TabIndex = 1;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(46, 169);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(139, 20);
            this.UserName.TabIndex = 2;
            this.UserName.Text = "Имя пользователя";
            this.UserName.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(46, 256);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 27);
            this.textBox2.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(46, 233);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(62, 20);
            this.Password.TabIndex = 4;
            this.Password.Text = "Пароль\r\n";
            this.Password.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(46, 303);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(62, 29);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Войти";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(46, 338);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(163, 29);
            this.SignUpButton.TabIndex = 6;
            this.SignUpButton.Text = "Зарегистрироваться";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(387, 264);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(146, 58);
            this.LogOut.TabIndex = 8;
            this.LogOut.Text = "Выйти";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // GoToVehiclesButton
            // 
            this.GoToVehiclesButton.Location = new System.Drawing.Point(235, 178);
            this.GoToVehiclesButton.Name = "GoToVehiclesButton";
            this.GoToVehiclesButton.Size = new System.Drawing.Size(146, 80);
            this.GoToVehiclesButton.TabIndex = 9;
            this.GoToVehiclesButton.Text = "Ваш Транспорт";
            this.GoToVehiclesButton.UseVisualStyleBackColor = true;
            this.GoToVehiclesButton.Click += new System.EventHandler(this.GoToVehiclesButton_Click);
            // 
            // GoToLotsButton
            // 
            this.GoToLotsButton.Location = new System.Drawing.Point(387, 178);
            this.GoToLotsButton.Name = "GoToLotsButton";
            this.GoToLotsButton.Size = new System.Drawing.Size(146, 80);
            this.GoToLotsButton.TabIndex = 10;
            this.GoToLotsButton.Text = "Ваши Места";
            this.GoToLotsButton.UseVisualStyleBackColor = true;
            this.GoToLotsButton.Click += new System.EventHandler(this.GoToLotsButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(466, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "RUB";
            // 
            // UserBalanceText
            // 
            this.UserBalanceText.AutoSize = true;
            this.UserBalanceText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserBalanceText.Location = new System.Drawing.Point(414, 65);
            this.UserBalanceText.Name = "UserBalanceText";
            this.UserBalanceText.Size = new System.Drawing.Size(21, 20);
            this.UserBalanceText.TabIndex = 13;
            this.UserBalanceText.Text = "__";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(331, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Баланс:";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // UsernameText
            // 
            this.UsernameText.AutoSize = true;
            this.UsernameText.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UsernameText.Location = new System.Drawing.Point(364, 31);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(107, 20);
            this.UsernameText.TabIndex = 11;
            this.UsernameText.Text = "Пользователь";
            // 
            // PayBalance
            // 
            this.PayBalance.Location = new System.Drawing.Point(235, 264);
            this.PayBalance.Name = "PayBalance";
            this.PayBalance.Size = new System.Drawing.Size(146, 58);
            this.PayBalance.TabIndex = 15;
            this.PayBalance.Text = "Пополнить Баланс";
            this.PayBalance.UseVisualStyleBackColor = true;
            this.PayBalance.Click += new System.EventHandler(this.PayBalance_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = global::ParkingProject.Properties.Resources.user_128;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::ParkingProject.Properties.Resources.user_128;
            this.pictureBox1.Location = new System.Drawing.Point(249, 31);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(79, 73);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(79, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 73);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ParkingProject.Properties.Resources.smart_parking_1586867697;
            this.pictureBox3.Location = new System.Drawing.Point(3, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(240, 142);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // UserLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(555, 443);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PayBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserBalanceText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsernameText);
            this.Controls.Add(this.GoToLotsButton);
            this.Controls.Add(this.GoToVehiclesButton);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "UserLoginForm";
            this.Text = "ParkingProject";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBox1;
        private Label UserName;
        private TextBox textBox2;
        private Label Password;
        private Button LoginButton;
        private Button SignUpButton;
        private Button LogOut;
        private Button GoToVehiclesButton;
        private Button GoToLotsButton;
        private Label label2;
        private Label UserBalanceText;
        private Label label1;
        private Label UsernameText;
        private Button PayBalance;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
    }
}