﻿using ProjektAPBD_PiotrPawlaks15182.Forms.InformationDialogs;
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
    public partial class AddRoom : Form
    {
        s15182Entities db;

        public AddRoom()
        {
            InitializeComponent();
            db = new s15182Entities();

            var roomCategories = from c in db.Kategoria
                                 select c.Nazwa;

            RoomCategoryComboBox.DataSource = roomCategories.ToList();
            RoomNumberTextBox.TextAlign = HorizontalAlignment.Center;
            RoomGuestNumberTextBox.TextAlign = HorizontalAlignment.Center;
        }

        private void AddRoomButton_Click(object sender, EventArgs e)
        {
            int RoomNumber = Int32.Parse(RoomNumberTextBox.Text);
            bool RoomExisits = db.Pokoj.Any(r => r.NrPokoju == RoomNumber);

            if (RoomExisits)
            {
                var OkForm = new RoomExistsDialog();
                OkForm.ShowDialog();
            }
            else
            {
                Pokoj newRoom = new Pokoj();

                newRoom.NrPokoju = Int32.Parse(RoomNumberTextBox.Text);
                newRoom.Liczba_miejsc = Int32.Parse(RoomGuestNumberTextBox.Text);

                var GetCategory = from c in db.Kategoria
                                  where c.Nazwa == RoomCategoryComboBox.Text
                                  select c.IdKategoria;

                newRoom.IdKategoria = GetCategory.FirstOrDefault();

                db.Pokoj.Add(newRoom);
                db.SaveChanges();

            }


            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
