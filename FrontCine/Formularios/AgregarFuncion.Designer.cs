namespace FrontCine.Formularios
{
    partial class AgregarFuncion
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
            this.label1 = new System.Windows.Forms.Label();
            this.CBpeliculas = new System.Windows.Forms.ComboBox();
            this.CBhorarios = new System.Windows.Forms.ComboBox();
            this.CBaudios = new System.Windows.Forms.ComboBox();
            this.CBsalas = new System.Windows.Forms.ComboBox();
            this.TXTprecio = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTNcancelar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Creacion de funcion";
            // 
            // CBpeliculas
            // 
            this.CBpeliculas.FormattingEnabled = true;
            this.CBpeliculas.Location = new System.Drawing.Point(40, 52);
            this.CBpeliculas.Name = "CBpeliculas";
            this.CBpeliculas.Size = new System.Drawing.Size(146, 23);
            this.CBpeliculas.TabIndex = 1;
            this.CBpeliculas.SelectedIndexChanged += new System.EventHandler(this.CBpeliculas_SelectedIndexChanged);
            // 
            // CBhorarios
            // 
            this.CBhorarios.FormattingEnabled = true;
            this.CBhorarios.Location = new System.Drawing.Point(214, 52);
            this.CBhorarios.Name = "CBhorarios";
            this.CBhorarios.Size = new System.Drawing.Size(121, 23);
            this.CBhorarios.TabIndex = 2;
            // 
            // CBaudios
            // 
            this.CBaudios.FormattingEnabled = true;
            this.CBaudios.Location = new System.Drawing.Point(354, 52);
            this.CBaudios.Name = "CBaudios";
            this.CBaudios.Size = new System.Drawing.Size(121, 23);
            this.CBaudios.TabIndex = 3;
            // 
            // CBsalas
            // 
            this.CBsalas.FormattingEnabled = true;
            this.CBsalas.Location = new System.Drawing.Point(495, 52);
            this.CBsalas.Name = "CBsalas";
            this.CBsalas.Size = new System.Drawing.Size(121, 23);
            this.CBsalas.TabIndex = 4;
            // 
            // TXTprecio
            // 
            this.TXTprecio.Location = new System.Drawing.Point(701, 52);
            this.TXTprecio.Name = "TXTprecio";
            this.TXTprecio.Size = new System.Drawing.Size(108, 23);
            this.TXTprecio.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(815, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 23);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pelicula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Horario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Audio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sala";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(701, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Precio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(809, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fecha de la funcion";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(40, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(888, 82);
            this.dataGridView1.TabIndex = 13;
            // 
            // column1
            // 
            this.column1.HeaderText = "Pelicula";
            this.column1.Name = "column1";
            this.column1.ReadOnly = true;
            this.column1.Width = 180;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Horario";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 140;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Audio";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 140;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Sala";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 140;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Precio";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 140;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Fecha de la funcion";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 130;
            // 
            // BTNcancelar
            // 
            this.BTNcancelar.Location = new System.Drawing.Point(862, 221);
            this.BTNcancelar.Name = "BTNcancelar";
            this.BTNcancelar.Size = new System.Drawing.Size(75, 23);
            this.BTNcancelar.TabIndex = 14;
            this.BTNcancelar.Text = "Cancelar";
            this.BTNcancelar.UseVisualStyleBackColor = true;
            this.BTNcancelar.Click += new System.EventHandler(this.BTNcancelar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(791, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 28);
            this.button2.TabIndex = 15;
            this.button2.Text = "Agregar Funcion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AgregarFuncion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 256);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BTNcancelar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TXTprecio);
            this.Controls.Add(this.CBsalas);
            this.Controls.Add(this.CBaudios);
            this.Controls.Add(this.CBhorarios);
            this.Controls.Add(this.CBpeliculas);
            this.Controls.Add(this.label1);
            this.Name = "AgregarFuncion";
            this.Text = "AgregarFuncion";
            this.Load += new System.EventHandler(this.AgregarFuncion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox CBpeliculas;
        private ComboBox CBhorarios;
        private ComboBox CBaudios;
        private ComboBox CBsalas;
        private TextBox TXTprecio;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button BTNcancelar;
        private Button button2;
    }
}