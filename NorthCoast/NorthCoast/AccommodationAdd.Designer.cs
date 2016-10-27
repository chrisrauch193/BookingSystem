namespace NorthCoast
{
    partial class AccommodationAdd
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
            this.pnlAccommodationCreate = new System.Windows.Forms.Panel();
            this.txtAccommodationID = new System.Windows.Forms.MaskedTextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.cbbAccommodationType = new System.Windows.Forms.ComboBox();
            this.lblAccommodationType = new System.Windows.Forms.Label();
            this.cbxNeedsServiced = new System.Windows.Forms.CheckBox();
            this.lblAccommodationID = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddAnother = new System.Windows.Forms.Button();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlAddButtons = new System.Windows.Forms.Panel();
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
            this.pnlAccommodationCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.pnlAddButtons.SuspendLayout();
            this.mnsNorthCoast.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAccommodationCreate
            // 
            this.pnlAccommodationCreate.Controls.Add(this.txtAccommodationID);
            this.pnlAccommodationCreate.Controls.Add(this.lblNotes);
            this.pnlAccommodationCreate.Controls.Add(this.txtNotes);
            this.pnlAccommodationCreate.Controls.Add(this.cbbAccommodationType);
            this.pnlAccommodationCreate.Controls.Add(this.lblAccommodationType);
            this.pnlAccommodationCreate.Controls.Add(this.cbxNeedsServiced);
            this.pnlAccommodationCreate.Controls.Add(this.lblAccommodationID);
            this.pnlAccommodationCreate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pnlAccommodationCreate.Location = new System.Drawing.Point(12, 27);
            this.pnlAccommodationCreate.Name = "pnlAccommodationCreate";
            this.pnlAccommodationCreate.Size = new System.Drawing.Size(232, 171);
            this.pnlAccommodationCreate.TabIndex = 36;
            // 
            // txtAccommodationID
            // 
            this.txtAccommodationID.ForeColor = System.Drawing.Color.Red;
            this.txtAccommodationID.Location = new System.Drawing.Point(172, 15);
            this.txtAccommodationID.Mask = ">LL00";
            this.txtAccommodationID.Name = "txtAccommodationID";
            this.txtAccommodationID.Size = new System.Drawing.Size(35, 20);
            this.txtAccommodationID.TabIndex = 41;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.ForeColor = System.Drawing.Color.Red;
            this.lblNotes.Location = new System.Drawing.Point(3, 88);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(35, 13);
            this.lblNotes.TabIndex = 40;
            this.lblNotes.Text = "Notes";
            // 
            // txtNotes
            // 
            this.txtNotes.ForeColor = System.Drawing.Color.Red;
            this.txtNotes.Location = new System.Drawing.Point(6, 104);
            this.txtNotes.MaxLength = 100;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(201, 60);
            this.txtNotes.TabIndex = 39;
            // 
            // cbbAccommodationType
            // 
            this.cbbAccommodationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAccommodationType.ForeColor = System.Drawing.Color.Red;
            this.cbbAccommodationType.FormattingEnabled = true;
            this.cbbAccommodationType.Location = new System.Drawing.Point(143, 41);
            this.cbbAccommodationType.Name = "cbbAccommodationType";
            this.cbbAccommodationType.Size = new System.Drawing.Size(64, 21);
            this.cbbAccommodationType.TabIndex = 38;
            // 
            // lblAccommodationType
            // 
            this.lblAccommodationType.AutoSize = true;
            this.lblAccommodationType.ForeColor = System.Drawing.Color.Red;
            this.lblAccommodationType.Location = new System.Drawing.Point(3, 44);
            this.lblAccommodationType.Name = "lblAccommodationType";
            this.lblAccommodationType.Size = new System.Drawing.Size(124, 13);
            this.lblAccommodationType.TabIndex = 37;
            this.lblAccommodationType.Text = "Accommodation Type ID";
            // 
            // cbxNeedsServiced
            // 
            this.cbxNeedsServiced.AutoSize = true;
            this.cbxNeedsServiced.ForeColor = System.Drawing.Color.Red;
            this.cbxNeedsServiced.Location = new System.Drawing.Point(6, 68);
            this.cbxNeedsServiced.Name = "cbxNeedsServiced";
            this.cbxNeedsServiced.Size = new System.Drawing.Size(108, 17);
            this.cbxNeedsServiced.TabIndex = 34;
            this.cbxNeedsServiced.Text = "Needs Serviced?";
            this.cbxNeedsServiced.UseVisualStyleBackColor = true;
            // 
            // lblAccommodationID
            // 
            this.lblAccommodationID.AutoSize = true;
            this.lblAccommodationID.ForeColor = System.Drawing.Color.Red;
            this.lblAccommodationID.Location = new System.Drawing.Point(3, 18);
            this.lblAccommodationID.Name = "lblAccommodationID";
            this.lblAccommodationID.Size = new System.Drawing.Size(94, 13);
            this.lblAccommodationID.TabIndex = 11;
            this.lblAccommodationID.Text = "AccommoadtionID";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Red;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddAnother
            // 
            this.btnAddAnother.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnAddAnother.FlatAppearance.BorderSize = 2;
            this.btnAddAnother.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddAnother.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAnother.ForeColor = System.Drawing.Color.Red;
            this.btnAddAnother.Location = new System.Drawing.Point(135, 3);
            this.btnAddAnother.Name = "btnAddAnother";
            this.btnAddAnother.Size = new System.Drawing.Size(94, 29);
            this.btnAddAnother.TabIndex = 35;
            this.btnAddAnother.Text = "Add Another";
            this.btnAddAnother.UseVisualStyleBackColor = true;
            this.btnAddAnother.Click += new System.EventHandler(this.btnAddAnother_Click);
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // pnlAddButtons
            // 
            this.pnlAddButtons.Controls.Add(this.btnAdd);
            this.pnlAddButtons.Controls.Add(this.btnAddAnother);
            this.pnlAddButtons.Location = new System.Drawing.Point(12, 204);
            this.pnlAddButtons.Name = "pnlAddButtons";
            this.pnlAddButtons.Size = new System.Drawing.Size(232, 35);
            this.pnlAddButtons.TabIndex = 37;
            // 
            // mnsNorthCoast
            // 
            this.mnsNorthCoast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mnsNorthCoast.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.northCoastToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnsNorthCoast.Location = new System.Drawing.Point(0, 0);
            this.mnsNorthCoast.Name = "mnsNorthCoast";
            this.mnsNorthCoast.Size = new System.Drawing.Size(254, 24);
            this.mnsNorthCoast.TabIndex = 38;
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
            // AccommodationAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(254, 246);
            this.Controls.Add(this.mnsNorthCoast);
            this.Controls.Add(this.pnlAddButtons);
            this.Controls.Add(this.pnlAccommodationCreate);
            this.Name = "AccommodationAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accommodation Add";
            this.Load += new System.EventHandler(this.AccommodationAdd_Load);
            this.pnlAccommodationCreate.ResumeLayout(false);
            this.pnlAccommodationCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.pnlAddButtons.ResumeLayout(false);
            this.mnsNorthCoast.ResumeLayout(false);
            this.mnsNorthCoast.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAccommodationCreate;
        private System.Windows.Forms.ComboBox cbbAccommodationType;
        private System.Windows.Forms.Label lblAccommodationType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddAnother;
        private System.Windows.Forms.Label lblAccommodationID;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.MaskedTextBox txtAccommodationID;
        private System.Windows.Forms.CheckBox cbxNeedsServiced;
        private System.Windows.Forms.ErrorProvider errP;
        private System.Windows.Forms.Panel pnlAddButtons;
        private System.Windows.Forms.TextBox txtNotes;
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