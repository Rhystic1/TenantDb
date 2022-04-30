namespace TenantDb
{
    partial class ViewDatabase
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
            this.database1DataSet1 = new TenantDb.Database1DataSet();
            this.tenanciesList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Z";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tenanciesList
            // 
            this.tenanciesList.FormattingEnabled = true;
            this.tenanciesList.ItemHeight = 25;
            this.tenanciesList.Location = new System.Drawing.Point(43, 92);
            this.tenanciesList.Name = "tenanciesList";
            this.tenanciesList.Size = new System.Drawing.Size(231, 554);
            this.tenanciesList.TabIndex = 0;
            // 
            // ViewDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 739);
            this.Controls.Add(this.tenanciesList);
            this.Name = "ViewDatabase";
            this.Text = "ViewDatabase";
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Database1DataSet database1DataSet1;
        private System.Windows.Forms.ListBox tenanciesList;
    }
}