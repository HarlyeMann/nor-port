﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/6/2021 4:18:42 PM
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
    public partial class CrudeBookingServiceRequestEdit : Form {
        
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a56
        private CrudeBookingServiceRequestContract _contract;
        
        private Boolean _isNew;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/60285c68-1faa-4eb4-bf34-b8c9086c7291
        public CrudeBookingServiceRequestEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/e04d0806-55ef-41cc-8669-acf0ddd850c7
        public void ShowAsAdd() {
            try {
                _contract = new CrudeBookingServiceRequestContract();
                _isNew = true;
                this.Text += " - Not Savable (Booking Missing)";
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
        public void ShowAsAddByRules(System.Guid userId) {
            try {
                _contract = new CrudeBookingServiceRequestContract();
                _isNew = true;
                _contract.UserId = userId;
                userPicker.SelectedValue = _contract.UserId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

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
        public void ShowAsAddByServiceSpecialServiceRequest(System.Guid serviceSpecialServiceRequestId) {
            try {
                _contract = new CrudeBookingServiceRequestContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ServiceSpecialServiceRequestId = serviceSpecialServiceRequestId;
                serviceSpecialServiceRequestPicker.SelectedValue = _contract.ServiceSpecialServiceRequestId;

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
        public void ShowAsAddByBooking(System.Guid bookingId) {
            try {
                _contract = new CrudeBookingServiceRequestContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.BookingId = bookingId;

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
        public void ShowAsAddByServiceRequestStatus(string serviceRequestStatusRcd) {
            try {
                _contract = new CrudeBookingServiceRequestContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ServiceRequestStatusRcd = serviceRequestStatusRcd;
                serviceRequestStatusRefCombo.Text = _contract.ServiceRequestStatusRcd != null ? _contract.ServiceRequestStatusRcd : String.Empty;

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
        public void ShowAsAddByServiceHotel(System.Guid serviceHotelId) {
            try {
                _contract = new CrudeBookingServiceRequestContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ServiceHotelId = serviceHotelId;

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
        public void ShowAsAddByServiceCarRental(System.Guid serviceCarRentalId) {
            try {
                _contract = new CrudeBookingServiceRequestContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ServiceCarRentalId = serviceCarRentalId;
                serviceCarRentalPicker.SelectedValue = _contract.ServiceCarRentalId;

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
        public void ShowAsAddByServiceType(string serviceTypeRcd) {
            try {
                _contract = new CrudeBookingServiceRequestContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ServiceTypeRcd = serviceTypeRcd;
                serviceTypeRefCombo.Text = _contract.ServiceTypeRcd != null ? _contract.ServiceTypeRcd : String.Empty;

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
        public void ShowAsAddByServiceFerry(System.Guid serviceFerryId) {
            try {
                _contract = new CrudeBookingServiceRequestContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ServiceFerryId = serviceFerryId;

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
        public void ShowAsAdd(System.Guid bookingId, string serviceTypeRcd, System.Guid serviceSpecialServiceRequestId, string serviceRequestStatusRcd, System.Guid serviceHotelId, System.Guid serviceCarRentalId, System.Guid userId, System.Guid serviceFerryId) {
            try {
                _contract = new CrudeBookingServiceRequestContract();
                _isNew = true;
                _contract.BookingId = bookingId;
                _contract.ServiceTypeRcd = serviceTypeRcd;
                serviceTypeRefCombo.Text = _contract.ServiceTypeRcd != null ? _contract.ServiceTypeRcd : String.Empty;
                _contract.ServiceSpecialServiceRequestId = serviceSpecialServiceRequestId;
                serviceSpecialServiceRequestPicker.SelectedValue = _contract.ServiceSpecialServiceRequestId;
                _contract.ServiceRequestStatusRcd = serviceRequestStatusRcd;
                serviceRequestStatusRefCombo.Text = _contract.ServiceRequestStatusRcd != null ? _contract.ServiceRequestStatusRcd : String.Empty;
                _contract.ServiceHotelId = serviceHotelId;
                _contract.ServiceCarRentalId = serviceCarRentalId;
                serviceCarRentalPicker.SelectedValue = _contract.ServiceCarRentalId;
                _contract.UserId = userId;
                userPicker.SelectedValue = userId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ServiceFerryId = serviceFerryId;

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
        public void ShowAsEdit(System.Guid bookingServiceRequestId) {
            var service = new CrudeBookingServiceRequestServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByBookingServiceRequestId(bookingServiceRequestId);
                serviceTypeRefCombo.Text = _contract.ServiceTypeRcd != null ? _contract.ServiceTypeRcd : String.Empty;
                serviceSpecialServiceRequestPicker.SelectedValue = _contract.ServiceSpecialServiceRequestId;
                serviceRequestStatusRefCombo.Text = _contract.ServiceRequestStatusRcd != null ? _contract.ServiceRequestStatusRcd : String.Empty;
                serviceCarRentalPicker.SelectedValue = _contract.ServiceCarRentalId;
                userPicker.SelectedValue = _contract.UserId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

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
            var service = new CrudeBookingServiceRequestServiceClient();
            try {
                _contract.ServiceTypeRcd = serviceTypeRefCombo.Text;
                _contract.ServiceSpecialServiceRequestId = (Guid)serviceSpecialServiceRequestPicker.SelectedValue;
                _contract.ServiceRequestStatusRcd = serviceRequestStatusRefCombo.Text;
                _contract.ServiceCarRentalId = (Guid)serviceCarRentalPicker.SelectedValue;
                _contract.UserId = (Guid)userPicker.SelectedValue;

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
