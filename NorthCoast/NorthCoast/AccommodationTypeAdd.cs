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
    public partial class AccommodationTypeAdd : Form
    {
        //Delcare Variables
        SqlDataAdapter daAccommodationType;
        DataSet dsNorthCoast = new DataSet();
        SqlCommandBuilder cmdBAccommodationType;
        DataRow drAccommodationType;
        String cnstr, sqlAccommodationType;

        public AccommodationTypeAdd()
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

        private void AccommodationTypeAdd_Load(object sender, EventArgs e)
        {
            // connect to database and create dataset and table to hold customer details
            // Use Properties to hold value for maintenance
            cnstr = Properties.Resources.connectStr;

            //Select all from the table AccommodationType
            sqlAccommodationType = @"select * from AccommodationType";
            daAccommodationType = new SqlDataAdapter(sqlAccommodationType, cnstr);
            cmdBAccommodationType = new SqlCommandBuilder(daAccommodationType);
            daAccommodationType.FillSchema(dsNorthCoast, SchemaType.Source, "AccommodationType");
            daAccommodationType.Fill(dsNorthCoast, "AccommodationType");
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
                if (!txtAccommodationType.MaskCompleted)
                {
                    throw new CustomerException("Please enter a valid Accommodation Type ID e.g. C08");
                }
            }
            catch (CustomerException ex)
            {
                ok = false;
                errP.SetError(txtAccommodationType, ex.Message);
            }
            try
            {
                if (String.IsNullOrEmpty(txtAccommodationDesc.Text.Trim()))
                {
                    throw new CustomerException("This is a required field - Please enter a description");
                }
            }
            catch (CustomerException ex)
            {
                ok = false;
                errP.SetError(txtAccommodationDesc, ex.Message);
            }
            try
            {
                if (String.IsNullOrEmpty(txtAccommodationSize.Text))
                {
                    throw new CustomerException("Please enter a valid Accommodation Size e.g. 08");
                }
            }
            catch (CustomerException ex)
            {
                ok = false;
                errP.SetError(txtAccommodationSize, ex.Message);
            }
            try
            {
                if (!txtChargePerDay.MaskCompleted)
                {
                    throw new CustomerException("Please enter a valid Charege Per Day e.g. £039.99");
                }
            }
            catch (CustomerException ex)
            {
                ok = false;
                errP.SetError(txtChargePerDay, ex.Message);
            }

            if (ok)
            {
                try
                {
                    drAccommodationType = dsNorthCoast.Tables["AccommodationType"].NewRow();

                    drAccommodationType["Accommodation_Type"] = txtAccommodationType.Text.Trim();
                    drAccommodationType["Accommodation_Desc"] = txtAccommodationDesc.Text.Trim();
                    drAccommodationType["Accommodation_Size"] = txtAccommodationSize.Text.Trim();
                    drAccommodationType["Charge_Per_Day"] = txtChargePerDay.Text.Substring(1,6).Trim();

                    dsNorthCoast.Tables["AccommodationType"].Rows.Add(drAccommodationType);
                    daAccommodationType.Update(dsNorthCoast, "AccommodationType");

                    MessageBox.Show("Accommodation Type Added");
                    btnAddAnother.Enabled = true;
                    btnAdd.Enabled = false;

                    //Restrict user to particular navigation
                    pnlAccommodationTypeCreate.Enabled = false;
                    btnAdd.Enabled = false;
                    btnAddAnother.Enabled = true;
                }
                catch (System.Data.ConstraintException sqlEx)
                {
                    MessageBox.Show(sqlEx.Message);
                }
            }
        }

        private String validDescription(String str)
        {
            String message = "ok";

            if (String.IsNullOrEmpty(str))
            {
                message = "This is a required field - Please enter data";
            }

            return message;
        }

        private void btnAddAnother_Click(object sender, EventArgs e)
        {
            //Restrict user to particular navigation
            pnlAccommodationTypeCreate.Enabled = true;
            btnAdd.Enabled = true;
            btnAddAnother.Enabled = false;
            txtAccommodationType.Clear();
            txtAccommodationDesc.Clear();
            txtAccommodationSize.Clear();
            txtChargePerDay.Clear();
        }

        private void txtAccommodationType_TextChanged(object sender, EventArgs e)
        {
            if (txtAccommodationType.MaskCompleted)
            {
                txtAccommodationSize.Text = txtAccommodationType.Text.Substring(1, 2);
            }
            else
            {
                txtAccommodationSize.Clear();
            }
        }
    }
}
