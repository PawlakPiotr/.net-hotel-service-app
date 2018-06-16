namespace ProjektAPBD_PiotrPawlaks15182.Forms.ActionDialogs
{
    partial class ChangeDiscount
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
            this.ImieLabel = new System.Windows.Forms.Label();
            this.ChangeDiscountButton = new System.Windows.Forms.Button();
            this.NewDiscountTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ImieLabel
            // 
            this.ImieLabel.AutoSize = true;
            this.ImieLabel.Location = new System.Drawing.Point(61, 147);
            this.ImieLabel.Name = "ImieLabel";
            this.ImieLabel.Size = new System.Drawing.Size(114, 20);
            this.ImieLabel.TabIndex = 0;
            this.ImieLabel.Text = "Procent rabatu";
            // 
            // ChangeDiscountButton
            // 
            this.ChangeDiscountButton.Location = new System.Drawing.Point(101, 212);
            this.ChangeDiscountButton.Name = "ChangeDiscountButton";
            this.ChangeDiscountButton.Size = new System.Drawing.Size(178, 47);
            this.ChangeDiscountButton.TabIndex = 1;
            this.ChangeDiscountButton.Text = "Zmień procent rabatu";
            this.ChangeDiscountButton.UseVisualStyleBackColor = true;
            this.ChangeDiscountButton.Click += new System.EventHandler(this.ChangeDiscountButton_Click);
            // 
            // NewDiscountTextBox
            // 
            this.NewDiscountTextBox.Location = new System.Drawing.Point(224, 144);
            this.NewDiscountTextBox.Name = "NewDiscountTextBox";
            this.NewDiscountTextBox.Size = new System.Drawing.Size(80, 26);
            this.NewDiscountTextBox.TabIndex = 2;
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(12, 60);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(366, 33);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangeDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 271);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NewDiscountTextBox);
            this.Controls.Add(this.ChangeDiscountButton);
            this.Controls.Add(this.ImieLabel);
            this.Name = "ChangeDiscount";
            this.Text = "ChangeDiscount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ImieLabel;
        private System.Windows.Forms.Button ChangeDiscountButton;
        private System.Windows.Forms.TextBox NewDiscountTextBox;
        private System.Windows.Forms.Label NameLabel;
    }
}