using System;

namespace ProjektAPBD_PiotrPawlaks15182.Forms.ItemsListsForms
{
    partial class RoomsList
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
            this.RoomsDataGridView = new System.Windows.Forms.DataGridView();
            this.ChangePriceButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RoomsDataGridView
            // 
            this.RoomsDataGridView.AllowUserToDeleteRows = false;
            this.RoomsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomsDataGridView.Location = new System.Drawing.Point(38, 41);
            this.RoomsDataGridView.Name = "RoomsDataGridView";
            this.RoomsDataGridView.RowTemplate.Height = 28;
            this.RoomsDataGridView.Size = new System.Drawing.Size(690, 332);
            this.RoomsDataGridView.TabIndex = 0;
            // 
            // ChangePriceButton
            // 
            this.ChangePriceButton.Location = new System.Drawing.Point(446, 391);
            this.ChangePriceButton.Name = "ChangePriceButton";
            this.ChangePriceButton.Size = new System.Drawing.Size(282, 46);
            this.ChangePriceButton.TabIndex = 1;
            this.ChangePriceButton.Text = "Zmień cenę";
            this.ChangePriceButton.UseVisualStyleBackColor = true;
            this.ChangePriceButton.Click += new System.EventHandler(this.ChangePriceButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(45, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zmień cene pobytu na dobę w danym pokoju";
            // 
            // RoomsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChangePriceButton);
            this.Controls.Add(this.RoomsDataGridView);
            this.Name = "RoomsList";
            this.Text = "RoomsList";
            ((System.ComponentModel.ISupportInitialize)(this.RoomsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RoomsDataGridView;
        private System.Windows.Forms.Button ChangePriceButton;
        private System.Windows.Forms.Label label1;
    }
}