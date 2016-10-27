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
    public partial class CustomerDelete : Form
    {
        //Delcare Variables
        SqlDataAdapter daCustomer, daCustomerBooking, daCustomerDel;
        DataSet dsNorthCoast = new DataSet();
        SqlCommandBuilder cmdBCustomer, cmdBCustomerBooking, cmdCustomerDel;
        DataRow drCustomer, drCustomerBooking, drCustomerDel;
        String cnstr, sqlCustomer, sqlCustomerBooking, sqlCustomerDel;
        private System.Windows.Forms.Button[] btnArray; 
        String[] letterGrid = new String[26];
        Boolean[] randomSelected = new Boolean[100];
        Boolean[] letterSelected = new Boolean[100];
        char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        public CustomerDelete()
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

        private void CustomerDelete_Load(object sender, EventArgs e)
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

            lsvCustomer.View = View.Details;
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
                lsvCustomer.Items.Add(item);
            }
            AddButtons();
        }

        private void AddButtons()
        {
            ///<summary>
            ///Adds the letter buttons to the letter grid for each question
            ///</summary>
            int letterGridSize = 26;

            int xPos = 0;
            int yPos = 0;
            //assign number of buttons = 26
            btnArray = new System.Windows.Forms.Button[26];
            for (int i = 0; i < 26; i++)
            {

                letterSelected[i] = false;
            }

            //Adding 12 Buttons to letter Grid
            for (int n = 0; n < letterGridSize; n++)
            {
                //Initialize one variable
                btnArray[n] = new System.Windows.Forms.Button();

                btnArray[n].Tag = n + 1; //Tag of button
                btnArray[n].Width = 25; //Width of button
                btnArray[n].Height = 25; //Height of button

                //Editing Properties
                btnArray[n].BackColor = Color.FromArgb(128, 255, 255);
                btnArray[n].FlatStyle = FlatStyle.Flat;
                btnArray[n].FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
                btnArray[n].FlatAppearance.BorderSize = 2;
                btnArray[n].FlatAppearance.BorderColor = Color.Blue;


                if (n == 13) //Location of second line of buttons:
                {
                    xPos = 0;
                    yPos = 20;
                }
                //Location of button
                btnArray[n].Left = xPos;
                btnArray[n].Top = yPos;
                //Add buttons to Panel
                pnlLetters.Controls.Add(btnArray[n]); //Let panel hold the buttons
                xPos = xPos + btnArray[n].Width; //Left of the next button

                //Convert the generated random number into a random letter for the letter grid
                btnArray[n].Text = alphabet[n].ToString();

                //Allow Drag and Drop
                btnArray[n].Click += new EventHandler(button_Click);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            using (SqlConnection c = new SqlConnection(cnstr))
            {
                c.Open();
                // use a SqlAdapter to execute the query
                using (SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM Customer WHERE Surname LIKE'" + btn.Text + "%'", c))
                {
                    // fill a data table
                    var t = new DataTable();
                    a.Fill(t);

                    // Bind the table to the list box
                    lbxCustomer.DisplayMember = "Surname";
                    lbxCustomer.ValueMember = "CustomerID";
                    lbxCustomer.DataSource = t;
                }
            }
        }

        private void lbxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection c = new SqlConnection(cnstr))
            {
                c.Open();
                // use a SqlAdapter to execute the query
                using (SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM CustomerBooking WHERE CustomerID LIKE'" + lbxCustomer.SelectedValue.ToString() + "%'", c))
                {
                    // fill a data table
                    var t = new DataTable();
                    a.Fill(t);

                    // Bind the table to the list box
                    lbxCustomerBooking.DisplayMember = "LocationID";
                    lbxCustomerBooking.ValueMember = "LocationID";
                    lbxCustomerBooking.DataSource = t;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            pnlConfirmDelete.Visible = true;
            //Check if customer has any bookings
            if (lbxCustomerBooking.Items.Count > 0)
            {
                btnDeleteBookings.Visible = true;
                btnConfirmNoBookings.Visible = false;
                lblConfirmDelete.Text = "This Customer has bookings, these bookings\ncannot be refunded if within six weeks\nAre you sure you want to delete this Customer?";
            }
            else
            {
                btnDeleteBookings.Visible = false;
                btnConfirmNoBookings.Visible = true;
                lblConfirmDelete.Text = "Are you sure you want to delete this Customer?";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            pnlConfirmDelete.Visible = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                drCustomer = dsNorthCoast.Tables["Customer"].Rows.Find(lbxCustomer.SelectedValue);
                drCustomer.Delete();
                daCustomer.Update(dsNorthCoast, "Customer");
                MessageBox.Show("Customer Deleted");
                btnDelete.Enabled = true;
                pnlConfirmDelete.Visible = false;
            }
            catch (System.Data.ConstraintException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void btnDeleteBookings_Click(object sender, EventArgs e)
        {
            try
            {
                //Delete all customer bookings and then the customer
                String customerID = lbxCustomer.SelectedValue.ToString().Trim();
                SqlConnection con = new SqlConnection(cnstr);
                con.Open();

                string sql = @"DELETE a FROM CustomerBooking a JOIN Customer b ON a.CustomerID = b.CustomerID AND a.CustomerID = '" + customerID + "' DELETE FROM Customer WHERE CustomerID = '" + customerID + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Customer and their booking deleted");
                btnDelete.Enabled = true;
                pnlConfirmDelete.Visible = false;
            }
            catch (System.Data.ConstraintException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
        }
    }
}
