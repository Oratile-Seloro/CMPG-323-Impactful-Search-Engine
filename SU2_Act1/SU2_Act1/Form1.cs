using System; //Oratile Seloro 35834609
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SU2_Act1
{
    public partial class frmSQLDatabase : Form
    {
        SqlConnection Connection;
        public frmSQLDatabase()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string connectionString;
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\OneDrive\\Documents\\SU2_Act1.mdf;Integrated Security=True;Connect Timeout=30";
            Connection = new SqlConnection(connectionString);

            Connection.Open();
            MessageBox.Show("Connected Successfully");

            Connection.Close();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string connectionString;
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\OneDrive\\Documents\\SU2_Act1.mdf;Integrated Security=True;Connect Timeout=30";
            Connection = new SqlConnection(connectionString);

            Connection.Open();

            SqlCommand command;
            string sqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter();

            sqlCommand = @"Select * FROM ClientList";
            command = new SqlCommand(sqlCommand, Connection);

            DataSet ds = new DataSet();

            adapter.SelectCommand = command;
            adapter.Fill(ds, "ClientList");

            dgvClientList.DataSource = ds;
            dgvClientList.DataMember = "ClientList";

            Connection.Close();
        }

        private void btnMoveData_Click(object sender, EventArgs e)
        {
            lstClientList.Items.Clear();
            lstClientList.Items.Add(string.Format("{0, -10}{1, -20}{2, -20}{3, -20}", "ID", "Name", "Surname", "Email"));
            lstClientList.Items.Add("----------------------------------------------------------------------------------");

            string connectionString;
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\OneDrive\\Documents\\SU2_Act1.mdf;Integrated Security=True;Connect Timeout=30";
            Connection = new SqlConnection(connectionString);

            Connection.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            string sql;

            sql = "Select * FROM ClientList";

            command = new SqlCommand(sql, Connection);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                lstClientList.Items.Add(string.Format("{0, -10}{1, -20}{2, -20}{3, -20}", dataReader.GetValue(0), dataReader.GetValue(1), dataReader.GetValue(2), dataReader.GetValue(3)));
            }

            dataReader.Close();
            command.Dispose();
            Connection.Close();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
