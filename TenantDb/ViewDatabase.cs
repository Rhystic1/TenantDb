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
        }

        private void ViewDatabase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet11.procViewDB' table. You can move, or remove it, as needed.
            this.procViewDBTableAdapter.Fill(this.database1DataSet11.procViewDB);

        }
    }
}
