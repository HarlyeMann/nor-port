﻿namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAircraftEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxAircraftName;
        
        private System.Windows.Forms.Label labelAircraftName;
        
        private AircraftTypeRefCombo aircraftTypeRefCombo;
        
        private System.Windows.Forms.Label labelAircraftTypeRefCombo;
        
        private AircraftConfigurationRefCombo aircraftConfigurationRefCombo;
        
        private System.Windows.Forms.Label labelAircraftConfigurationRefCombo;
        
        private AircraftBodyRefCombo aircraftBodyRefCombo;
        
        private System.Windows.Forms.Label labelAircraftBodyRefCombo;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerOperationalDateTime;
        
        private System.Windows.Forms.Label labelOperationalDateTime;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerFirstFlightDateTime;
        
        private System.Windows.Forms.Label labelFirstFlightDateTime;
        
        private System.Windows.Forms.TextBox textBoxEngineType;
        
        private System.Windows.Forms.Label labelEngineType;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPassengerCapacity;
        
        private System.Windows.Forms.Label labelPassengerCapacity;
        
        private DefaultUserPicker userPicker;
        
        private System.Windows.Forms.Label labelUserPicker;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelAircraftName = new System.Windows.Forms.Label();
            this.textBoxAircraftName = new System.Windows.Forms.TextBox();
            this.labelAircraftTypeRefCombo = new System.Windows.Forms.Label();
            this.aircraftTypeRefCombo = new AircraftTypeRefCombo();
            this.labelAircraftConfigurationRefCombo = new System.Windows.Forms.Label();
            this.aircraftConfigurationRefCombo = new AircraftConfigurationRefCombo();
            this.labelAircraftBodyRefCombo = new System.Windows.Forms.Label();
            this.aircraftBodyRefCombo = new AircraftBodyRefCombo();
            this.labelOperationalDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerOperationalDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelFirstFlightDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerFirstFlightDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelEngineType = new System.Windows.Forms.Label();
            this.textBoxEngineType = new System.Windows.Forms.TextBox();
            this.labelPassengerCapacity = new System.Windows.Forms.Label();
            this.maskedTextBoxPassengerCapacity = new System.Windows.Forms.MaskedTextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelAircraftName
            //
            this.labelAircraftName.AutoSize = true;
            this.labelAircraftName.Location = new System.Drawing.Point(11, 13);
            this.labelAircraftName.Name = "labelAircraftName";
            this.labelAircraftName.Size = new System.Drawing.Size(71, 13);
            this.labelAircraftName.TabIndex = 2;
            this.labelAircraftName.Text = "Aircraft Name:";
            //
            //textBoxAircraftName
            //
            this.textBoxAircraftName.Location = new System.Drawing.Point(154, 13);
            this.textBoxAircraftName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAircraftName.Name = "textBoxAircraftName";
            this.textBoxAircraftName.Size = new System.Drawing.Size(250, 20);
            this.textBoxAircraftName.TabIndex = 3;
            //
            // labelAircraftTypeRefCombo
            //
            this.labelAircraftTypeRefCombo.AutoSize = true;
            this.labelAircraftTypeRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelAircraftTypeRefCombo.Name = "labelAircraftTypeRefCombo";
            this.labelAircraftTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelAircraftTypeRefCombo.TabIndex = 4;
            this.labelAircraftTypeRefCombo.Text = "Aircraft Type:";
            //
            //aircraftTypeRefCombo
            //
            this.aircraftTypeRefCombo.Location = new System.Drawing.Point(154, 36);
            this.aircraftTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.aircraftTypeRefCombo.Name = "aircraftTypeRefCombo";
            this.aircraftTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.aircraftTypeRefCombo.TabIndex = 5;
            //
            // labelAircraftConfigurationRefCombo
            //
            this.labelAircraftConfigurationRefCombo.AutoSize = true;
            this.labelAircraftConfigurationRefCombo.Location = new System.Drawing.Point(11, 59);
            this.labelAircraftConfigurationRefCombo.Name = "labelAircraftConfigurationRefCombo";
            this.labelAircraftConfigurationRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelAircraftConfigurationRefCombo.TabIndex = 6;
            this.labelAircraftConfigurationRefCombo.Text = "Aircraft Configuration:";
            //
            //aircraftConfigurationRefCombo
            //
            this.aircraftConfigurationRefCombo.Location = new System.Drawing.Point(154, 59);
            this.aircraftConfigurationRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.aircraftConfigurationRefCombo.Name = "aircraftConfigurationRefCombo";
            this.aircraftConfigurationRefCombo.Size = new System.Drawing.Size(250, 20);
            this.aircraftConfigurationRefCombo.TabIndex = 7;
            //
            // labelAircraftBodyRefCombo
            //
            this.labelAircraftBodyRefCombo.AutoSize = true;
            this.labelAircraftBodyRefCombo.Location = new System.Drawing.Point(11, 82);
            this.labelAircraftBodyRefCombo.Name = "labelAircraftBodyRefCombo";
            this.labelAircraftBodyRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelAircraftBodyRefCombo.TabIndex = 8;
            this.labelAircraftBodyRefCombo.Text = "Aircraft Body:";
            //
            //aircraftBodyRefCombo
            //
            this.aircraftBodyRefCombo.Location = new System.Drawing.Point(154, 82);
            this.aircraftBodyRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.aircraftBodyRefCombo.Name = "aircraftBodyRefCombo";
            this.aircraftBodyRefCombo.Size = new System.Drawing.Size(250, 20);
            this.aircraftBodyRefCombo.TabIndex = 9;
            //
            // labelOperationalDateTime
            //
            this.labelOperationalDateTime.AutoSize = true;
            this.labelOperationalDateTime.Location = new System.Drawing.Point(11, 105);
            this.labelOperationalDateTime.Name = "labelOperationalDateTime";
            this.labelOperationalDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelOperationalDateTime.TabIndex = 10;
            this.labelOperationalDateTime.Text = "Operational Date Time:";
            //
            //dateTimePickerOperationalDateTime
            //
            this.dateTimePickerOperationalDateTime.Location = new System.Drawing.Point(154, 105);
            this.dateTimePickerOperationalDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerOperationalDateTime.Name = "dateTimePickerOperationalDateTime";
            this.dateTimePickerOperationalDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerOperationalDateTime.TabIndex = 11;
            this.dateTimePickerOperationalDateTime.Checked = false;
            this.dateTimePickerOperationalDateTime.ShowCheckBox = true;
            //
            // labelFirstFlightDateTime
            //
            this.labelFirstFlightDateTime.AutoSize = true;
            this.labelFirstFlightDateTime.Location = new System.Drawing.Point(11, 128);
            this.labelFirstFlightDateTime.Name = "labelFirstFlightDateTime";
            this.labelFirstFlightDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelFirstFlightDateTime.TabIndex = 12;
            this.labelFirstFlightDateTime.Text = "First Flight Date Time:";
            //
            //dateTimePickerFirstFlightDateTime
            //
            this.dateTimePickerFirstFlightDateTime.Location = new System.Drawing.Point(154, 128);
            this.dateTimePickerFirstFlightDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFirstFlightDateTime.Name = "dateTimePickerFirstFlightDateTime";
            this.dateTimePickerFirstFlightDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerFirstFlightDateTime.TabIndex = 13;
            this.dateTimePickerFirstFlightDateTime.Checked = false;
            this.dateTimePickerFirstFlightDateTime.ShowCheckBox = true;
            //
            // labelEngineType
            //
            this.labelEngineType.AutoSize = true;
            this.labelEngineType.Location = new System.Drawing.Point(11, 151);
            this.labelEngineType.Name = "labelEngineType";
            this.labelEngineType.Size = new System.Drawing.Size(71, 13);
            this.labelEngineType.TabIndex = 14;
            this.labelEngineType.Text = "Engine Type:";
            //
            //textBoxEngineType
            //
            this.textBoxEngineType.Location = new System.Drawing.Point(154, 151);
            this.textBoxEngineType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEngineType.Name = "textBoxEngineType";
            this.textBoxEngineType.Size = new System.Drawing.Size(250, 20);
            this.textBoxEngineType.TabIndex = 15;
            //
            // labelPassengerCapacity
            //
            this.labelPassengerCapacity.AutoSize = true;
            this.labelPassengerCapacity.Location = new System.Drawing.Point(11, 174);
            this.labelPassengerCapacity.Name = "labelPassengerCapacity";
            this.labelPassengerCapacity.Size = new System.Drawing.Size(71, 13);
            this.labelPassengerCapacity.TabIndex = 16;
            this.labelPassengerCapacity.Text = "Passenger Capacity:";
            //
            //maskedTextBoxPassengerCapacity
            //
            this.maskedTextBoxPassengerCapacity.Location = new System.Drawing.Point(154, 174);
            this.maskedTextBoxPassengerCapacity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxPassengerCapacity.Name = "maskedTextBoxPassengerCapacity";
            this.maskedTextBoxPassengerCapacity.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxPassengerCapacity.TabIndex = 17;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 197);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 18;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(154, 197);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 19;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 220);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 20;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(154, 220);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 21;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(312, 243);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(212, 243);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(92, 22);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // EditForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 271);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeAircraftEdit";
            this.Text = "Aircraft Edit";
            this.Controls.Add(this.labelAircraftName);
            this.Controls.Add(this.textBoxAircraftName);
            this.Controls.Add(this.labelAircraftTypeRefCombo);
            this.Controls.Add(this.aircraftTypeRefCombo);
            this.Controls.Add(this.labelAircraftConfigurationRefCombo);
            this.Controls.Add(this.aircraftConfigurationRefCombo);
            this.Controls.Add(this.labelAircraftBodyRefCombo);
            this.Controls.Add(this.aircraftBodyRefCombo);
            this.Controls.Add(this.labelOperationalDateTime);
            this.Controls.Add(this.dateTimePickerOperationalDateTime);
            this.Controls.Add(this.labelFirstFlightDateTime);
            this.Controls.Add(this.dateTimePickerFirstFlightDateTime);
            this.Controls.Add(this.labelEngineType);
            this.Controls.Add(this.textBoxEngineType);
            this.Controls.Add(this.labelPassengerCapacity);
            this.Controls.Add(this.maskedTextBoxPassengerCapacity);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
