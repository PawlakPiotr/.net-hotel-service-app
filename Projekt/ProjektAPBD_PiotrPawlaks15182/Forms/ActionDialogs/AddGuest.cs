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
            db = new s15182Entities();
            GuestAdded = false;

            ImieTextBox.TextAlign = HorizontalAlignment.Center;
            NazwiskoTextBox.TextAlign = HorizontalAlignment.Center;
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
    }
}
