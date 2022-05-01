namespace TenantDb
{
    partial class Form1
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
            this.addToDatabaseButton = new System.Windows.Forms.Button();
            this.viewDBButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addToDatabaseButton
            // 
            this.addToDatabaseButton.Location = new System.Drawing.Point(139, 42);
            this.addToDatabaseButton.Name = "addToDatabaseButton";
            this.addToDatabaseButton.Size = new System.Drawing.Size(267, 49);
            this.addToDatabaseButton.TabIndex = 0;
            this.addToDatabaseButton.Text = "Add to Database...";
            this.addToDatabaseButton.UseVisualStyleBackColor = true;
            this.addToDatabaseButton.Click += new System.EventHandler(this.addToDatabaseButton_Click);
            // 
            // viewDBButton
            // 
            this.viewDBButton.Location = new System.Drawing.Point(139, 127);
            this.viewDBButton.Name = "viewDBButton";
            this.viewDBButton.Size = new System.Drawing.Size(267, 49);
            this.viewDBButton.TabIndex = 1;
            this.viewDBButton.Text = "View Database";
            this.viewDBButton.UseVisualStyleBackColor = true;
            this.viewDBButton.Click += new System.EventHandler(this.viewDBButton_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 230);
            this.Controls.Add(this.viewDBButton);
            this.Controls.Add(this.addToDatabaseButton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tenancy Database Tool";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addToDatabaseButton;
        private System.Windows.Forms.Button viewDBButton;
    }
}

