namespace FrontCine.Formularios
{
    partial class InsertarPeliculas
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
            this.cboPaises = new System.Windows.Forms.ComboBox();
            this.cboClasificaciones = new System.Windows.Forms.ComboBox();
            this.cboDistribuidoras = new System.Windows.Forms.ComboBox();
            this.cboDirectores = new System.Windows.Forms.ComboBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.cboGeneros = new System.Windows.Forms.ComboBox();
            this.dtpEstreno = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clasificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // cboPaises
            // 
            this.cboPaises.FormattingEnabled = true;
            this.cboPaises.Location = new System.Drawing.Point(198, 292);
            this.cboPaises.Name = "cboPaises";
            this.cboPaises.Size = new System.Drawing.Size(151, 28);
            this.cboPaises.TabIndex = 1;
            // 
            // cboClasificaciones
            // 
            this.cboClasificaciones.FormattingEnabled = true;
            this.cboClasificaciones.Location = new System.Drawing.Point(198, 469);
            this.cboClasificaciones.Name = "cboClasificaciones";
            this.cboClasificaciones.Size = new System.Drawing.Size(151, 28);
            this.cboClasificaciones.TabIndex = 2;
            // 
            // cboDistribuidoras
            // 
            this.cboDistribuidoras.FormattingEnabled = true;
            this.cboDistribuidoras.Location = new System.Drawing.Point(198, 229);
            this.cboDistribuidoras.Name = "cboDistribuidoras";
            this.cboDistribuidoras.Size = new System.Drawing.Size(151, 28);
            this.cboDistribuidoras.TabIndex = 3;
            // 
            // cboDirectores
            // 
            this.cboDirectores.FormattingEnabled = true;
            this.cboDirectores.Location = new System.Drawing.Point(198, 346);
            this.cboDirectores.Name = "cboDirectores";
            this.cboDirectores.Size = new System.Drawing.Size(151, 28);
            this.cboDirectores.TabIndex = 4;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(198, 39);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(265, 27);
            this.txtTitulo.TabIndex = 5;
            // 
            // cboGeneros
            // 
            this.cboGeneros.FormattingEnabled = true;
            this.cboGeneros.Location = new System.Drawing.Point(198, 406);
            this.cboGeneros.Name = "cboGeneros";
            this.cboGeneros.Size = new System.Drawing.Size(151, 28);
            this.cboGeneros.TabIndex = 0;
            // 
            // dtpEstreno
            // 
            this.dtpEstreno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEstreno.Location = new System.Drawing.Point(198, 100);
            this.dtpEstreno.Name = "dtpEstreno";
            this.dtpEstreno.Size = new System.Drawing.Size(250, 27);
            this.dtpEstreno.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(958, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cargar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(198, 169);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(80, 27);
            this.txtDuracion.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Distribuidora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pais";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Director";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Genero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Clasificacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Titulo ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Fecha de Estreno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Duracion";
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
            this.dgvPeliculas.Location = new System.Drawing.Point(405, 156);
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.RowHeadersVisible = false;
            this.dgvPeliculas.RowHeadersWidth = 51;
            this.dgvPeliculas.RowTemplate.Height = 29;
            this.dgvPeliculas.Size = new System.Drawing.Size(674, 341);
            this.dgvPeliculas.TabIndex = 17;
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
            // InsertarPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 610);
            this.Controls.Add(this.dgvPeliculas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpEstreno);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.cboDirectores);
            this.Controls.Add(this.cboDistribuidoras);
            this.Controls.Add(this.cboClasificaciones);
            this.Controls.Add(this.cboPaises);
            this.Controls.Add(this.cboGeneros);
            this.Name = "InsertarPeliculas";
            this.Text = "InsertarPeliculas";
            this.Load += new System.EventHandler(this.InsertarPeliculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox cboPaises;
        private ComboBox cboClasificaciones;
        private ComboBox cboDistribuidoras;
        private ComboBox cboDirectores;
        private TextBox txtTitulo;
        private ComboBox cboGeneros;
        private DateTimePicker dtpEstreno;
        private Button button1;
        private TextBox txtDuracion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DataGridView dgvPeliculas;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn Duracion;
        private DataGridViewTextBoxColumn Clasificacion;
        private DataGridViewTextBoxColumn Genero;
    }
}