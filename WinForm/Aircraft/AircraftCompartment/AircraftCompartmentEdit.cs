﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/6/2021 4:51:01 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateWithDurianGenerator.UsingWinForm
*/
using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    // links:
    //  docLink: http://sql2x.org/documentationLink/3d7a6660-be53-41aa-8f9d-7504e6026105
    public partial class AircraftCompartmentEdit : Form {
        
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a5a
        private CrudeAircraftCompartmentContract _contract;
        
        // true if form is in New modus, else Edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a5b
        private Boolean _isNew;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/e6bf67b2-7eb4-4882-bf12-aa5ae6eec6bf
        public AircraftCompartmentEdit() {
            InitializeComponent();
            InitializeGridAircraftCompartment();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        // bring up add form for AircraftCompartment
        // links:
        //  docLink: http://sql2x.org/documentationLink/c0944961-8179-40a2-a561-c8873b691f2c
        public void ShowAsAdd() {
            _contract = new CrudeAircraftCompartmentContract();
            _isNew = true;
            this.Text += " - Not Savable (Aircraft Missing)";
            RefreshAircraftCompartment();
            Show();
        }
        
        // bring up add form for AircraftCompartment with rules
        // links:
        //  docLink: http://sql2x.org/documentationLink/6018e96e-28a1-4df4-879b-01a6bda81cc7
        public void ShowAsAddByRules(System.Guid userId) {
            _contract = new CrudeAircraftCompartmentContract();
            _isNew = true;
            _contract.UserId = userId;
            userPicker.SelectedValue = _contract.UserId;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();

            RefreshAircraftCompartment();
            Show();
        }
        
        // bring up add form for AircraftCompartment by foreign key Aircraft
        // links:
        //  docLink: http://sql2x.org/documentationLink/2461e69c-dd05-47db-8f32-27ac1641a8d9
        public void ShowAsAddByAircraft(System.Guid aircraftId) {
            _contract = new CrudeAircraftCompartmentContract();
            _isNew = true;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();
            _contract.AircraftId = aircraftId;

            RefreshAircraftCompartment();
            Show();
        }
        
        // bring up add form for AircraftCompartment by foreign key AircraftCompartmentType
        // links:
        //  docLink: http://sql2x.org/documentationLink/2461e69c-dd05-47db-8f32-27ac1641a8d9
        public void ShowAsAddByAircraftCompartmentType(string aircraftCompartmentTypeRcd) {
            _contract = new CrudeAircraftCompartmentContract();
            _isNew = true;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();
            _contract.AircraftCompartmentTypeRcd = aircraftCompartmentTypeRcd;
            aircraftCompartmentTypeRefCombo.Text = _contract.AircraftCompartmentTypeRcd != null ? _contract.AircraftCompartmentTypeRcd : String.Empty;

            RefreshAircraftCompartment();
            Show();
        }
        
        // bring up add form for AircraftCompartment by foreign key AircraftCompartmentMeasurement
        // links:
        //  docLink: http://sql2x.org/documentationLink/2461e69c-dd05-47db-8f32-27ac1641a8d9
        public void ShowAsAddByAircraftCompartmentMeasurement(System.Guid aircraftCompartmentMeasurementId) {
            _contract = new CrudeAircraftCompartmentContract();
            _isNew = true;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();
            _contract.AircraftCompartmentMeasurementId = aircraftCompartmentMeasurementId;

            RefreshAircraftCompartment();
            Show();
        }
        
        // bring up add form for AircraftCompartment
        // links:
        //  docLink: http://sql2x.org/documentationLink/8568fd9a-b807-4aad-ac74-7826975e3241
        public void ShowAsAdd(System.Guid aircraftId, System.Guid aircraftCompartmentMeasurementId, string aircraftCompartmentTypeRcd, string aircraftCompartmentName, System.Guid userId) {
            _contract = new CrudeAircraftCompartmentContract();
            _isNew = true;
            _contract.AircraftId = aircraftId;
            _contract.AircraftCompartmentMeasurementId = aircraftCompartmentMeasurementId;
            _contract.AircraftCompartmentTypeRcd = aircraftCompartmentTypeRcd;
            aircraftCompartmentTypeRefCombo.Text = _contract.AircraftCompartmentTypeRcd != null ? _contract.AircraftCompartmentTypeRcd : String.Empty;
            _contract.AircraftCompartmentName = aircraftCompartmentName;
            textBoxAircraftCompartmentName.Text = _contract.AircraftCompartmentName;
            _contract.UserId = userId;
            userPicker.SelectedValue = userId;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();

            RefreshAircraftCompartment();
            Show();
        }
        
        // bring up edit form for AircraftCompartment
        // links:
        //  docLink: http://sql2x.org/documentationLink/d7ff032d-3bcf-438f-9850-900ca0ebca98
        public void ShowAsEdit(System.Guid aircraftCompartmentId) {
            var service = new CrudeAircraftCompartmentServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByAircraftCompartmentId(aircraftCompartmentId);
                aircraftCompartmentTypeRefCombo.Text = _contract.AircraftCompartmentTypeRcd != null ? _contract.AircraftCompartmentTypeRcd : String.Empty;
                textBoxAircraftCompartmentName.Text = _contract.AircraftCompartmentName;
                userPicker.SelectedValue = _contract.UserId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                RefreshAircraftCompartment();
                Show();
            } catch (Exception ex) {
                MessageBox.Show (ex.Message);
            } finally {
                service.Close();
            }
        }
        
        // save and close AircraftCompartment
        // links:
        //  docLink: http://sql2x.org/documentationLink/d71519ff-fa27-4f64-9194-56886e4070ba
        private void buttonSave_Click(object sender, EventArgs e) {
            var service = new CrudeAircraftCompartmentServiceClient();
            try {
                _contract.AircraftCompartmentTypeRcd = aircraftCompartmentTypeRefCombo.Text;
                _contract.AircraftCompartmentName = textBoxAircraftCompartmentName.Text;
                _contract.UserId = (Guid)userPicker.SelectedValue;

                if (_isNew)
                    service.Insert(_contract);
                else
                    service.Update(_contract);
            } catch (Exception ex) {
                MessageBox.Show (ex.Message);
            } finally {
                service.Close();
            }

            Close();
        }
        
        // search AircraftCompartment
        // links:
        //  docLink: http://sql2x.org/documentationLink/80a1bfbb-de84-4829-b248-3618a1657aae
        private void buttonAircraftCompartmentSearch_Click(object sender, EventArgs e) {
            RefreshAircraftCompartment();
        }
        
        // bring up edit form for AircraftCompartment
        // links:
        //  docLink: http://sql2x.org/documentationLink/634a3333-2588-4ce9-a69e-146e6db06604
        private void buttonAircraftCompartmentEdit_Click(object sender, EventArgs e) {
            // no code because ChildDefinition is missing
        }
        
        // bring up add form for AircraftCompartment
        // links:
        //  docLink: http://sql2x.org/documentationLink/8a47adae-c002-48ab-8926-9daa6f237b92
        private void buttonAircraftCompartmentAdd_Click(object sender, EventArgs e) {
            // no code because ChildDefinition is missing
        }
        
        // bring up edit form for AircraftCompartment
        // links:
        //  docLink: http://sql2x.org/documentationLink/a0d70634-76b1-43a0-bf41-c77b3ab4107f
        private void dataGridViewAircraftCompartment_DoubleClick(object sender, EventArgs e) {
            var editForm = new AircraftCompartmentEdit();
            editForm.MdiParent = this.MdiParent;
            // no code because ChildDefinition is missing
        }
        
        // close form for AircraftCompartment
        // links:
        //  docLink: http://sql2x.org/documentationLink/6cba4762-d598-4fc1-a165-225b3b86183f
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        // refresh AircraftCompartment's
        // links:
        //  docLink: http://sql2x.org/documentationLink/40b9491c-7991-43e7-9e8d-06181fd0a7c6
        public void RefreshAircraftCompartment() {
            // no code because ChildDefinition is missing}
        }
        
        // initialize grid for AircraftCompartment
        // links:
        //  docLink: http://sql2x.org/documentationLink/680c9cdb-dd8c-46bb-bb39-82bc124ebf5b
        private void InitializeGridAircraftCompartment() {
            dataGridViewAircraftCompartment.Columns.Clear();
            dataGridViewAircraftCompartment.AutoGenerateColumns = false;
            dataGridViewAircraftCompartment.Columns.Add("ExtensionData", "");
            dataGridViewAircraftCompartment.Columns["ExtensionData"].Visible = false;

            dataGridViewAircraftCompartment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewAircraftCompartment.AutoResizeColumns();
        }
    }
}
