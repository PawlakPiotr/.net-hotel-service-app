namespace ProjektAPBD_PiotrPawlaks15182
{
    partial class Form1
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
            this.BookingGridView = new System.Windows.Forms.DataGridView();
            this.ReserveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.PaidBookingCheckBox = new System.Windows.Forms.CheckBox();
            this.GuestsListButton = new System.Windows.Forms.Button();
            this.ShowValuesButton = new System.Windows.Forms.Button();
            this.NazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.AddCategoryButton = new System.Windows.Forms.Button();
            this.AddRoomButton = new System.Windows.Forms.Button();
            this.RoomsListButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BookingGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BookingGridView
            // 
            this.BookingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookingGridView.Location = new System.Drawing.Point(34, 96);
            this.BookingGridView.Name = "BookingGridView";
            this.BookingGridView.RowTemplate.Height = 28;
            this.BookingGridView.Size = new System.Drawing.Size(1025, 394);
            this.BookingGridView.TabIndex = 0;
            // 
            // ReserveButton
            // 
            this.ReserveButton.Location = new System.Drawing.Point(34, 517);
            this.ReserveButton.Name = "ReserveButton";
            this.ReserveButton.Size = new System.Drawing.Size(234, 46);
            this.ReserveButton.TabIndex = 1;
            this.ReserveButton.Text = "Zarezerwuj";
            this.ReserveButton.UseVisualStyleBackColor = true;
            this.ReserveButton.Click += new System.EventHandler(this.ReserveButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(868, 517);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(191, 46);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Usuń";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // PaidBookingCheckBox
            // 
            this.PaidBookingCheckBox.AutoSize = true;
            this.PaidBookingCheckBox.Location = new System.Drawing.Point(756, 45);
            this.PaidBookingCheckBox.Name = "PaidBookingCheckBox";
            this.PaidBookingCheckBox.Size = new System.Drawing.Size(191, 24);
            this.PaidBookingCheckBox.TabIndex = 5;
            this.PaidBookingCheckBox.Text = "Zapłacone rezerwacje";
            this.PaidBookingCheckBox.UseVisualStyleBackColor = true;
            // 
            // GuestsListButton
            // 
            this.GuestsListButton.Location = new System.Drawing.Point(34, 34);
            this.GuestsListButton.Name = "GuestsListButton";
            this.GuestsListButton.Size = new System.Drawing.Size(155, 44);
            this.GuestsListButton.TabIndex = 6;
            this.GuestsListButton.Text = "Lista gości";
            this.GuestsListButton.UseVisualStyleBackColor = true;
            this.GuestsListButton.Click += new System.EventHandler(this.GuestsListButton_Click);
            // 
            // ShowValuesButton
            // 
            this.ShowValuesButton.Location = new System.Drawing.Point(953, 34);
            this.ShowValuesButton.Name = "ShowValuesButton";
            this.ShowValuesButton.Size = new System.Drawing.Size(106, 44);
            this.ShowValuesButton.TabIndex = 7;
            this.ShowValuesButton.Text = "Pokaż";
            this.ShowValuesButton.UseVisualStyleBackColor = true;
            this.ShowValuesButton.Click += new System.EventHandler(this.ShowValuesButton_Click);
            // 
            // NazwiskoTextBox
            // 
            this.NazwiskoTextBox.Location = new System.Drawing.Point(538, 43);
            this.NazwiskoTextBox.Name = "NazwiskoTextBox";
            this.NazwiskoTextBox.Size = new System.Drawing.Size(201, 26);
            this.NazwiskoTextBox.TabIndex = 8;
            this.NazwiskoTextBox.TextChanged += new System.EventHandler(this.NazwiskoTextBox_TextChanged);
            // 
            // AddCategoryButton
            // 
            this.AddCategoryButton.Location = new System.Drawing.Point(674, 517);
            this.AddCategoryButton.Name = "AddCategoryButton";
            this.AddCategoryButton.Size = new System.Drawing.Size(176, 46);
            this.AddCategoryButton.TabIndex = 9;
            this.AddCategoryButton.Text = "Dodaj Kategorie";
            this.AddCategoryButton.UseVisualStyleBackColor = true;
            this.AddCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
            // 
            // AddRoomButton
            // 
            this.AddRoomButton.Location = new System.Drawing.Point(454, 517);
            this.AddRoomButton.Name = "AddRoomButton";
            this.AddRoomButton.Size = new System.Drawing.Size(193, 46);
            this.AddRoomButton.TabIndex = 10;
            this.AddRoomButton.Text = "Dodaj Pokój ";
            this.AddRoomButton.UseVisualStyleBackColor = true;
            this.AddRoomButton.Click += new System.EventHandler(this.AddRoomButton_Click);
            // 
            // RoomsListButton
            // 
            this.RoomsListButton.Location = new System.Drawing.Point(205, 34);
            this.RoomsListButton.Name = "RoomsListButton";
            this.RoomsListButton.Size = new System.Drawing.Size(155, 44);
            this.RoomsListButton.TabIndex = 11;
            this.RoomsListButton.Text = "Lista pokoi";
            this.RoomsListButton.UseVisualStyleBackColor = true;
            this.RoomsListButton.Click += new System.EventHandler(this.RoomsListButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1105, 575);
            this.Controls.Add(this.RoomsListButton);
            this.Controls.Add(this.AddRoomButton);
            this.Controls.Add(this.AddCategoryButton);
            this.Controls.Add(this.NazwiskoTextBox);
            this.Controls.Add(this.ShowValuesButton);
            this.Controls.Add(this.GuestsListButton);
            this.Controls.Add(this.PaidBookingCheckBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ReserveButton);
            this.Controls.Add(this.BookingGridView);
            this.MinimumSize = new System.Drawing.Size(1127, 631);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BookingGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BookingGridView;
        private System.Windows.Forms.Button ReserveButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.CheckBox PaidBookingCheckBox;
        private System.Windows.Forms.Button GuestsListButton;
        private System.Windows.Forms.Button ShowValuesButton;
        private System.Windows.Forms.TextBox NazwiskoTextBox;
        private System.Windows.Forms.Button AddCategoryButton;
        private System.Windows.Forms.Button AddRoomButton;
        private System.Windows.Forms.Button RoomsListButton;
    }
}

