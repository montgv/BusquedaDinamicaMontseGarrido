namespace BusquedaDinamicaMontseGarrido
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.cbColumna = new System.Windows.Forms.ComboBox();
            this.lbBusqueda = new System.Windows.Forms.Label();
            this.lbColumna = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(39, 172);
            this.dgv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.Size = new System.Drawing.Size(746, 347);
            this.dgv.TabIndex = 0;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(39, 116);
            this.tbBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(362, 26);
            this.tbBuscar.TabIndex = 1;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(199, 18);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(388, 45);
            this.lbTitulo.TabIndex = 2;
            this.lbTitulo.Text = "Búsqueda dinámica DGV";
            // 
            // cbColumna
            // 
            this.cbColumna.FormattingEnabled = true;
            this.cbColumna.Location = new System.Drawing.Point(517, 116);
            this.cbColumna.Name = "cbColumna";
            this.cbColumna.Size = new System.Drawing.Size(268, 28);
            this.cbColumna.TabIndex = 3;
            this.cbColumna.SelectedIndexChanged += new System.EventHandler(this.cbColumna_SelectedIndexChanged);
            // 
            // lbBusqueda
            // 
            this.lbBusqueda.AutoSize = true;
            this.lbBusqueda.Location = new System.Drawing.Point(35, 82);
            this.lbBusqueda.Name = "lbBusqueda";
            this.lbBusqueda.Size = new System.Drawing.Size(191, 20);
            this.lbBusqueda.TabIndex = 4;
            this.lbBusqueda.Text = "Realiza aquí la búsqueda:";
            // 
            // lbColumna
            // 
            this.lbColumna.AutoSize = true;
            this.lbColumna.Location = new System.Drawing.Point(513, 82);
            this.lbColumna.Name = "lbColumna";
            this.lbColumna.Size = new System.Drawing.Size(272, 20);
            this.lbColumna.TabIndex = 5;
            this.lbColumna.Text = "Selecciona la columna donde buscar:";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 545);
            this.Controls.Add(this.lbColumna);
            this.Controls.Add(this.lbBusqueda);
            this.Controls.Add(this.cbColumna);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.dgv);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.ComboBox cbColumna;
        private System.Windows.Forms.Label lbBusqueda;
        private System.Windows.Forms.Label lbColumna;
    }
}

