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
    public partial class BookingEdit : Form
    {
        //Delcare Variables
        SqlDataAdapter daCustomer, daCustomerBooking, daLocation, daBookings;
        DataSet dsNorthCoast = new DataSet();
        SqlCommandBuilder cmdBCustomer, cmdBCustomerBooking, cmdBLocation, cmdBBookings;
        DataRow drCustomer, drCustomerBooking, drLocation, drBookings;
        String cnstr, sqlCustomer, sqlCustomerBooking, sqlLocation, sqlBookings, sqlDataGrid;
        String sqlAllBookings = @"SELECT CustomerBooking.CustomerID, Surname, Forename, Location.LocationID, Accommodation_Type, Arrival_Date, Departure_Date FROM CustomerBooking, Customer, Location, Accommodation WHERE Customer.CustomerID = CustomerBooking.CustomerID AND CustomerBooking.LocationID = Location.LocationID AND Location.AccommodationID = Accommodation.AccommodationID";


        public BookingEdit()
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

        private void BookingDelete_Load(object sender, EventArgs e)
        {
            // connect to database and create dataset and table to hold customer details
            // Use Properties to hold value for maintenance
            cnstr = Properties.Resources.connectStr;

            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, cnstr);
            cmdBCustomer = new SqlCommandBuilder(daCustomer);
            daCustomer.FillSchema(dsNorthCoast, SchemaType.Source, "Customer");
            daCustomer.Fill(dsNorthCoast, "Customer");

            sqlCustomerBooking = @"select * from CustomerBooking";
            daCustomerBooking = new SqlDataAdapter(sqlCustomerBooking, cnstr);
            cmdBCustomerBooking = new SqlCommandBuilder(daCustomerBooking);
            daCustomerBooking.FillSchema(dsNorthCoast, SchemaType.Source, "CustomerBooking");
            daCustomerBooking.Fill(dsNorthCoast, "CustomerBooking");

            FillDataGrid(sqlAllBookings);

            //AutoSize all columns
            dgvBookings.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBookings.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBookings.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBookings.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBookings.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBookings.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBookings.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
        private void FillDataGrid(String sqlStatement)
        {
            //Selecting and outputting certain columns to display the selected bookings to user
            SqlConnection sqlConnection = new SqlConnection(cnstr);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlStatement, sqlConnection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dgvBookings.ReadOnly = true;
            dgvBookings.DataSource = ds.Tables[0];
        }

        private string SearchDataGridStatementCustomerBooking(String column, String search)
        {
            //Selecting sql to display in the datagrid
            sqlDataGrid = @"SELECT CustomerBooking.CustomerID, Surname, Forename, Location.LocationID, Accommodation_Type, Arrival_Date, Departure_Date FROM CustomerBooking, Customer, Location, Accommodation WHERE Customer.CustomerID = CustomerBooking.CustomerID AND CustomerBooking.LocationID = Location.LocationID AND Location.AccommodationID = Accommodation.AccommodationID AND CustomerBooking." + column + " LIKE'%" + search + "%'";
            return sqlDataGrid;
        }

        private string SearchDataGridStatementCustomer(String column, String search)
        {
            //Selecting sql to display in the datagrid
            sqlDataGrid = @"SELECT CustomerBooking.CustomerID, Surname, Forename, Location.LocationID, Accommodation_Type, Arrival_Date, Departure_Date FROM CustomerBooking, Customer, Location, Accommodation WHERE Customer.CustomerID = CustomerBooking.CustomerID AND CustomerBooking.LocationID = Location.LocationID AND Location.AccommodationID = Accommodation.AccommodationID AND Customer." + column + " LIKE'%" + search + "%'";
            return sqlDataGrid;
        }

        private string SearchDataGridStatementAccommodation(String column, String search)
        {
            //Selecting sql to display in the datagrid
            sqlDataGrid = @"SELECT CustomerBooking.CustomerID, Surname, Forename, Location.LocationID, Accommodation_Type, Arrival_Date, Departure_Date FROM CustomerBooking, Customer, Location, Accommodation WHERE Customer.CustomerID = CustomerBooking.CustomerID AND CustomerBooking.LocationID = Location.LocationID AND Location.AccommodationID = Accommodation.AccommodationID AND Accommodation." + column + " LIKE'%" + search + "%'";
            return sqlDataGrid;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                drCustomerBooking = drCustomerBooking = FindInMultiPKey(dsNorthCoast.Tables["CustomerBooking"]);
                drCustomerBooking.Delete();
                SqlCommandBuilder objCommandBuilder = new SqlCommandBuilder(daCustomerBooking);
                daCustomerBooking.Update(dsNorthCoast, "CustomerBooking");
                MessageBox.Show("Customer Deleted");
                FillDataGrid(sqlAllBookings);
                pnlBookingDelete.Visible = false;
                dgvBookings.Enabled = true;
            }
            catch (System.Data.ConstraintException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
        }

        private void dgvBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvBookings.Rows[e.RowIndex];
                    txtCustomerID.Text = row.Cells["CustomerID"].Value.ToString();
                    txtForename.Text = row.Cells["Forename"].Value.ToString();
                    txtSurname.Text = row.Cells["Surname"].Value.ToString();
                    txtLocationID.Text = row.Cells["LocationID"].Value.ToString();
                    String arrivalDate = row.Cells["Arrival_Date"].Value.ToString();
                    DateTime arrivalDate1 = Convert.ToDateTime(arrivalDate);
                    txtArrivalDate.Text = arrivalDate1.ToString("dd/MM/yyyy");
                    txtArrivalDateConvert.Text = arrivalDate1.ToString("yyyyMMdd");
                    String departureDate = row.Cells["Arrival_Date"].Value.ToString();
                    DateTime departureDate1 = Convert.ToDateTime(departureDate);
                    txtDepartureDate.Text = departureDate1.ToString("dd/MM/yyyy");
                    pnlBookingDelete.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Please Select a Booking");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Show update panel and disable all other controls
            pnlBookingUpdate.Visible = true;
            pnlBookingDelete.Visible = false;
            dgvBookings.Enabled = false;

            //Fill in all options with original booking details
            String sqlquery = "SELECT * FROM CustomerBooking, Location, Accommodation WHERE CustomerID = '" + txtCustomerID.Text + "' AND CustomerBooking.LocationID = '" + txtLocationID.Text + "'AND Location.LocationID = '" + txtLocationID.Text + "' AND Location.AccommodationID = Accommodation.AccommodationID AND Arrival_Date = '" + txtArrivalDateConvert.Text + "'";
            try
            {
                using (var connection = new SqlConnection(cnstr))
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sqlquery;
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            String accommodationType = reader["Accommodation_Type"].ToString().Substring(0, 1);
                            if (accommodationType == "C")
                            {
                                cbbAccommodationType.SelectedItem = "Caravan";
                            }
                            else if (accommodationType == "T")
                            {
                                cbbAccommodationType.SelectedItem = "Tent";
                            }
                            else if (accommodationType == "P")
                            {
                                cbbAccommodationType.SelectedItem = "Pitch";
                            }
                            cbbNumberOfPeople.SelectedItem = reader["Number_Of_People"].ToString();
                            dtpArrivalDate.Value = Convert.ToDateTime(reader["Arrival_Date"].ToString());
                            cbbNumberOfNights.SelectedItem = (Convert.ToDateTime(reader["Departure_Date"].ToString()) - Convert.ToDateTime(reader["Arrival_Date"].ToString())).TotalDays.ToString();
                            cbxDisabledAccess.Checked = Convert.ToBoolean(reader["Disabled_Access"].ToString());
                            cbxSeaView.Checked = Convert.ToBoolean(reader["Sea_View"].ToString());
                            cbxWater.Checked = Convert.ToBoolean(reader["Water"].ToString());
                            cbxElectric.Checked = Convert.ToBoolean(reader["Electric"].ToString());

                            //Display Other available accommodation for originally settings
                            SearchBookings(true);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }

        private void SearchBookings(bool filling)
        {
            Boolean ok = true;

            if (!filling)
            {
                ok = ValidateBooking();
            }
            
            if (ok)
            {
                using (SqlConnection c = new SqlConnection(cnstr))
                {
                    //Delcare Variables
                    string accommodationType, numberOfPeople, accommodationTypeID, seaView, disabledAccess;
                    DateTime newDate;

                    //Set Current Need variables
                    seaView = (cbxSeaView.CheckState == CheckState.Checked ? 1 : 0).ToString();
                    disabledAccess = (cbxDisabledAccess.CheckState == CheckState.Checked ? 1 : 0).ToString();

                    //Create Class later for this!!!!!!!!!!!!
                    if (IsOdd(int.Parse(cbbNumberOfPeople.Text)))
                    {
                        if (int.Parse(cbbNumberOfPeople.Text) < 10)
                        {
                            numberOfPeople = "0" + (int.Parse(cbbNumberOfPeople.Text) + 1).ToString();
                        }
                        else
                        {
                            numberOfPeople = (int.Parse(cbbNumberOfPeople.Text) + 1).ToString();

                        }

                    }
                    else
                    {
                        if (int.Parse(cbbNumberOfPeople.Text) < 10)
                        {
                            numberOfPeople = "0" + cbbNumberOfPeople.Text;
                        }
                        else
                        {
                            numberOfPeople = cbbNumberOfPeople.Text;

                        }
                    }
                    accommodationType = cbbAccommodationType.Text.Substring(0, 1);

                    accommodationTypeID = accommodationType + numberOfPeople;



                    c.Open();

                    if (cbbNumberOfNights.Text == "Indefinite")
                    {
                        newDate = dtpArrivalDate.Value.Date.AddMonths(1);
                    }
                    else
                    {
                        newDate = dtpArrivalDate.Value.Date.AddDays(Convert.ToDouble(cbbNumberOfNights.Text));
                    }
                    //MessageBox.Show(newDate.ToString("yyyyMMdd"));

                    // use a SqlAdapter to execute the query
                    using (SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM Location, Accommodation, AccommodationType WHERE (Accommodation.Accommodation_Type LIKE'%" + accommodationTypeID + "%' AND AccommodationType.Accommodation_Type LIKE'%" + accommodationTypeID + "%') AND (Accommodation.AccommodationID = Location.AccommodationID) AND Location.LocationID NOT IN (SELECT LocationID FROM dbo.CustomerBooking WHERE '" + dtpArrivalDate.Value.Date.ToString("yyyyMMdd") + "' BETWEEN [Arrival_Date] AND [Departure_Date] OR '" + newDate.ToString("yyyyMMdd") + "' BETWEEN [Arrival_Date] AND [Departure_Date]) AND Location.Sea_View = '" + seaView + "' AND Location.Disabled_Access = '" + disabledAccess + "'", c))
                    {
                        // fill a data table
                        var t = new DataTable();
                        a.Fill(t);

                        // Bind the table to the list box
                        lbxAccommodation_Type.DisplayMember = "Accommodation_Desc"; //"Accommodation_Desc";
                        lbxAccommodation_Type.ValueMember = "LocationID"; //"Accommodation_Type";
                        lbxAccommodation_Type.DataSource = t;
                    }
                }
            }
        }

        private Boolean ValidateBooking()
        {
            errP.Clear();
            Boolean ok = true;
            CustomerBooking cB = new CustomerBooking();

            try
            {
                cB.AccommodationType = cbbAccommodationType.Text;
            }
            catch (CustomerException ex)
            {
                ok = false;
                errP.SetError(cbbAccommodationType, ex.Message);
            }
            try
            {
                cB.NoOfPeople = cbbNumberOfPeople.Text;
            }
            catch (CustomerException ex)
            {
                ok = false;
                errP.SetError(cbbNumberOfPeople, ex.Message);
            }
            try
            {
                cB.ArrivalDate = dtpArrivalDate.Value.Date;
            }
            catch (CustomerException ex)
            {
                ok = false;
                errP.SetError(dtpArrivalDate, ex.Message);
            }
            try //dtpArrivalDate.Value.AddDays(Convert.ToDouble(cbbNumberOfNights.Text));
            {
                cB.NoOfNights = cbbNumberOfNights.Text;
            }
            catch (CustomerException ex)
            {
                ok = false;
                errP.SetError(cbbNumberOfNights, ex.Message);
            }

            return ok;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Boolean ok = true;
            ok = ValidateBooking();

            if (ok)
            {
                //bool is false as we now want to calidate the new entered data
                SearchBookings(false);

                //Stop user from making chances to original booking details
                cbbAccommodationType.Enabled = false;
                cbbNumberOfPeople.Enabled = false;
                dtpArrivalDate.Enabled = false;
                cbbNumberOfNights.Enabled = false;
                btnSearch.Enabled = false;
                lbxAccommodation_Type.Enabled = true;
                btnFilter.Enabled = true;
                cbxElectric.Enabled = true;
                cbxWater.Enabled = true;
                cbxSeaView.Enabled = false;
                cbxDisabledAccess.Enabled = false;
                btnConfirmUpdate.Enabled = true;
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            //Allow users to edit their original booking details
            cbbAccommodationType.Enabled = true;
            cbbNumberOfPeople.Enabled = true;
            dtpArrivalDate.Enabled = true;
            cbbNumberOfNights.Enabled = true;
            btnSearch.Enabled = true;
            lbxAccommodation_Type.Enabled = false;
            btnFilter.Enabled = false;
            cbxElectric.Enabled = false;
            cbxWater.Enabled = false;
            cbxSeaView.Enabled = true;
            cbxDisabledAccess.Enabled = true;
            btnConfirmUpdate.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlBookingUpdate.Visible = false;
            pnlBookingDelete.Visible = true;
            dgvBookings.Enabled = true;
        }

        private DataRow FindInMultiPKey(DataTable myTable)
        {
            DataRow foundRow;
            // Create an array for the key values to find.
            object[] findTheseVals = new object[3];
            // Set the values of the keys to find.
            findTheseVals[0] = txtCustomerID.Text;
            findTheseVals[1] = txtLocationID.Text;
            findTheseVals[2] = txtArrivalDate.Text;
            foundRow = myTable.Rows.Find(findTheseVals);

            return foundRow;
        }

        private void btnConfirmUpdate_Click(object sender, EventArgs e)
        {
            int no = int.Parse(txtCustomerID.Text);
            String primaryKey = txtCustomerID.Text + txtLocationID.Text + txtArrivalDateConvert.Text;
            drCustomerBooking = FindInMultiPKey(dsNorthCoast.Tables["CustomerBooking"]);

            drCustomerBooking.BeginEdit();


            drCustomerBooking["CustomerID"] = txtCustomerID.Text.Trim();

            drCustomerBooking["LocationID"] = lbxAccommodation_Type.SelectedValue.ToString();

            drCustomerBooking["Arrival_Date"] = dtpArrivalDate.Value.Date.ToString();
            if (cbbNumberOfNights.Text == "Indefinite")
            {
                drCustomerBooking["Departure_Date"] = dtpArrivalDate.Value.AddMonths(1);
            }
            else
            {
                drCustomerBooking["Departure_Date"] = dtpArrivalDate.Value.Date.AddDays(Convert.ToDouble(cbbNumberOfNights.Text)).ToString();
            }

            drCustomerBooking["Date_Of_Booking"] = DateTime.Now.ToString(); //DateTime.Now.ToString("yyyyMMdd");
            drCustomerBooking["Deposit_Paid"] = 1;
            drCustomerBooking["Number_Of_People"] = cbbNumberOfPeople.Text;
            drCustomerBooking["Electric"] = cbxElectric.CheckState == CheckState.Checked ? 1 : 0;
            drCustomerBooking["Water"] = cbxWater.CheckState == CheckState.Checked ? 1 : 0;
            drCustomerBooking["Checked_In"] = 0;
            drCustomerBooking["Checked_Out"] = 0;
            drCustomerBooking["Booking_Paid"] = 0;

            drCustomerBooking.EndEdit();
            SqlCommandBuilder objCommandBuilder = new SqlCommandBuilder(daCustomerBooking);
            daCustomerBooking.Update(dsNorthCoast, "CustomerBooking");
            MessageBox.Show("Booking Updated");
            FillDataGrid(sqlAllBookings);
            pnlBookingUpdate.Visible = false;
            dgvBookings.Enabled = true;
        }

        private void dgvBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Create date to search database with for arrival and departure date
            DateTime dtpDate = Convert.ToDateTime(dtpSearch.Value);
            String dtpDateString = dtpDate.ToString("yyyy-MM-dd");

            //Search
            switch (cbxSearch.SelectedItem.ToString())
            {
                case "Customer ID":
                    //Search the rows in the column Accommodation_Type
                    FillDataGrid(SearchDataGridStatementCustomerBooking("CustomerID", txtSearch.Text));
                    break;
                case "Surname":
                    //Search the rows in the column Accommodation_Desc
                    FillDataGrid(SearchDataGridStatementCustomer("Surname", txtSearch.Text));
                    break;
                case "Forename":
                    //Search the rows in the column Accommodation_Size
                    FillDataGrid(SearchDataGridStatementCustomer("Forename", txtSearch.Text));
                    break;
                case "Location ID":
                    //Search the rows in the column Charge_Per_Day
                    FillDataGrid(SearchDataGridStatementCustomerBooking("LocationID", txtSearch.Text));
                    break;
                case "Accommodation Type":
                    //Search the rows in the column Accommodation_Type
                    FillDataGrid(SearchDataGridStatementAccommodation("Accommodation_Type", txtSearch.Text));
                    break;
                case "Arrival Date":
                    //Search the rows in the column Arrival_Date
                    FillDataGrid(SearchDataGridStatementCustomerBooking("Arrival_Date", dtpDateString));
                    break;
                case "Departure Date":
                    //Search the rows in the column Departure_Date
                    FillDataGrid(SearchDataGridStatementCustomerBooking("Departure_Date", dtpDateString));
                    break;
                default:
                    //Show all rows in the datagrid
                    FillDataGrid(sqlAllBookings);
                    break;
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            //Show all rows in the datagrid
            FillDataGrid(sqlAllBookings);
        }

        private void cbxSearch_TextChanged(object sender, EventArgs e)
        {
            switch (cbxSearch.SelectedItem.ToString())
            {
                case "Arrival Date":
                    //Show date selector instead of textbox
                    txtSearch.Visible = false;
                    dtpSearch.Visible = true;
                    break;
                case "Departure Date":
                    //Show date selector instead of textbox
                    txtSearch.Visible = false;
                    dtpSearch.Visible = true;
                    break;
                default:
                    //Show textbox instead of date selector
                    txtSearch.Visible = true;
                    dtpSearch.Visible = false;
                    break;
            }
        }
    }
}
