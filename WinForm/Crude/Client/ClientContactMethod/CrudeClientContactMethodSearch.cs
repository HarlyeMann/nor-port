﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/6/2021 4:18:42 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//  docLink: http://sql2x.org/documentationLink/d8f07424-3438-4ff9-8853-3976c1227bad
namespace SolutionNorSolutionPort.UserInterface {

    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    // links:
    //  docLink: http://sql2x.org/documentationLink/9dd1c3bf-68b5-40b4-868a-735ee7394422
    public partial class CrudeClientContactMethodSearch : Form {
        
        // the following fields holds initial state for foreign key's
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a58
        private string _contactMethodRcd;
        
        private System.Guid _clientId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/4b63dffb-c4e4-44d4-8efd-0313f43db503
        public CrudeClientContactMethodSearch() {
            InitializeComponent();
            InitializeGridCrudeClientContactMethod();
            this.AcceptButton = buttonCrudeClientContactMethodSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        // links:
        //  docLink: http://sql2x.org/documentationLink/5a2d259e-c278-4e61-8414-4f659db90878
        public void Show(string contactMethodRcd, System.Guid clientId, System.Guid userId) {
            try {
                _contactMethodRcd = contactMethodRcd;
                _clientId = clientId;
                _userId = userId;
                userPicker.SelectedValue = userId;

                RefreshCrudeClientContactMethod();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/c778f8fe-1b09-4755-891f-f9d3126d1b85
        private void buttonCrudeClientContactMethodEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientContactMethodEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeClientContactMethod.CurrentRow.Cells["ClientContactMethodId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        // links:
        //  docLink: http://sql2x.org/documentationLink/499f894b-7c95-446b-be0a-57fd47b768e3
        private void buttonCrudeClientContactMethodAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientContactMethodEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/b9e26c97-bd6d-404a-80ad-d252a24c6fe8
        private void dataGridViewCrudeClientContactMethod_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientContactMethodEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeClientContactMethod.CurrentRow.Cells["ClientContactMethodId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        // links:
        //  docLink: http://sql2x.org/documentationLink/4c1fe3ad-84a0-4295-bd83-73d9e9afe750
        private void buttonCrudeClientContactMethodSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeClientContactMethod();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // closes the form
        // links:
        //  docLink: http://sql2x.org/documentationLink/6b990ce5-1c34-4759-bffd-659ae312004d
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        // refresh the grid
        // links:
        //  docLink: http://sql2x.org/documentationLink/a90065e7-8ace-4de7-9367-d4653a7c637f
        public void RefreshCrudeClientContactMethod() {
            var clientContactMethod = new CrudeClientContactMethodServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = clientContactMethod.FetchWithFilter(
                             Guid.Empty
                            ,clientPicker.SelectedValue
                            ,contactMethodRefCombo.Text
                            ,textBoxContactMethodWay.Text
                            ,textBoxComment.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeClientContactMethod.AutoGenerateColumns = false;
                dataGridViewCrudeClientContactMethod.DataSource = bindingSource;
                dataGridViewCrudeClientContactMethod.AutoResizeColumns();
                dataGridViewCrudeClientContactMethod.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                clientContactMethod.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        // links:
        //  docLink: http://sql2x.org/documentationLink/634adebf-e682-407b-bf2e-223610d00e66
        private void InitializeGridCrudeClientContactMethod() {
            try {
                dataGridViewCrudeClientContactMethod.Columns.Clear();
                dataGridViewCrudeClientContactMethod.AutoGenerateColumns = false;
                dataGridViewCrudeClientContactMethod.Columns.Add("ContactMethodRcd","Contact Method");
                dataGridViewCrudeClientContactMethod.Columns["ContactMethodRcd"].DataPropertyName = "ContactMethodRcd";
                dataGridViewCrudeClientContactMethod.Columns.Add("ContactMethodWay","Contact Method Way");
                dataGridViewCrudeClientContactMethod.Columns["ContactMethodWay"].DataPropertyName = "ContactMethodWay";
                dataGridViewCrudeClientContactMethod.Columns.Add("Comment","Comment");
                dataGridViewCrudeClientContactMethod.Columns["Comment"].DataPropertyName = "Comment";
                dataGridViewCrudeClientContactMethod.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeClientContactMethod.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeClientContactMethod.Columns.Add("ClientContactMethodId","Client Contact Method");
                dataGridViewCrudeClientContactMethod.Columns["ClientContactMethodId"].DataPropertyName = "ClientContactMethodId";
                dataGridViewCrudeClientContactMethod.Columns["ClientContactMethodId"].Visible = false;
                dataGridViewCrudeClientContactMethod.Columns.Add("ClientId","Client");
                dataGridViewCrudeClientContactMethod.Columns["ClientId"].DataPropertyName = "ClientId";
                dataGridViewCrudeClientContactMethod.Columns["ClientId"].Visible = false;
                dataGridViewCrudeClientContactMethod.Columns.Add("ExtensionData", "");
                dataGridViewCrudeClientContactMethod.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeClientContactMethod.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeClientContactMethod.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
