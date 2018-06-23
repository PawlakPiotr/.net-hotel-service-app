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
    public partial class ChangeRoomPrice : Form
    {
        s15182Entities db;
        public static bool Changed;

        public ChangeRoomPrice()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;

            db = new s15182Entities();
            Changed = false;

            var get = db.Pokoj.FirstOrDefault(g => g.NrPokoju == RoomsList.Rindex);
            var getKategoria = db.Kategoria.FirstOrDefault(r => r.IdKategoria == get.IdKategoria);

            RoomNumberLabel.Text = get.NrPokoju + " ";
            CategoryLabel.Text = getKategoria.Nazwa + "";

            ChangePriceTextBox.TextAlign = HorizontalAlignment.Center;
            ChangePriceButton.Enabled = false;
        }

        private void ChangePriceButton_Click(object sender, EventArgs e)
        {
            var get = db.Pokoj.FirstOrDefault(g => g.NrPokoju == RoomsList.Rindex);
            var getKategoria = db.Kategoria.FirstOrDefault(r => r.IdKategoria == get.IdKategoria);
            
            getKategoria.Cena = Int32.Parse(ChangePriceTextBox.Text);

            db.SaveChanges();
            Changed = true;
            this.Close();
        }

        private void ChangePriceTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        private void ValidateInputs()
        {
            var isNUmeric = Int32.TryParse(ChangePriceTextBox.Text, out int n);

            if (n > 0)
            {
                ChangePriceButton.Enabled = true;
            }
            else
                ChangePriceButton.Enabled = false;
        }
    }
}
