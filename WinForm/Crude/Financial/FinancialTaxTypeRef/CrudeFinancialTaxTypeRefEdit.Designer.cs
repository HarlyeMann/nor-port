﻿namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFinancialTaxTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxFinancialTaxType;
        
        private System.Windows.Forms.Label labelFinancialTaxType;
        
        private System.Windows.Forms.TextBox textBoxFinancialTaxTypeName;
        
        private System.Windows.Forms.Label labelFinancialTaxTypeName;
        
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
            this.labelFinancialTaxType = new System.Windows.Forms.Label();
            this.textBoxFinancialTaxType = new System.Windows.Forms.TextBox();
            this.labelFinancialTaxTypeName = new System.Windows.Forms.Label();
            this.textBoxFinancialTaxTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelFinancialTaxType
            //
            this.labelFinancialTaxType.AutoSize = true;
            this.labelFinancialTaxType.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialTaxType.Name = "labelFinancialTaxType";
            this.labelFinancialTaxType.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialTaxType.TabIndex = 2;
            this.labelFinancialTaxType.Text = "Financial Tax Type:";
            //
            //textBoxFinancialTaxType
            //
            this.textBoxFinancialTaxType.Location = new System.Drawing.Point(161, 13);
            this.textBoxFinancialTaxType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialTaxType.Name = "textBoxFinancialTaxType";
            this.textBoxFinancialTaxType.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialTaxType.TabIndex = 3;
            //
            // labelFinancialTaxTypeName
            //
            this.labelFinancialTaxTypeName.AutoSize = true;
            this.labelFinancialTaxTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialTaxTypeName.Name = "labelFinancialTaxTypeName";
            this.labelFinancialTaxTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialTaxTypeName.TabIndex = 4;
            this.labelFinancialTaxTypeName.Text = "Financial Tax Type Name:";
            //
            //textBoxFinancialTaxTypeName
            //
            this.textBoxFinancialTaxTypeName.Location = new System.Drawing.Point(161, 36);
            this.textBoxFinancialTaxTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialTaxTypeName.Name = "textBoxFinancialTaxTypeName";
            this.textBoxFinancialTaxTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialTaxTypeName.TabIndex = 5;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 59);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 6;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(161, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(319, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(219, 82);
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
            this.ClientSize = new System.Drawing.Size(423, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeFinancialTaxTypeRefEdit";
            this.Text = "Financial Tax Type Ref Edit";
            this.Controls.Add(this.labelFinancialTaxType);
            this.Controls.Add(this.textBoxFinancialTaxType);
            this.Controls.Add(this.labelFinancialTaxTypeName);
            this.Controls.Add(this.textBoxFinancialTaxTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
