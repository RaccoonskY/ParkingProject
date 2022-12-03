namespace ParkingProject
{
    partial class CurrentLotForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.RentCostLotText = new System.Windows.Forms.Label();
            this.LotName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BuyLotButton = new System.Windows.Forms.Button();
            this.RentHoursTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.UserVehsBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "RUB";
            // 
            // UserBalanceText
            // 
            this.UserBalanceText.AutoSize = true;
            this.UserBalanceText.Location = new System.Drawing.Point(338, 69);
            this.UserBalanceText.Name = "UserBalanceText";
            this.UserBalanceText.Size = new System.Drawing.Size(21, 20);
            this.UserBalanceText.TabIndex = 12;
            this.UserBalanceText.Text = "__";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Balance: ";
            // 
            // UsernameText
            // 
            this.UsernameText.AutoSize = true;
            this.UsernameText.Location = new System.Drawing.Point(275, 35);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(75, 20);
            this.UsernameText.TabIndex = 10;
            this.UsernameText.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Информация о форме:";
            // 
            // RentCostLotText
            // 
            this.RentCostLotText.AutoSize = true;
            this.RentCostLotText.Location = new System.Drawing.Point(80, 99);
            this.RentCostLotText.Name = "RentCostLotText";
            this.RentCostLotText.Size = new System.Drawing.Size(59, 20);
            this.RentCostLotText.TabIndex = 15;
            this.RentCostLotText.Text = "LotCost";
            // 
            // LotName
            // 
            this.LotName.AutoSize = true;
            this.LotName.Location = new System.Drawing.Point(112, 69);
            this.LotName.Name = "LotName";
            this.LotName.Size = new System.Drawing.Size(49, 20);
            this.LotName.TabIndex = 16;
            this.LotName.Text = "Name";
            this.LotName.Click += new System.EventHandler(this.LotName_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Название:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Цена:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "RUB";
            // 
            // BuyLotButton
            // 
            this.BuyLotButton.Location = new System.Drawing.Point(26, 207);
            this.BuyLotButton.Name = "BuyLotButton";
            this.BuyLotButton.Size = new System.Drawing.Size(94, 29);
            this.BuyLotButton.TabIndex = 20;
            this.BuyLotButton.Text = "Оплатить";
            this.BuyLotButton.UseVisualStyleBackColor = true;
            this.BuyLotButton.Click += new System.EventHandler(this.BuyLotButton_Click);
            // 
            // RentHoursTextBox
            // 
            this.RentHoursTextBox.Location = new System.Drawing.Point(169, 140);
            this.RentHoursTextBox.Name = "RentHoursTextBox";
            this.RentHoursTextBox.Size = new System.Drawing.Size(58, 27);
            this.RentHoursTextBox.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Количество часов:";
            // 
            // UserVehsBox
            // 
            this.UserVehsBox.FormattingEnabled = true;
            this.UserVehsBox.Location = new System.Drawing.Point(26, 173);
            this.UserVehsBox.Name = "UserVehsBox";
            this.UserVehsBox.Size = new System.Drawing.Size(151, 28);
            this.UserVehsBox.TabIndex = 24;
            // 
            // CurrentLotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 285);
            this.Controls.Add(this.UserVehsBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RentHoursTextBox);
            this.Controls.Add(this.BuyLotButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LotName);
            this.Controls.Add(this.RentCostLotText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserBalanceText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsernameText);
            this.Name = "CurrentLotForm";
            this.Text = "CurrentLotForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label UserBalanceText;
        private Label label1;
        private Label UsernameText;
        private Label label3;
        private Label RentCostLotText;
        private Label LotName;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button BuyLotButton;
        private TextBox RentHoursTextBox;
        private Label label7;
        private ComboBox UserVehsBox;
    }
}