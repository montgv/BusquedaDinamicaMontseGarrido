using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusquedaDinamicaMontseGarrido
{
    public partial class FormPrincipal : Form
    {
        string cadenaConexion = "server=localhost; database=Montse; user id=sa; password=oretania";

        public FormPrincipal()
        {
            InitializeComponent();

            //Cambiamos el color de fondo, el color y el tipo de la letra al formulario
            BackColor = Color.FromArgb(184, 240, 237);
            ForeColor = Color.FromArgb(222, 120, 125);
            Font = new Font("Comic Sans MS", 11, FontStyle.Bold);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conectar();

            aniadirColumnasComboBox();

            Estilos estilo = new Estilos(this.dgv);

            //Introducimos los diferetentes estilos
            estilo.definirFilas("#7adcd5", "#b8575e", "#50b4ad", "----------");
            estilo.definirCabecera("#7adcd5", "#50b4ad");
            estilo.definirFilarAlternas("#de787d", "#7adcd5", "**********");

            //Ajustamos el tamño de todas las columnas
            foreach (DataGridViewColumn dgvColumna in this.dgv.Columns)
            {
                dgvColumna.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }

        //Añadimos la columnas al comboBox
        private void aniadirColumnasComboBox()
        {
            foreach (DataGridViewColumn columna in dgv.Columns)
            {
                cbColumna.Items.Add(columna.HeaderText);
            }
            cbColumna.SelectedIndex = 0;
        }

        //Conectamos con la base de datos
        public void conectar()
        {
            string sentencia = "SELECT * FROM formulario";

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

        //Evento que al cambiar el texto del textBox filtra por rowFilter
        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            consultarRowFilter();
        }

        //Filtro rowFilter
        private void consultarRowFilter()
        {
            string sentencia = "SELECT * FROM formulario";

            SqlConnection conexion = new SqlConnection(cadenaConexion);

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(sentencia, conexion);
                SqlDataReader dataReader = comando.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dataReader);

                dt.DefaultView.RowFilter = string.Format(cbColumna.Text + " LIKE '{0}'", tbBuscar.Text);

                dgv.DataSource = dt;
                comando.Dispose();
                conexion.Close();

            }
            catch (SqlException e)
            {
                MessageBox.Show("No se puede realizar la conexión del RowFilter.");
            }
        }

        //Evento que al seleccionar un item del comboBox filtra por rowFilter
        private void cbColumna_SelectedIndexChanged(object sender, EventArgs e)
        {
            consultarRowFilter();
        }
    }
}
