namespace ProjektAPBD_PiotrPawlaks15182.Forms.ActionDialogs
{
    partial class ChangeRoomPrice
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
            this.ChangePriceButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RoomNumberLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ChangePriceTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChangePriceButton
            // 
            this.ChangePriceButton.Location = new System.Drawing.Point(86, 319);
            this.ChangePriceButton.Name = "ChangePriceButton";
            this.ChangePriceButton.Size = new System.Drawing.Size(196, 48);
            this.ChangePriceButton.TabIndex = 0;
            this.ChangePriceButton.Text = "Zmień cenę";
            this.ChangePriceButton.UseVisualStyleBackColor = true;
            this.ChangePriceButton.Click += new System.EventHandler(this.ChangePriceButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numer pokoju";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategoria";
            // 
            // RoomNumberLabel
            // 
            this.RoomNumberLabel.AutoSize = true;
            this.RoomNumberLabel.Location = new System.Drawing.Point(231, 84);
            this.RoomNumberLabel.Name = "RoomNumberLabel";
            this.RoomNumberLabel.Size = new System.Drawing.Size(0, 20);
            this.RoomNumberLabel.TabIndex = 3;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(221, 151);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(0, 20);
            this.CategoryLabel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cena pobytu 24h";
            // 
            // ChangePriceTextBox
            // 
            this.ChangePriceTextBox.Location = new System.Drawing.Point(225, 243);
            this.ChangePriceTextBox.Name = "ChangePriceTextBox";
            this.ChangePriceTextBox.Size = new System.Drawing.Size(75, 26);
            this.ChangePriceTextBox.TabIndex = 6;
            // 
            // ChangeRoomPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 389);
            this.Controls.Add(this.ChangePriceTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.RoomNumberLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChangePriceButton);
            this.Name = "ChangeRoomPrice";
            this.Text = "ChangeRoomPRice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangePriceButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RoomNumberLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ChangePriceTextBox;
    }
}