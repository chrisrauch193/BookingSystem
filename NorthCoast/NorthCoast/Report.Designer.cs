namespace NorthCoast
{
    partial class Report
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
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.btnServiceInvoice = new System.Windows.Forms.Button();
            this.btnCheckInInvoice = new System.Windows.Forms.Button();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.btnCheckOutInvoice = new System.Windows.Forms.Button();
            this.mnsNorthCoast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
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
            this.mnsNorthCoast.Size = new System.Drawing.Size(817, 24);
            this.mnsNorthCoast.TabIndex = 9;
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
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(12, 38);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Size = new System.Drawing.Size(790, 353);
            this.dgvReport.TabIndex = 49;
            // 
            // btnServiceInvoice
            // 
            this.btnServiceInvoice.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnServiceInvoice.FlatAppearance.BorderSize = 2;
            this.btnServiceInvoice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnServiceInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceInvoice.Location = new System.Drawing.Point(12, 397);
            this.btnServiceInvoice.Name = "btnServiceInvoice";
            this.btnServiceInvoice.Size = new System.Drawing.Size(186, 34);
            this.btnServiceInvoice.TabIndex = 50;
            this.btnServiceInvoice.Text = "This Weeks Servicing";
            this.btnServiceInvoice.UseVisualStyleBackColor = true;
            this.btnServiceInvoice.Click += new System.EventHandler(this.btnServiceInvoice_Click);
            // 
            // btnCheckInInvoice
            // 
            this.btnCheckInInvoice.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnCheckInInvoice.FlatAppearance.BorderSize = 2;
            this.btnCheckInInvoice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCheckInInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckInInvoice.Location = new System.Drawing.Point(213, 397);
            this.btnCheckInInvoice.Name = "btnCheckInInvoice";
            this.btnCheckInInvoice.Size = new System.Drawing.Size(186, 34);
            this.btnCheckInInvoice.TabIndex = 51;
            this.btnCheckInInvoice.Text = "Check In";
            this.btnCheckInInvoice.UseVisualStyleBackColor = true;
            this.btnCheckInInvoice.Click += new System.EventHandler(this.btnCheckInInvoice_Click);
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnPrintInvoice.FlatAppearance.BorderSize = 2;
            this.btnPrintInvoice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPrintInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintInvoice.Location = new System.Drawing.Point(616, 397);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(186, 34);
            this.btnPrintInvoice.TabIndex = 52;
            this.btnPrintInvoice.Text = "Print Invoice";
            this.btnPrintInvoice.UseVisualStyleBackColor = true;
            // 
            // btnCheckOutInvoice
            // 
            this.btnCheckOutInvoice.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnCheckOutInvoice.FlatAppearance.BorderSize = 2;
            this.btnCheckOutInvoice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCheckOutInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOutInvoice.Location = new System.Drawing.Point(414, 397);
            this.btnCheckOutInvoice.Name = "btnCheckOutInvoice";
            this.btnCheckOutInvoice.Size = new System.Drawing.Size(186, 34);
            this.btnCheckOutInvoice.TabIndex = 53;
            this.btnCheckOutInvoice.Text = "Check Out";
            this.btnCheckOutInvoice.UseVisualStyleBackColor = true;
            this.btnCheckOutInvoice.Click += new System.EventHandler(this.btnCheckOutInvoice_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(817, 439);
            this.Controls.Add(this.btnCheckOutInvoice);
            this.Controls.Add(this.btnPrintInvoice);
            this.Controls.Add(this.btnCheckInInvoice);
            this.Controls.Add(this.btnServiceInvoice);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.mnsNorthCoast);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.mnsNorthCoast.ResumeLayout(false);
            this.mnsNorthCoast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Button btnServiceInvoice;
        private System.Windows.Forms.Button btnCheckInInvoice;
        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.Button btnCheckOutInvoice;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}