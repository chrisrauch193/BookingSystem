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

namespace NorthCoast
{
    public partial class LocationAdd : Form
    {
        //Delcare Variables
        SqlDataAdapter daAccommodation, daLocation;
        DataSet dsNorthCoast = new DataSet();
        SqlCommandBuilder cmdBAccommodation, cmdBLocation;
        DataRow drAccommodation, drLocation;
        String cnstr, sqlLocation;

        public LocationAdd()
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

        private void LocationAdd_Load(object sender, EventArgs e)
        {
            // connect to database and create dataset and table to hold customer details
            // Use Properties to hold value for maintenance
            cnstr = Properties.Resources.connectStr;

            //Select all from the table Accomodation
            sqlLocation = @"select * from Location";
            daLocation = new SqlDataAdapter(sqlLocation, cnstr);
            cmdBLocation = new SqlCommandBuilder(daLocation);
            daLocation.FillSchema(dsNorthCoast, SchemaType.Source, "Location");
            daLocation.Fill(dsNorthCoast, "Location");

            //Select all Accommodation ID's from table Accommodation and add them to a combobox
            SqlConnection conn = new SqlConnection(cnstr);
            SqlDataAdapter ada = new SqlDataAdapter("SELECT AccommodationID FROM Accommodation WHERE AccommodationID NOT IN (SELECT AccommodationID FROM Location)", conn);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                cbbAccommodationID.Items.Add(dr["AccommodationID"].ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // simple add using validation method checking existence and min/max length
            // of a string ( used for surname, forename and street)
            // sets error provider against invalid field
            //Create varbles and errP message icon for validation
            errP.Clear();
            Boolean ok = true;


            try
            {
                if (!txtLocationID.MaskCompleted)
                {
                    throw new CustomerException("Please enter a valid Location ID e.g. L001");
                }
            }
            catch (CustomerException ex)
            {
                ok = false;
                errP.SetError(txtLocationID, ex.Message);
            }
            try
            {
                if (String.IsNullOrEmpty(cbbAccommodationID.Text.Trim()))
                {
                    throw new CustomerException("This is a required field - Select an Accommodation Type or select null, '0000'");
                }
            }
            catch (CustomerException ex)
            {
                ok = false;
                errP.SetError(cbbAccommodationID, ex.Message);
            }

            if (ok)
            {
                try
                {
                    drLocation = dsNorthCoast.Tables["Location"].NewRow();

                    drLocation["LocationID"] = txtLocationID.Text.Trim();
                    drLocation["AccommodationID"] = cbbAccommodationID.SelectedItem.ToString().Trim();
                    drLocation["Disabled_Access"] = cbxDisabledAccess.CheckState == CheckState.Checked ? 1 : 0;
                    drLocation["Sea_View"] = cbxSeaView.CheckState == CheckState.Checked ? 1 : 0;

                    dsNorthCoast.Tables["Location"].Rows.Add(drLocation);
                    daLocation.Update(dsNorthCoast, "Location");

                    MessageBox.Show("Location Added");
                    btnAddAnother.Enabled = true;
                    btnAdd.Enabled = false;

                    //Restrict user to particular navigation
                    pnlLocationCreate.Enabled = false;
                    btnAdd.Enabled = false;
                    btnAddAnother.Enabled = true;
                }
                catch (System.Data.ConstraintException sqlEx)
                {
                    MessageBox.Show(sqlEx.Message);
                }
            }
        }

        private void btnAddAnother_Click(object sender, EventArgs e)
        {
            //Restrict user to particular navigation
            pnlLocationCreate.Enabled = true;
            btnAdd.Enabled = true;
            btnAddAnother.Enabled = false;
            txtLocationID.Clear();
            cbbAccommodationID.SelectedItem = null;
            cbxDisabledAccess.Checked = false;
            cbxSeaView.Checked = false;
        }
    }
}
