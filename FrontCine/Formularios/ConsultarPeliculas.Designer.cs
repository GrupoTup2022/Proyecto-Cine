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
            this.dgvPeliculasActivas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distribuidora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clasificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvPeliculasBajas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculasActivas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculasBajas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPeliculasActivas
            // 
            this.dgvPeliculasActivas.AllowUserToAddRows = false;
            this.dgvPeliculasActivas.AllowUserToDeleteRows = false;
            this.dgvPeliculasActivas.AllowUserToOrderColumns = true;
            this.dgvPeliculasActivas.AllowUserToResizeColumns = false;
            this.dgvPeliculasActivas.AllowUserToResizeRows = false;
            this.dgvPeliculasActivas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPeliculasActivas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculasActivas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Titulo,
            this.Duracion,
            this.fecha,
            this.Pais,
            this.Director,
            this.distribuidora,
            this.Clasificacion,
            this.Genero,
            this.Column1,
            this.Editar});
            this.dgvPeliculasActivas.Location = new System.Drawing.Point(49, 216);
            this.dgvPeliculasActivas.Name = "dgvPeliculasActivas";
            this.dgvPeliculasActivas.ReadOnly = true;
            this.dgvPeliculasActivas.RowHeadersVisible = false;
            this.dgvPeliculasActivas.RowHeadersWidth = 51;
            this.dgvPeliculasActivas.RowTemplate.Height = 29;
            this.dgvPeliculasActivas.Size = new System.Drawing.Size(1283, 411);
            this.dgvPeliculasActivas.TabIndex = 18;
            this.dgvPeliculasActivas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeliculasActivas_CellContentClick);
            // 
            // Id
            // 
            this.Id.FillWeight = 106.9519F;
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Titulo
            // 
            this.Titulo.FillWeight = 99.22757F;
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.MinimumWidth = 6;
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // Duracion
            // 
            this.Duracion.FillWeight = 99.22757F;
            this.Duracion.HeaderText = "Duracion";
            this.Duracion.MinimumWidth = 6;
            this.Duracion.Name = "Duracion";
            this.Duracion.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.FillWeight = 99.22757F;
            this.fecha.HeaderText = "Fecha de Estreno";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // Pais
            // 
            this.Pais.FillWeight = 99.22757F;
            this.Pais.HeaderText = "Pais";
            this.Pais.MinimumWidth = 6;
            this.Pais.Name = "Pais";
            this.Pais.ReadOnly = true;
            // 
            // Director
            // 
            this.Director.FillWeight = 99.22757F;
            this.Director.HeaderText = "Director";
            this.Director.MinimumWidth = 6;
            this.Director.Name = "Director";
            this.Director.ReadOnly = true;
            // 
            // distribuidora
            // 
            this.distribuidora.FillWeight = 99.22757F;
            this.distribuidora.HeaderText = "Distribuidora";
            this.distribuidora.MinimumWidth = 6;
            this.distribuidora.Name = "distribuidora";
            this.distribuidora.ReadOnly = true;
            // 
            // Clasificacion
            // 
            this.Clasificacion.FillWeight = 99.22757F;
            this.Clasificacion.HeaderText = "Clasificacion";
            this.Clasificacion.MinimumWidth = 6;
            this.Clasificacion.Name = "Clasificacion";
            this.Clasificacion.ReadOnly = true;
            // 
            // Genero
            // 
            this.Genero.FillWeight = 99.22757F;
            this.Genero.HeaderText = "Genero";
            this.Genero.MinimumWidth = 6;
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 99.22757F;
            this.Column1.HeaderText = "Acciones";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "Desabilitar";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            // 
            // dgvPeliculasBajas
            // 
            this.dgvPeliculasBajas.AllowUserToAddRows = false;
            this.dgvPeliculasBajas.AllowUserToDeleteRows = false;
            this.dgvPeliculasBajas.AllowUserToOrderColumns = true;
            this.dgvPeliculasBajas.AllowUserToResizeColumns = false;
            this.dgvPeliculasBajas.AllowUserToResizeRows = false;
            this.dgvPeliculasBajas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPeliculasBajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculasBajas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewButtonColumn2,
            this.dataGridViewButtonColumn1});
            this.dgvPeliculasBajas.Location = new System.Drawing.Point(49, 216);
            this.dgvPeliculasBajas.Name = "dgvPeliculasBajas";
            this.dgvPeliculasBajas.ReadOnly = true;
            this.dgvPeliculasBajas.RowHeadersVisible = false;
            this.dgvPeliculasBajas.RowHeadersWidth = 51;
            this.dgvPeliculasBajas.RowTemplate.Height = 29;
            this.dgvPeliculasBajas.Size = new System.Drawing.Size(1283, 411);
            this.dgvPeliculasBajas.TabIndex = 19;
            this.dgvPeliculasBajas.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 106.9519F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 99.22757F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 99.22757F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Duracion";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 99.22757F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Fecha de Estreno";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.FillWeight = 99.22757F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Pais";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.FillWeight = 99.22757F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Director";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.FillWeight = 99.22757F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Distribuidora";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.FillWeight = 99.22757F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Clasificacion";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.FillWeight = 99.22757F;
            this.dataGridViewTextBoxColumn9.HeaderText = "Genero";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.FillWeight = 99.22757F;
            this.dataGridViewButtonColumn2.HeaderText = "Acciones";
            this.dataGridViewButtonColumn2.MinimumWidth = 6;
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.ReadOnly = true;
            this.dataGridViewButtonColumn2.Text = "Desabilitar";
            this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Editar";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Text = "Editar";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // ConsultarPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 710);
            this.Controls.Add(this.dgvPeliculasBajas);
            this.Controls.Add(this.dgvPeliculasActivas);
            this.Name = "ConsultarPeliculas";
            this.Text = "Peliculas";
            this.Load += new System.EventHandler(this.ConsultarPeliculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculasActivas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculasBajas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvPeliculasActivas;
        private DataGridView dgvPeliculasBajas;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn Duracion;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn Pais;
        private DataGridViewTextBoxColumn Director;
        private DataGridViewTextBoxColumn distribuidora;
        private DataGridViewTextBoxColumn Clasificacion;
        private DataGridViewTextBoxColumn Genero;
        private DataGridViewButtonColumn Column1;
        private DataGridViewButtonColumn Editar;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewButtonColumn dataGridViewButtonColumn2;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
    }
}