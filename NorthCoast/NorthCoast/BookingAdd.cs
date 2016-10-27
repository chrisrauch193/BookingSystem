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
    public partial class BookingAdd : Form
    {
        //Declare Variables
        SqlDataAdapter daCustomer, daCustomerBooking, daLocation;
        DataSet dsNorthCoast = new DataSet();
        SqlCommandBuilder cmdBCustomer, cmdBCustomerBooking, cmdBLocation;
        DataRow drCustomer, drCustomerBooking, drLocation;
        String cnstr, sqlCustomer, sqlCustomerBooking, sqlLocation, sqlChargePerDay;
        int nextCustomerID;

        public BookingAdd()
        {
            InitializeComponent();
            //hold application name once in Properties and use on all forms
            this.Text = Properties.Resources.appStr;
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

        private void BookingCreation_Load(object sender, EventArgs e)
        {
            SetupDataset();
        }

        private void SetupDataset()
        {
            // disable  Add / AddAnother buttons
            btnAddAnother.Enabled = false;
            btnAdd.Enabled = true;

            dtpArrivalDate.MinDate = DateTime.Now.Date.AddDays(3);
            dtpArrivalDate.MaxDate = DateTime.Now.Date.AddMonths(6);
            dtpDOB.MaxDate = DateTime.Now.AddYears(-18);


            // connect to database and create dataset and table to hold customer details
            // Use Properties to hold value for maintenance
            cnstr = Properties.Resources.connectStr;
            //cnstr = @"Data Source = localhost\sqlexpress; Initial Catalog = North_Coast; Integrated Security = true";
            //cnstr = @"Data Source = localhost; Initial Catalog = North_Coast; Integrated Security = true";

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

            // Binding data to form control
            //Adding all customers to the customer listbox
            lbxCustomer.DataSource = dsNorthCoast.Tables["Customer"];
            lbxCustomer.DisplayMember = "Surname";
            lbxCustomer.ValueMember = "CustomerID";

            //CustomerBooking Code
            sqlCustomerBooking = @"select * from CustomerBooking";
            daCustomerBooking = new SqlDataAdapter(sqlCustomerBooking, cnstr);
            cmdBCustomerBooking = new SqlCommandBuilder(daCustomerBooking);
            daCustomerBooking.FillSchema(dsNorthCoast, SchemaType.Source, "CustomerBooking");
            daCustomerBooking.Fill(dsNorthCoast, "CustomerBooking");


            SqlConnection conn = new SqlConnection(cnstr);
            SqlDataAdapter ada = new SqlDataAdapter("select * from Customer order by CustomerID", conn);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem item = new ListViewItem(dr["CustomerID"].ToString());
                item.SubItems.Add(dr["Surname"].ToString());
                item.SubItems.Add(dr["Forename"].ToString());
                item.SubItems.Add(dr["AddressLine1"].ToString());
                item.SubItems.Add(dr["Date_Of_Birth"].ToString());
            }


            //Location Code
            sqlLocation = @"select * from Location";
            daLocation = new SqlDataAdapter(sqlLocation, cnstr);
            cmdBLocation = new SqlCommandBuilder(daLocation);
            daLocation.FillSchema(dsNorthCoast, SchemaType.Source, "Location");
            daLocation.Fill(dsNorthCoast, "Location");
        }

        //validation methods
        private bool validString(Control txt, int min, int max)
        {
            bool ok = true;
            TextBox txtB = (TextBox)txt;
            if (String.IsNullOrEmpty(txtB.Text))
            {
                ok = false;
                errP.SetError(txtB, " required field - must enter data");
            }
            else if (txtB.Text.Length < min || txtB.Text.Length > max)
            {
                ok = false;
                errP.SetError(txtB, " must have minimum of " + min + " chars and a maximum of " + max);
            }


            return ok;
        }

        private bool validLetters(Control txt)
        {
            bool ok = true;
            TextBox txtB = (TextBox)txt;
            for (int x = 0; x < txtB.Text.Length; x++)
            {   // if( txtB.Text[x])
                //  complete to check for letters  and possible embedded hyphen

            }
            return ok;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // simple add using validation method checking existence and min/max length
            // of a string ( used for surname, forename and street)
            // sets error provider against invalid field
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                //Calcualte total cost per day for the user
            
            sqlChargePerDay = @"SELECT Charge_Per_Day, AccommodationType.Accommodation_Type, Accommodation.Accommodation_Type, Accommodation.AccommodationID, Location.AccommodationID, LocationID FROM AccommodationType, Accommodation, Location WHERE AccommodationType.Accommodation_Type = Accommodation.Accommodation_Type AND Accommodation.AccommodationID = Location.AccommodationID AND LocationID = '" + lbxAccommodation_Type.SelectedValue + "'";
            SqlConnection con = new SqlConnection(cnstr);
            con.Open();
            SqlCommand command = new SqlCommand(sqlChargePerDay, con);
            txtChargePerDay.Text = command.ExecuteScalar().ToString();

            Decimal fivePercent = Convert.ToDecimal(Convert.ToDouble(txtChargePerDay.Text) * 0.05);
            Decimal tenPercent = Convert.ToDecimal(Convert.ToDouble(txtChargePerDay.Text) * 0.1);

            switch (dtpArrivalDate.Value.Month.ToString())
            {
                case "12":
                case "1":
                case "2":
                    //Cheapest dates of the year no additional cost
                    txtDateOfBookingC.Text = "0.00";
                    break;
                case "6":
                case "7":
                case "8":
                    //Most expensive dates of the year, plus 10%
                    txtDateOfBookingC.Text = string.Format("{0:0.00}", tenPercent);
                    break;
                default:
                    //All other dates are plus 5%
                    txtTwelveWeeksC.Text = string.Format("{0:0.00}", fivePercent);
                    break;
            }
            if (cbbNumberOfNights.SelectedItem == "Indefinite")
            {
                txtIndefiniteC.Text = txtTwelveWeeksC.Text = string.Format("{0:0.00}", fivePercent);
            }
            if ((dtpArrivalDate.Value.Date - DateTime.Now.Date).Days > 84)
            {
                txtTwelveWeeksC.Text = string.Format("{0:0.00}", fivePercent);
            }
            if (cbxElectric.Checked)
            {
                txtElectricC.Text = "5.00";
            }
            if (cbxWater.Checked)
            {
                txtWaterC.Text = "5.00";
            }
            Decimal finalChargePerDay = Convert.ToDecimal((Convert.ToDouble(txtChargePerDay.Text)) + (Convert.ToDouble(txtDateOfBookingC.Text)) + (Convert.ToDouble(txtIndefiniteC.Text)) - (Convert.ToDouble(txtTwelveWeeksC.Text)) + (Convert.ToDouble(txtElectricC.Text)) + (Convert.ToDouble(txtWaterC.Text)));
            txtFinalChargePerDay.Text = string.Format("{0:0.00}", finalChargePerDay);
            if (cbbNumberOfNights.SelectedItem == "Indefinite")
            {
                txtTotalCost.Text = "";
            }
            else
            {
                Decimal totalCost = finalChargePerDay * Convert.ToDecimal(cbbNumberOfNights.SelectedItem);
                txtTotalCost.Text = string.Format("{0:0.00}", totalCost);
            }

            lbxAccommodation_Type.Enabled = false;
            dtpArrivalDate.Enabled = false;
            cbbNumberOfNights.Enabled = false;
            cbbNumberOfPeople.Enabled = false;
            cbbAccommodationType.Enabled = false;
            cbxElectric.Enabled = false;
            cbxWater.Enabled = false;
            btnNext.Enabled = false;
            btnBack.Enabled = true;
            btnCustomerCreate.Enabled = true;
            btnCustomerSelect.Enabled = true;
            btnSearch.Enabled = false;
            btnFilter.Enabled = false;
            cbxSeaView.Enabled = false;
            cbxDisabledAccess.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            lbxAccommodation_Type.Enabled = true;
            dtpArrivalDate.Enabled = true;
            cbbNumberOfNights.Enabled = true;
            cbbNumberOfPeople.Enabled = true;
            cbbAccommodationType.Enabled = true;
            cbxElectric.Enabled = true;
            cbxWater.Enabled = true;
            btnNext.Enabled = true;
            btnBack.Enabled = false;
            btnCustomerCreate.Enabled = false;
            btnCustomerSelect.Enabled = false;
            btnSearch.Enabled = true;
            btnFilter.Enabled = true;
            cbxSeaView.Enabled = true;
            cbxDisabledAccess.Enabled = true;
            pnlCustomer.Visible = false;
        }

        private void btnCustomerCreate_Click(object sender, EventArgs e)
        {
            pnlCustomer.Visible = true;
            pnlCustomerCreate.Enabled = true;
            pnlCustomerSelect.Enabled = false;
        }

        private void btnCustomerSelect_Click(object sender, EventArgs e)
        {
            pnlCustomer.Visible = true;
            pnlCustomerCreate.Enabled = false;
            pnlCustomerSelect.Enabled = true;
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            errP.Clear();
            Boolean ok = true;

            //Inprogress

            CustomerBooking cB = new CustomerBooking();

            try
            {
                cB.CustomerID = int.Parse(lbxCustomer.SelectedValue.ToString());
            }
            catch (CustomerException ex)
            {
                ok = false;
                errP.SetError(lbxCustomer, ex.Message);
            }
            try
            {
                drLocation = dsNorthCoast.Tables["Location"].Rows.Find(lbxAccommodation_Type.SelectedValue);
                cB.LocationID = drLocation["LocationID"].ToString();
            }
            catch (Exception ex)
            {
                ok = false;
                if (ex is NullReferenceException)
                {
                    //spits out the errors if there are any
                    MessageBox.Show("Accommodation has not been selected");
                }
                else if (ex is CustomerException)
                {
                    errP.SetError(lbxAccommodation_Type, ex.Message);
                }
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
            try
            {
                cB.NoOfPeople = cbbNumberOfPeople.Text;
            }
            catch (CustomerException ex)
            {
                ok = false;
                errP.SetError(cbbNumberOfPeople, ex.Message);
            }


            if (ok)
            {
                try
                {
                    drCustomerBooking = dsNorthCoast.Tables["CustomerBooking"].NewRow();
                    drCustomer = dsNorthCoast.Tables["Customer"].Rows.Find(lbxCustomer.SelectedValue);

                    drCustomerBooking["CustomerID"] = drCustomer["CustomerID"].ToString();

                    drLocation = dsNorthCoast.Tables["Location"].Rows.Find(lbxAccommodation_Type.SelectedValue);
                    drCustomerBooking["LocationID"] = drLocation["LocationID"].ToString();

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

                    dsNorthCoast.Tables["CustomerBooking"].Rows.Add(drCustomerBooking);
                    daCustomerBooking.Update(dsNorthCoast, "CustomerBooking");

                    MessageBox.Show("Customer Booking Added");
                    btnBackToBooking.Enabled = false;
                    btnAddBooking.Enabled = false;
                    btnAddAnotherBooking.Enabled = true;
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show(sqlEx.Message);
                }
            }
        }

        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
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
                    btnNext.Enabled = true;
                }
            }
        }
        private void lbxAccommodation_Type_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            btnNext.Enabled = false;
        }

        private void cbxWater_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxElectric_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBackToBooking_Click(object sender, EventArgs e)
        {
            pnlCustomer.Visible = false;
        }

        private void btnAddAnotherBooking_Click(object sender, EventArgs e)
        {
            //bring user back to the start of the page
            pnlBooking.Visible = true;
            pnlCustomer.Visible = false;
            btnBackToBooking.Enabled = true;
            btnAddBooking.Enabled = true;
            btnAddAnotherBooking.Enabled = false;
            btnSearch.Enabled = true;
            btnFilter.Enabled = false;
            cbxElectric.Enabled = false;
            cbxWater.Enabled = false;
            cbxSeaView.Enabled = true;
            cbxDisabledAccess.Enabled = true;
            btnNext.Enabled = false;
            pnlCustomerMenu.Enabled = false;
            lbxAccommodation_Type.Enabled = true;
            dtpArrivalDate.Enabled = true;
            cbbNumberOfNights.Enabled = true;
            cbbNumberOfPeople.Enabled = true;
            cbbAccommodationType.Enabled = true;
            btnBack.Enabled = false;
        }
    }
}