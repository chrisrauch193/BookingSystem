namespace NorthCoast
{
    partial class LocationEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvLocation = new System.Windows.Forms.DataGridView();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pnlLocationEdit = new System.Windows.Forms.Panel();
            this.cbxSeaView = new System.Windows.Forms.CheckBox();
            this.txtLocationID = new System.Windows.Forms.MaskedTextBox();
            this.cbbAccommodationID = new System.Windows.Forms.ComboBox();
            this.lblAccommodationID = new System.Windows.Forms.Label();
            this.cbxDisabledAccess = new System.Windows.Forms.CheckBox();
            this.lblLocationID = new System.Windows.Forms.Label();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlConfirmDelete = new System.Windows.Forms.Panel();
            this.btnConfirmCascade = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblConfirmDelete = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbxSearch = new System.Windows.Forms.ComboBox();
            this.mnsNorthCoast = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.northCoastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accommodationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAccommodationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAccommodationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editLocationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accommodationTypeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busToursToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.workInProgressToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.bikeHireToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.workInProgressToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.equipmentHireToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.workInProgressToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocation)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.pnlLocationEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.pnlConfirmDelete.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.mnsNorthCoast.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLocation
            // 
            this.dgvLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocation.Location = new System.Drawing.Point(12, 37);
            this.dgvLocation.Name = "dgvLocation";
            this.dgvLocation.Size = new System.Drawing.Size(453, 345);
            this.dgvLocation.TabIndex = 48;
            this.dgvLocation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccommodation_CellClick);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnBack);
            this.pnlButtons.Controls.Add(this.btnConfirm);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnUpdate);
            this.pnlButtons.Enabled = false;
            this.pnlButtons.Location = new System.Drawing.Point(481, 351);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(236, 31);
            this.pnlButtons.TabIndex = 50;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(17, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 55;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnConfirm.FlatAppearance.BorderSize = 2;
            this.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Location = new System.Drawing.Point(143, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 54;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(143, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(17, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlLocationEdit
            // 
            this.pnlLocationEdit.Controls.Add(this.cbxSeaView);
            this.pnlLocationEdit.Controls.Add(this.txtLocationID);
            this.pnlLocationEdit.Controls.Add(this.cbbAccommodationID);
            this.pnlLocationEdit.Controls.Add(this.lblAccommodationID);
            this.pnlLocationEdit.Controls.Add(this.cbxDisabledAccess);
            this.pnlLocationEdit.Controls.Add(this.lblLocationID);
            this.pnlLocationEdit.Enabled = false;
            this.pnlLocationEdit.Location = new System.Drawing.Point(481, 100);
            this.pnlLocationEdit.Name = "pnlLocationEdit";
            this.pnlLocationEdit.Size = new System.Drawing.Size(236, 245);
            this.pnlLocationEdit.TabIndex = 49;
            // 
            // cbxSeaView
            // 
            this.cbxSeaView.AutoSize = true;
            this.cbxSeaView.Location = new System.Drawing.Point(33, 158);
            this.cbxSeaView.Name = "cbxSeaView";
            this.cbxSeaView.Size = new System.Drawing.Size(71, 17);
            this.cbxSeaView.TabIndex = 62;
            this.cbxSeaView.Text = "Sea View";
            this.cbxSeaView.UseVisualStyleBackColor = true;
            // 
            // txtLocationID
            // 
            this.txtLocationID.ForeColor = System.Drawing.Color.Red;
            this.txtLocationID.Location = new System.Drawing.Point(180, 27);
            this.txtLocationID.Mask = ">L000";
            this.txtLocationID.Name = "txtLocationID";
            this.txtLocationID.Size = new System.Drawing.Size(29, 20);
            this.txtLocationID.TabIndex = 61;
            // 
            // cbbAccommodationID
            // 
            this.cbbAccommodationID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAccommodationID.ForeColor = System.Drawing.Color.Red;
            this.cbbAccommodationID.FormattingEnabled = true;
            this.cbbAccommodationID.Items.AddRange(new object[] {
            "0000"});
            this.cbbAccommodationID.Location = new System.Drawing.Point(143, 68);
            this.cbbAccommodationID.Name = "cbbAccommodationID";
            this.cbbAccommodationID.Size = new System.Drawing.Size(64, 21);
            this.cbbAccommodationID.TabIndex = 60;
            // 
            // lblAccommodationID
            // 
            this.lblAccommodationID.AutoSize = true;
            this.lblAccommodationID.Location = new System.Drawing.Point(27, 68);
            this.lblAccommodationID.Name = "lblAccommodationID";
            this.lblAccommodationID.Size = new System.Drawing.Size(97, 26);
            this.lblAccommodationID.TabIndex = 59;
            this.lblAccommodationID.Text = "Accommodation ID\r\n(Null = 0000)";
            // 
            // cbxDisabledAccess
            // 
            this.cbxDisabledAccess.AutoSize = true;
            this.cbxDisabledAccess.Location = new System.Drawing.Point(33, 119);
            this.cbxDisabledAccess.Name = "cbxDisabledAccess";
            this.cbxDisabledAccess.Size = new System.Drawing.Size(105, 17);
            this.cbxDisabledAccess.TabIndex = 58;
            this.cbxDisabledAccess.Text = "Disabled Access";
            this.cbxDisabledAccess.UseVisualStyleBackColor = true;
            // 
            // lblLocationID
            // 
            this.lblLocationID.AutoSize = true;
            this.lblLocationID.Location = new System.Drawing.Point(30, 30);
            this.lblLocationID.Name = "lblLocationID";
            this.lblLocationID.Size = new System.Drawing.Size(62, 13);
            this.lblLocationID.TabIndex = 57;
            this.lblLocationID.Text = "Location ID";
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // pnlConfirmDelete
            // 
            this.pnlConfirmDelete.Controls.Add(this.btnConfirmCascade);
            this.pnlConfirmDelete.Controls.Add(this.btnCancel);
            this.pnlConfirmDelete.Controls.Add(this.lblConfirmDelete);
            this.pnlConfirmDelete.Location = new System.Drawing.Point(237, 157);
            this.pnlConfirmDelete.Name = "pnlConfirmDelete";
            this.pnlConfirmDelete.Size = new System.Drawing.Size(248, 100);
            this.pnlConfirmDelete.TabIndex = 51;
            this.pnlConfirmDelete.Visible = false;
            // 
            // btnConfirmCascade
            // 
            this.btnConfirmCascade.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnConfirmCascade.FlatAppearance.BorderSize = 2;
            this.btnConfirmCascade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirmCascade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmCascade.Location = new System.Drawing.Point(170, 59);
            this.btnConfirmCascade.Name = "btnConfirmCascade";
            this.btnConfirmCascade.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmCascade.TabIndex = 3;
            this.btnConfirmCascade.Text = "Confirm";
            this.btnConfirmCascade.UseVisualStyleBackColor = true;
            this.btnConfirmCascade.Click += new System.EventHandler(this.btnConfirmCascade_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(3, 59);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblConfirmDelete
            // 
            this.lblConfirmDelete.AutoSize = true;
            this.lblConfirmDelete.Location = new System.Drawing.Point(3, 10);
            this.lblConfirmDelete.Name = "lblConfirmDelete";
            this.lblConfirmDelete.Size = new System.Drawing.Size(242, 39);
            this.lblConfirmDelete.TabIndex = 0;
            this.lblConfirmDelete.Text = "This Location is being used in the bookings, if you\r\ncontinue with the delete the" +
    " bookings will also be \r\ndeleted with no refund. Are you sure?";
            this.lblConfirmDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.btnAll);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.cbxSearch);
            this.pnlSearch.Location = new System.Drawing.Point(481, 37);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(236, 57);
            this.pnlSearch.TabIndex = 52;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSearch.FlatAppearance.BorderSize = 2;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(161, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(57, 23);
            this.btnSearch.TabIndex = 57;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAll
            // 
            this.btnAll.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnAll.FlatAppearance.BorderSize = 2;
            this.btnAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Location = new System.Drawing.Point(161, 3);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(57, 23);
            this.btnAll.TabIndex = 56;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.Color.Red;
            this.txtSearch.Location = new System.Drawing.Point(17, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(138, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // cbxSearch
            // 
            this.cbxSearch.ForeColor = System.Drawing.Color.Red;
            this.cbxSearch.FormattingEnabled = true;
            this.cbxSearch.Items.AddRange(new object[] {
            "Location ID",
            "Accommodation ID",
            "Disabled Access",
            "Sea View"});
            this.cbxSearch.Location = new System.Drawing.Point(17, 3);
            this.cbxSearch.Name = "cbxSearch";
            this.cbxSearch.Size = new System.Drawing.Size(141, 21);
            this.cbxSearch.TabIndex = 0;
            this.cbxSearch.Text = "Location ID";
            // 
            // mnsNorthCoast
            // 
            this.mnsNorthCoast.BackColor = System.Drawing.Color.Aqua;
            this.mnsNorthCoast.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.northCoastToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnsNorthCoast.Location = new System.Drawing.Point(0, 0);
            this.mnsNorthCoast.Name = "mnsNorthCoast";
            this.mnsNorthCoast.Size = new System.Drawing.Size(729, 24);
            this.mnsNorthCoast.TabIndex = 53;
            this.mnsNorthCoast.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // mainMenuToolStripMenuItem1
            // 
            this.mainMenuToolStripMenuItem1.Name = "mainMenuToolStripMenuItem1";
            this.mainMenuToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.mainMenuToolStripMenuItem1.Text = "Main Menu";
            this.mainMenuToolStripMenuItem1.Click += new System.EventHandler(this.mainMenuToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // northCoastToolStripMenuItem
            // 
            this.northCoastToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookingsToolStripMenuItem,
            this.busToursToolStripMenuItem1,
            this.bikeHireToolStripMenuItem1,
            this.equipmentHireToolStripMenuItem1});
            this.northCoastToolStripMenuItem.Name = "northCoastToolStripMenuItem";
            this.northCoastToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.northCoastToolStripMenuItem.Text = "North Coast";
            // 
            // bookingsToolStripMenuItem
            // 
            this.bookingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.bookingToolStripMenuItem1,
            this.accommodationToolStripMenuItem,
            this.locationToolStripMenuItem1,
            this.accommodationTypeToolStripMenuItem1,
            this.reportToolStripMenuItem});
            this.bookingsToolStripMenuItem.Name = "bookingsToolStripMenuItem";
            this.bookingsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.bookingsToolStripMenuItem.Text = "Bookings";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem,
            this.deleteCustomerToolStripMenuItem,
            this.updateCustomerToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // deleteCustomerToolStripMenuItem
            // 
            this.deleteCustomerToolStripMenuItem.Name = "deleteCustomerToolStripMenuItem";
            this.deleteCustomerToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.deleteCustomerToolStripMenuItem.Text = "Delete Customer";
            this.deleteCustomerToolStripMenuItem.Click += new System.EventHandler(this.deleteCustomerToolStripMenuItem_Click);
            // 
            // updateCustomerToolStripMenuItem
            // 
            this.updateCustomerToolStripMenuItem.Name = "updateCustomerToolStripMenuItem";
            this.updateCustomerToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.updateCustomerToolStripMenuItem.Text = "Update Customer";
            this.updateCustomerToolStripMenuItem.Click += new System.EventHandler(this.updateCustomerToolStripMenuItem_Click);
            // 
            // bookingToolStripMenuItem1
            // 
            this.bookingToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookingToolStripMenuItem,
            this.editBookingsToolStripMenuItem});
            this.bookingToolStripMenuItem1.Name = "bookingToolStripMenuItem1";
            this.bookingToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.bookingToolStripMenuItem1.Text = "Booking";
            // 
            // addBookingToolStripMenuItem
            // 
            this.addBookingToolStripMenuItem.Name = "addBookingToolStripMenuItem";
            this.addBookingToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.addBookingToolStripMenuItem.Text = "Add Booking";
            this.addBookingToolStripMenuItem.Click += new System.EventHandler(this.addBookingToolStripMenuItem_Click);
            // 
            // editBookingsToolStripMenuItem
            // 
            this.editBookingsToolStripMenuItem.Name = "editBookingsToolStripMenuItem";
            this.editBookingsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.editBookingsToolStripMenuItem.Text = "Edit Bookings";
            this.editBookingsToolStripMenuItem.Click += new System.EventHandler(this.editBookingsToolStripMenuItem_Click);
            // 
            // accommodationToolStripMenuItem
            // 
            this.accommodationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAccommodationToolStripMenuItem,
            this.editAccommodationsToolStripMenuItem});
            this.accommodationToolStripMenuItem.Name = "accommodationToolStripMenuItem";
            this.accommodationToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.accommodationToolStripMenuItem.Text = "Accommodation";
            // 
            // addAccommodationToolStripMenuItem
            // 
            this.addAccommodationToolStripMenuItem.Name = "addAccommodationToolStripMenuItem";
            this.addAccommodationToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.addAccommodationToolStripMenuItem.Text = "Add Accommodation";
            this.addAccommodationToolStripMenuItem.Click += new System.EventHandler(this.addAccommodationToolStripMenuItem_Click);
            // 
            // editAccommodationsToolStripMenuItem
            // 
            this.editAccommodationsToolStripMenuItem.Name = "editAccommodationsToolStripMenuItem";
            this.editAccommodationsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.editAccommodationsToolStripMenuItem.Text = "Edit Accommodations";
            this.editAccommodationsToolStripMenuItem.Click += new System.EventHandler(this.editAccommodationsToolStripMenuItem_Click);
            // 
            // locationToolStripMenuItem1
            // 
            this.locationToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLocationToolStripMenuItem,
            this.editLocationsToolStripMenuItem});
            this.locationToolStripMenuItem1.Name = "locationToolStripMenuItem1";
            this.locationToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.locationToolStripMenuItem1.Text = "Location";
            // 
            // addLocationToolStripMenuItem
            // 
            this.addLocationToolStripMenuItem.Name = "addLocationToolStripMenuItem";
            this.addLocationToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.addLocationToolStripMenuItem.Text = "Add Location";
            this.addLocationToolStripMenuItem.Click += new System.EventHandler(this.addLocationToolStripMenuItem_Click);
            // 
            // editLocationsToolStripMenuItem
            // 
            this.editLocationsToolStripMenuItem.Name = "editLocationsToolStripMenuItem";
            this.editLocationsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.editLocationsToolStripMenuItem.Text = "Edit Locations";
            this.editLocationsToolStripMenuItem.Click += new System.EventHandler(this.editLocationsToolStripMenuItem_Click);
            // 
            // accommodationTypeToolStripMenuItem1
            // 
            this.accommodationTypeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTypeToolStripMenuItem,
            this.editTypesToolStripMenuItem});
            this.accommodationTypeToolStripMenuItem1.Name = "accommodationTypeToolStripMenuItem1";
            this.accommodationTypeToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.accommodationTypeToolStripMenuItem1.Text = "AccommodationType";
            // 
            // addTypeToolStripMenuItem
            // 
            this.addTypeToolStripMenuItem.Name = "addTypeToolStripMenuItem";
            this.addTypeToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.addTypeToolStripMenuItem.Text = "Add Type";
            this.addTypeToolStripMenuItem.Click += new System.EventHandler(this.addTypeToolStripMenuItem_Click);
            // 
            // editTypesToolStripMenuItem
            // 
            this.editTypesToolStripMenuItem.Name = "editTypesToolStripMenuItem";
            this.editTypesToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.editTypesToolStripMenuItem.Text = "Edit Types";
            this.editTypesToolStripMenuItem.Click += new System.EventHandler(this.editTypesToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // busToursToolStripMenuItem1
            // 
            this.busToursToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workInProgressToolStripMenuItem3});
            this.busToursToolStripMenuItem1.Name = "busToursToolStripMenuItem1";
            this.busToursToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.busToursToolStripMenuItem1.Text = "Bus Tours";
            // 
            // workInProgressToolStripMenuItem3
            // 
            this.workInProgressToolStripMenuItem3.Name = "workInProgressToolStripMenuItem3";
            this.workInProgressToolStripMenuItem3.Size = new System.Drawing.Size(163, 22);
            this.workInProgressToolStripMenuItem3.Text = "Work in Progress";
            // 
            // bikeHireToolStripMenuItem1
            // 
            this.bikeHireToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workInProgressToolStripMenuItem4});
            this.bikeHireToolStripMenuItem1.Name = "bikeHireToolStripMenuItem1";
            this.bikeHireToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.bikeHireToolStripMenuItem1.Text = "Bike Hire";
            // 
            // workInProgressToolStripMenuItem4
            // 
            this.workInProgressToolStripMenuItem4.Name = "workInProgressToolStripMenuItem4";
            this.workInProgressToolStripMenuItem4.Size = new System.Drawing.Size(163, 22);
            this.workInProgressToolStripMenuItem4.Text = "Work in Progress";
            // 
            // equipmentHireToolStripMenuItem1
            // 
            this.equipmentHireToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workInProgressToolStripMenuItem5});
            this.equipmentHireToolStripMenuItem1.Name = "equipmentHireToolStripMenuItem1";
            this.equipmentHireToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.equipmentHireToolStripMenuItem1.Text = "Equipment Hire";
            // 
            // workInProgressToolStripMenuItem5
            // 
            this.workInProgressToolStripMenuItem5.Name = "workInProgressToolStripMenuItem5";
            this.workInProgressToolStripMenuItem5.Size = new System.Drawing.Size(163, 22);
            this.workInProgressToolStripMenuItem5.Text = "Work in Progress";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // LocationEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(729, 392);
            this.Controls.Add(this.mnsNorthCoast);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlConfirmDelete);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlLocationEdit);
            this.Controls.Add(this.dgvLocation);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "LocationEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Location Delete";
            this.Load += new System.EventHandler(this.LocationDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocation)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.pnlLocationEdit.ResumeLayout(false);
            this.pnlLocationEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.pnlConfirmDelete.ResumeLayout(false);
            this.pnlConfirmDelete.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.mnsNorthCoast.ResumeLayout(false);
            this.mnsNorthCoast.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLocation;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel pnlLocationEdit;
        private System.Windows.Forms.CheckBox cbxSeaView;
        private System.Windows.Forms.MaskedTextBox txtLocationID;
        private System.Windows.Forms.ComboBox cbbAccommodationID;
        private System.Windows.Forms.Label lblAccommodationID;
        private System.Windows.Forms.CheckBox cbxDisabledAccess;
        private System.Windows.Forms.Label lblLocationID;
        private System.Windows.Forms.ErrorProvider errP;
        private System.Windows.Forms.Panel pnlConfirmDelete;
        private System.Windows.Forms.Button btnConfirmCascade;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblConfirmDelete;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbxSearch;
        private System.Windows.Forms.MenuStrip mnsNorthCoast;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem northCoastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editBookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accommodationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAccommodationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAccommodationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editLocationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accommodationTypeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busToursToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem workInProgressToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem bikeHireToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem workInProgressToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem equipmentHireToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem workInProgressToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;

    }
}