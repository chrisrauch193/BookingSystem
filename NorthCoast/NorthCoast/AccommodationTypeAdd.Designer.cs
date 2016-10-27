namespace NorthCoast
{
    partial class AccommodationTypeAdd
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
            this.pnlAccommodationTypeCreate = new System.Windows.Forms.Panel();
            this.txtAccommodationSize = new System.Windows.Forms.TextBox();
            this.txtAccommodationDesc = new System.Windows.Forms.TextBox();
            this.txtChargePerDay = new System.Windows.Forms.MaskedTextBox();
            this.txtAccommodationType = new System.Windows.Forms.MaskedTextBox();
            this.lblAccommodationDesc = new System.Windows.Forms.Label();
            this.lblAccommodationType = new System.Windows.Forms.Label();
            this.lblAccommodationSize = new System.Windows.Forms.Label();
            this.lblChargePerDay = new System.Windows.Forms.Label();
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
            this.pnlAccommodationTypeCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.pnlAddButtons.SuspendLayout();
            this.mnsNorthCoast.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAccommodationTypeCreate
            // 
            this.pnlAccommodationTypeCreate.Controls.Add(this.txtAccommodationSize);
            this.pnlAccommodationTypeCreate.Controls.Add(this.txtAccommodationDesc);
            this.pnlAccommodationTypeCreate.Controls.Add(this.txtChargePerDay);
            this.pnlAccommodationTypeCreate.Controls.Add(this.txtAccommodationType);
            this.pnlAccommodationTypeCreate.Controls.Add(this.lblAccommodationDesc);
            this.pnlAccommodationTypeCreate.Controls.Add(this.lblAccommodationType);
            this.pnlAccommodationTypeCreate.Controls.Add(this.lblAccommodationSize);
            this.pnlAccommodationTypeCreate.Controls.Add(this.lblChargePerDay);
            this.pnlAccommodationTypeCreate.Location = new System.Drawing.Point(12, 36);
            this.pnlAccommodationTypeCreate.Name = "pnlAccommodationTypeCreate";
            this.pnlAccommodationTypeCreate.Size = new System.Drawing.Size(194, 190);
            this.pnlAccommodationTypeCreate.TabIndex = 36;
            // 
            // txtAccommodationSize
            // 
            this.txtAccommodationSize.Enabled = false;
            this.txtAccommodationSize.ForeColor = System.Drawing.Color.Red;
            this.txtAccommodationSize.Location = new System.Drawing.Point(152, 136);
            this.txtAccommodationSize.Name = "txtAccommodationSize";
            this.txtAccommodationSize.Size = new System.Drawing.Size(19, 20);
            this.txtAccommodationSize.TabIndex = 55;
            // 
            // txtAccommodationDesc
            // 
            this.txtAccommodationDesc.ForeColor = System.Drawing.Color.Red;
            this.txtAccommodationDesc.Location = new System.Drawing.Point(10, 60);
            this.txtAccommodationDesc.MaxLength = 100;
            this.txtAccommodationDesc.Multiline = true;
            this.txtAccommodationDesc.Name = "txtAccommodationDesc";
            this.txtAccommodationDesc.Size = new System.Drawing.Size(162, 66);
            this.txtAccommodationDesc.TabIndex = 45;
            // 
            // txtChargePerDay
            // 
            this.txtChargePerDay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChargePerDay.ForeColor = System.Drawing.Color.Red;
            this.txtChargePerDay.Location = new System.Drawing.Point(121, 161);
            this.txtChargePerDay.Mask = "£000.00";
            this.txtChargePerDay.Name = "txtChargePerDay";
            this.txtChargePerDay.Size = new System.Drawing.Size(51, 20);
            this.txtChargePerDay.TabIndex = 39;
            // 
            // txtAccommodationType
            // 
            this.txtAccommodationType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccommodationType.ForeColor = System.Drawing.Color.Red;
            this.txtAccommodationType.Location = new System.Drawing.Point(145, 12);
            this.txtAccommodationType.Mask = ">L00";
            this.txtAccommodationType.Name = "txtAccommodationType";
            this.txtAccommodationType.Size = new System.Drawing.Size(26, 20);
            this.txtAccommodationType.TabIndex = 37;
            this.txtAccommodationType.TextChanged += new System.EventHandler(this.txtAccommodationType_TextChanged);
            // 
            // lblAccommodationDesc
            // 
            this.lblAccommodationDesc.AutoSize = true;
            this.lblAccommodationDesc.ForeColor = System.Drawing.Color.Red;
            this.lblAccommodationDesc.Location = new System.Drawing.Point(7, 44);
            this.lblAccommodationDesc.Name = "lblAccommodationDesc";
            this.lblAccommodationDesc.Size = new System.Drawing.Size(139, 13);
            this.lblAccommodationDesc.TabIndex = 37;
            this.lblAccommodationDesc.Text = "Accommodation Description";
            // 
            // lblAccommodationType
            // 
            this.lblAccommodationType.AutoSize = true;
            this.lblAccommodationType.ForeColor = System.Drawing.Color.Red;
            this.lblAccommodationType.Location = new System.Drawing.Point(7, 15);
            this.lblAccommodationType.Name = "lblAccommodationType";
            this.lblAccommodationType.Size = new System.Drawing.Size(124, 13);
            this.lblAccommodationType.TabIndex = 11;
            this.lblAccommodationType.Text = "Accommodation Type ID";
            // 
            // lblAccommodationSize
            // 
            this.lblAccommodationSize.AutoSize = true;
            this.lblAccommodationSize.ForeColor = System.Drawing.Color.Red;
            this.lblAccommodationSize.Location = new System.Drawing.Point(7, 139);
            this.lblAccommodationSize.Name = "lblAccommodationSize";
            this.lblAccommodationSize.Size = new System.Drawing.Size(106, 13);
            this.lblAccommodationSize.TabIndex = 10;
            this.lblAccommodationSize.Text = "Accommodation Size";
            // 
            // lblChargePerDay
            // 
            this.lblChargePerDay.AutoSize = true;
            this.lblChargePerDay.ForeColor = System.Drawing.Color.Red;
            this.lblChargePerDay.Location = new System.Drawing.Point(7, 164);
            this.lblChargePerDay.Name = "lblChargePerDay";
            this.lblChargePerDay.Size = new System.Drawing.Size(82, 13);
            this.lblChargePerDay.TabIndex = 12;
            this.lblChargePerDay.Text = "Charge Per Day";
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
            this.btnAdd.Size = new System.Drawing.Size(79, 23);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddAnother
            // 
            this.btnAddAnother.Enabled = false;
            this.btnAddAnother.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnAddAnother.FlatAppearance.BorderSize = 2;
            this.btnAddAnother.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddAnother.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAnother.ForeColor = System.Drawing.Color.Red;
            this.btnAddAnother.Location = new System.Drawing.Point(112, 3);
            this.btnAddAnother.Name = "btnAddAnother";
            this.btnAddAnother.Size = new System.Drawing.Size(79, 23);
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
            this.pnlAddButtons.Location = new System.Drawing.Point(12, 232);
            this.pnlAddButtons.Name = "pnlAddButtons";
            this.pnlAddButtons.Size = new System.Drawing.Size(194, 28);
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
            this.mnsNorthCoast.Size = new System.Drawing.Size(224, 24);
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
            // 
            // editAccommodationsToolStripMenuItem
            // 
            this.editAccommodationsToolStripMenuItem.Name = "editAccommodationsToolStripMenuItem";
            this.editAccommodationsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.editAccommodationsToolStripMenuItem.Text = "Edit Accommodations";
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
            // AccommodationTypeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(224, 266);
            this.Controls.Add(this.mnsNorthCoast);
            this.Controls.Add(this.pnlAddButtons);
            this.Controls.Add(this.pnlAccommodationTypeCreate);
            this.Name = "AccommodationTypeAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accommodation Type Add";
            this.Load += new System.EventHandler(this.AccommodationTypeAdd_Load);
            this.pnlAccommodationTypeCreate.ResumeLayout(false);
            this.pnlAccommodationTypeCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.pnlAddButtons.ResumeLayout(false);
            this.mnsNorthCoast.ResumeLayout(false);
            this.mnsNorthCoast.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAccommodationTypeCreate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddAnother;
        private System.Windows.Forms.MaskedTextBox txtAccommodationType;
        private System.Windows.Forms.TextBox txtAccommodationDesc;
        private System.Windows.Forms.MaskedTextBox txtChargePerDay;
        private System.Windows.Forms.Label lblAccommodationDesc;
        private System.Windows.Forms.Label lblAccommodationType;
        private System.Windows.Forms.Label lblAccommodationSize;
        private System.Windows.Forms.Label lblChargePerDay;
        private System.Windows.Forms.ErrorProvider errP;
        private System.Windows.Forms.Panel pnlAddButtons;
        private System.Windows.Forms.TextBox txtAccommodationSize;
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