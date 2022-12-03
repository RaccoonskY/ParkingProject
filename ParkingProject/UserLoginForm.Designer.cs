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
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 178);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 27);
            this.textBox1.TabIndex = 1;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(46, 155);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(139, 20);
            this.UserName.TabIndex = 2;
            this.UserName.Text = "Имя пользователя";
            this.UserName.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(46, 242);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 27);
            this.textBox2.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(46, 219);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(62, 20);
            this.Password.TabIndex = 4;
            this.Password.Text = "Пароль\r\n";
            this.Password.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(46, 289);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(62, 29);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Войти";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(46, 324);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(163, 29);
            this.SignUpButton.TabIndex = 6;
            this.SignUpButton.Text = "Зарегистрироваться";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(114, 289);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(67, 29);
            this.LogOut.TabIndex = 8;
            this.LogOut.Text = "Выйти";
            this.LogOut.UseVisualStyleBackColor = true;
            // 
            // GoToVehiclesButton
            // 
            this.GoToVehiclesButton.Location = new System.Drawing.Point(249, 170);
            this.GoToVehiclesButton.Name = "GoToVehiclesButton";
            this.GoToVehiclesButton.Size = new System.Drawing.Size(146, 80);
            this.GoToVehiclesButton.TabIndex = 9;
            this.GoToVehiclesButton.Text = "Ваш Транспорт";
            this.GoToVehiclesButton.UseVisualStyleBackColor = true;
            // 
            // GoToLotsButton
            // 
            this.GoToLotsButton.Location = new System.Drawing.Point(249, 273);
            this.GoToLotsButton.Name = "GoToLotsButton";
            this.GoToLotsButton.Size = new System.Drawing.Size(146, 80);
            this.GoToLotsButton.TabIndex = 10;
            this.GoToLotsButton.Text = "Ваши Места";
            this.GoToLotsButton.UseVisualStyleBackColor = true;
            // 
            // UserLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 453);
            this.Controls.Add(this.GoToLotsButton);
            this.Controls.Add(this.GoToVehiclesButton);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.textBox1);
            this.Name = "UserLoginForm";
            this.Text = "ParkingProject";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}