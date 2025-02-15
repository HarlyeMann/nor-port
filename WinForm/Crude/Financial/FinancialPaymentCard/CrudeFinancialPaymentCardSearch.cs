﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/6/2021 4:18:46 PM
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
    public partial class CrudeFinancialPaymentCardSearch : Form {
        
        // the following fields holds initial state for foreign key's
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a58
        private string _financialCardTypeRcd;
        
        private System.Guid _financialCurrencyId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/4b63dffb-c4e4-44d4-8efd-0313f43db503
        public CrudeFinancialPaymentCardSearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialPaymentCard();
            this.AcceptButton = buttonCrudeFinancialPaymentCardSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        // links:
        //  docLink: http://sql2x.org/documentationLink/5a2d259e-c278-4e61-8414-4f659db90878
        public void Show(string financialCardTypeRcd, System.Guid financialCurrencyId, System.Guid userId) {
            try {
                _financialCardTypeRcd = financialCardTypeRcd;
                _financialCurrencyId = financialCurrencyId;
                _userId = userId;
                userPicker.SelectedValue = userId;

                RefreshCrudeFinancialPaymentCard();

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
        private void buttonCrudeFinancialPaymentCardEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialPaymentCardEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialPaymentCard.CurrentRow.Cells["FinancialPaymentCardId"].Value);
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
        private void buttonCrudeFinancialPaymentCardAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialPaymentCardEdit();
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
        private void dataGridViewCrudeFinancialPaymentCard_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialPaymentCardEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialPaymentCard.CurrentRow.Cells["FinancialPaymentCardId"].Value);
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
        private void buttonCrudeFinancialPaymentCardSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialPaymentCard();
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
        public void RefreshCrudeFinancialPaymentCard() {
            var financialPaymentCard = new CrudeFinancialPaymentCardServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialPaymentCard.FetchWithFilter(
                             Guid.Empty
                            ,financialCardTypeRefCombo.Text
                            ,textBoxNameOnCard.Text
                            ,textBoxCardNumber.Text
                            ,maskedTextBoxCardVerificationValue.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxCardVerificationValue.Text)
                            ,textBoxAddressVerificationCode.Text
                            ,maskedTextBoxIssuedYear.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxIssuedYear.Text)
                            ,maskedTextBoxIssuedMonth.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxIssuedMonth.Text)
                            ,maskedTextBoxExpiryYear.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxExpiryYear.Text)
                            ,maskedTextBoxExpiryMonth.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxExpiryMonth.Text)
                            ,maskedTextBoxAmount.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxAmount.Text)
                            ,financialCurrencyPicker.SelectedValue
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeFinancialPaymentCard.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialPaymentCard.DataSource = bindingSource;
                dataGridViewCrudeFinancialPaymentCard.AutoResizeColumns();
                dataGridViewCrudeFinancialPaymentCard.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialPaymentCard.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        // links:
        //  docLink: http://sql2x.org/documentationLink/634adebf-e682-407b-bf2e-223610d00e66
        private void InitializeGridCrudeFinancialPaymentCard() {
            try {
                dataGridViewCrudeFinancialPaymentCard.Columns.Clear();
                dataGridViewCrudeFinancialPaymentCard.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialPaymentCard.Columns.Add("FinancialCardTypeRcd","Financial Card Type");
                dataGridViewCrudeFinancialPaymentCard.Columns["FinancialCardTypeRcd"].DataPropertyName = "FinancialCardTypeRcd";
                dataGridViewCrudeFinancialPaymentCard.Columns.Add("NameOnCard","Name On Card");
                dataGridViewCrudeFinancialPaymentCard.Columns["NameOnCard"].DataPropertyName = "NameOnCard";
                dataGridViewCrudeFinancialPaymentCard.Columns.Add("CardNumber","Card Number");
                dataGridViewCrudeFinancialPaymentCard.Columns["CardNumber"].DataPropertyName = "CardNumber";
                dataGridViewCrudeFinancialPaymentCard.Columns.Add("AddressVerificationCode","Address Verification Code");
                dataGridViewCrudeFinancialPaymentCard.Columns["AddressVerificationCode"].DataPropertyName = "AddressVerificationCode";
                dataGridViewCrudeFinancialPaymentCard.Columns.Add("CardVerificationValue","Card Verification Value");
                dataGridViewCrudeFinancialPaymentCard.Columns["CardVerificationValue"].DataPropertyName = "CardVerificationValue";
                dataGridViewCrudeFinancialPaymentCard.Columns.Add("IssuedYear","Issued Year");
                dataGridViewCrudeFinancialPaymentCard.Columns["IssuedYear"].DataPropertyName = "IssuedYear";
                dataGridViewCrudeFinancialPaymentCard.Columns.Add("IssuedMonth","Issued Month");
                dataGridViewCrudeFinancialPaymentCard.Columns["IssuedMonth"].DataPropertyName = "IssuedMonth";
                dataGridViewCrudeFinancialPaymentCard.Columns.Add("ExpiryYear","Expiry Year");
                dataGridViewCrudeFinancialPaymentCard.Columns["ExpiryYear"].DataPropertyName = "ExpiryYear";
                dataGridViewCrudeFinancialPaymentCard.Columns.Add("ExpiryMonth","Expiry Month");
                dataGridViewCrudeFinancialPaymentCard.Columns["ExpiryMonth"].DataPropertyName = "ExpiryMonth";
                dataGridViewCrudeFinancialPaymentCard.Columns.Add("Amount","Amount");
                dataGridViewCrudeFinancialPaymentCard.Columns["Amount"].DataPropertyName = "Amount";
                dataGridViewCrudeFinancialPaymentCard.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialPaymentCard.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialPaymentCard.Columns.Add("FinancialPaymentCardId","Financial Payment Card");
                dataGridViewCrudeFinancialPaymentCard.Columns["FinancialPaymentCardId"].DataPropertyName = "FinancialPaymentCardId";
                dataGridViewCrudeFinancialPaymentCard.Columns["FinancialPaymentCardId"].Visible = false;
                dataGridViewCrudeFinancialPaymentCard.Columns.Add("FinancialCurrencyId","Financial Currency");
                dataGridViewCrudeFinancialPaymentCard.Columns["FinancialCurrencyId"].DataPropertyName = "FinancialCurrencyId";
                dataGridViewCrudeFinancialPaymentCard.Columns["FinancialCurrencyId"].Visible = false;
                dataGridViewCrudeFinancialPaymentCard.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialPaymentCard.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialPaymentCard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialPaymentCard.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
