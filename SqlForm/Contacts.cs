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

namespace SqlForm
{
    public partial class Contacts : Form
    {
        string connectionString = @"Data Source=LEGION-42\SQLEXPRESS;" +
                                  @"Initial Catalog=address_book;Integrated Security=True;" +
                                  @"Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;" +
                                  @"ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        SqlDataAdapter dataAdapter;
        DataTable table;

        public Contacts()
        {
            InitializeComponent();
        }

        private void Contacts_Load(object sender, EventArgs e)
        {
            cboSearchBy.SelectedIndex = 0;
            dgvResult.DataSource = bindingSource;

            GetData("select * from contacts");
        }

        private void GetData(string query)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(query, connectionString);
                table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource.DataSource = table;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
