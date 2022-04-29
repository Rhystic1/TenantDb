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
                    InsertMainData(conn, tenant2IsPresent);

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

        private bool InsertMainData(SqlConnection conn, bool tenant2IsPresent)
        {
            SqlCommand cmd = new SqlCommand("[dbo].[procCreateTenancy]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenancyName", tenancyNameTextbox.Text);
            cmd.Parameters.AddWithValue("@propertyName", propertyNameTextbox.Text);
            cmd.Parameters.AddWithValue("@landlordName", landlordNameTextbox.Text);
            cmd.Parameters.AddWithValue("@tenantName", tenant1NameTextbox.Text);
            cmd.ExecuteNonQuery();
            if (tenant2TextBox.Text.Length > 0)
            {
                SqlCommand cmd2a = new SqlCommand("[dbo].[procTenant2]", conn);
                cmd2a.CommandType = CommandType.StoredProcedure;
                cmd2a.Parameters.AddWithValue("@tenancyName", tenancyNameTextbox.Text);
                cmd2a.Parameters.AddWithValue("@propertyName", propertyNameTextbox.Text);
                cmd2a.Parameters.AddWithValue("@landlordName", landlordNameTextbox.Text);
                cmd2a.Parameters.AddWithValue("@tenant2Name", tenant2TextBox.Text);
                cmd2a.ExecuteNonQuery();
                tenant2IsPresent = true;
            }

            return tenant2IsPresent;
        }
    }
}
