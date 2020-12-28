﻿namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFerryIdentifierTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxFerryIdentifierType;
        
        private System.Windows.Forms.Label labelFerryIdentifierType;
        
        private System.Windows.Forms.TextBox textBoxFerryIdentifierTypeName;
        
        private System.Windows.Forms.Label labelFerryIdentifierTypeName;
        
        private System.Windows.Forms.TextBox textBoxState;
        
        private System.Windows.Forms.Label labelState;
        
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
            this.labelFerryIdentifierType = new System.Windows.Forms.Label();
            this.textBoxFerryIdentifierType = new System.Windows.Forms.TextBox();
            this.labelFerryIdentifierTypeName = new System.Windows.Forms.Label();
            this.textBoxFerryIdentifierTypeName = new System.Windows.Forms.TextBox();
            this.labelState = new System.Windows.Forms.Label();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelFerryIdentifierType
            //
            this.labelFerryIdentifierType.AutoSize = true;
            this.labelFerryIdentifierType.Location = new System.Drawing.Point(11, 13);
            this.labelFerryIdentifierType.Name = "labelFerryIdentifierType";
            this.labelFerryIdentifierType.Size = new System.Drawing.Size(71, 13);
            this.labelFerryIdentifierType.TabIndex = 2;
            this.labelFerryIdentifierType.Text = "Ferry Identifier Type:";
            //
            //textBoxFerryIdentifierType
            //
            this.textBoxFerryIdentifierType.Location = new System.Drawing.Point(182, 13);
            this.textBoxFerryIdentifierType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFerryIdentifierType.Name = "textBoxFerryIdentifierType";
            this.textBoxFerryIdentifierType.Size = new System.Drawing.Size(250, 20);
            this.textBoxFerryIdentifierType.TabIndex = 3;
            //
            // labelFerryIdentifierTypeName
            //
            this.labelFerryIdentifierTypeName.AutoSize = true;
            this.labelFerryIdentifierTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelFerryIdentifierTypeName.Name = "labelFerryIdentifierTypeName";
            this.labelFerryIdentifierTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelFerryIdentifierTypeName.TabIndex = 4;
            this.labelFerryIdentifierTypeName.Text = "Ferry Identifier Type Name:";
            //
            //textBoxFerryIdentifierTypeName
            //
            this.textBoxFerryIdentifierTypeName.Location = new System.Drawing.Point(182, 36);
            this.textBoxFerryIdentifierTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFerryIdentifierTypeName.Name = "textBoxFerryIdentifierTypeName";
            this.textBoxFerryIdentifierTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFerryIdentifierTypeName.TabIndex = 5;
            //
            // labelState
            //
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(11, 59);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(71, 13);
            this.labelState.TabIndex = 6;
            this.labelState.Text = "State:";
            //
            //textBoxState
            //
            this.textBoxState.Location = new System.Drawing.Point(182, 59);
            this.textBoxState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(250, 20);
            this.textBoxState.TabIndex = 7;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 82);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 8;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(182, 82);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(340, 105);
            
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
            this.buttonSave.Location = new System.Drawing.Point(240, 105);
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
            this.ClientSize = new System.Drawing.Size(444, 133);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeFerryIdentifierTypeRefEdit";
            this.Text = "Ferry Identifier Type Ref Edit";
            this.Controls.Add(this.labelFerryIdentifierType);
            this.Controls.Add(this.textBoxFerryIdentifierType);
            this.Controls.Add(this.labelFerryIdentifierTypeName);
            this.Controls.Add(this.textBoxFerryIdentifierTypeName);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
