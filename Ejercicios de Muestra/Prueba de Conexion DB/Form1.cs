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

namespace Prueba_de_Conexion_DB
{
    public partial class FormDataBaseTest : Form
    {
        public FormDataBaseTest()
        {
            InitializeComponent();
        }
        static string cadenaConexion = $"server= LAPTOP-JULIAN\\SQLEXPRESS ; database = master ; integrated security = true";
        SqlConnection connection = new SqlConnection(cadenaConexion);

        private void btnConect_Click(object sender, EventArgs e)
        {
            if (connection.State==ConnectionState.Open)
            {
                MessageBox.Show($"La conexion a {connection.Database} está abierta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                connection.Open();
                dgvUsuarios.DataSource=cargarDatos();
                MessageBox.Show($"La conexion a {connection.Database} a sido exitosa!");
            }
        }

        private void btnDisconect_Click(object sender, EventArgs e)
        {
            if (connection.State==ConnectionState.Closed)
            {
                MessageBox.Show($"La conexion a {connection.Database} ya ha sido cerrada previamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dgvUsuarios.DataSource = new DataTable();
                dgvUsuarios.Refresh();
                connection.Close();
                MessageBox.Show($"Se ha cerrado la conexion a {connection.Database} exitosamente!");
            }
        }

        private DataTable cargarDatos()
        {
            string solicitud = "select * from Usuarios";
            SqlCommand command = new SqlCommand(solicitud, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
