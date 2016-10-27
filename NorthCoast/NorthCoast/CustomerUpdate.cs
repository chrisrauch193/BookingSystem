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
    public partial class CustomerUpdate : Form
    {
        //Delcare Variables
        SqlDataAdapter daCustomer;
        DataSet dsNorthCoast = new DataSet();
        SqlCommandBuilder cmdBCustomer;
        DataRow drCustomer;
        String cnstr, sqlCustomer, sqlDataGrid;
        String sqlAllCustomers = @"SELECT * from Customer";

        public CustomerUpdate()
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

        private void CustomerUpdate_Load(object sender, EventArgs e)
        {
            // connect to database and create dataset and table to hold customer details
            // Use Properties to hold value for maintenance
            cnstr = Properties.Resources.connectStr;

            sqlCustomer = sqlAllCustomers;
            daCustomer = new SqlDataAdapter(sqlCustomer, cnstr);
            cmdBCustomer = new SqlCommandBuilder(daCustomer);
            daCustomer.FillSchema(dsNorthCoast, SchemaType.Source, "Customer");
            daCustomer.Fill(dsNorthCoast, "Customer");

            FillDataGrid(sqlAllCustomers);

            //AutoSize all columns
            dgvCustomer.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCustomer.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCustomer.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCustomer.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCustomer.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCustomer.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCustomer.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCustomer.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCustomer.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCustomer.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCustomer.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCustomer.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCustomer.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCustomer.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void FillDataGrid(String sqlStatement)
        {
            //Selecting and outputting selected Accommodation Types to user
            SqlConnection sqlConnection = new SqlConnection(cnstr);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlStatement, sqlConnection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dgvCustomer.ReadOnly = true;
            dgvCustomer.DataSource = ds.Tables[0];
        }

        private string SearchDataGridStatement(String column, String search)
        {
            //Selecting sql to display in the datagrid
            sqlDataGrid = @"SELECT * from Customer WHERE " + column + " LIKE'%" + search + "%'";
            return sqlDataGrid;
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvCustomer.Rows[e.RowIndex];
                    txtCustomerID.Text = row.Cells["CustomerID"].Value.ToString();
                    cbbTitle.SelectedItem = row.Cells["Title"].Value.ToString();
                    txtForename.Text = row.Cells["Forename"].Value.ToString();
                    txtSurname.Text = row.Cells["Surname"].Value.ToString();
                    dtpDOB.Value = Convert.ToDateTime(row.Cells["Date_Of_Birth"].Value.ToString());
                    txtAddressLine1.Text = row.Cells["AddressLine1"].Value.ToString();
                    txtAddressLine2.Text = row.Cells["AddressLine2"].Value.ToString();
                    txtTown.Text = row.Cells["Town"].Value.ToString();
                    txtPostcode.Text = row.Cells["PostCode"].Value.ToString();
                    txtTelNo.Text = row.Cells["Tel_No"].Value.ToString();
                    txtMobNo.Text = row.Cells["Mobile_No"].Value.ToString();
                    txtEmail.Text = row.Cells["Email_Address"].Value.ToString();
                    cbxNewsletterSub.Checked = Convert.ToBoolean(row.Cells["Newsletter_Subscription"].Value.ToString());
                    pnlCustomerUpdate.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Please Select an Accommodation Type");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (cbxSearch.SelectedItem.ToString())
            {
                case "Customer ID":
                    //Search the rows in the column Accommodation_Type
                    FillDataGrid(SearchDataGridStatement("CustomerID", txtSearch.Text));
                    break;
                case "Title":
                    //Search the rows in the column Accommodation_Desc
                    FillDataGrid(SearchDataGridStatement("Title", txtSearch.Text));
                    break;
                case "Forename":
                    //Search the rows in the column Accommodation_Size
                    FillDataGrid(SearchDataGridStatement("Forename", txtSearch.Text));
                    break;
                case "Surname":
                    //Search the rows in the column Charge_Per_Day
                    FillDataGrid(SearchDataGridStatement("Surname", txtSearch.Text));
                    break;
                case "Address Line 1":
                    //Search the rows in the column Charge_Per_Day
                    FillDataGrid(SearchDataGridStatement("AddressLine1", txtSearch.Text));
                    break;
                case "Address Line 2":
                    //Search the rows in the column Charge_Per_Day
                    FillDataGrid(SearchDataGridStatement("AddressLine2", txtSearch.Text));
                    break;
                case "Town":
                    //Search the rows in the column Charge_Per_Day
                    FillDataGrid(SearchDataGridStatement("Town", txtSearch.Text));
                    break;
                case "PostCode":
                    //Search the rows in the column Charge_Per_Day
                    FillDataGrid(SearchDataGridStatement("PostCode", txtSearch.Text));
                    break;
                case "Telephone No":
                    //Search the rows in the column Charge_Per_Day
                    FillDataGrid(SearchDataGridStatement("Tel_No", txtSearch.Text));
                    break;
                case "Mobile No":
                    //Search the rows in the column Charge_Per_Day
                    FillDataGrid(SearchDataGridStatement("Mobile_No", txtSearch.Text));
                    break;
                case "Email Address":
                    //Search the rows in the column Charge_Per_Day
                    FillDataGrid(SearchDataGridStatement("Email_Address", txtSearch.Text));
                    break;
                case "Date Of Birth":
                    //Search the rows in the column Charge_Per_Day
                    FillDataGrid(SearchDataGridStatement("Date_Of_Birth", txtSearch.Text));
                    break;
                case "Newsletters Sub":
                    //Search the rows in the column Charge_Per_Day
                    FillDataGrid(SearchDataGridStatement("Newsletter_Subscription", txtSearch.Text));
                    break;
                default:
                    //Show all rows in the datagrid
                    FillDataGrid(sqlAllCustomers);
                    break;
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            FillDataGrid(sqlAllCustomers);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // simple update using validation method checking existence and min/max length
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
                errP.SetError(txtTelNo, ex.Message);
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
                    drCustomer = dsNorthCoast.Tables["Customer"].Rows.Find(int.Parse(txtCustomerID.Text));

                    drCustomer.BeginEdit();

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

                    drCustomer.EndEdit();
                    SqlCommandBuilder objCommandBuilder = new SqlCommandBuilder(daCustomer);
                    daCustomer.Update(dsNorthCoast, "Customer");
                    MessageBox.Show("Customer Updated");
                    FillDataGrid(sqlAllCustomers);
                    pnlCustomerUpdate.Enabled = false;
                }
                catch (System.Data.ConstraintException sqlEx)
                {
                    MessageBox.Show(sqlEx.Message);
                }
            }
        }
    }
}
