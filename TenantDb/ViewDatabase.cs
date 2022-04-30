using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TenantDb
{
    public partial class ViewDatabase : Form
    {
        public ViewDatabase()
        {
            InitializeComponent();
            GetTenanciesFromDB();        
        }
        private void GetTenanciesFromDB()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = @"Data Source=(localdb)\MSSqlLocalDb;Database=tenant;Trusted_Connection=true";
                conn.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Tenancies", conn))
                {
                    var tenanciesTable = new DataTable();
                    adapter.Fill(tenanciesTable);
                    tenanciesList.DataSource = tenanciesTable;
                    tenanciesList.DisplayMember = "tenancyName";
                }
            }
        }
    }
}
