namespace ParkingProject
{
    partial class UserVehicleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.UserBalanceText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameText = new System.Windows.Forms.Label();
            this.VehModelTextBox = new System.Windows.Forms.TextBox();
            this.GovNumberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UserVehs = new System.Windows.Forms.ComboBox();
            this.DeleteVehButton = new System.Windows.Forms.Button();
            this.AddVehichleButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "RUB";
            // 
            // UserBalanceText
            // 
            this.UserBalanceText.AutoSize = true;
            this.UserBalanceText.Location = new System.Drawing.Point(372, 84);
            this.UserBalanceText.Name = "UserBalanceText";
            this.UserBalanceText.Size = new System.Drawing.Size(21, 20);
            this.UserBalanceText.TabIndex = 17;
            this.UserBalanceText.Text = "__";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Баланс:";
            // 
            // UsernameText
            // 
            this.UsernameText.AutoSize = true;
            this.UsernameText.Location = new System.Drawing.Point(309, 50);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(107, 20);
            this.UsernameText.TabIndex = 15;
            this.UsernameText.Text = "Пользователь";
            // 
            // VehModelTextBox
            // 
            this.VehModelTextBox.Location = new System.Drawing.Point(49, 224);
            this.VehModelTextBox.Name = "VehModelTextBox";
            this.VehModelTextBox.Size = new System.Drawing.Size(207, 27);
            this.VehModelTextBox.TabIndex = 19;
            // 
            // GovNumberTextBox
            // 
            this.GovNumberTextBox.Location = new System.Drawing.Point(49, 287);
            this.GovNumberTextBox.Name = "GovNumberTextBox";
            this.GovNumberTextBox.Size = new System.Drawing.Size(207, 27);
            this.GovNumberTextBox.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Модель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Гос. Номер";
            // 
            // UserVehs
            // 
            this.UserVehs.FormattingEnabled = true;
            this.UserVehs.Location = new System.Drawing.Point(49, 156);
            this.UserVehs.Name = "UserVehs";
            this.UserVehs.Size = new System.Drawing.Size(151, 28);
            this.UserVehs.TabIndex = 23;
            // 
            // DeleteVehButton
            // 
            this.DeleteVehButton.Location = new System.Drawing.Point(215, 156);
            this.DeleteVehButton.Name = "DeleteVehButton";
            this.DeleteVehButton.Size = new System.Drawing.Size(94, 29);
            this.DeleteVehButton.TabIndex = 24;
            this.DeleteVehButton.Text = "Удалить";
            this.DeleteVehButton.UseVisualStyleBackColor = true;
            this.DeleteVehButton.Click += new System.EventHandler(this.DeleteVehButton_Click);
            // 
            // AddVehichleButton
            // 
            this.AddVehichleButton.Location = new System.Drawing.Point(49, 340);
            this.AddVehichleButton.Name = "AddVehichleButton";
            this.AddVehichleButton.Size = new System.Drawing.Size(94, 29);
            this.AddVehichleButton.TabIndex = 25;
            this.AddVehichleButton.Text = "Добавить";
            this.AddVehichleButton.UseVisualStyleBackColor = true;
            this.AddVehichleButton.Click += new System.EventHandler(this.AddVehichleButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Модель";
            // 
            // UserVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 413);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddVehichleButton);
            this.Controls.Add(this.DeleteVehButton);
            this.Controls.Add(this.UserVehs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GovNumberTextBox);
            this.Controls.Add(this.VehModelTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserBalanceText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsernameText);
            this.Name = "UserVehicleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label UserBalanceText;
        private Label label1;
        private Label UsernameText;
        private TextBox VehModelTextBox;
        private TextBox GovNumberTextBox;
        private Label label3;
        private Label label4;
        private ComboBox UserVehs;
        private Button DeleteVehButton;
        private Button AddVehichleButton;
        private Label label5;
    }
}