namespace TenantDb
{
    partial class AddToDatabase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tenancyNameLabel = new System.Windows.Forms.Label();
            this.tenant1Label = new System.Windows.Forms.Label();
            this.propertyNameLabel = new System.Windows.Forms.Label();
            this.landlordNameLabel = new System.Windows.Forms.Label();
            this.tenancyNameTextbox = new System.Windows.Forms.TextBox();
            this.tenant1NameTextbox = new System.Windows.Forms.TextBox();
            this.propertyNameTextbox = new System.Windows.Forms.TextBox();
            this.landlordNameTextbox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.successMessage = new System.Windows.Forms.Label();
            this.tenant2Label = new System.Windows.Forms.Label();
            this.tenant2TextBox = new System.Windows.Forms.TextBox();
            this.errorDescription = new System.Windows.Forms.Label();
            this.tenant4Label = new System.Windows.Forms.Label();
            this.tenant3Label = new System.Windows.Forms.Label();
            this.tenant3TextBox = new System.Windows.Forms.TextBox();
            this.tenant4TextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tenancyNameLabel
            // 
            this.tenancyNameLabel.AutoSize = true;
            this.tenancyNameLabel.Location = new System.Drawing.Point(47, 87);
            this.tenancyNameLabel.Name = "tenancyNameLabel";
            this.tenancyNameLabel.Size = new System.Drawing.Size(157, 25);
            this.tenancyNameLabel.TabIndex = 0;
            this.tenancyNameLabel.Text = "Tenancy Name";
            // 
            // tenant1Label
            // 
            this.tenant1Label.AutoSize = true;
            this.tenant1Label.Location = new System.Drawing.Point(47, 139);
            this.tenant1Label.Name = "tenant1Label";
            this.tenant1Label.Size = new System.Drawing.Size(97, 25);
            this.tenant1Label.TabIndex = 1;
            this.tenant1Label.Text = "Tenant 1";
            // 
            // propertyNameLabel
            // 
            this.propertyNameLabel.AutoSize = true;
            this.propertyNameLabel.Location = new System.Drawing.Point(506, 84);
            this.propertyNameLabel.Name = "propertyNameLabel";
            this.propertyNameLabel.Size = new System.Drawing.Size(155, 25);
            this.propertyNameLabel.TabIndex = 2;
            this.propertyNameLabel.Text = "Property Name";
            // 
            // landlordNameLabel
            // 
            this.landlordNameLabel.AutoSize = true;
            this.landlordNameLabel.Location = new System.Drawing.Point(49, 335);
            this.landlordNameLabel.Name = "landlordNameLabel";
            this.landlordNameLabel.Size = new System.Drawing.Size(96, 25);
            this.landlordNameLabel.TabIndex = 3;
            this.landlordNameLabel.Text = "Landlord";
            // 
            // tenancyNameTextbox
            // 
            this.tenancyNameTextbox.Location = new System.Drawing.Point(234, 87);
            this.tenancyNameTextbox.Name = "tenancyNameTextbox";
            this.tenancyNameTextbox.Size = new System.Drawing.Size(240, 31);
            this.tenancyNameTextbox.TabIndex = 1;
            // 
            // tenant1NameTextbox
            // 
            this.tenant1NameTextbox.Location = new System.Drawing.Point(234, 139);
            this.tenant1NameTextbox.Name = "tenant1NameTextbox";
            this.tenant1NameTextbox.Size = new System.Drawing.Size(240, 31);
            this.tenant1NameTextbox.TabIndex = 2;
            // 
            // propertyNameTextbox
            // 
            this.propertyNameTextbox.Location = new System.Drawing.Point(688, 84);
            this.propertyNameTextbox.Name = "propertyNameTextbox";
            this.propertyNameTextbox.Size = new System.Drawing.Size(239, 31);
            this.propertyNameTextbox.TabIndex = 6;
            // 
            // landlordNameTextbox
            // 
            this.landlordNameTextbox.Location = new System.Drawing.Point(234, 335);
            this.landlordNameTextbox.Name = "landlordNameTextbox";
            this.landlordNameTextbox.Size = new System.Drawing.Size(240, 31);
            this.landlordNameTextbox.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(562, 380);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(175, 35);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // successMessage
            // 
            this.successMessage.AutoSize = true;
            this.successMessage.ForeColor = System.Drawing.Color.ForestGreen;
            this.successMessage.Location = new System.Drawing.Point(393, 385);
            this.successMessage.Name = "successMessage";
            this.successMessage.Size = new System.Drawing.Size(134, 25);
            this.successMessage.TabIndex = 9;
            this.successMessage.Text = "Entry added!";
            this.successMessage.Visible = false;
            // 
            // tenant2Label
            // 
            this.tenant2Label.AutoSize = true;
            this.tenant2Label.Location = new System.Drawing.Point(47, 191);
            this.tenant2Label.Name = "tenant2Label";
            this.tenant2Label.Size = new System.Drawing.Size(97, 25);
            this.tenant2Label.TabIndex = 10;
            this.tenant2Label.Text = "Tenant 2";
            // 
            // tenant2TextBox
            // 
            this.tenant2TextBox.Location = new System.Drawing.Point(234, 185);
            this.tenant2TextBox.Name = "tenant2TextBox";
            this.tenant2TextBox.Size = new System.Drawing.Size(240, 31);
            this.tenant2TextBox.TabIndex = 3;
            // 
            // errorDescription
            // 
            this.errorDescription.AutoSize = true;
            this.errorDescription.ForeColor = System.Drawing.Color.ForestGreen;
            this.errorDescription.Location = new System.Drawing.Point(12, 350);
            this.errorDescription.Name = "errorDescription";
            this.errorDescription.Size = new System.Drawing.Size(0, 25);
            this.errorDescription.TabIndex = 12;
            this.errorDescription.Visible = false;
            // 
            // tenant4Label
            // 
            this.tenant4Label.AutoSize = true;
            this.tenant4Label.Location = new System.Drawing.Point(48, 287);
            this.tenant4Label.Name = "tenant4Label";
            this.tenant4Label.Size = new System.Drawing.Size(97, 25);
            this.tenant4Label.TabIndex = 13;
            this.tenant4Label.Text = "Tenant 4";
            // 
            // tenant3Label
            // 
            this.tenant3Label.AutoSize = true;
            this.tenant3Label.Location = new System.Drawing.Point(48, 242);
            this.tenant3Label.Name = "tenant3Label";
            this.tenant3Label.Size = new System.Drawing.Size(97, 25);
            this.tenant3Label.TabIndex = 14;
            this.tenant3Label.Text = "Tenant 3";
            // 
            // tenant3TextBox
            // 
            this.tenant3TextBox.Location = new System.Drawing.Point(234, 239);
            this.tenant3TextBox.Name = "tenant3TextBox";
            this.tenant3TextBox.Size = new System.Drawing.Size(240, 31);
            this.tenant3TextBox.TabIndex = 4;
            // 
            // tenant4TextBox
            // 
            this.tenant4TextBox.Location = new System.Drawing.Point(234, 289);
            this.tenant4TextBox.Name = "tenant4TextBox";
            this.tenant4TextBox.Size = new System.Drawing.Size(240, 31);
            this.tenant4TextBox.TabIndex = 5;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(780, 380);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(175, 35);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddToDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.tenant4TextBox);
            this.Controls.Add(this.tenant3TextBox);
            this.Controls.Add(this.tenant3Label);
            this.Controls.Add(this.tenant4Label);
            this.Controls.Add(this.errorDescription);
            this.Controls.Add(this.tenant2TextBox);
            this.Controls.Add(this.tenant2Label);
            this.Controls.Add(this.successMessage);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.landlordNameTextbox);
            this.Controls.Add(this.propertyNameTextbox);
            this.Controls.Add(this.tenant1NameTextbox);
            this.Controls.Add(this.tenancyNameTextbox);
            this.Controls.Add(this.landlordNameLabel);
            this.Controls.Add(this.propertyNameLabel);
            this.Controls.Add(this.tenant1Label);
            this.Controls.Add(this.tenancyNameLabel);
            this.Name = "AddToDatabase";
            this.Text = "AddToDatabase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tenancyNameLabel;
        private System.Windows.Forms.Label tenant1Label;
        private System.Windows.Forms.Label propertyNameLabel;
        private System.Windows.Forms.Label landlordNameLabel;
        private System.Windows.Forms.TextBox tenancyNameTextbox;
        private System.Windows.Forms.TextBox tenant1NameTextbox;
        private System.Windows.Forms.TextBox propertyNameTextbox;
        private System.Windows.Forms.TextBox landlordNameTextbox;
        private System.Windows.Forms.Button addButton;
        public System.Windows.Forms.Label successMessage;
        private System.Windows.Forms.Label tenant2Label;
        private System.Windows.Forms.TextBox tenant2TextBox;
        public System.Windows.Forms.Label errorDescription;
        private System.Windows.Forms.Label tenant4Label;
        private System.Windows.Forms.Label tenant3Label;
        private System.Windows.Forms.TextBox tenant3TextBox;
        private System.Windows.Forms.TextBox tenant4TextBox;
        private System.Windows.Forms.Button cancelButton;
    }
}