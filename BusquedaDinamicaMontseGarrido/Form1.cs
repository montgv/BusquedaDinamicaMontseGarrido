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

namespace BusquedaDinamicaMontseGarrido
{
    public partial class Form1 : Form
    {
        string cadenaConexion = "Server = localhost; Database = Montse; User Id = sa; Password = oretania";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conectar();
        }

        public void conectar()
        {
            string sentencia = "SELECT * FROM ";

            SqlConnection conexion = new SqlConnection(cadenaConexion);

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(sentencia, conexion);
                SqlDataReader dataReader = comando.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dataReader);
                dgv.DataSource = dt;
                comando.Dispose();
                conexion.Close();

            } catch (SqlException e)
            {
                MessageBox.Show("No se puede realizar la conexión.");
            }
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            consultarRowFilter();
        }

        private void consultarRowFilter()
        {
            string sentencia = "SELECT * FROM ";

            SqlConnection conexion = new SqlConnection(cadenaConexion);

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(sentencia, conexion);
                SqlDataReader dataReader = comando.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dataReader);

                dt.DefaultView.RowFilter = string.Format(" LIKE '{0}'", tbBuscar.Text);

                dgv.DataSource = dt;
                comando.Dispose();
                conexion.Close();

            }
            catch (SqlException e)
            {
                MessageBox.Show("No se puede realizar la conexión del RowFilter.");
            }
        }
    }
}
