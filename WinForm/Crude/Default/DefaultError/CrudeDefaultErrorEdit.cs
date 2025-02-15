﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/6/2021 4:18:43 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPort.BusinessLogicLayer;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//  docLink: http://sql2x.org/documentationLink/cd82fac1-15df-4881-b376-80b77ab185d0
namespace SolutionNorSolutionPort.UserInterface {

    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    // links:
    //  docLink: http://sql2x.org/documentationLink/43b6be6f-d1b6-4470-937c-dbf4588a80ee
    public partial class CrudeDefaultErrorEdit : Form {
        
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a56
        private CrudeDefaultErrorContract _contract;
        
        private Boolean _isNew;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/60285c68-1faa-4eb4-bf34-b8c9086c7291
        public CrudeDefaultErrorEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/e04d0806-55ef-41cc-8669-acf0ddd850c7
        public void ShowAsAdd() {
            try {
                _contract = new CrudeDefaultErrorContract();
                _isNew = true;
                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/599dcb45-f71b-4672-bb18-46975a4fe9b3
        public void ShowAsAddByRules(System.Guid defaultUserId) {
            try {
                _contract = new CrudeDefaultErrorContract();
                _isNew = true;
                _contract.DefaultUserId = defaultUserId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows by foreign keys
        // links:
        //  docLink: http://sql2x.org/documentationLink/f21e72c1-2d57-44c1-a9c1-1b80bad6a391
        public void ShowAsAddByDefaultUser(System.Guid defaultUserId) {
            try {
                _contract = new CrudeDefaultErrorContract();
                _isNew = true;
                _contract.DefaultUserId = defaultUserId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows by foreign keys
        // links:
        //  docLink: http://sql2x.org/documentationLink/f21e72c1-2d57-44c1-a9c1-1b80bad6a391
        public void ShowAsAddByDefaultErrorLayer(string defaultErrorLayerRcd) {
            try {
                _contract = new CrudeDefaultErrorContract();
                _isNew = true;
                _contract.DefaultErrorLayerRcd = defaultErrorLayerRcd;
                defaultErrorLayerRefCombo.Text = _contract.DefaultErrorLayerRcd != null ? _contract.DefaultErrorLayerRcd : String.Empty;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows by foreign keys
        // links:
        //  docLink: http://sql2x.org/documentationLink/f21e72c1-2d57-44c1-a9c1-1b80bad6a391
        public void ShowAsAddByDefaultErrorType(string defaultErrorTypeRcd) {
            try {
                _contract = new CrudeDefaultErrorContract();
                _isNew = true;
                _contract.DefaultErrorTypeRcd = defaultErrorTypeRcd;
                defaultErrorTypeRefCombo.Text = _contract.DefaultErrorTypeRcd != null ? _contract.DefaultErrorTypeRcd : String.Empty;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/f5685d96-a0bb-4f7b-beaa-b3d578c7cf28
        public void ShowAsAdd(string defaultErrorLayerRcd, string defaultErrorTypeRcd, string layerAddress, string errorMessage, string stackTrace, string methodName, string domainName, string className, System.Guid defaultUserId, System.DateTime dateTime) {
            try {
                _contract = new CrudeDefaultErrorContract();
                _isNew = true;
                _contract.DefaultErrorLayerRcd = defaultErrorLayerRcd;
                defaultErrorLayerRefCombo.Text = _contract.DefaultErrorLayerRcd != null ? _contract.DefaultErrorLayerRcd : String.Empty;
                _contract.DefaultErrorTypeRcd = defaultErrorTypeRcd;
                defaultErrorTypeRefCombo.Text = _contract.DefaultErrorTypeRcd != null ? _contract.DefaultErrorTypeRcd : String.Empty;
                _contract.LayerAddress = layerAddress;
                textBoxLayerAddress.Text = _contract.LayerAddress;
                _contract.ErrorMessage = errorMessage;
                textBoxErrorMessage.Text = _contract.ErrorMessage;
                _contract.StackTrace = stackTrace;
                textBoxStackTrace.Text = _contract.StackTrace;
                _contract.MethodName = methodName;
                textBoxMethodName.Text = _contract.MethodName;
                _contract.DomainName = domainName;
                textBoxDomainName.Text = _contract.DomainName;
                _contract.ClassName = className;
                textBoxClassName.Text = _contract.ClassName;
                _contract.DefaultUserId = defaultUserId;
                _contract.DateTime = dateTime;
                dateTimePickerDateTime.Value = _contract.DateTime != DateTime.MinValue ? _contract.DateTime : dateTimePickerDateTime.MinDate;
                dateTimePickerDateTime.Checked = _contract.DateTime != DateTime.MinValue;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the form in edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/49afd26c-4f21-4992-967b-be190eacef77
        public void ShowAsEdit(System.Guid defaultErrorId, System.Guid defaultUserId) {
            var service = new CrudeDefaultErrorServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByDefaultErrorId(defaultErrorId);
                defaultErrorLayerRefCombo.Text = _contract.DefaultErrorLayerRcd != null ? _contract.DefaultErrorLayerRcd : String.Empty;
                defaultErrorTypeRefCombo.Text = _contract.DefaultErrorTypeRcd != null ? _contract.DefaultErrorTypeRcd : String.Empty;
                textBoxLayerAddress.Text = _contract.LayerAddress;
                textBoxErrorMessage.Text = _contract.ErrorMessage;
                textBoxStackTrace.Text = _contract.StackTrace;
                textBoxMethodName.Text = _contract.MethodName;
                textBoxDomainName.Text = _contract.DomainName;
                textBoxClassName.Text = _contract.ClassName;
                _contract.DefaultUserId = defaultUserId;
                dateTimePickerDateTime.Value = _contract.DateTime != DateTime.MinValue ? _contract.DateTime : dateTimePickerDateTime.MinDate;
                dateTimePickerDateTime.Checked = _contract.DateTime != DateTime.MinValue;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                service.Close();
            }
        }
        
        // saves the form
        // links:
        //  docLink: http://sql2x.org/documentationLink/c9522930-91f8-4468-a936-8030bb2a6482
        private void buttonSave_Click(object sender, EventArgs e) {
            var service = new CrudeDefaultErrorServiceClient();
            try {
                _contract.DefaultErrorLayerRcd = defaultErrorLayerRefCombo.Text;
                _contract.DefaultErrorTypeRcd = defaultErrorTypeRefCombo.Text;
                _contract.LayerAddress = textBoxLayerAddress.Text;
                _contract.ErrorMessage = textBoxErrorMessage.Text;
                _contract.StackTrace = textBoxStackTrace.Text;
                _contract.MethodName = textBoxMethodName.Text;
                _contract.DomainName = textBoxDomainName.Text;
                _contract.ClassName = textBoxClassName.Text;
                _contract.DateTime = dateTimePickerDateTime.Checked ? Convert.ToDateTime(dateTimePickerDateTime.Value): DateTime.MinValue;

                if (_isNew)
                    service.Insert(_contract);
                else
                    service.Update(_contract);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                service.Close();
            }

            Close();
        }
        
        // closes the form
        // links:
        //  docLink: http://sql2x.org/documentationLink/876f1492-f546-42ac-aae3-11837d1d842a
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
