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
    public partial class Report : Form
    {
        //Delcare Variables
        SqlDataAdapter daAccommodation, daCustomerBooking;
        DataSet dsNorthCoast = new DataSet();
        SqlCommandBuilder cmdBAccommodation, cmdBCustomerBooking;
        String cnstr, sqlBookings, sqlCheckIn, sqlCheckOut, sqlWeeklyService;

        public Report()
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

        private void Report_Load(object sender, EventArgs e)
        {
            // connect to database and create dataset and table to hold customer details
            // Use Properties to hold value for maintenance
            cnstr = Properties.Resources.connectStr;

            //Select all accommodations from the table Accomodation that need serviced
            sqlWeeklyService = @"SELECT * FROM Accommodation WHERE Needs_Serviced = 1";
            daAccommodation = new SqlDataAdapter(sqlWeeklyService, cnstr);
            cmdBAccommodation = new SqlCommandBuilder(daAccommodation);
            daAccommodation.FillSchema(dsNorthCoast, SchemaType.Source, "Accommodation");
            daAccommodation.Fill(dsNorthCoast, "Accommodation");

            //Select all Bookings from the table CustomerBooking that are checking in or checking out that day.
            sqlBookings = @"SELECT * FROM CustomerBooking";
            daCustomerBooking = new SqlDataAdapter(sqlBookings, cnstr);
            cmdBCustomerBooking = new SqlCommandBuilder(daCustomerBooking);
            daCustomerBooking.FillSchema(dsNorthCoast, SchemaType.Source, "CustomerBooking");
            daCustomerBooking.Fill(dsNorthCoast, "CustomerBooking");
        }

        private void btnServiceInvoice_Click(object sender, EventArgs e)
        {
            //Selecting and outputting selected Accommodation Types to user
            SqlConnection sqlConnection = new SqlConnection(cnstr);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlWeeklyService, sqlConnection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dgvReport.ReadOnly = true;
            dgvReport.DataSource = ds.Tables[0];

            //AutoSize all columns
            dgvReport.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReport.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReport.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReport.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnCheckInInvoice_Click(object sender, EventArgs e)
        {
            sqlCheckIn = "SELECT CustomerID, LocationID, Arrival_Date, Departure_Date, Deposit_Paid, Booking_Paid, Checked_In, Checked_Out FROM CustomerBooking WHERE Arrival_Date = '" + DateTime.Today.Date.ToString("yyMMdd") + "'";
            //Selecting and outputting selected Accommodation Types to user
            SqlConnection sqlConnection = new SqlConnection(cnstr);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCheckIn, sqlConnection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dgvReport.ReadOnly = true;
            dgvReport.DataSource = ds.Tables[0];

            //AutoSize all columns
            dgvReport.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReport.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReport.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReport.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReport.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReport.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReport.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReport.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnCheckOutInvoice_Click(object sender, EventArgs e)
        {
            sqlCheckOut = "SELECT CustomerID, LocationID, Arrival_Date, Departure_Date, Deposit_Paid, Booking_Paid, Checked_In, Checked_Out FROM CustomerBooking WHERE Departure_Date = '" + DateTime.Today.Date.ToString("yyMMdd") + "'";
            //Selecting and outputting selected Accommodation Types to user
            SqlConnection sqlConnection = new SqlConnection(cnstr);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCheckOut, sqlConnection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dgvReport.ReadOnly = true;
            dgvReport.DataSource = ds.Tables[0];

            //AutoSize all columns
            dgvReport.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReport.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReport.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReport.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReport.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReport.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReport.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReport.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
