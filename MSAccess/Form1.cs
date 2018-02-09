using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSAccess
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetdataMethod();
        }

        private DataTable GetdataMethod()
        {
            DataTable dt = new DataTable();
            string connectionstring = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            OleDbConnection conn = new OleDbConnection(connectionstring);

            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from htbl", conn);
            adapter.Fill(dt);


            return dt;
        }
    }
}
