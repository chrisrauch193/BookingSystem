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
    public partial class AccommodationEdit : Form
    {
        //Delcare Variables
        SqlDataAdapter daAccommodationType, daAccommodation;
        DataSet dsNorthCoast = new DataSet();
        SqlCommandBuilder cmdBAccommodationType, cmdBAccommodation;
        DataRow drAccommodation;
        String cnstr, sqlAccommodationType, sqlAccommodation, sqlDataGrid, originalKey;

        public AccommodationEdit()
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

        private void AccommodationDelete_Load(object sender, EventArgs e)
        {
            SetupDataset();
        }

        private void SetupDataset()
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

            //Select all from the table AccommodationType
            sqlAccommodationType = @"select * from AccommodationType";
            daAccommodationType = new SqlDataAdapter(sqlAccommodationType, cnstr);
            cmdBAccommodationType = new SqlCommandBuilder(daAccommodationType);
            daAccommodationType.FillSchema(dsNorthCoast, SchemaType.Source, "AccommodationType");
            daAccommodationType.Fill(dsNorthCoast, "AccommodationType");

            FillDataGrid("SELECT * from Accommodation");

            //AutoSize all columns
            dgvAccommodation.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvAccommodation.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvAccommodation.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvAccommodation.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void FillDataGrid(String sqlStatement)
        {
            //Selecting and outputting selected Accommodation Types to user
            SqlConnection sqlConnection = new SqlConnection(cnstr);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlStatement, sqlConnection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dgvAccommodation.ReadOnly = true;
            dgvAccommodation.DataSource = ds.Tables[0];
        }

        private string SearchDataGridStatement(String column, String search)
        {
            //Selecting sql to display in the datagrid
            sqlDataGrid = @"SELECT * from Accommodation WHERE " + column + " LIKE'%" + search + "%'";
            return sqlDataGrid;
        }

        private void dgvAccommodation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvAccommodation.Rows[e.RowIndex];
                    txtAccommodationID.Text = row.Cells["AccommodationID"].Value.ToString();
                    originalKey = row.Cells["AccommodationID"].Value.ToString();
                    cbbAccommodationType.SelectedItem = row.Cells["Accommodation_Type"].Value.ToString();
                    cbxNeedsServiced.Checked = Convert.ToBoolean(row.Cells["Needs_Serviced"].Value.ToString());
                    txtNotes.Text = row.Cells["Notes"].Value.ToString();
                    pnlButtons.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Please Select an Accommodation Type");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                drAccommodation = dsNorthCoast.Tables["Accommodation"].Rows.Find(originalKey);
                drAccommodation.Delete();
                daAccommodation.Update(dsNorthCoast, "Accommodation");
                MessageBox.Show("Accommodation Deleted");
                FillDataGrid("SELECT * from Accommodation");
                pnlAccommodaitonEdit.Enabled = false;
                pnlButtons.Enabled = false;
            }
            catch (SqlException)
            {
                MessageBox.Show("This accommodation is on a location currently, please update location accommodation to 0000 before trying to delete this accommodation.");
                SetupDataset();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btnBack.Visible = true;
            btnConfirm.Visible = true;
            dgvAccommodation.Enabled = false;
            pnlAccommodaitonEdit.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = true;
            btnUpdate.Visible = true;
            btnBack.Visible = false;
            btnConfirm.Visible = false;
            dgvAccommodation.Enabled = true;
            pnlAccommodaitonEdit.Enabled = false;
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
                    drAccommodation = dsNorthCoast.Tables["Accommodation"].Rows.Find(originalKey);

                    drAccommodation.BeginEdit();

                    drAccommodation["AccommodationID"] = txtAccommodationID.Text.Trim();
                    drAccommodation["Accommodation_Type"] = cbbAccommodationType.SelectedItem.ToString().Trim();
                    drAccommodation["Needs_Serviced"] = cbxNeedsServiced.CheckState == CheckState.Checked ? 1 : 0;
                    drAccommodation["Notes"] = txtNotes.Text.Trim();

                    drAccommodation.EndEdit();
                    SqlCommandBuilder objCommandBuilder = new SqlCommandBuilder(daAccommodation);
                    daAccommodation.Update(dsNorthCoast, "Accommodation");
                    MessageBox.Show("Accommodation Updated");
                    FillDataGrid("SELECT * from Accommodation");

                    btnDelete.Visible = true;
                    btnUpdate.Visible = true;
                    btnBack.Visible = false;
                    btnConfirm.Visible = false;
                    dgvAccommodation.Enabled = true;
                    pnlAccommodaitonEdit.Enabled = false;
                    pnlButtons.Enabled = false;
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show(sqlEx.Message);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (cbxSearch.SelectedItem.ToString())
            {
                case "Accommodation ID":
                    //Search the rows in the column Accommodation_Type
                    FillDataGrid(SearchDataGridStatement("AccommodationID", txtSearch.Text));
                    break;
                case "Accommodation Type":
                    //Search the rows in the column Accommodation_Desc
                    FillDataGrid(SearchDataGridStatement("Accommodation_Type", txtSearch.Text));
                    break;
                case "Needs Serviced":
                    //Search the rows in the column Accommodation_Size
                    FillDataGrid(SearchDataGridStatement("Needs_Serviced", txtSearch.Text));
                    break;
                case "Notes":
                    //Search the rows in the column Charge_Per_Day
                    FillDataGrid(SearchDataGridStatement("Notes", txtSearch.Text));
                    break;
                default:
                    //Show all rows in the datagrid
                    FillDataGrid(@"SELECT * from Accommodation");
                    break;
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            FillDataGrid(@"SELECT * from Accommodation");
        }
    }
}
