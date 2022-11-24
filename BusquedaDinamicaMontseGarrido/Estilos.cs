using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusquedaDinamicaMontseGarrido
{
    class Estilos
    {
        private DataGridView formulario;

        public Estilos(DataGridView dataGridView)
        {
            this.formulario = dataGridView;
        }

        /*
         * En esta función estamos definiendo el estilo de todas las filas del datagridview
         */
        public void definirFilas(String colorLetra, String colorFondo, String colorSeleccionado,
            String valorPorDefecto, int tamanioFuente = 11, String fuente = "Comic Sans MS")
        {
            ColorConverter converter = new ColorConverter();

            DataGridViewCellStyle estiloFila;
            estiloFila = new DataGridViewCellStyle();
            estiloFila.BackColor = (Color)converter.ConvertFromString(colorLetra);
            estiloFila.ForeColor = (Color)converter.ConvertFromString(colorFondo);
            estiloFila.Alignment = DataGridViewContentAlignment.MiddleCenter;
            estiloFila.Font = new Font(fuente, tamanioFuente, FontStyle.Bold);
            estiloFila.NullValue = valorPorDefecto;
            estiloFila.SelectionBackColor = (Color)converter.ConvertFromString(colorSeleccionado);

            formulario.DefaultCellStyle = estiloFila;
            formulario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        /*
         * En esta función estamos definiendo el estilo de la cabecera del datagridview
         */
        public void definirCabecera(String colorLetra, String colorFondo, int tamanioFuente = 12,
            String fuente = "Comic Sans MS")
        {
            ColorConverter converter = new ColorConverter();

            DataGridViewCellStyle estiloCabecera;
            estiloCabecera = new DataGridViewCellStyle();
            estiloCabecera.BackColor = (Color)converter.ConvertFromString(colorLetra);
            estiloCabecera.ForeColor = (Color)converter.ConvertFromString(colorFondo);
            estiloCabecera.Alignment = DataGridViewContentAlignment.MiddleCenter;
            estiloCabecera.Font = new Font(fuente, tamanioFuente, FontStyle.Bold);

            formulario.ColumnHeadersDefaultCellStyle = estiloCabecera;
            formulario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            formulario.ColumnHeadersHeight = 50;
            formulario.EnableHeadersVisualStyles = false;
        }

        /*
         * En esta función estamos definiendo el estilo de las filas alternas del datagridview
         */
        public void definirFilarAlternas(String colorLetra, String colorFondo, String valorPorDefecto,
            int tamanioFuente = 11, String fuente = "Comic Sans MS")
        {
            ColorConverter converter = new ColorConverter();

            DataGridViewCellStyle estiloAlterno;
            estiloAlterno = new DataGridViewCellStyle();
            estiloAlterno.BackColor = (Color)converter.ConvertFromString(colorLetra);
            estiloAlterno.ForeColor = (Color)converter.ConvertFromString(colorFondo);
            estiloAlterno.Font = new Font(fuente, tamanioFuente, FontStyle.Bold);
            estiloAlterno.NullValue = valorPorDefecto;

            formulario.AlternatingRowsDefaultCellStyle = estiloAlterno;
        }
    }
}
