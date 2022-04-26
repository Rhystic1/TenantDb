using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TenantDb
{
    public partial class AddToDatabase : Form
    {
        public AddToDatabase()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                try
                {
                    errorDescription.Visible = false;
                    successMessage.Visible = false;
                    bool tenant2IsPresent = false;
                    conn.ConnectionString = @"Data Source=(localdb)\MSSqlLocalDb;Database=tenant;Trusted_Connection=true";
                    conn.Open();
                    tenant2IsPresent = InsertMainData(conn, tenant2IsPresent);
                    SyncTenants(conn, tenant2IsPresent);
                    SyncLandlord(conn);
                    SyncProperty(conn, tenant2IsPresent);

                    successMessage.Text = "Entry added!";
                    successMessage.ForeColor = Color.ForestGreen;
                    successMessage.Visible = true;
                }
                catch (Exception ex)
                {
                    successMessage.ForeColor = Color.Red;
                    successMessage.Text = "Error";
                    successMessage.Visible = true;
                    errorDescription.ForeColor = Color.Red;
                    errorDescription.Text = ex.Message;
                    errorDescription.Visible = true;
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private static void SyncLandlord(SqlConnection conn)
        {
            SqlCommand cmdJoinLandlord = new SqlCommand("UPDATE Tenancy SET landlordId = Landlords.landlordId FROM Landlords WHERE Tenancy.tenancyId = (SELECT TOP 1 tenancyId FROM Tenancy ORDER BY tenancyId DESC) AND Landlords.landlordId = (SELECT TOP 1 landlordId FROM Landlords ORDER BY landlordId DESC)", conn);
            cmdJoinLandlord.ExecuteNonQuery();
        }

        private void SyncTenants(SqlConnection conn, bool tenant2IsPresent)
        {
            SqlCommand cmdJoinTenants = new SqlCommand("UPDATE Tenancy SET tenant1Id = Tenants.tenantId FROM Tenants WHERE Tenancy.tenancyId = (SELECT TOP 1 tenancyId FROM Tenancy ORDER BY tenancyId DESC) AND Tenants.tenantName = @tenantName", conn);
            cmdJoinTenants.Parameters.AddWithValue("@tenantName", tenant1NameTextbox.Text);
            cmdJoinTenants.ExecuteNonQuery();
            if (tenant2IsPresent == true)
            {
                SqlCommand cmdJoinTenant2 = new SqlCommand("UPDATE Tenancy SET tenant2Id = Tenants.tenantId FROM Tenants WHERE Tenancy.tenancyId = (SELECT TOP 1 tenancyId FROM Tenancy ORDER BY tenancyId DESC) AND Tenants.tenantName = @tenant2Name", conn);
                cmdJoinTenant2.Parameters.AddWithValue("@tenant2Name", tenant2TextBox.Text);
                cmdJoinTenant2.ExecuteNonQuery();
            }
        }

        private bool InsertMainData(SqlConnection conn, bool tenant2IsPresent)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Tenancy (tenancyName) VALUES (@tenancyName); IF NOT EXISTS (SELECT 1 FROM Properties WHERE propertyName = @propertyName) BEGIN INSERT INTO Properties (propertyName) VALUES (@propertyName) END; IF NOT EXISTS (SELECT 1 FROM Landlords WHERE landlordName = @landlordName) BEGIN INSERT INTO Landlords (landlordName) VALUES (@landlordName) END; IF NOT EXISTS (SELECT 1 FROM Tenants WHERE tenantName = @tenantName) BEGIN INSERT INTO Tenants (tenantName) VALUES (@tenantName) END", conn);
            cmd.Parameters.AddWithValue("@tenancyName", tenancyNameTextbox.Text);
            cmd.Parameters.AddWithValue("@propertyName", propertyNameTextbox.Text);
            cmd.Parameters.AddWithValue("@landlordName", landlordNameTextbox.Text);
            cmd.Parameters.AddWithValue("@tenantName", tenant1NameTextbox.Text);
            cmd.ExecuteNonQuery();
            if (tenant2TextBox.Text.Length > 0)
            {
                SqlCommand cmd2a = new SqlCommand("IF NOT EXISTS (SELECT 1 FOM Tenants WHERE tenantName = @tenant2Name) BEGIN INSERT INTO Tenants (tenantName) VALUES (@tenant2Name) END", conn);
                cmd2a.Parameters.AddWithValue("@tenant2Name", tenant2TextBox.Text);
                tenant2IsPresent = true;
            }

            return tenant2IsPresent;
        }
        private bool SyncProperty(SqlConnection conn, bool tenant2IsPresent)
        {
            SqlCommand cmdSyncPropertyTenancy = new SqlCommand("UPDATE Tenancy SET propertyId = Properties.propertyId FROM Properties WHERE Tenancy.tenancyId = (SELECT TOP 1 tenancyId FROM Tenancy ORDER BY tenancyId DESC) AND Tenancy.tenancyName = @tenancyName;", conn);
            cmdSyncPropertyTenancy.Parameters.AddWithValue("@tenancyName", tenancyNameTextbox.Text);
            cmdSyncPropertyTenancy.ExecuteNonQuery();
            SqlCommand cmdSyncPropertyTenant = new SqlCommand("UPDATE Properties SET tenantId = Tenants.tenantId FROM Tenants WHERE Tenancy.tenancyId = (SELECT TOP 1 tenancyId FROM Tenancy ORDER BY tenancyId DESC) AND Tenants.tenantName = @tenantName", conn);
            cmdSyncPropertyTenant.Parameters.AddWithValue("@tenantName", tenant1NameTextbox.Text);
            //FIX ME - "The multi-part identifier "Tenancy.tenancyId" could not be bound."
            cmdSyncPropertyTenant.ExecuteNonQuery();
            if (tenant2IsPresent == true)
            {
                SqlCommand cmdSyncPropertyTenant2 = new SqlCommand("UPDATE Properties SET tenant2Id = Tenants.tenantId FROM Tenants WHERE Tenancy.tenancyId = (SELECT TOP 1 tenancyId FROM Tenancy ORDER BY tenancyId DESC) AND Tenants.tenantName = @tenant2Name", conn);
                cmdSyncPropertyTenant2.Parameters.AddWithValue("@tenant2Name", tenant2TextBox.Text);
                cmdSyncPropertyTenant2.ExecuteNonQuery();
            }
            return tenant2IsPresent;
        }
    }
}
