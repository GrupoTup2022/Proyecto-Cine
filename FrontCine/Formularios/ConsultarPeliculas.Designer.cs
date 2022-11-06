namespace FrontCine.Formularios
{
    partial class ConsultarPeliculas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clasificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPeliculas
            // 
            this.dgvPeliculas.AllowUserToAddRows = false;
            this.dgvPeliculas.AllowUserToDeleteRows = false;
            this.dgvPeliculas.AllowUserToOrderColumns = true;
            this.dgvPeliculas.AllowUserToResizeColumns = false;
            this.dgvPeliculas.AllowUserToResizeRows = false;
            this.dgvPeliculas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Titulo,
            this.Duracion,
            this.Clasificacion,
            this.Genero});
            this.dgvPeliculas.Location = new System.Drawing.Point(47, 125);
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.RowHeadersVisible = false;
            this.dgvPeliculas.RowHeadersWidth = 51;
            this.dgvPeliculas.RowTemplate.Height = 29;
            this.dgvPeliculas.Size = new System.Drawing.Size(984, 452);
            this.dgvPeliculas.TabIndex = 18;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.MinimumWidth = 6;
            this.Titulo.Name = "Titulo";
            // 
            // Duracion
            // 
            this.Duracion.HeaderText = "Duracion";
            this.Duracion.MinimumWidth = 6;
            this.Duracion.Name = "Duracion";
            // 
            // Clasificacion
            // 
            this.Clasificacion.HeaderText = "Clasificacion";
            this.Clasificacion.MinimumWidth = 6;
            this.Clasificacion.Name = "Clasificacion";
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.MinimumWidth = 6;
            this.Genero.Name = "Genero";
            // 
            // ConsultarPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 608);
            this.Controls.Add(this.dgvPeliculas);
            this.Name = "ConsultarPeliculas";
            this.Text = "Peliculas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvPeliculas;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn Duracion;
        private DataGridViewTextBoxColumn Clasificacion;
        private DataGridViewTextBoxColumn Genero;
    }
}