using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektAPBD_PiotrPawlaks15182.Forms
{
    public partial class MakeBooking : Form
    {
        public static bool MakeBookingButtonCliked;
        s15182Entities db;

        public MakeBooking()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;

            db = new s15182Entities();
            MakeBookingButtonCliked = false;

            var roomNumbers = from r in db.Pokoj select r.NrPokoju;

            RoomNumberComboBox.DataSource = roomNumbers.ToList();

            ShowRoomCategory();
            SetVisitPrice();

            NotPaidCheckBox.Checked = true;
            MakeBookingButton.Enabled = false;

        }

        private void RoomNumberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowRoomCategory();
        }

        private void PaidCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (NotPaidCheckBox.Checked)
            {
                NotPaidCheckBox.Checked = false;
            }
           
        }

        private void NotPaidCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (PaidCheckBox.Checked)
            {
                PaidCheckBox.Checked = false;
            }
        }

        private void ImieTextBox_TextChanged(object sender, EventArgs e)
        {
            string ImieInput = ImieTextBox.Text.Replace(" ", "");
            string NazwiskoInput = NazwiskoTextBox.Text.Replace(" ","");

            SetMakeBookingButtonState(
                !NazwiskoInput.Equals(""), !ImieInput.Equals("")
                                        );
        }

        private void NazwiskoTextBox_TextChanged(object sender, EventArgs e)
        {
            string ImieInput = ImieTextBox.Text.Replace(" ", "");
            string NazwiskoInput = NazwiskoTextBox.Text.Replace(" ", "");

            SetMakeBookingButtonState(
                !ImieInput.Equals(""), !NazwiskoInput.Equals("")
                                        );
        }

        private void MakeBookingButton_Click(object sender, EventArgs e)
        {
            AddBooking();
            MakeBookingButtonCliked = true;
        }

        private void AddBooking()
        {
            Rezerwacja rez = new Rezerwacja();

            string imie = ImieTextBox.Text;
            string nazwisko = NazwiskoTextBox.Text;

            bool GoscExisits = db.Gosc.Any(gosc => gosc.Imie == imie
                                                && gosc.Nazwisko == nazwisko);

            if (!GoscExisits)
            {
                AddNewGosc();
            }

            var GetIdGosc = from g in db.Gosc
                            where g.Imie == imie && g.Nazwisko == nazwisko
                            select g.IdGosc;

            rez.IdGosc = GetIdGosc.ToList().FirstOrDefault();


            var GetCountRezerwacje = db.Rezerwacja.Max(r => r.IdRezerwacja);

            rez.IdRezerwacja = GetCountRezerwacje+1;

            rez.NrPokoju = Int32.Parse(RoomNumberComboBox.Text);
            rez.DataOd = DateTime.Parse(DateFrom.Text);
            rez.DataDo = DateTime.Parse(DateTo.Text);

            if (PaidCheckBox.Checked)
            {
                rez.Zaplacona = true;
            }else 
                if (NotPaidCheckBox.Checked)
            {
                rez.Zaplacona = false;
            }

            db.Rezerwacja.Add(rez);
            db.SaveChanges();
            this.Close();
        }

        private void AddNewGosc()
        {
            string imie = ImieTextBox.Text;
            string nazwisko = NazwiskoTextBox.Text;

            Gosc nowyGosc = new Gosc();
            nowyGosc.Imie = imie;
            nowyGosc.Nazwisko = nazwisko;
            nowyGosc.Procent_rabatu = 0;

            var GetGoscId = db.Gosc.Max(g => g.IdGosc);

            nowyGosc.IdGosc = GetGoscId + 1;

            db.Gosc.Add(nowyGosc);
            db.SaveChanges();
        }

        private void SetMakeBookingButtonState(bool FirstCondition, bool SecondCondition)
        {
            if (FirstCondition)
            {
                if (SecondCondition)
                {
                    MakeBookingButton.Enabled = true;
                }
                else
                    MakeBookingButton.Enabled = false;
            }
            else
                MakeBookingButton.Enabled = false;
        }

        private void ShowRoomCategory()
        {
            int roomNumber = Int32.Parse(RoomNumberComboBox.Text);

            var roomCategory = from r in db.Pokoj
                               join g in db.Kategoria on r.IdKategoria equals g.IdKategoria
                               where r.NrPokoju == roomNumber
                               select new
                               {
                                   g.Nazwa
                               };


            RoomCategoryLabel.Text = roomCategory.ToList().First().ToString()
                                    .Replace("{", "")
                                    .Replace("Nazwa", "")
                                    .Replace("=", "")
                                    .Replace("}", "")
                                    .Replace(" ", "");

            SetVisitPrice();
        }

        private void SetVisitPrice()
        {
            var SetPrice = (from p in db.Kategoria
                            where p.Nazwa == RoomCategoryLabel.Text
                            select p.Cena).FirstOrDefault();

            var Price = SetPrice;

            var DateFr = DateFrom.Value;
            var DateT = DateTo.Value;

            TimeSpan ts = DateT - DateFr;

            int diff = ts.Days+1;

            if(diff > 0)
                PriceLabel.Text = Price*diff + " zł ";
            else
                PriceLabel.Text = Price + " zł ";
        }

        private void DateFrom_ValueChanged(object sender, EventArgs e)
        {
            SetVisitPrice();
        }

        private void DateTo_ValueChanged(object sender, EventArgs e)
        {
            SetVisitPrice();
        }
    }
}
