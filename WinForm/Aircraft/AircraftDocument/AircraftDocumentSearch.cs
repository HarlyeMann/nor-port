﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/6/2021 4:51:11 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateWithDurianGenerator.UsingWinForm
*/
using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using SolutionNorSolutionPort.BusinessLogicLayer;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//  docLink: http://sql2x.org/documentationLink/c4e2b5ff-4b03-4e33-b63a-7c9899829434
namespace SolutionNorSolutionPort.UserInterface {

    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    // links:
    //  docLink: http://sql2x.org/documentationLink/e652f7b4-5cee-4eaa-8cbf-547f51efd7c6
    public partial class AircraftDocumentSearch : Form {
        
        // keep foreign keys as private members
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a59
        private System.Guid _aircraftId;
        
        private string _aircraftDocumentTypeRcd;
        
        private System.Guid _userId;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/79943c87-e38f-4cb4-82f2-d55079e54b54
        public AircraftDocumentSearch() {
            InitializeComponent();
            InitializeGridAircraftDocument();
            this.AcceptButton = buttonAircraftDocumentSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/c25d8511-8577-4915-821a-4c7ec7a5b8ce
        public void Show(System.Guid aircraftId, string aircraftDocumentTypeRcd, System.Guid userId) {
            _aircraftId = aircraftId;
            _aircraftDocumentTypeRcd = aircraftDocumentTypeRcd;
            _userId = userId;
            userPicker.SelectedValue = userId;
            RefreshAircraftDocument();
            base.Show();
        }
        
        // bring up edit form for AircraftDocument
        // links:
        //  docLink: http://sql2x.org/documentationLink/883480d1-2639-43f1-9096-131194b043c8
        private void buttonAircraftDocumentEdit_Click(object sender, EventArgs e) {
            var editForm = new AircraftDocumentEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewAircraftDocument.CurrentRow.Cells["AircraftDocumentId"].Value);
        }
        
        // bring up add form for AircraftDocument
        // links:
        //  docLink: http://sql2x.org/documentationLink/99b0d247-c5de-47a0-a27a-a6825fb73541
        private void buttonAircraftDocumentAdd_Click(object sender, EventArgs e) {
            var editForm = new AircraftDocumentEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAddByRules(_userId);
        }
        
        // bring up edit form for AircraftDocument
        // links:
        //  docLink: http://sql2x.org/documentationLink/c7fc6d72-476a-4d4b-b327-08e419db92a5
        private void dataGridViewAircraftDocument_DoubleClick(object sender, EventArgs e) {
            var editForm = new AircraftDocumentEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewAircraftDocument.CurrentRow.Cells["AircraftDocumentId"].Value);
        }
        
        // search AircraftDocument's using values from comboboxes and edit fields
        // links:
        //  docLink: http://sql2x.org/documentationLink/3d544c02-f541-4590-ac27-775c1f57bcea
        private void buttonAircraftDocumentSearch_Click(object sender, EventArgs e) {
            RefreshAircraftDocument();
        }
        
        // close the form
        // links:
        //  docLink: http://sql2x.org/documentationLink/6e648338-5d0d-4bf3-957e-07f4fe317d4b
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        // fetch AircraftDocument's from business layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/75fb8ca9-978e-42eb-b15f-4a9f56dc6454
        public void RefreshAircraftDocument() {
            var aircraftDocument = new AircraftSearchServiceClient();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = aircraftDocument.AircraftDocumentIndexWithFilter(_aircraftId);
                dataGridViewAircraftDocument.AutoGenerateColumns = false;
                dataGridViewAircraftDocument.DataSource = bindingSource;
                dataGridViewAircraftDocument.AutoResizeColumns();
                dataGridViewAircraftDocument.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                aircraftDocument.Close();
            }
        }
        
        // initialize grid forAircraftDocument's
        // links:
        //  docLink: http://sql2x.org/documentationLink/d6ea3697-5f07-488c-9680-d154a8dee287
        private void InitializeGridAircraftDocument() {
            dataGridViewAircraftDocument.Columns.Clear();
            dataGridViewAircraftDocument.AutoGenerateColumns = false;
            dataGridViewAircraftDocument.Columns.Add("AircraftName","Aircraft Name");
            dataGridViewAircraftDocument.Columns["AircraftName"].DataPropertyName = "AircraftName";
            dataGridViewAircraftDocument.Columns.Add("AircraftDocumentTypeName","Aircraft Document Type Name");
            dataGridViewAircraftDocument.Columns["AircraftDocumentTypeName"].DataPropertyName = "AircraftDocumentTypeName";
            dataGridViewAircraftDocument.Columns.Add("DocumentName","Document Name");
            dataGridViewAircraftDocument.Columns["DocumentName"].DataPropertyName = "DocumentName";
            dataGridViewAircraftDocument.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewAircraftDocument.Columns["DefaultUserName"].DataPropertyName = "DefaultUserName";
            dataGridViewAircraftDocument.Columns.Add("EngineType","Engine Type");
            dataGridViewAircraftDocument.Columns["EngineType"].DataPropertyName = "EngineType";
            dataGridViewAircraftDocument.Columns.Add("AircraftId","Aircraft Id");
            dataGridViewAircraftDocument.Columns["AircraftId"].DataPropertyName = "AircraftId";
            dataGridViewAircraftDocument.Columns["AircraftId"].Visible = false;
            dataGridViewAircraftDocument.Columns.Add("AircraftDocumentTypeRcd","Aircraft Document Type");
            dataGridViewAircraftDocument.Columns["AircraftDocumentTypeRcd"].DataPropertyName = "AircraftDocumentTypeRcd";
            dataGridViewAircraftDocument.Columns.Add("DocumentDateTime","Document Date Time");
            dataGridViewAircraftDocument.Columns["DocumentDateTime"].DataPropertyName = "DocumentDateTime";
            dataGridViewAircraftDocument.Columns.Add("ExpiryDateTime","Expiry Date Time");
            dataGridViewAircraftDocument.Columns["ExpiryDateTime"].DataPropertyName = "ExpiryDateTime";
            dataGridViewAircraftDocument.Columns.Add("UserId","User Id");
            dataGridViewAircraftDocument.Columns["UserId"].DataPropertyName = "UserId";
            dataGridViewAircraftDocument.Columns["UserId"].Visible = false;
            dataGridViewAircraftDocument.Columns.Add("DateTime","Date Time");
            dataGridViewAircraftDocument.Columns["DateTime"].DataPropertyName = "DateTime";
            dataGridViewAircraftDocument.Columns.Add("AircraftDocumentId","Aircraft Document Id");
            dataGridViewAircraftDocument.Columns["AircraftDocumentId"].DataPropertyName = "AircraftDocumentId";
            dataGridViewAircraftDocument.Columns["AircraftDocumentId"].Visible = false;
            dataGridViewAircraftDocument.Columns.Add("ExtensionData", "");
            dataGridViewAircraftDocument.Columns["ExtensionData"].Visible = false;

            dataGridViewAircraftDocument.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewAircraftDocument.AutoResizeColumns();
        }
    }
}
