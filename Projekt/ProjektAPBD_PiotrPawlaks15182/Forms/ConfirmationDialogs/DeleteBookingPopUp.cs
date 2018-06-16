using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektAPBD_PiotrPawlaks15182
{
    public partial class DeleteBookingPopUp : Form
    {
        public static bool deleteButtonClicked;

        public DeleteBookingPopUp()
        {
            InitializeComponent();
            deleteButtonClicked = false;
        }

        private void DeleteBookingButton_Click(object sender, EventArgs e)
        {
            deleteButtonClicked = true;
            this.Close();
        }

        private void CancelDeleteButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
