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
    public partial class AccommodationAdd : Form
    {
        //Delcare Variables
        SqlDataAdapter daAccommodationType, daAccommodation;
        DataSet dsNorthCoast = new DataSet();
        SqlCommandBuilder cmdBAccommodationType, cmdBAccommodation;
        DataRow drAccommodation;
        String cnstr, sqlAccommodationType, sqlAccommodation;

        public AccommodationAdd()
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

        private void AccommodationAdd_Load(object sender, EventArgs e)
        {
            // connect to database and create dataset and table to hold customer details
            // Use Properties to hold value for maintenance
            cnstr = Properties.Resources.connectStr;

            //Select all from the table Accomodation
            sqlAccommodation = @"select * from Accommodation";
            daAccommodation = new SqlDataAdapter(sqlAccommodation, cnstr);
            cmdBAccommodation = new SqlCommandBuilder(daAccommodation);
            daAccommodation.FillSchema(dsNorthCoast, SchemaType.Source, "Accommodation");
            daAccommodation.Fill(dsNorthCoast, "Accommodation");

            //Select all Accommodation Type's from table AccommodationType and add them to a combobox
            SqlConnection conn = new SqlConnection(cnstr);
            SqlDataAdapter ada = new SqlDataAdapter("select Accommodation_Type from AccommodationType", conn);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                cbbAccommodationType.Items.Add(dr["Accommodation_Type"].ToString());
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
                if (!txtAccommodationID.MaskCompleted)
                {
                    throw new CustomerException("Please enter a valid Accommodation ID e.g. CL08");
                }
            }
            catch (CustomerException ex)
            {
                ok = false;
                errP.SetError(txtAccommodationID, ex.Message);
            }
            try
            {
                if (String.IsNullOrEmpty(cbbAccommodationType.Text.Trim()))
                {
                    throw new CustomerException("This is a required field - Select an Accommodation Type");
                }
            }
            catch (CustomerException ex)
            {
                ok = false;
                errP.SetError(cbbAccommodationType, ex.Message);
            }

            if (ok)
            {
                try
                {
                    drAccommodation = dsNorthCoast.Tables["Accommodation"].NewRow();

                    drAccommodation["AccommodationID"] = txtAccommodationID.Text.Trim();
                    drAccommodation["Accommodation_Type"] = cbbAccommodationType.SelectedItem.ToString().Trim();
                    drAccommodation["Needs_Serviced"] = cbxNeedsServiced.CheckState == CheckState.Checked ? 1 : 0;
                    drAccommodation["Notes"] = txtNotes.Text.Trim();

                    dsNorthCoast.Tables["Accommodation"].Rows.Add(drAccommodation);
                    daAccommodation.Update(dsNorthCoast, "Accommodation");

                    MessageBox.Show("Accommodation Added");
                    btnAddAnother.Enabled = true;
                    btnAdd.Enabled = false;

                    //Restrict user to particular navigation
                    pnlAccommodationCreate.Enabled = false;
                    btnAdd.Enabled = false;
                    btnAddAnother.Enabled = true;
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show(sqlEx.Message);
                }
            }
        }

        private void btnAddAnother_Click(object sender, EventArgs e)
        {
            //Restrict user to particular navigation
            pnlAccommodationCreate.Enabled = true;
            btnAdd.Enabled = true;
            btnAddAnother.Enabled = false;
            txtAccommodationID.Clear();
            cbbAccommodationType.SelectedItem = null;
            cbxNeedsServiced.Checked = false;
            txtNotes.Clear();
        }
    }
}
