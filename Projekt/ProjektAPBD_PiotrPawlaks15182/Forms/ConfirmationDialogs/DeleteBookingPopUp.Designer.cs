namespace ProjektAPBD_PiotrPawlaks15182
{
    partial class DeleteBookingPopUp
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
            this.DeleteBookingButton = new System.Windows.Forms.Button();
            this.CancelDeleteButton = new System.Windows.Forms.Button();
            this.QLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeleteBookingButton
            // 
            this.DeleteBookingButton.Location = new System.Drawing.Point(12, 179);
            this.DeleteBookingButton.Name = "DeleteBookingButton";
            this.DeleteBookingButton.Size = new System.Drawing.Size(144, 52);
            this.DeleteBookingButton.TabIndex = 0;
            this.DeleteBookingButton.Text = "Usuń";
            this.DeleteBookingButton.UseVisualStyleBackColor = true;
            this.DeleteBookingButton.Click += new System.EventHandler(this.DeleteBookingButton_Click);
            // 
            // CancelDeleteButton
            // 
            this.CancelDeleteButton.Location = new System.Drawing.Point(189, 179);
            this.CancelDeleteButton.Name = "CancelDeleteButton";
            this.CancelDeleteButton.Size = new System.Drawing.Size(144, 52);
            this.CancelDeleteButton.TabIndex = 1;
            this.CancelDeleteButton.Text = "Anuluj";
            this.CancelDeleteButton.UseVisualStyleBackColor = true;
            this.CancelDeleteButton.Click += new System.EventHandler(this.CancelDeleteButton_Click);
            // 
            // QLabel
            // 
            this.QLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.QLabel.Location = new System.Drawing.Point(26, 47);
            this.QLabel.Name = "QLabel";
            this.QLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.QLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.QLabel.Size = new System.Drawing.Size(291, 100);
            this.QLabel.TabIndex = 2;
            this.QLabel.Text = "Czy na pewno chcesz usunąć rezerwacje?";
            this.QLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteBookingPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 253);
            this.Controls.Add(this.QLabel);
            this.Controls.Add(this.CancelDeleteButton);
            this.Controls.Add(this.DeleteBookingButton);
            this.Name = "DeleteBookingPopUp";
            this.Text = "DbChangeInformation";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button DeleteBookingButton;
        private System.Windows.Forms.Button CancelDeleteButton;
        private System.Windows.Forms.Label QLabel;
    }
}