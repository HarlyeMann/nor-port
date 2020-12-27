﻿namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFinancialCurrencySearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialCurrencySearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialCurrencyAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialCurrencyEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialCurrency;
        
        private System.Windows.Forms.TextBox textBoxFinancialCurrencyTypeName;
        
        private System.Windows.Forms.Label labelFinancialCurrencyTypeName;
        
        private FinancialCurrencyTypeRefCombo financialCurrencyTypeRefCombo;
        
        private System.Windows.Forms.Label labelFinancialCurrencyTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxFinancialCurrencyTypeCode;
        
        private System.Windows.Forms.Label labelFinancialCurrencyTypeCode;
        
        private FinancialCurrencyTypeRefCombo financialCurrencyAgainstFinancialCurrencyTypeRefCombo;
        
        private System.Windows.Forms.Label labelFinancialCurrencyAgainstFinancialCurrencyTypeRefCombo;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAmount;
        
        private System.Windows.Forms.Label labelAmount;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEqualsAmount;
        
        private System.Windows.Forms.Label labelEqualsAmount;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDecimalCount;
        
        private System.Windows.Forms.Label labelDecimalCount;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerValidFromDateTime;
        
        private System.Windows.Forms.Label labelValidFromDateTime;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerValidUntilDateTime;
        
        private System.Windows.Forms.Label labelValidUntilDateTime;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private DefaultUserPicker userPicker;
        
        private System.Windows.Forms.Label labelUserPicker;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialCurrencyAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialCurrencyEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialCurrencySearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialCurrency = new System.Windows.Forms.DataGridView();
            this.labelFinancialCurrencyTypeName = new System.Windows.Forms.Label();
            this.textBoxFinancialCurrencyTypeName = new System.Windows.Forms.TextBox();
            this.labelFinancialCurrencyTypeRefCombo = new System.Windows.Forms.Label();
            this.financialCurrencyTypeRefCombo = new FinancialCurrencyTypeRefCombo();
            this.labelFinancialCurrencyTypeCode = new System.Windows.Forms.Label();
            this.textBoxFinancialCurrencyTypeCode = new System.Windows.Forms.TextBox();
            this.labelFinancialCurrencyAgainstFinancialCurrencyTypeRefCombo = new System.Windows.Forms.Label();
            this.financialCurrencyAgainstFinancialCurrencyTypeRefCombo = new FinancialCurrencyTypeRefCombo();
            this.labelAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelEqualsAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxEqualsAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelDecimalCount = new System.Windows.Forms.Label();
            this.maskedTextBoxDecimalCount = new System.Windows.Forms.MaskedTextBox();
            this.labelValidFromDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerValidFromDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelValidUntilDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerValidUntilDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialCurrency)).BeginInit();
            this.SuspendLayout();
            //
            // labelFinancialCurrencyTypeName
            //
            this.labelFinancialCurrencyTypeName.AutoSize = true;
            this.labelFinancialCurrencyTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialCurrencyTypeName.Name = "labelFinancialCurrencyTypeName";
            this.labelFinancialCurrencyTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCurrencyTypeName.TabIndex = 2;
            this.labelFinancialCurrencyTypeName.Text = "Financial Currency Type Name:";
            //
            //textBoxFinancialCurrencyTypeName
            //
            this.textBoxFinancialCurrencyTypeName.Location = new System.Drawing.Point(350, 13);
            this.textBoxFinancialCurrencyTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialCurrencyTypeName.Name = "textBoxFinancialCurrencyTypeName";
            this.textBoxFinancialCurrencyTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialCurrencyTypeName.TabIndex = 3;
            //
            // labelFinancialCurrencyTypeRefCombo
            //
            this.labelFinancialCurrencyTypeRefCombo.AutoSize = true;
            this.labelFinancialCurrencyTypeRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialCurrencyTypeRefCombo.Name = "labelFinancialCurrencyTypeRefCombo";
            this.labelFinancialCurrencyTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCurrencyTypeRefCombo.TabIndex = 4;
            this.labelFinancialCurrencyTypeRefCombo.Text = "Financial Currency Type:";
            //
            //financialCurrencyTypeRefCombo
            //
            this.financialCurrencyTypeRefCombo.Location = new System.Drawing.Point(350, 36);
            this.financialCurrencyTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialCurrencyTypeRefCombo.Name = "financialCurrencyTypeRefCombo";
            this.financialCurrencyTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.financialCurrencyTypeRefCombo.TabIndex = 5;
            //
            // labelFinancialCurrencyTypeCode
            //
            this.labelFinancialCurrencyTypeCode.AutoSize = true;
            this.labelFinancialCurrencyTypeCode.Location = new System.Drawing.Point(11, 59);
            this.labelFinancialCurrencyTypeCode.Name = "labelFinancialCurrencyTypeCode";
            this.labelFinancialCurrencyTypeCode.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCurrencyTypeCode.TabIndex = 6;
            this.labelFinancialCurrencyTypeCode.Text = "Financial Currency Type Code:";
            //
            //textBoxFinancialCurrencyTypeCode
            //
            this.textBoxFinancialCurrencyTypeCode.Location = new System.Drawing.Point(350, 59);
            this.textBoxFinancialCurrencyTypeCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialCurrencyTypeCode.Name = "textBoxFinancialCurrencyTypeCode";
            this.textBoxFinancialCurrencyTypeCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialCurrencyTypeCode.TabIndex = 7;
            //
            // labelFinancialCurrencyAgainstFinancialCurrencyTypeRefCombo
            //
            this.labelFinancialCurrencyAgainstFinancialCurrencyTypeRefCombo.AutoSize = true;
            this.labelFinancialCurrencyAgainstFinancialCurrencyTypeRefCombo.Location = new System.Drawing.Point(11, 82);
            this.labelFinancialCurrencyAgainstFinancialCurrencyTypeRefCombo.Name = "labelFinancialCurrencyAgainstFinancialCurrencyTypeRefCombo";
            this.labelFinancialCurrencyAgainstFinancialCurrencyTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCurrencyAgainstFinancialCurrencyTypeRefCombo.TabIndex = 8;
            this.labelFinancialCurrencyAgainstFinancialCurrencyTypeRefCombo.Text = "Financial Currency Against Financial Currency Type:";
            //
            //financialCurrencyAgainstFinancialCurrencyTypeRefCombo
            //
            this.financialCurrencyAgainstFinancialCurrencyTypeRefCombo.Location = new System.Drawing.Point(350, 82);
            this.financialCurrencyAgainstFinancialCurrencyTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialCurrencyAgainstFinancialCurrencyTypeRefCombo.Name = "financialCurrencyAgainstFinancialCurrencyTypeRefCombo";
            this.financialCurrencyAgainstFinancialCurrencyTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.financialCurrencyAgainstFinancialCurrencyTypeRefCombo.TabIndex = 9;
            //
            // labelAmount
            //
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(11, 105);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(71, 13);
            this.labelAmount.TabIndex = 10;
            this.labelAmount.Text = "Amount:";
            //
            //maskedTextBoxAmount
            //
            this.maskedTextBoxAmount.Location = new System.Drawing.Point(350, 105);
            this.maskedTextBoxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxAmount.Name = "maskedTextBoxAmount";
            this.maskedTextBoxAmount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxAmount.TabIndex = 11;
            //
            // labelEqualsAmount
            //
            this.labelEqualsAmount.AutoSize = true;
            this.labelEqualsAmount.Location = new System.Drawing.Point(11, 128);
            this.labelEqualsAmount.Name = "labelEqualsAmount";
            this.labelEqualsAmount.Size = new System.Drawing.Size(71, 13);
            this.labelEqualsAmount.TabIndex = 12;
            this.labelEqualsAmount.Text = "Equals Amount:";
            //
            //maskedTextBoxEqualsAmount
            //
            this.maskedTextBoxEqualsAmount.Location = new System.Drawing.Point(350, 128);
            this.maskedTextBoxEqualsAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxEqualsAmount.Name = "maskedTextBoxEqualsAmount";
            this.maskedTextBoxEqualsAmount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxEqualsAmount.TabIndex = 13;
            //
            // labelDecimalCount
            //
            this.labelDecimalCount.AutoSize = true;
            this.labelDecimalCount.Location = new System.Drawing.Point(11, 151);
            this.labelDecimalCount.Name = "labelDecimalCount";
            this.labelDecimalCount.Size = new System.Drawing.Size(71, 13);
            this.labelDecimalCount.TabIndex = 14;
            this.labelDecimalCount.Text = "Decimal Count:";
            //
            //maskedTextBoxDecimalCount
            //
            this.maskedTextBoxDecimalCount.Location = new System.Drawing.Point(350, 151);
            this.maskedTextBoxDecimalCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxDecimalCount.Name = "maskedTextBoxDecimalCount";
            this.maskedTextBoxDecimalCount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxDecimalCount.TabIndex = 15;
            //
            // labelValidFromDateTime
            //
            this.labelValidFromDateTime.AutoSize = true;
            this.labelValidFromDateTime.Location = new System.Drawing.Point(11, 174);
            this.labelValidFromDateTime.Name = "labelValidFromDateTime";
            this.labelValidFromDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelValidFromDateTime.TabIndex = 16;
            this.labelValidFromDateTime.Text = "Valid From Date Time:";
            //
            //dateTimePickerValidFromDateTime
            //
            this.dateTimePickerValidFromDateTime.Location = new System.Drawing.Point(350, 174);
            this.dateTimePickerValidFromDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerValidFromDateTime.Name = "dateTimePickerValidFromDateTime";
            this.dateTimePickerValidFromDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerValidFromDateTime.TabIndex = 17;
            this.dateTimePickerValidFromDateTime.Checked = false;
            this.dateTimePickerValidFromDateTime.ShowCheckBox = true;
            //
            // labelValidUntilDateTime
            //
            this.labelValidUntilDateTime.AutoSize = true;
            this.labelValidUntilDateTime.Location = new System.Drawing.Point(11, 197);
            this.labelValidUntilDateTime.Name = "labelValidUntilDateTime";
            this.labelValidUntilDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelValidUntilDateTime.TabIndex = 18;
            this.labelValidUntilDateTime.Text = "Valid Until Date Time:";
            //
            //dateTimePickerValidUntilDateTime
            //
            this.dateTimePickerValidUntilDateTime.Location = new System.Drawing.Point(350, 197);
            this.dateTimePickerValidUntilDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerValidUntilDateTime.Name = "dateTimePickerValidUntilDateTime";
            this.dateTimePickerValidUntilDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerValidUntilDateTime.TabIndex = 19;
            this.dateTimePickerValidUntilDateTime.Checked = false;
            this.dateTimePickerValidUntilDateTime.ShowCheckBox = true;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(350, 220);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 21;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 243);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 22;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(350, 243);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 23;
            // 
            // dataGridViewCrudeFinancialCurrency
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialCurrency.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialCurrency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialCurrency.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialCurrency.Location = new System.Drawing.Point(12, 276);
            this.dataGridViewCrudeFinancialCurrency.Name = "dataGridViewCrudeFinancialCurrency";
            this.dataGridViewCrudeFinancialCurrency.Size = new System.Drawing.Size(588, 96);
            this.dataGridViewCrudeFinancialCurrency.TabIndex = 0;
            this.dataGridViewCrudeFinancialCurrency.ReadOnly = true;
            this.dataGridViewCrudeFinancialCurrency.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialCurrency_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(508, 379);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialCurrencySearch
            // 
            this.buttonCrudeFinancialCurrencySearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialCurrencySearch.Location = new System.Drawing.Point(408, 379);
            this.buttonCrudeFinancialCurrencySearch.Name = "buttonCrudeFinancialCurrencySearch";
            this.buttonCrudeFinancialCurrencySearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialCurrencySearch.TabIndex = 2;
            this.buttonCrudeFinancialCurrencySearch.Text = "&Search";
            this.buttonCrudeFinancialCurrencySearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialCurrencySearch.Click += new System.EventHandler(this.buttonCrudeFinancialCurrencySearch_Click);
            // 
            // buttonCrudeFinancialCurrencyAdd
            // 
            this.buttonCrudeFinancialCurrencyAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialCurrencyAdd.Location = new System.Drawing.Point(308, 379);
            this.buttonCrudeFinancialCurrencyAdd.Name = "buttonCrudeFinancialCurrencyAdd";
            this.buttonCrudeFinancialCurrencyAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialCurrencyAdd.TabIndex = 3;
            this.buttonCrudeFinancialCurrencyAdd.Text = "&Add";
            this.buttonCrudeFinancialCurrencyAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialCurrencyAdd.Click += new System.EventHandler(this.buttonCrudeFinancialCurrencyAdd_Click);
            // 
            // buttonCrudeFinancialCurrencyEdit
            // 
            this.buttonCrudeFinancialCurrencyEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialCurrencyEdit.Location = new System.Drawing.Point(208, 379);
            this.buttonCrudeFinancialCurrencyEdit.Name = "buttonCrudeFinancialCurrencyEdit";
            this.buttonCrudeFinancialCurrencyEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialCurrencyEdit.TabIndex = 4;
            this.buttonCrudeFinancialCurrencyEdit.Text = "&Edit";
            this.buttonCrudeFinancialCurrencyEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialCurrencyEdit.Click += new System.EventHandler(this.buttonCrudeFinancialCurrencyEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 407);
            this.Controls.Add(this.buttonCrudeFinancialCurrencySearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialCurrencyAdd);
            this.Controls.Add(this.buttonCrudeFinancialCurrencyEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialCurrency);
            this.Name = "CrudeFinancialCurrencySearch";
            this.Text = "Financial Currency Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialCurrency)).EndInit();
            this.Controls.Add(this.labelFinancialCurrencyTypeName);
            this.Controls.Add(this.textBoxFinancialCurrencyTypeName);
            this.Controls.Add(this.labelFinancialCurrencyTypeRefCombo);
            this.Controls.Add(this.financialCurrencyTypeRefCombo);
            this.Controls.Add(this.labelFinancialCurrencyTypeCode);
            this.Controls.Add(this.textBoxFinancialCurrencyTypeCode);
            this.Controls.Add(this.labelFinancialCurrencyAgainstFinancialCurrencyTypeRefCombo);
            this.Controls.Add(this.financialCurrencyAgainstFinancialCurrencyTypeRefCombo);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.maskedTextBoxAmount);
            this.Controls.Add(this.labelEqualsAmount);
            this.Controls.Add(this.maskedTextBoxEqualsAmount);
            this.Controls.Add(this.labelDecimalCount);
            this.Controls.Add(this.maskedTextBoxDecimalCount);
            this.Controls.Add(this.labelValidFromDateTime);
            this.Controls.Add(this.dateTimePickerValidFromDateTime);
            this.Controls.Add(this.labelValidUntilDateTime);
            this.Controls.Add(this.dateTimePickerValidUntilDateTime);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
