namespace FrontCine.Formularios
{
    partial class Funciones
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
            this.CBpeliculas = new System.Windows.Forms.ComboBox();
            this.DTPfecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BTNconsultarFuncion = new System.Windows.Forms.Button();
            this.BTNsalir = new System.Windows.Forms.Button();
            this.BTNagregarFuncion = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CBpeliculas
            // 
            this.CBpeliculas.FormattingEnabled = true;
            this.CBpeliculas.Location = new System.Drawing.Point(12, 76);
            this.CBpeliculas.Name = "CBpeliculas";
            this.CBpeliculas.Size = new System.Drawing.Size(208, 23);
            this.CBpeliculas.TabIndex = 0;
            this.CBpeliculas.SelectedIndexChanged += new System.EventHandler(this.CBpeliculas_SelectedIndexChanged);
            // 
            // DTPfecha
            // 
            this.DTPfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPfecha.Location = new System.Drawing.Point(12, 151);
            this.DTPfecha.Name = "DTPfecha";
            this.DTPfecha.Size = new System.Drawing.Size(100, 23);
            this.DTPfecha.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Peliculas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // BTNconsultarFuncion
            // 
            this.BTNconsultarFuncion.Location = new System.Drawing.Point(12, 192);
            this.BTNconsultarFuncion.Name = "BTNconsultarFuncion";
            this.BTNconsultarFuncion.Size = new System.Drawing.Size(75, 23);
            this.BTNconsultarFuncion.TabIndex = 13;
            this.BTNconsultarFuncion.Text = "Consultar funcion";
            this.BTNconsultarFuncion.UseVisualStyleBackColor = true;
            this.BTNconsultarFuncion.Click += new System.EventHandler(this.BTNconsultarFuncion_Click);
            // 
            // BTNsalir
            // 
            this.BTNsalir.Location = new System.Drawing.Point(1082, 518);
            this.BTNsalir.Name = "BTNsalir";
            this.BTNsalir.Size = new System.Drawing.Size(75, 23);
            this.BTNsalir.TabIndex = 14;
            this.BTNsalir.Text = "Salir";
            this.BTNsalir.UseVisualStyleBackColor = true;
            this.BTNsalir.Click += new System.EventHandler(this.BTNsalir_Click);
            // 
            // BTNagregarFuncion
            // 
            this.BTNagregarFuncion.Location = new System.Drawing.Point(992, 35);
            this.BTNagregarFuncion.Name = "BTNagregarFuncion";
            this.BTNagregarFuncion.Size = new System.Drawing.Size(116, 35);
            this.BTNagregarFuncion.TabIndex = 15;
            this.BTNagregarFuncion.Text = "Agregar Funcion";
            this.BTNagregarFuncion.UseVisualStyleBackColor = true;
            this.BTNagregarFuncion.Click += new System.EventHandler(this.BTNagregarFuncion_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(264, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(893, 383);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID DE LA FUNCION";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NOMBRE DE LA PELICULA";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 180;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "HORARIO DE LA FUNCION";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "AUDIO";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "SALA";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "PRECIO";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "FECHA";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "DAR DE BAJA";
            this.Column8.Name = "Column8";
            this.Column8.Text = "DAR DE BAJA";
            this.Column8.UseColumnTextForButtonValue = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Funciones";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 47);
            this.button1.TabIndex = 18;
            this.button1.Text = "Cargar todas las funciones";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Funciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 556);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTNagregarFuncion);
            this.Controls.Add(this.BTNsalir);
            this.Controls.Add(this.BTNconsultarFuncion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTPfecha);
            this.Controls.Add(this.CBpeliculas);
            this.Name = "Funciones";
            this.Text = "InsertarFuncion";
            this.Load += new System.EventHandler(this.Funciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox CBpeliculas;
        private DateTimePicker DTPfecha;
        private Label label1;
        private Label label5;
        private Button BTNconsultarFuncion;
        private Button BTNsalir;
        private Button BTNagregarFuncion;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewButtonColumn Column8;
        private Label label7;
        private Button button1;
    }
}