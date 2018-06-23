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
    public partial class AddGuest : Form
    {
        s15182Entities db;

        public static bool GuestAdded;

        public AddGuest()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;

            db = new s15182Entities();
            GuestAdded = false;

            ImieTextBox.TextAlign = HorizontalAlignment.Center;
            NazwiskoTextBox.TextAlign = HorizontalAlignment.Center;
            DiscountTextBox.TextAlign = HorizontalAlignment.Center;

            AddGuestButton.Enabled = false;
        }

        private void AddGuestButton_Click(object sender, EventArgs e)
        {
            var GuestExists = db.Gosc.Any(g => g.Nazwisko == NazwiskoTextBox.Text);

            if (!GuestExists)
            {
                AddNewGuest();
                GuestAdded = true;
                this.Close();
            }
            else
            {
                GuestAdded = false;
                this.Close();
            }
        }

        private void AddNewGuest()
        {
            var GetId = db.Gosc.Max(g => g.IdGosc);

            Gosc gs = new Gosc();

            gs.IdGosc = GetId + 1;
            gs.Imie = ImieTextBox.Text;
            gs.Nazwisko = NazwiskoTextBox.Text;
            gs.Procent_rabatu = Int32.Parse(DiscountTextBox.Text);

            db.Gosc.Add(gs);
            db.SaveChanges();
        }

        private void ImieTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        private void NazwiskoTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        private void DiscountTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }


        private void ValidateInputs()
        {
            String Imie = ImieTextBox.Text.Replace(" ", "");
            String Nazwisko = NazwiskoTextBox.Text.Replace(" ", "");

            if (!Nazwisko.Equals(""))
            {
                if (!Imie.Equals(""))
                {
                    var isNUmeric = Int32.TryParse(DiscountTextBox.Text, out int n);

                    if (n > 0)
                    {
                        AddGuestButton.Enabled = true;
                    }
                    else
                        AddGuestButton.Enabled = false;
                }
                else
                    AddGuestButton.Enabled = false;
            }
            else
                AddGuestButton.Enabled = false;
        }

    }
}
