using ProjektAPBD_PiotrPawlaks15182.Forms.ItemsListsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektAPBD_PiotrPawlaks15182.Forms.ActionDialogs
{
    public partial class ChangeDiscount : Form
    {
        s15182Entities db;
        public static bool Changed;

        public ChangeDiscount()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;

            db = new s15182Entities();
            Changed = false;

            var get = db.Gosc.FirstOrDefault(g => g.IdGosc == GuestList.Gindex);

            NameLabel.Text = get.Imie+" "+get.Nazwisko;
            NewDiscountTextBox.TextAlign = HorizontalAlignment.Center;
            ChangeDiscountButton.Enabled = false;
        }

        private void ChangeDiscountButton_Click(object sender, EventArgs e)
        {
            var get = db.Gosc.FirstOrDefault(g => g.IdGosc == GuestList.Gindex);

            get.Procent_rabatu = Int32.Parse(NewDiscountTextBox.Text);

            db.SaveChanges();
            Changed = true;

            this.Close();
        }

        private void ValidateInputs()
        {
            var isNUmeric = Int32.TryParse(NewDiscountTextBox.Text, out int n);

            if (n > 0)
            {
                ChangeDiscountButton.Enabled = true;
            }
            else
                ChangeDiscountButton.Enabled = false;
        }

        private void NewDiscountTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }
    }
}
