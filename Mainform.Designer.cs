namespace Assignment4
{
    partial class Mainform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDestination = new Label();
            lblAirline = new Label();
            lblFlightId = new Label();
            lblFlightDuration = new Label();
            txtDestination = new TextBox();
            txtFlightDuration = new TextBox();
            txtFlightID = new TextBox();
            txtAirline = new TextBox();
            lstOutput = new ListBox();
            btnAddPlane = new Button();
            btnTakeOff = new Button();
            lstAddedPlanes = new ListBox();
            SuspendLayout();
            // 
            // lblDestination
            // 
            lblDestination.AutoSize = true;
            lblDestination.Location = new Point(23, 24);
            lblDestination.Name = "lblDestination";
            lblDestination.Size = new Size(67, 15);
            lblDestination.TabIndex = 0;
            lblDestination.Text = "Destination";
            // 
            // lblAirline
            // 
            lblAirline.AutoSize = true;
            lblAirline.Location = new Point(23, 73);
            lblAirline.Name = "lblAirline";
            lblAirline.Size = new Size(85, 15);
            lblAirline.TabIndex = 1;
            lblAirline.Text = "Airline/Aircraft";
            // 
            // lblFlightId
            // 
            lblFlightId.AutoSize = true;
            lblFlightId.Location = new Point(23, 118);
            lblFlightId.Name = "lblFlightId";
            lblFlightId.Size = new Size(51, 15);
            lblFlightId.TabIndex = 2;
            lblFlightId.Text = "Flight ID";
            // 
            // lblFlightDuration
            // 
            lblFlightDuration.AutoSize = true;
            lblFlightDuration.Location = new Point(23, 168);
            lblFlightDuration.Name = "lblFlightDuration";
            lblFlightDuration.Size = new Size(113, 15);
            lblFlightDuration.TabIndex = 3;
            lblFlightDuration.Text = "Flight Duration (hrs)";
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(142, 21);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(100, 23);
            txtDestination.TabIndex = 4;
            // 
            // txtFlightDuration
            // 
            txtFlightDuration.Location = new Point(142, 160);
            txtFlightDuration.Name = "txtFlightDuration";
            txtFlightDuration.Size = new Size(100, 23);
            txtFlightDuration.TabIndex = 5;
            // 
            // txtFlightID
            // 
            txtFlightID.Location = new Point(142, 110);
            txtFlightID.Name = "txtFlightID";
            txtFlightID.Size = new Size(100, 23);
            txtFlightID.TabIndex = 6;
            // 
            // txtAirline
            // 
            txtAirline.Location = new Point(142, 65);
            txtAirline.Name = "txtAirline";
            txtAirline.Size = new Size(100, 23);
            txtAirline.TabIndex = 7;
            // 
            // lstOutput
            // 
            lstOutput.FormattingEnabled = true;
            lstOutput.ItemHeight = 15;
            lstOutput.Location = new Point(12, 290);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(986, 334);
            lstOutput.TabIndex = 8;
            // 
            // btnAddPlane
            // 
            btnAddPlane.Location = new Point(33, 227);
            btnAddPlane.Name = "btnAddPlane";
            btnAddPlane.Size = new Size(75, 23);
            btnAddPlane.TabIndex = 9;
            btnAddPlane.Text = "Add Plane";
            btnAddPlane.UseVisualStyleBackColor = true;
            btnAddPlane.Click += btnAddPlane_Click;
            // 
            // btnTakeOff
            // 
            btnTakeOff.Location = new Point(157, 227);
            btnTakeOff.Name = "btnTakeOff";
            btnTakeOff.Size = new Size(75, 23);
            btnTakeOff.TabIndex = 10;
            btnTakeOff.Text = "Take Off";
            btnTakeOff.UseVisualStyleBackColor = true;
            btnTakeOff.Click += btnTakeOff_Click;
            // 
            // lstAddedPlanes
            // 
            lstAddedPlanes.ForeColor = SystemColors.HotTrack;
            lstAddedPlanes.FormattingEnabled = true;
            lstAddedPlanes.ItemHeight = 15;
            lstAddedPlanes.Location = new Point(261, 21);
            lstAddedPlanes.Name = "lstAddedPlanes";
            lstAddedPlanes.Size = new Size(737, 229);
            lstAddedPlanes.TabIndex = 12;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 635);
            Controls.Add(lstAddedPlanes);
            Controls.Add(btnTakeOff);
            Controls.Add(btnAddPlane);
            Controls.Add(lstOutput);
            Controls.Add(txtAirline);
            Controls.Add(txtFlightID);
            Controls.Add(txtFlightDuration);
            Controls.Add(txtDestination);
            Controls.Add(lblFlightDuration);
            Controls.Add(lblFlightId);
            Controls.Add(lblAirline);
            Controls.Add(lblDestination);
            Name = "Mainform";
            Text = "Control Tower - Departures";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDestination;
        private Label lblAirline;
        private Label lblFlightId;
        private Label lblFlightDuration;
        private TextBox txtDestination;
        private TextBox txtFlightDuration;
        private TextBox txtFlightID;
        private TextBox txtAirline;
        private ListBox lstOutput;
        private Button btnAddPlane;
        private Button btnTakeOff;
        private ListBox lstAddedPlanes;
    }
}
