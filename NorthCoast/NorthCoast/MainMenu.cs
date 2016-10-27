using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthCoast
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        #region MenuStripEvents
        //Menu Strip events for all pages
        private void mainMenuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frMainMenu = new MainMenu();
            frMainMenu.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmCustomerAdd = new CustomerAdd();
            frmCustomerAdd.Show();
            this.Hide();
        }

        private void deleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmCustomerDelete = new CustomerDelete();
            frmCustomerDelete.Show();
            this.Hide();
        }

        private void updateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmCustomerUpdate = new CustomerUpdate();
            frmCustomerUpdate.Show();
            this.Hide();
        }

        private void addBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmBookingAdd = new BookingAdd();
            frmBookingAdd.Show();
            this.Hide();
        }

        private void editBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmBookingEdit = new BookingEdit();
            frmBookingEdit.Show();
            this.Hide();
        }

        private void addAccommodationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmAccommodationAdd = new AccommodationAdd();
            frmAccommodationAdd.Show();
            this.Hide();
        }

        private void editAccommodationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmAccommodationEdit = new AccommodationEdit();
            frmAccommodationEdit.Show();
            this.Hide();
        }

        private void addLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmLocationAdd = new LocationAdd();
            frmLocationAdd.Show();
            this.Hide();
        }

        private void editLocationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmLocationEdit = new LocationEdit();
            frmLocationEdit.Show();
            this.Hide();
        }

        private void addTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmAccommodationTypeAdd = new AccommodationTypeAdd();
            frmAccommodationTypeAdd.Show();
            this.Hide();
        }

        private void editTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmAccommodationTypeEdit = new AccommodationTypeEdit();
            frmAccommodationTypeEdit.Show();
            this.Hide();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmReport = new Report();
            frmReport.Show();
            this.Hide();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"K:\A2\NorthCoast\NorthCoast\Resources\UserManual.pdf");          
        }
        #endregion
    }
}
