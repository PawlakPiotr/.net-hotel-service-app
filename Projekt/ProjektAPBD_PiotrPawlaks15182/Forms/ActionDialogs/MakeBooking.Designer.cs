namespace ProjektAPBD_PiotrPawlaks15182.Forms
{
    partial class MakeBooking
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
            this.MakeBookingButton = new System.Windows.Forms.Button();
            this.DateFrom = new System.Windows.Forms.DateTimePicker();
            this.DateTo = new System.Windows.Forms.DateTimePicker();
            this.ImieTextBox = new System.Windows.Forms.TextBox();
            this.NazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.PaidCheckBox = new System.Windows.Forms.CheckBox();
            this.NotPaidCheckBox = new System.Windows.Forms.CheckBox();
            this.RoomNumberComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RoomCategoryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MakeBookingButton
            // 
            this.MakeBookingButton.Location = new System.Drawing.Point(83, 480);
            this.MakeBookingButton.Name = "MakeBookingButton";
            this.MakeBookingButton.Size = new System.Drawing.Size(222, 51);
            this.MakeBookingButton.TabIndex = 0;
            this.MakeBookingButton.Text = "Zarezerwuj";
            this.MakeBookingButton.UseVisualStyleBackColor = true;
            this.MakeBookingButton.Click += new System.EventHandler(this.MakeBookingButton_Click);
            // 
            // DateFrom
            // 
            this.DateFrom.Location = new System.Drawing.Point(187, 52);
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.Size = new System.Drawing.Size(200, 26);
            this.DateFrom.TabIndex = 1;
            // 
            // DateTo
            // 
            this.DateTo.Location = new System.Drawing.Point(187, 110);
            this.DateTo.Name = "DateTo";
            this.DateTo.Size = new System.Drawing.Size(200, 26);
            this.DateTo.TabIndex = 2;
            // 
            // ImieTextBox
            // 
            this.ImieTextBox.Location = new System.Drawing.Point(187, 176);
            this.ImieTextBox.Name = "ImieTextBox";
            this.ImieTextBox.Size = new System.Drawing.Size(200, 26);
            this.ImieTextBox.TabIndex = 3;
            this.ImieTextBox.TextChanged += new System.EventHandler(this.ImieTextBox_TextChanged);
            // 
            // NazwiskoTextBox
            // 
            this.NazwiskoTextBox.Location = new System.Drawing.Point(187, 240);
            this.NazwiskoTextBox.Name = "NazwiskoTextBox";
            this.NazwiskoTextBox.Size = new System.Drawing.Size(200, 26);
            this.NazwiskoTextBox.TabIndex = 4;
            this.NazwiskoTextBox.TextChanged += new System.EventHandler(this.NazwiskoTextBox_TextChanged);
            // 
            // PaidCheckBox
            // 
            this.PaidCheckBox.AutoSize = true;
            this.PaidCheckBox.Location = new System.Drawing.Point(276, 424);
            this.PaidCheckBox.Name = "PaidCheckBox";
            this.PaidCheckBox.Size = new System.Drawing.Size(111, 24);
            this.PaidCheckBox.TabIndex = 6;
            this.PaidCheckBox.Text = "Zapłacona";
            this.PaidCheckBox.UseVisualStyleBackColor = true;
            this.PaidCheckBox.CheckedChanged += new System.EventHandler(this.PaidCheckBox_CheckedChanged);
            // 
            // NotPaidCheckBox
            // 
            this.NotPaidCheckBox.AutoSize = true;
            this.NotPaidCheckBox.Location = new System.Drawing.Point(98, 424);
            this.NotPaidCheckBox.Name = "NotPaidCheckBox";
            this.NotPaidCheckBox.Size = new System.Drawing.Size(136, 24);
            this.NotPaidCheckBox.TabIndex = 7;
            this.NotPaidCheckBox.Text = "Nie zapłacona";
            this.NotPaidCheckBox.UseVisualStyleBackColor = true;
            this.NotPaidCheckBox.CheckedChanged += new System.EventHandler(this.NotPaidCheckBox_CheckedChanged);
            // 
            // RoomNumberComboBox
            // 
            this.RoomNumberComboBox.FormattingEnabled = true;
            this.RoomNumberComboBox.Location = new System.Drawing.Point(187, 307);
            this.RoomNumberComboBox.Name = "RoomNumberComboBox";
            this.RoomNumberComboBox.Size = new System.Drawing.Size(197, 28);
            this.RoomNumberComboBox.TabIndex = 8;
            this.RoomNumberComboBox.SelectedIndexChanged += new System.EventHandler(this.RoomNumberComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Data od";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Numer pokoju";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Data do";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Imię";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kategoria";
            // 
            // RoomCategoryLabel
            // 
            this.RoomCategoryLabel.AutoSize = true;
            this.RoomCategoryLabel.Location = new System.Drawing.Point(187, 374);
            this.RoomCategoryLabel.Name = "RoomCategoryLabel";
            this.RoomCategoryLabel.Size = new System.Drawing.Size(0, 20);
            this.RoomCategoryLabel.TabIndex = 15;
            // 
            // MakeBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 552);
            this.Controls.Add(this.RoomCategoryLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RoomNumberComboBox);
            this.Controls.Add(this.NotPaidCheckBox);
            this.Controls.Add(this.PaidCheckBox);
            this.Controls.Add(this.NazwiskoTextBox);
            this.Controls.Add(this.ImieTextBox);
            this.Controls.Add(this.DateTo);
            this.Controls.Add(this.DateFrom);
            this.Controls.Add(this.MakeBookingButton);
            this.Name = "MakeBooking";
            this.Text = "MakeBooking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MakeBookingButton;
        private System.Windows.Forms.DateTimePicker DateFrom;
        private System.Windows.Forms.DateTimePicker DateTo;
        private System.Windows.Forms.TextBox ImieTextBox;
        private System.Windows.Forms.TextBox NazwiskoTextBox;
        private System.Windows.Forms.CheckBox PaidCheckBox;
        private System.Windows.Forms.CheckBox NotPaidCheckBox;
        private System.Windows.Forms.ComboBox RoomNumberComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label RoomCategoryLabel;
    }
}