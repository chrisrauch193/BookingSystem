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
    public partial class CustomerAdd : Form
    {
        //Delcare Variables
        SqlDataAdapter daCustomer;
        DataSet dsNorthCoast = new DataSet();
        SqlCommandBuilder cmdBCustomer;
        DataRow drCustomer;
        String cnstr, sqlCustomer;
        int nextCustomerID;

        public CustomerAdd()
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

        private void CustomerAdd_Load(object sender, EventArgs e)
        {
            // disable  Add / AddAnother buttons
            btnAddAnother.Enabled = false;
            btnAdd.Enabled = true;
            dtpDOB.MaxDate = DateTime.Now.AddYears(-18);

            // connect to database and create dataset and table to hold customer details
            // Use Properties to hold value for maintenance
            cnstr = Properties.Resources.connectStr;

            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, cnstr);
            cmdBCustomer = new SqlCommandBuilder(daCustomer);
            daCustomer.FillSchema(dsNorthCoast, SchemaType.Source, "Customer");
            daCustomer.Fill(dsNorthCoast, "Customer");
            int noRows = dsNorthCoast.Tables["Customer"].Rows.Count;
            if (noRows == 0)
                nextCustomerID = 1000;
            else
            {
                drCustomer = dsNorthCoast.Tables["Customer"].Rows[noRows - 1];
                nextCustomerID = int.Parse(drCustomer["CustomerID"].ToString()) + 1;
            }
            txtCustomerID.Text = nextCustomerID.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // simple add using validation method checking existence and min/max length
            // of a string ( used for surname, forename and street)
            // sets error provider against invalid field
            //Create varbles and errP message icon for validation
            errP.Clear();
            Boolean ok = true;
            Boolean numberEntered = true;
            Customer c = new Customer();



            try
            {
                c.CustomerID = int.Parse(txtCustomerID.Text.Trim());
            }
            catch (CustomerException ex)
            {
                ok = false;
                errP.SetError(txtCustomerID, ex.Message);
            }
            try
            {
                c.Forename = txtForename.Text.Trim();
            }
            catch (CustomerException ex)
            {
                ok = false;
                errP.SetError(txtForename, ex.Message);
            }
            try
            {
                c.Surname = txtSurname.Text.Trim();
            }
            catch (CustomerException ex)
            {
                ok = false;
                errP.SetError(txtSurname, ex.Message);
            }
            try
            {
                c.DateOfBirth = dtpDOB.Value.Date;
            }
            catch (CustomerException ex)
            {
                ok = false;
                errP.SetError(dtpDOB, ex.Message);
            }
            try
            {
                c.Title = cbbTitle.Text.Trim();
            }
            catch (CustomerException ex)
            {
                ok = false;
                errP.SetError(cbbTitle, ex.Message);
            }
            try
            {
                c.AddressLine1 = txtAddressLine1.Text.Trim();
            }
            catch (CustomerException ex)
            {
                ok = false;
                errP.SetError(txtAddressLine1, ex.Message);
            }
            try
            {
                c.Town = txtTown.Text.Trim();
            }
            catch (CustomerException ex)
            {
                ok = false;
                errP.SetError(txtTown, ex.Message);
            }
            try
            {
                if (!txtPostcode.MaskCompleted)
                {
                    throw new CustomerException("Please enter a valid Postcode e.g. BT23 6QQ");
                }
            }
            catch (CustomerException ex)
            {
                ok = false;
                errP.SetError(txtPostcode, ex.Message);
            }
            if (txtTelNo.Text.Trim() == "(   )     -" && txtMobNo.Text.Trim() == "(   )     -")
            {
                numberEntered = false;
                ok = false;
                errP.SetError(txtTelNo, "You must enter either a telephone number, a mobile number or both");
                errP.SetError(txtMobNo, "You must enter either a telephone number, a mobile number or both");
            }
            if (numberEntered)
            {
                if (txtTelNo.Text.Trim() != "(   )     -")
                {
                    try
                    {
                        if (!txtTelNo.MaskCompleted)
                        {
                            throw new CustomerException("Please enter a valid Phone Number");
                        }
                    }
                    catch (CustomerException ex)
                    {
                        ok = false;
                        errP.SetError(txtTelNo, ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        if (!txtMobNo.MaskCompleted)
                        {
                            throw new CustomerException("Please enter a valid Phone Number");
                        }
                    }
                    catch (CustomerException ex)
                    {
                        ok = false;
                        errP.SetError(txtMobNo, ex.Message);
                    }
                }
            }
            try
            {
                c.Email = txtEmail.Text.Trim();
            }
            catch (CustomerException ex)
            {
                ok = false;
                errP.SetError(txtEmail, ex.Message);
            }

            if (ok)
            {
                try
                {
                    drCustomer = dsNorthCoast.Tables["Customer"].NewRow();

                    drCustomer["CustomerID"] = int.Parse(txtCustomerID.Text);
                    drCustomer["Title"] = cbbTitle.SelectedItem.ToString();
                    drCustomer["Forename"] = txtForename.Text.Trim();
                    drCustomer["Surname"] = txtSurname.Text.Trim();
                    drCustomer["Date_Of_Birth"] = dtpDOB.Value.Date.ToString();
                    drCustomer["AddressLine1"] = txtAddressLine1.Text.Trim();
                    drCustomer["AddressLine2"] = txtAddressLine2.Text.Trim();
                    drCustomer["Town"] = txtTown.Text.Trim();
                    drCustomer["Postcode"] = txtPostcode.Text.Trim();
                    if (txtTelNo.Text.Trim() != "(   )     -" && txtMobNo.Text.Trim() != "(   )     -")
                    {
                        drCustomer["Tel_No"] = txtTelNo.Text.Trim();
                        drCustomer["Mobile_No"] = txtMobNo.Text.Trim();
                    }
                    else if (txtTelNo.Text.Trim() == "(   )     -")
                    {
                        drCustomer["Tel_No"] = null;
                        drCustomer["Mobile_No"] = txtMobNo.Text.Trim();
                    }
                    else
                    {
                        drCustomer["Tel_No"] = txtTelNo.Text.Trim();
                        drCustomer["Mobile_No"] = null;
                    }
                    drCustomer["Email_Address"] = txtEmail.Text.Trim();
                    drCustomer["Newsletter_Subscription"] = cbxNewsletterSub.CheckState == CheckState.Checked ? 1 : 0;

                    dsNorthCoast.Tables["Customer"].Rows.Add(drCustomer);
                    daCustomer.Update(dsNorthCoast, "Customer");

                    MessageBox.Show("Customer Added");
                    btnAddAnother.Enabled = true;
                    btnAdd.Enabled = false;
                }
                catch (System.Data.ConstraintException sqlEx)
                {
                    MessageBox.Show(sqlEx.Message);
                }
            }
        }

        private void btnAddAnother_Click(object sender, EventArgs e)
        {
            nextCustomerID++;
            txtCustomerID.Text = nextCustomerID.ToString();
            cbbTitle.SelectedItem = null;
            txtForename.Clear();
            txtSurname.Clear();
            dtpDOB.Value = dtpDOB.MinDate;
            txtAddressLine1.Clear();
            txtAddressLine2.Clear();
            txtTown.Clear();
            txtPostcode.Clear();
            txtTelNo.Clear();
            txtMobNo.Clear();
            txtEmail.Clear();
            btnAdd.Enabled = true;
            btnAddAnother.Enabled = false;
        }
    }
}
