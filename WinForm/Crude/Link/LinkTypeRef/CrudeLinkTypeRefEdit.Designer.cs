﻿namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeLinkTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxLinkType;
        
        private System.Windows.Forms.Label labelLinkType;
        
        private System.Windows.Forms.TextBox textBoxLinkTypeName;
        
        private System.Windows.Forms.Label labelLinkTypeName;
        
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
            this.labelLinkType = new System.Windows.Forms.Label();
            this.textBoxLinkType = new System.Windows.Forms.TextBox();
            this.labelLinkTypeName = new System.Windows.Forms.Label();
            this.textBoxLinkTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelLinkType
            //
            this.labelLinkType.AutoSize = true;
            this.labelLinkType.Location = new System.Drawing.Point(11, 13);
            this.labelLinkType.Name = "labelLinkType";
            this.labelLinkType.Size = new System.Drawing.Size(71, 13);
            this.labelLinkType.TabIndex = 2;
            this.labelLinkType.Text = "Link Type:";
            //
            //textBoxLinkType
            //
            this.textBoxLinkType.Location = new System.Drawing.Point(140, 13);
            this.textBoxLinkType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLinkType.Name = "textBoxLinkType";
            this.textBoxLinkType.Size = new System.Drawing.Size(250, 20);
            this.textBoxLinkType.TabIndex = 3;
            //
            // labelLinkTypeName
            //
            this.labelLinkTypeName.AutoSize = true;
            this.labelLinkTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelLinkTypeName.Name = "labelLinkTypeName";
            this.labelLinkTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelLinkTypeName.TabIndex = 4;
            this.labelLinkTypeName.Text = "Link Type Name:";
            //
            //textBoxLinkTypeName
            //
            this.textBoxLinkTypeName.Location = new System.Drawing.Point(140, 36);
            this.textBoxLinkTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLinkTypeName.Name = "textBoxLinkTypeName";
            this.textBoxLinkTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxLinkTypeName.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(198, 82);
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
            this.ClientSize = new System.Drawing.Size(402, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeLinkTypeRefEdit";
            this.Text = "Link Type Ref Edit";
            this.Controls.Add(this.labelLinkType);
            this.Controls.Add(this.textBoxLinkType);
            this.Controls.Add(this.labelLinkTypeName);
            this.Controls.Add(this.textBoxLinkTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
