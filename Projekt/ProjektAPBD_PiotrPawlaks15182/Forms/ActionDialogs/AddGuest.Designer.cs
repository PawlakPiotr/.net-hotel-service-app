namespace ProjektAPBD_PiotrPawlaks15182.Forms.ActionDialogs
{
    partial class AddGuest
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
            this.AddGuestButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ImieTextBox = new System.Windows.Forms.TextBox();
            this.NazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DiscountTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddGuestButton
            // 
            this.AddGuestButton.Location = new System.Drawing.Point(86, 321);
            this.AddGuestButton.Name = "AddGuestButton";
            this.AddGuestButton.Size = new System.Drawing.Size(239, 48);
            this.AddGuestButton.TabIndex = 0;
            this.AddGuestButton.Text = "Dodaj gościa";
            this.AddGuestButton.UseVisualStyleBackColor = true;
            this.AddGuestButton.Click += new System.EventHandler(this.AddGuestButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(179, 54);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 20);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Imię";
            // 
            // ImieTextBox
            // 
            this.ImieTextBox.Location = new System.Drawing.Point(86, 94);
            this.ImieTextBox.Name = "ImieTextBox";
            this.ImieTextBox.Size = new System.Drawing.Size(239, 26);
            this.ImieTextBox.TabIndex = 2;
            this.ImieTextBox.TextChanged += new System.EventHandler(this.ImieTextBox_TextChanged);
            // 
            // NazwiskoTextBox
            // 
            this.NazwiskoTextBox.Location = new System.Drawing.Point(86, 175);
            this.NazwiskoTextBox.Name = "NazwiskoTextBox";
            this.NazwiskoTextBox.Size = new System.Drawing.Size(239, 26);
            this.NazwiskoTextBox.TabIndex = 4;
            this.NazwiskoTextBox.TextChanged += new System.EventHandler(this.NazwiskoTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwisko";
            // 
            // DiscountTextBox
            // 
            this.DiscountTextBox.Location = new System.Drawing.Point(221, 249);
            this.DiscountTextBox.Name = "DiscountTextBox";
            this.DiscountTextBox.Size = new System.Drawing.Size(104, 26);
            this.DiscountTextBox.TabIndex = 6;
            this.DiscountTextBox.TextChanged += new System.EventHandler(this.DiscountTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Procent rabatu";
            // 
            // AddGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 381);
            this.Controls.Add(this.DiscountTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NazwiskoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ImieTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AddGuestButton);
            this.Name = "AddGuest";
            this.Text = "AddGuest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddGuestButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox ImieTextBox;
        private System.Windows.Forms.TextBox NazwiskoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DiscountTextBox;
        private System.Windows.Forms.Label label3;
    }
}