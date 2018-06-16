using ProjektAPBD_PiotrPawlaks15182.Forms.ActionDialogs;
using ProjektAPBD_PiotrPawlaks15182.Forms.ConfirmationDialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektAPBD_PiotrPawlaks15182.Forms.ItemsListsForms
{
    public partial class GuestList : Form
    {

        private const string dbConncection = "Data Source=db-mssql;Initial Catalog=s15182;Integrated Security=True";
        public static int Gindex;

        public GuestList()
        {
            InitializeComponent();
            ShowGuests();
        }

        private void AddGuestButton_Click(object sender, EventArgs e)
        {
            var AddG = new AddGuest();
            AddG.ShowDialog();

            if (AddGuest.GuestAdded)
            {
                ShowGuests();
            }
        }

        private void DeleteGuestButton_Click(object sender, EventArgs e)
        {
            var Delete = new DeleteGuestPopUp();
            Delete.ShowDialog();

            if (DeleteGuestPopUp.DeleteAccepted)
            {
                DeleteGuest();
                ShowGuests();
            }
        }

        private void ShowGuests()
        {
            using (var con = new SqlConnection(dbConncection))
            {
                con.Open();
                var com = new SqlCommand();

                com.Connection = con;
                com.CommandText = "select imie, nazwisko, procent_rabatu, count(IdRezerwacja) as 'Liczba dokonanych rezrwacji', Gosc.IdGosc from Gosc " +
                                    "inner join Rezerwacja on Rezerwacja.IdGosc = Gosc.IdGosc " +
                                    "group by Gosc.IdGosc, nazwisko, imie, procent_rabatu";
                SqlDataAdapter sqd = new SqlDataAdapter(com);

                DataTable dt = new DataTable();
                sqd.Fill(dt);

                GuestListGridView.DataSource = dt;

                com.Dispose();
            }
        }
        private void DeleteGuest()
        {
            int idGoscCell = 4;
            var index = Convert.ToInt32(GuestListGridView.CurrentRow.Cells[idGoscCell].Value);


            string dbConncection = "Data Source=db-mssql;Initial Catalog=s15182;Integrated Security=True";
            using (var con = new SqlConnection(dbConncection))
            {
                con.Open();
                var com = new SqlCommand();
                com.Connection = con;

                com.CommandText = "delete from Rezerwacja where idGosc=@id";
                com.Parameters.Add("@id", SqlDbType.Int).Value = index;

                com.ExecuteNonQuery();
                com.Dispose();

                var comd = new SqlCommand();
                comd.Connection = con;

                comd.CommandText = "delete from Gosc where idGosc=@id";
                comd.Parameters.Add("@id", SqlDbType.Int).Value = index;

                comd.ExecuteNonQuery();
                comd.Dispose();

            }
        }

        private void ChangeDiscountButton_Click(object sender, EventArgs e)
        {
            Gindex = Convert.ToInt32(GuestListGridView.CurrentRow.Cells[4].Value);

            var DiscountForm = new ChangeDiscount();
            DiscountForm.ShowDialog();

            if (ChangeDiscount.Changed)
            {
                ShowGuests();
            }
        }
    }
}
