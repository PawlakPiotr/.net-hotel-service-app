using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektAPBD_PiotrPawlaks15182.Forms.ConfirmationDialogs
{
    public partial class DeleteGuestPopUp : Form
    {
        public static bool DeleteAccepted;

        public DeleteGuestPopUp()
        {
            InitializeComponent();
            DeleteAccepted = false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DeleteAccepted = false;
            this.Close();
           
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DeleteAccepted = true;
            this.Close();
        }
    }
}
