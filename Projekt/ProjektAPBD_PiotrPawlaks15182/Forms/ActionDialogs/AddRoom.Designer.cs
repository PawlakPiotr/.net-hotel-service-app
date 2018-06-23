namespace ProjektAPBD_PiotrPawlaks15182.Forms.ActionDialogs
{
    partial class AddRoom
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
            this.AddRoomButton = new System.Windows.Forms.Button();
            this.RoomCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.RoomNumberTextBox = new System.Windows.Forms.TextBox();
            this.AddRoomLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RoomGuestNumberTextBox = new System.Windows.Forms.TextBox();
            this.RoomGuestNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddRoomButton
            // 
            this.AddRoomButton.Location = new System.Drawing.Point(116, 272);
            this.AddRoomButton.Name = "AddRoomButton";
            this.AddRoomButton.Size = new System.Drawing.Size(190, 45);
            this.AddRoomButton.TabIndex = 0;
            this.AddRoomButton.Text = "Dodaj pokój";
            this.AddRoomButton.UseVisualStyleBackColor = true;
            this.AddRoomButton.Click += new System.EventHandler(this.AddRoomButton_Click);
            // 
            // RoomCategoryComboBox
            // 
            this.RoomCategoryComboBox.FormattingEnabled = true;
            this.RoomCategoryComboBox.Location = new System.Drawing.Point(216, 189);
            this.RoomCategoryComboBox.Name = "RoomCategoryComboBox";
            this.RoomCategoryComboBox.Size = new System.Drawing.Size(178, 28);
            this.RoomCategoryComboBox.TabIndex = 1;
            // 
            // RoomNumberTextBox
            // 
            this.RoomNumberTextBox.Location = new System.Drawing.Point(216, 71);
            this.RoomNumberTextBox.Name = "RoomNumberTextBox";
            this.RoomNumberTextBox.Size = new System.Drawing.Size(178, 26);
            this.RoomNumberTextBox.TabIndex = 2;
            this.RoomNumberTextBox.TextChanged += new System.EventHandler(this.RoomNumberTextBox_TextChanged);
            // 
            // AddRoomLabel
            // 
            this.AddRoomLabel.AutoSize = true;
            this.AddRoomLabel.Location = new System.Drawing.Point(72, 74);
            this.AddRoomLabel.Name = "AddRoomLabel";
            this.AddRoomLabel.Size = new System.Drawing.Size(107, 20);
            this.AddRoomLabel.TabIndex = 3;
            this.AddRoomLabel.Text = "Numer pokoju";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kategoria pokoju";
            // 
            // RoomGuestNumberTextBox
            // 
            this.RoomGuestNumberTextBox.Location = new System.Drawing.Point(216, 132);
            this.RoomGuestNumberTextBox.Name = "RoomGuestNumberTextBox";
            this.RoomGuestNumberTextBox.Size = new System.Drawing.Size(178, 26);
            this.RoomGuestNumberTextBox.TabIndex = 5;
            this.RoomGuestNumberTextBox.TextChanged += new System.EventHandler(this.RoomGuestNumberTextBox_TextChanged);
            // 
            // RoomGuestNumberLabel
            // 
            this.RoomGuestNumberLabel.AutoSize = true;
            this.RoomGuestNumberLabel.Location = new System.Drawing.Point(72, 138);
            this.RoomGuestNumberLabel.Name = "RoomGuestNumberLabel";
            this.RoomGuestNumberLabel.Size = new System.Drawing.Size(103, 20);
            this.RoomGuestNumberLabel.TabIndex = 6;
            this.RoomGuestNumberLabel.Text = "Liczba miejsc";
            this.RoomGuestNumberLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 354);
            this.Controls.Add(this.RoomGuestNumberLabel);
            this.Controls.Add(this.RoomGuestNumberTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddRoomLabel);
            this.Controls.Add(this.RoomNumberTextBox);
            this.Controls.Add(this.RoomCategoryComboBox);
            this.Controls.Add(this.AddRoomButton);
            this.Name = "AddRoom";
            this.Text = "AddRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddRoomButton;
        private System.Windows.Forms.ComboBox RoomCategoryComboBox;
        private System.Windows.Forms.TextBox RoomNumberTextBox;
        private System.Windows.Forms.Label AddRoomLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RoomGuestNumberTextBox;
        private System.Windows.Forms.Label RoomGuestNumberLabel;
    }
}