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
using System.IO;
using System.Diagnostics;

namespace SqlForm
{
    public partial class Contacts : Form
    {
        SqlDataAdapter dataAdapter;         // ALLOW TO BUILD THE CONNECTION BETWEEN THE PROGRAM AND THE DATABASE
        DataTable table;                    // TABLE TO HOLD THE INFORMATION TO FILL THE DATAGRID VIEW
        SqlConnection connection;           // VARIABLE TO HOLD THE SQL CONNECTION

        string querySelection = "select * from contacts";

        string connectionString = @"Data Source=LEGION-42\SQLEXPRESS;" +
                                  @"Initial Catalog=address_book;Integrated Security=True;" +
                                  @"Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;" +
                                  @"ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public Contacts()
        {
            InitializeComponent();
        }

        private void Contacts_Load(object sender, EventArgs e)
        {
            cboSearchBy.SelectedIndex = 0;

            dgvResult.DataSource = bindingSource;

            GetData(querySelection);
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
                dgvResult.Columns[0].ReadOnly = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "SQL Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command;

            string insert = @"insert into contacts(date_added, company, website, title, " +
                            @"first_name, last_name, address, city, state, postal_code, " +
                            @"mobile, email, notes, image)" +

                            @"values(@date_added, @company, @website, @title, " +
                            @"@first_name, @last_name, @address, @city, @state, @postal_code, " +
                            @"@mobile, @email, @notes, @image)" ;

            using (connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    command = new SqlCommand(insert, connection);

                    command.Parameters.AddWithValue("date_added", dtpEntered.Value.Date);
                    command.Parameters.AddWithValue("company", txtCompany.Text);
                    command.Parameters.AddWithValue("website", txtWebsite.Text);
                    command.Parameters.AddWithValue("title", txtTitle.Text);
                    command.Parameters.AddWithValue("first_name", txtFirstName.Text);
                    command.Parameters.AddWithValue("last_name", txtLastName.Text);
                    command.Parameters.AddWithValue("address", txtAddress.Text);
                    command.Parameters.AddWithValue("city", txtCity.Text);
                    command.Parameters.AddWithValue("state", txtState.Text);
                    command.Parameters.AddWithValue("postal_code", txtPostalCode.Text);
                    command.Parameters.AddWithValue("mobile", txtMobile.Text);
                    command.Parameters.AddWithValue("email", txtEmail.Text);
                    command.Parameters.AddWithValue("notes", txtNotes.Text);

                    if (!string.IsNullOrEmpty(openFileDialog.FileName))
                    {
                        command.Parameters.AddWithValue("image", File.ReadAllBytes(openFileDialog.FileName));   // CONVERT IMAGE TO BYTES FOR SAVING
                    }
                    else
                    {
                        command.Parameters.Add("@image", SqlDbType.VarBinary).Value = DBNull.Value;
                    }

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SQL Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }

            GetData(querySelection);
            dgvResult.Update();
        }

        private void dgvResult_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var commandBuilder = new SqlCommandBuilder(dataAdapter);        // NEW SQL COMMAND BUILDER OBJECT
            dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand();  // GET THE UPDATE COMMAND

            try
            {
                bindingSource.EndEdit();                                    // UPDATES THE TABLE THAT IS IN MEMORY IN OUR PROGRAM
                dataAdapter.Update(table);                                  // ACTUALLY UPDATES THE DATABASE
                MessageBox.Show("Record updated successfully!", "Record updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvResult.CurrentCell.OwningRow;          // GRAB A REFERENCE TO THE CURRENT ROW
            string value = row.Cells["id"].Value.ToString();                // GRAB THE VALUE FROM THE ID FIELD  OF THE SELECTED RECORD
            string firstName = row.Cells["first_name"].Value.ToString();    // GRAB THE VALUE FROM THE FIRST NAME FIELD ...
            string lastName = row.Cells["last_name"].Value.ToString();      // GRAB THE VALUE FROM THE LAST NAME FIELD ...

            DialogResult result = MessageBox.Show($"Do you really want to delete\n" +
                                                  $"[ID: {value}] {firstName} {lastName} ?",
                                                  "Message", MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string delete = $"delete from contacts " +                  // THE SQL COMMAND TO DELETE THE RECORD
                                $"where id = '{value}'";              // FROM THE SQL TABLE

                using(connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        var command = new SqlCommand(delete, connection);
                        command.ExecuteNonQuery();                          // EXECUTES THE DELETE COMMAND
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "SQL Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                GetData(querySelection);
                dgvResult.Update();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (cboSearchBy.SelectedItem.ToString())
            {
                case "By First Name":
                    GetData($"select * from contacts where lower(first_name) like '%{txtSearch.Text.ToLower()}%'"); // % IN ANY POSITION
                    break;

                case "By Last Name":
                    GetData($"select * from contacts where lower(last_name) like '%{txtSearch.Text.ToLower()}%'");
                    break;

                case "By Company":
                    GetData($"select * from contacts where lower(company) like '%{txtSearch.Text.ToLower()}%'");

                    break;
            }

            if (dgvResult.Rows.Count == 1)
            {
                MessageBox.Show("No record found!", "Searching result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void pibUserImage_MouseClick(object sender, MouseEventArgs e)
        {
            var form = new Form();
            form.BackgroundImage = pibUserImage.Image;
            form.Size = pibUserImage.Image.Size;
            form.Show();
        }

        private void pibUserImage_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pibUserImage.Load(openFileDialog.FileName);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var streamWriter = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (DataGridViewRow row in dgvResult.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            streamWriter.Write(cell.Value);  
                        }

                        streamWriter.WriteLine();
                    }
                }

                Process.Start("notepad.exe", saveFileDialog.FileName);
            }
        }
    }
}
