using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TenantDb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addToDatabaseButton_Click(object sender, EventArgs e)
        {
            AddToDatabase addToDatabase = new AddToDatabase();
            addToDatabase.Show();
        }

        private void viewDBButton_Click(object sender, EventArgs e)
        {
            ViewDatabase viewDatabase = new ViewDatabase();
            viewDatabase.Show();
        }
    }
}
