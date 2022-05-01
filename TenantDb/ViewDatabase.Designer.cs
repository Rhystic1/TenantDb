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
            this.components = new System.ComponentModel.Container();
            this.database1DataSet1 = new TenantDb.Database1DataSet();
            this.database1DataSet11 = new TenantDb.Database1DataSet1();
            this.procViewDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.procViewDBTableAdapter = new TenantDb.Database1DataSet1TableAdapters.procViewDBTableAdapter();
            this.tableAdapterManager = new TenantDb.Database1DataSet1TableAdapters.TableAdapterManager();
            this.procViewDBBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.procViewDBDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procViewDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procViewDBBindingNavigator)).BeginInit();
            this.procViewDBBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.procViewDBDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Z";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSet11
            // 
            this.database1DataSet11.DataSetName = "Database1DataSet1";
            this.database1DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // procViewDBBindingSource
            // 
            this.procViewDBBindingSource.DataMember = "procViewDB";
            this.procViewDBBindingSource.DataSource = this.database1DataSet11;
            // 
            // procViewDBTableAdapter
            // 
            this.procViewDBTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.LandlordsTableAdapter = null;
            this.tableAdapterManager.PropertiesTableAdapter = null;
            this.tableAdapterManager.TenancyTableAdapter = null;
            this.tableAdapterManager.TenantsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TenantDb.Database1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // procViewDBBindingNavigator
            // 
            this.procViewDBBindingNavigator.AddNewItem = null;
            this.procViewDBBindingNavigator.BindingSource = this.procViewDBBindingSource;
            this.procViewDBBindingNavigator.CountItem = null;
            this.procViewDBBindingNavigator.DeleteItem = null;
            this.procViewDBBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.procViewDBBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorSeparator2});
            this.procViewDBBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.procViewDBBindingNavigator.MoveFirstItem = null;
            this.procViewDBBindingNavigator.MoveLastItem = null;
            this.procViewDBBindingNavigator.MoveNextItem = null;
            this.procViewDBBindingNavigator.MovePreviousItem = null;
            this.procViewDBBindingNavigator.Name = "procViewDBBindingNavigator";
            this.procViewDBBindingNavigator.PositionItem = null;
            this.procViewDBBindingNavigator.Size = new System.Drawing.Size(1774, 25);
            this.procViewDBBindingNavigator.TabIndex = 0;
            this.procViewDBBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // procViewDBDataGridView
            // 
            this.procViewDBDataGridView.AllowUserToAddRows = false;
            this.procViewDBDataGridView.AllowUserToDeleteRows = false;
            this.procViewDBDataGridView.AutoGenerateColumns = false;
            this.procViewDBDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.procViewDBDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.procViewDBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.procViewDBDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.procViewDBDataGridView.DataSource = this.procViewDBBindingSource;
            this.procViewDBDataGridView.Location = new System.Drawing.Point(0, 46);
            this.procViewDBDataGridView.Name = "procViewDBDataGridView";
            this.procViewDBDataGridView.ReadOnly = true;
            this.procViewDBDataGridView.RowHeadersWidth = 82;
            this.procViewDBDataGridView.RowTemplate.Height = 33;
            this.procViewDBDataGridView.Size = new System.Drawing.Size(1774, 867);
            this.procViewDBDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Tenancy";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tenancy";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 140;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Tenant 1";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tenant 1";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 142;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tenant 2";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tenant 2";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 142;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Tenant 3";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tenant 3";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 142;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Tenant 4";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tenant 4";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 142;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Landlord";
            this.dataGridViewTextBoxColumn6.HeaderText = "Landlord";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 141;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Property";
            this.dataGridViewTextBoxColumn7.HeaderText = "Property";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 138;
            // 
            // ViewDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 925);
            this.Controls.Add(this.procViewDBDataGridView);
            this.Controls.Add(this.procViewDBBindingNavigator);
            this.Name = "ViewDatabase";
            this.Text = "a";
            this.Load += new System.EventHandler(this.ViewDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procViewDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procViewDBBindingNavigator)).EndInit();
            this.procViewDBBindingNavigator.ResumeLayout(false);
            this.procViewDBBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.procViewDBDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet1;
        private Database1DataSet1 database1DataSet11;
        private System.Windows.Forms.BindingSource procViewDBBindingSource;
        private Database1DataSet1TableAdapters.procViewDBTableAdapter procViewDBTableAdapter;
        private Database1DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator procViewDBBindingNavigator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView procViewDBDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}