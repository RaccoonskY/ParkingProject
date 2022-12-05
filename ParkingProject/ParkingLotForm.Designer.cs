namespace ParkingProject
{
    partial class ParkingLotForm
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
            this.ParkingLotsBox = new System.Windows.Forms.ListBox();
            this.UsernameText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.LotSearchTextBox = new System.Windows.Forms.TextBox();
            this.UserLotsBox = new System.Windows.Forms.ListBox();
            this.UserBalanceText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChooseLotButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ParkingLotsBox
            // 
            this.ParkingLotsBox.FormattingEnabled = true;
            this.ParkingLotsBox.ItemHeight = 20;
            this.ParkingLotsBox.Location = new System.Drawing.Point(12, 109);
            this.ParkingLotsBox.Name = "ParkingLotsBox";
            this.ParkingLotsBox.Size = new System.Drawing.Size(209, 264);
            this.ParkingLotsBox.TabIndex = 2;
            this.ParkingLotsBox.SelectedIndexChanged += new System.EventHandler(this.ParkingLotsBox_SelectedIndexChanged);
            this.ParkingLotsBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LotChoose);
            // 
            // UsernameText
            // 
            this.UsernameText.AutoSize = true;
            this.UsernameText.Location = new System.Drawing.Point(376, 22);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(75, 20);
            this.UsernameText.TabIndex = 3;
            this.UsernameText.Text = "Username";
            this.UsernameText.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Баланс:";
            // 
            // LotSearchTextBox
            // 
            this.LotSearchTextBox.Location = new System.Drawing.Point(12, 76);
            this.LotSearchTextBox.Name = "LotSearchTextBox";
            this.LotSearchTextBox.Size = new System.Drawing.Size(125, 27);
            this.LotSearchTextBox.TabIndex = 5;
            // 
            // UserLotsBox
            // 
            this.UserLotsBox.FormattingEnabled = true;
            this.UserLotsBox.ItemHeight = 20;
            this.UserLotsBox.Location = new System.Drawing.Point(242, 109);
            this.UserLotsBox.Name = "UserLotsBox";
            this.UserLotsBox.Size = new System.Drawing.Size(209, 264);
            this.UserLotsBox.TabIndex = 7;
            // 
            // UserBalanceText
            // 
            this.UserBalanceText.AutoSize = true;
            this.UserBalanceText.Location = new System.Drawing.Point(439, 56);
            this.UserBalanceText.Name = "UserBalanceText";
            this.UserBalanceText.Size = new System.Drawing.Size(21, 20);
            this.UserBalanceText.TabIndex = 8;
            this.UserBalanceText.Text = "__";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "RUB";
            // 
            // ChooseLotButton
            // 
            this.ChooseLotButton.Location = new System.Drawing.Point(12, 41);
            this.ChooseLotButton.Name = "ChooseLotButton";
            this.ChooseLotButton.Size = new System.Drawing.Size(100, 29);
            this.ChooseLotButton.TabIndex = 10;
            this.ChooseLotButton.Text = "Выбрать";
            this.ChooseLotButton.UseVisualStyleBackColor = true;
            this.ChooseLotButton.Click += new System.EventHandler(this.ChooseLotButton_Click);
            // 
            // ParkingLotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 412);
            this.Controls.Add(this.ChooseLotButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserBalanceText);
            this.Controls.Add(this.UserLotsBox);
            this.Controls.Add(this.LotSearchTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsernameText);
            this.Controls.Add(this.ParkingLotsBox);
            this.Name = "ParkingLotForm";
            this.Text = "ParkingLotForm";
            this.Load += new System.EventHandler(this.ParkingLotForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListBox ParkingLotsBox;
        private Label UsernameText;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox LotSearchTextBox;
        private ListBox UserLotsBox;
        public Label UserBalanceText;
        private Label label2;
        private Button ChooseLotButton;
    }
}