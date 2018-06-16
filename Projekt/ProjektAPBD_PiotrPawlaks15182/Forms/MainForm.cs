using ProjektAPBD_PiotrPawlaks15182.Forms;
using ProjektAPBD_PiotrPawlaks15182.Forms.ActionDialogs;
using ProjektAPBD_PiotrPawlaks15182.Forms.ItemsListsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektAPBD_PiotrPawlaks15182
{
    public partial class Form1 : Form
    {
        s15182Entities db;

        public Form1()
        {
            InitializeComponent();
            db = new s15182Entities();

            showAllReservations();
        }

        private void NazwiskoTextBox_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void ShowValuesButton_Click(object sender, EventArgs e)
        {
            if (PaidBookingCheckBox.Checked)
            {
                var selectPaidBookings = from r in db.Rezerwacja
                                         join g in db.Gosc on r.IdGosc equals g.IdGosc
                                         where r.Zaplacona == true
                                         select new
                                         {
                                             r.DataOd,
                                             r.DataDo,
                                             r.NrPokoju,
                                             g.Imie,
                                             g.Nazwisko,
                                             r.Zaplacona,
                                             g.IdGosc,
                                             r.IdRezerwacja
                                         };

                BookingGridView.DataSource = selectPaidBookings.ToList();
            }
            if (!PaidBookingCheckBox.Checked && NazwiskoTextBox.Text.Equals(""))
            {
                showAllReservations();
            }
            if (PaidBookingCheckBox.Checked && !NazwiskoTextBox.Text.Equals(""))
            {
                var selectNamePaidBookings = from r in db.Rezerwacja
                                         join g in db.Gosc on r.IdGosc equals g.IdGosc
                                         where g.Nazwisko == NazwiskoTextBox.Text && r.Zaplacona == true
                                         select new
                                         {
                                             r.DataOd,
                                             r.DataDo,
                                             r.NrPokoju,
                                             g.Imie,
                                             g.Nazwisko,
                                             r.Zaplacona,
                                             g.IdGosc,
                                             r.IdRezerwacja
                                         };

                BookingGridView.DataSource = selectNamePaidBookings.ToList();
            }
            if (!PaidBookingCheckBox.Checked && !NazwiskoTextBox.Text.Equals(""))
            {
                var selectNamePaidBookings = from r in db.Rezerwacja
                                             join g in db.Gosc on r.IdGosc equals g.IdGosc
                                             where g.Nazwisko == NazwiskoTextBox.Text && r.Zaplacona == false
                                             select new
                                             {
                                                 r.DataOd,
                                                 r.DataDo,
                                                 r.NrPokoju,
                                                 g.Imie,
                                                 g.Nazwisko,
                                                 r.Zaplacona,
                                                 g.IdGosc,
                                                 r.IdRezerwacja
                                             };

                BookingGridView.DataSource = selectNamePaidBookings.ToList();
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            var confrimDelete = new DeleteBookingPopUp();
            confrimDelete.ShowDialog();
          
            if (DeleteBookingPopUp.deleteButtonClicked)
            {
                int idGoscCell = 6;
                var index = Convert.ToInt32(BookingGridView.CurrentRow.Cells[idGoscCell].Value);
                var idRezerwacji = Convert.ToInt32(BookingGridView.CurrentRow.Cells[7].Value);

                string dbConncection = "Data Source=db-mssql;Initial Catalog=s15182;Integrated Security=True";
                using (var con = new SqlConnection(dbConncection))
                {
                    con.Open();
                    var com = new SqlCommand();
                    com.Connection = con;
                    com.CommandText = "delete from Rezerwacja where idGosc=@id and idRezerwacja=@idR";
                    com.Parameters.Add("@id", SqlDbType.Int).Value = index;
                    com.Parameters.Add("@idR", SqlDbType.Int).Value = idRezerwacji;
                    com.ExecuteNonQuery();
                    com.Dispose();
                }
                showAllReservations();
            }
        }

        private void showAllReservations()
        {
            var selectAll = from r in db.Rezerwacja
                            join g in db.Gosc on r.IdGosc equals g.IdGosc
                            select new
                            {
                                r.DataOd,
                                r.DataDo,
                                r.NrPokoju,
                                g.Imie,
                                g.Nazwisko,
                                r.Zaplacona,
                                g.IdGosc,
                                r.IdRezerwacja
                            };

            BookingGridView.DataSource = selectAll.ToList();
        }

        private void ReserveButton_Click(object sender, EventArgs e)
        {
            var makeBooking = new MakeBooking();
            makeBooking.ShowDialog();

            if (MakeBooking.MakeBookingButtonCliked)
            {
                showAllReservations();
            }
        }

        private void AddRoomButton_Click(object sender, EventArgs e)
        {
            var AddRoomDialog = new AddRoom();
            AddRoomDialog.ShowDialog();
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            var AddCategoryDialog = new AddCategory();
            AddCategoryDialog.ShowDialog();

        }

        private void GuestsListButton_Click(object sender, EventArgs e)
        {
            var GuestsListsForm = new GuestList();
            GuestsListsForm.ShowDialog();
        }

        private void RoomsListButton_Click(object sender, EventArgs e)
        {
            var RoomsList = new RoomsList();
            RoomsList.ShowDialog();
        }
    }
}
