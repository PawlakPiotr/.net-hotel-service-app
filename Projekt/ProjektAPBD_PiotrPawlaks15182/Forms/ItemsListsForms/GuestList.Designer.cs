namespace ProjektAPBD_PiotrPawlaks15182.Forms.ItemsListsForms
{
    partial class GuestList
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
            this.GuestListGridView = new System.Windows.Forms.DataGridView();
            this.DeleteGuestButton = new System.Windows.Forms.Button();
            this.AddGuestButton = new System.Windows.Forms.Button();
            this.ChangeDiscountButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GuestListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GuestListGridView
            // 
            this.GuestListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GuestListGridView.Location = new System.Drawing.Point(32, 37);
            this.GuestListGridView.Name = "GuestListGridView";
            this.GuestListGridView.RowTemplate.Height = 28;
            this.GuestListGridView.Size = new System.Drawing.Size(701, 306);
            this.GuestListGridView.TabIndex = 0;
            // 
            // DeleteGuestButton
            // 
            this.DeleteGuestButton.Location = new System.Drawing.Point(783, 59);
            this.DeleteGuestButton.Name = "DeleteGuestButton";
            this.DeleteGuestButton.Size = new System.Drawing.Size(179, 48);
            this.DeleteGuestButton.TabIndex = 1;
            this.DeleteGuestButton.Text = "Usuń gościa";
            this.DeleteGuestButton.UseVisualStyleBackColor = true;
            this.DeleteGuestButton.Click += new System.EventHandler(this.DeleteGuestButton_Click);
            // 
            // AddGuestButton
            // 
            this.AddGuestButton.Location = new System.Drawing.Point(783, 168);
            this.AddGuestButton.Name = "AddGuestButton";
            this.AddGuestButton.Size = new System.Drawing.Size(179, 48);
            this.AddGuestButton.TabIndex = 2;
            this.AddGuestButton.Text = "Dodaj gościa";
            this.AddGuestButton.UseVisualStyleBackColor = true;
            this.AddGuestButton.Click += new System.EventHandler(this.AddGuestButton_Click);
            // 
            // ChangeDiscountButton
            // 
            this.ChangeDiscountButton.Location = new System.Drawing.Point(783, 272);
            this.ChangeDiscountButton.Name = "ChangeDiscountButton";
            this.ChangeDiscountButton.Size = new System.Drawing.Size(179, 48);
            this.ChangeDiscountButton.TabIndex = 3;
            this.ChangeDiscountButton.Text = "Zmień procent rabatu";
            this.ChangeDiscountButton.UseVisualStyleBackColor = true;
            this.ChangeDiscountButton.Click += new System.EventHandler(this.ChangeDiscountButton_Click);
            // 
            // GuestList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 380);
            this.Controls.Add(this.ChangeDiscountButton);
            this.Controls.Add(this.AddGuestButton);
            this.Controls.Add(this.DeleteGuestButton);
            this.Controls.Add(this.GuestListGridView);
            this.Name = "GuestList";
            this.Text = "GuestList";
            ((System.ComponentModel.ISupportInitialize)(this.GuestListGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GuestListGridView;
        private System.Windows.Forms.Button DeleteGuestButton;
        private System.Windows.Forms.Button AddGuestButton;
        private System.Windows.Forms.Button ChangeDiscountButton;
    }
}