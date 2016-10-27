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
    public partial class LocationEdit : Form
    {
        //Delcare Variables
        SqlDataAdapter daLocation, daCustomerBooking;
        DataSet dsNorthCoast = new DataSet();
        SqlCommandBuilder cmdBLocation, cmdBCustomerBooking;
        DataRow drLocation;
        String cnstr, sqlLocation, sqlCustomerBooking, sqlDataGrid, originalKey;
        String sqlAll = @"SELECT * from Location";

        public LocationEdit()
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

        private void LocationDelete_Load(object sender, EventArgs e)
        {
            SetupDataset();
        }

        private void SetupDataset()
        {
            // connect to database and create dataset and table to hold customer details
            // Use Properties to hold value for maintenance
            cnstr = Properties.Resources.connectStr;

            //Select all from the table Location
            sqlLocation = @"select * from Location";
            daLocation = new SqlDataAdapter(sqlLocation, cnstr);
            cmdBLocation = new SqlCommandBuilder(daLocation);
            daLocation.FillSchema(dsNorthCoast, SchemaType.Source, "Location");
            daLocation.Fill(dsNorthCoast, "Location");

            //CustomerBooking Code
            sqlCustomerBooking = @"select * from CustomerBooking";
            daCustomerBooking = new SqlDataAdapter(sqlCustomerBooking, cnstr);
            cmdBCustomerBooking = new SqlCommandBuilder(daCustomerBooking);
            daCustomerBooking.FillSchema(dsNorthCoast, SchemaType.Source, "CustomerBooking");
            daCustomerBooking.Fill(dsNorthCoast, "CustomerBooking");

            FillAccommodationComboBox();
            FillDataGrid(sqlAll);

            //AutoSize all columns
            dgvLocation.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvLocation.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvLocation.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvLocation.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void FillDataGrid(String sqlStatement)
        {
            //Selecting and outputting all selected Locations to user
            SqlConnection sqlConnection = new SqlConnection(cnstr);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlStatement, sqlConnection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dgvLocation.ReadOnly = true;
            dgvLocation.DataSource = ds.Tables[0];
        }

        private string SearchDataGridStatement(String column, String search)
        {
            //Selecting sql to display in the datagrid
            sqlDataGrid = @"SELECT * from Location WHERE " + column + " LIKE'%" + search + "%'";
            return sqlDataGrid;
        }

        private void FillAccommodationComboBox()
        {
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

        private void dgvAccommodation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvLocation.Rows[e.RowIndex];
                    txtLocationID.Text = row.Cells["LocationID"].Value.ToString();
                    originalKey = row.Cells["LocationID"].Value.ToString();
                    cbxDisabledAccess.Checked = Convert.ToBoolean(row.Cells["Disabled_Access"].Value.ToString());
                    cbxSeaView.Checked = Convert.ToBoolean(row.Cells["Sea_View"].Value.ToString());
                    pnlButtons.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Please Select an Accommodation Type");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = true;
            btnUpdate.Visible = true;
            btnBack.Visible = false;
            btnConfirm.Visible = false;
            dgvLocation.Enabled = true;
            pnlLocationEdit.Enabled = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
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
                    drLocation = dsNorthCoast.Tables["Location"].Rows.Find(originalKey);

                    drLocation.BeginEdit();

                    drLocation["LocationID"] = txtLocationID.Text.Trim();
                    drLocation["AccommodationID"] = cbbAccommodationID.SelectedItem.ToString().Trim();
                    drLocation["Disabled_Access"] = cbxDisabledAccess.CheckState == CheckState.Checked ? 1 : 0;
                    drLocation["Sea_View"] = cbxSeaView.CheckState == CheckState.Checked ? 1 : 0;

                    drLocation.EndEdit();
                    SqlCommandBuilder objCommandBuilder = new SqlCommandBuilder(daLocation);
                    daLocation.Update(dsNorthCoast, "Location");
                    MessageBox.Show("Location Updated");
                    FillDataGrid(sqlAll);

                    btnDelete.Visible = true;
                    btnUpdate.Visible = true;
                    btnBack.Visible = false;
                    btnConfirm.Visible = false;
                    dgvLocation.Enabled = true;
                    pnlLocationEdit.Enabled = false;
                    pnlButtons.Enabled = false;

                    SetupDataset();
                }
                catch (System.Data.ConstraintException sqlEx)
                {
                    MessageBox.Show(sqlEx.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                drLocation = dsNorthCoast.Tables["Location"].Rows.Find(originalKey);
                drLocation.Delete();
                daLocation.Update(dsNorthCoast, "Location");
                MessageBox.Show("Location Deleted");
                FillDataGrid(sqlAll);
                pnlLocationEdit.Enabled = false;
                pnlButtons.Enabled = false;
            }
            catch (SqlException)
            {
                dgvLocation.Enabled = true;
                pnlConfirmDelete.Visible = true;
                pnlButtons.Enabled = false;
                pnlLocationEdit.Enabled = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btnBack.Visible = true;
            btnConfirm.Visible = true;
            dgvLocation.Enabled = false;
            pnlLocationEdit.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetupDataset();
            pnlConfirmDelete.Visible = false;
            pnlButtons.Enabled = true;
            pnlLocationEdit.Enabled = true;
        }

        private void btnConfirmCascade_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cnstr))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM CustomerBooking WHERE LocationID = '" + originalKey + "'", con))
                    {
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                    MessageBox.Show("Customer Bookings Deleted");
                }

                SetupDataset();

                drLocation = dsNorthCoast.Tables["Location"].Rows.Find(originalKey);
                drLocation.Delete();
                daLocation.Update(dsNorthCoast, "Location");
                MessageBox.Show("Location Deleted");
                FillDataGrid(sqlAll);

                SetupDataset();
                pnlConfirmDelete.Visible = false;
                dgvLocation.Enabled = true;
                pnlLocationEdit.Enabled = false;
                pnlButtons.Enabled = false;
            }
            catch (SystemException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (cbxSearch.SelectedItem.ToString())
            {
                case "Location ID":
                    //Search the rows in the column Accommodation_Type
                    FillDataGrid(SearchDataGridStatement("LocationID", txtSearch.Text));
                    break;
                case "Accommodation ID":
                    //Search the rows in the column Accommodation_Desc
                    FillDataGrid(SearchDataGridStatement("AccommodationID", txtSearch.Text));
                    break;
                case "Disabled Access":
                    //Search the rows in the column Accommodation_Size
                    FillDataGrid(SearchDataGridStatement("Disabled_Access", txtSearch.Text));
                    break;
                case "Sea View":
                    //Search the rows in the column Charge_Per_Day
                    FillDataGrid(SearchDataGridStatement("Sea_View", txtSearch.Text));
                    break;
                default:
                    //Show all rows in the datagrid
                    FillDataGrid(sqlAll);
                    break;
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            FillDataGrid(sqlAll);
        }
    }
}
