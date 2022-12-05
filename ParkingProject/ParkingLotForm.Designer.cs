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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ParkingLotsBox
            // 
            this.ParkingLotsBox.FormattingEnabled = true;
            this.ParkingLotsBox.ItemHeight = 20;
            this.ParkingLotsBox.Location = new System.Drawing.Point(13, 136);
            this.ParkingLotsBox.Name = "ParkingLotsBox";
            this.ParkingLotsBox.Size = new System.Drawing.Size(209, 264);
            this.ParkingLotsBox.TabIndex = 2;
            this.ParkingLotsBox.SelectedIndexChanged += new System.EventHandler(this.ParkingLotsBox_SelectedIndexChanged);
            this.ParkingLotsBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LotChoose);
            // 
            // UsernameText
            // 
            this.UsernameText.AutoSize = true;
            this.UsernameText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UsernameText.Location = new System.Drawing.Point(372, 26);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(80, 20);
            this.UsernameText.TabIndex = 3;
            this.UsernameText.Text = "Username";
            this.UsernameText.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(372, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
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
            this.UserLotsBox.Location = new System.Drawing.Point(243, 136);
            this.UserLotsBox.Name = "UserLotsBox";
            this.UserLotsBox.Size = new System.Drawing.Size(209, 264);
            this.UserLotsBox.TabIndex = 7;
            // 
            // UserBalanceText
            // 
            this.UserBalanceText.AutoSize = true;
            this.UserBalanceText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserBalanceText.Location = new System.Drawing.Point(439, 56);
            this.UserBalanceText.Name = "UserBalanceText";
            this.UserBalanceText.Size = new System.Drawing.Size(21, 20);
            this.UserBalanceText.TabIndex = 8;
            this.UserBalanceText.Text = "__";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(483, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = global::ParkingProject.Properties.Resources.user_128;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::ParkingProject.Properties.Resources.user_128;
            this.pictureBox1.Location = new System.Drawing.Point(287, 12);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(79, 73);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(79, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 73);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "Свободные места:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(243, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "Ваши места:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ParkingProject.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(118, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // ParkingLotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(532, 412);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ChooseLotButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserBalanceText);
            this.Controls.Add(this.UserLotsBox);
            this.Controls.Add(this.LotSearchTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsernameText);
            this.Controls.Add(this.ParkingLotsBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ParkingLotForm";
            this.Text = "ParkingLotForm";
            this.Load += new System.EventHandler(this.ParkingLotForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
    }
}