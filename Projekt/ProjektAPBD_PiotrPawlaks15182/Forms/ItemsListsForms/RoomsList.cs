using ProjektAPBD_PiotrPawlaks15182.Forms.ActionDialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektAPBD_PiotrPawlaks15182.Forms.ItemsListsForms
{
    public partial class RoomsList : Form
    {
        s15182Entities db;
        public static int Rindex;

        public RoomsList()
        {
            InitializeComponent();

            db = new s15182Entities();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            showRooms();
        }

        private void ChangePriceButton_Click(object sender, EventArgs e)
        {
            Rindex = Convert.ToInt32(RoomsDataGridView.CurrentRow.Cells[0].Value);
            var ChangePrice = new ChangeRoomPrice();
            ChangePrice.ShowDialog();

            if (ChangeRoomPrice.Changed)
            {
                showRooms();
            }
            
        }

        private void showRooms()
        {
            var GetRoomsList = from r in db.Pokoj
                               join k in db.Kategoria on r.IdKategoria equals k.IdKategoria
                               select new
                               {
                                   r.NrPokoju,
                                   k.Nazwa,
                                   r.Liczba_miejsc,
                                   k.Cena
                               };

            RoomsDataGridView.DataSource = GetRoomsList.ToList();
        }
    }
}
