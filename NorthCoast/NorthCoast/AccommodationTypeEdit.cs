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
    public partial class AccommodationTypeEdit : Form
    {
        //Delcare Variables
        SqlDataAdapter daAccommodationType;
        DataSet dsNorthCoast = new DataSet();
        SqlCommandBuilder cmdBAccommodationType;
        DataRow drAccommodationType;
        String cnstr, sqlAccommodationType, sqlDataGrid, originalKey;

        public AccommodationTypeEdit()
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

        private void AccommodationTypeDelete_Load(object sender, EventArgs e)
        {
            SetupDataset();
        }

        private void SetupDataset()
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

            //Selecting and outputting all Accommodation Types to user
            sqlDataGrid = @"SELECT * from AccommodationType";
            FillDataGrid(sqlDataGrid);

            //AutoSize all columns
            dgvAccommodationType.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvAccommodationType.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvAccommodationType.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvAccommodationType.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void FillDataGrid(String sqlStatement)
        {
            //Selecting and outputting selected Accommodation Types to user
            SqlConnection sqlConnection = new SqlConnection(cnstr);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlStatement, sqlConnection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dgvAccommodationType.ReadOnly = true;
            dgvAccommodationType.DataSource = ds.Tables[0];
        }

        private string SearchDataGridStatement(String column, String search)
        {
            //Selecting sql to display in the datagrid
            sqlDataGrid = @"SELECT * from AccommodationType WHERE " + column + " LIKE'%" + search + "%'";
            return sqlDataGrid;
        }

        private void dgvAccommodationType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvAccommodationType.Rows[e.RowIndex];
                    txtAccommodationType.Text = row.Cells["Accommodation_Type"].Value.ToString();
                    originalKey = row.Cells["Accommodation_Type"].Value.ToString();
                    txtAccommodationDesc.Text = row.Cells["Accommodation_Desc"].Value.ToString();
                    txtAccommodationSize.Text = row.Cells["Accommodation_Size"].Value.ToString();
                    txtChargePerDay.Text = row.Cells["Charge_Per_day"].Value.ToString();
                    pnlButtons.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Please Select an Accommodation Type");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btnBack.Visible = true;
            btnConfirm.Visible = true;
            dgvAccommodationType.Enabled = false;
            pnlAccommodaitonTypeEdit.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                drAccommodationType = dsNorthCoast.Tables["AccommodationType"].Rows.Find(originalKey);
                drAccommodationType.Delete();
                daAccommodationType.Update(dsNorthCoast, "AccommodationType");
                MessageBox.Show("Accommodation Type Deleted");
                FillDataGrid(@"SELECT * from AccommodationType");
                pnlAccommodaitonTypeEdit.Enabled = false;
                pnlButtons.Enabled = false;
            }
            catch (SqlException)
            {
                MessageBox.Show("This Accommodation Type is being used in Accommodations, please edit or remove all Accommodations using this Accommodation Type before deleting");
                SetupDataset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = true;
            btnUpdate.Visible = true;
            btnBack.Visible = false;
            btnConfirm.Visible = false;
            dgvAccommodationType.Enabled = true;
            pnlAccommodaitonTypeEdit.Enabled = false;
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
                    drAccommodationType = dsNorthCoast.Tables["AccommodationType"].Rows.Find(originalKey);

                    drAccommodationType.BeginEdit();

                    drAccommodationType["Accommodation_Type"] = txtAccommodationType.Text.Trim();
                    drAccommodationType["Accommodation_Desc"] = txtAccommodationDesc.Text.Trim();
                    drAccommodationType["Accommodation_Size"] = txtAccommodationSize.Text.Trim();
                    drAccommodationType["Charge_Per_Day"] = txtChargePerDay.Text.Substring(1, 6).Trim();

                    drAccommodationType.EndEdit();
                    SqlCommandBuilder objCommandBuilder = new SqlCommandBuilder(daAccommodationType);
                    daAccommodationType.Update(dsNorthCoast, "AccommodationType");
                    MessageBox.Show("Accommodation Type Updated");
                    FillDataGrid(@"SELECT * from AccommodationType");

                    btnDelete.Visible = true;
                    btnUpdate.Visible = true;
                    btnBack.Visible = false;
                    btnConfirm.Visible = false;
                    dgvAccommodationType.Enabled = true;
                    pnlAccommodaitonTypeEdit.Enabled = false;
                    pnlButtons.Enabled = false;
                }
                catch (System.Data.ConstraintException sqlEx)
                {
                    MessageBox.Show(sqlEx.Message);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (cbxSearch.SelectedItem.ToString())
            {
                case "Accommodation Type":
                    //Search the rows in the column Accommodation_Type
                    FillDataGrid(SearchDataGridStatement("Accommodation_Type", txtSearch.Text));
                    break;
                case "Accommodation Desc":
                    //Search the rows in the column Accommodation_Desc
                    FillDataGrid(SearchDataGridStatement("Accommodation_Desc", txtSearch.Text));
                    break;
                case "Accommodation Size":
                    //Search the rows in the column Accommodation_Size
                    FillDataGrid(SearchDataGridStatement("Accommodation_Size", txtSearch.Text));
                    break;
                case "Charge Per Day":
                    //Search the rows in the column Charge_Per_Day
                    FillDataGrid(SearchDataGridStatement("Charge_Per_Day", txtSearch.Text));
                    break;
                default:
                    //Show all rows in the datagrid
                    FillDataGrid(@"SELECT * from AccommodationType");
                    break;
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            //Show all rows in the datagrid
            FillDataGrid(@"SELECT * from AccommodationType");
        }
    }
}
