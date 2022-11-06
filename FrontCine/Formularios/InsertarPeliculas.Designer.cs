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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboPaises
            // 
            this.cboPaises.FormattingEnabled = true;
            this.cboPaises.Location = new System.Drawing.Point(51, 208);
            this.cboPaises.Name = "cboPaises";
            this.cboPaises.Size = new System.Drawing.Size(151, 28);
            this.cboPaises.TabIndex = 1;
            // 
            // cboClasificaciones
            // 
            this.cboClasificaciones.FormattingEnabled = true;
            this.cboClasificaciones.Location = new System.Drawing.Point(51, 153);
            this.cboClasificaciones.Name = "cboClasificaciones";
            this.cboClasificaciones.Size = new System.Drawing.Size(151, 28);
            this.cboClasificaciones.TabIndex = 2;
            // 
            // cboDistribuidoras
            // 
            this.cboDistribuidoras.FormattingEnabled = true;
            this.cboDistribuidoras.Location = new System.Drawing.Point(51, 95);
            this.cboDistribuidoras.Name = "cboDistribuidoras";
            this.cboDistribuidoras.Size = new System.Drawing.Size(151, 28);
            this.cboDistribuidoras.TabIndex = 3;
            // 
            // cboDirectores
            // 
            this.cboDirectores.FormattingEnabled = true;
            this.cboDirectores.Location = new System.Drawing.Point(51, 270);
            this.cboDirectores.Name = "cboDirectores";
            this.cboDirectores.Size = new System.Drawing.Size(151, 28);
            this.cboDirectores.TabIndex = 4;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(284, 42);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(265, 27);
            this.txtTitulo.TabIndex = 5;
            // 
            // cboGeneros
            // 
            this.cboGeneros.FormattingEnabled = true;
            this.cboGeneros.Location = new System.Drawing.Point(51, 41);
            this.cboGeneros.Name = "cboGeneros";
            this.cboGeneros.Size = new System.Drawing.Size(151, 28);
            this.cboGeneros.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(284, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(284, 167);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(265, 27);
            this.txtDuracion.TabIndex = 8;
            // 
            // InsertarPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 590);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.cboDirectores);
            this.Controls.Add(this.cboDistribuidoras);
            this.Controls.Add(this.cboClasificaciones);
            this.Controls.Add(this.cboPaises);
            this.Controls.Add(this.cboGeneros);
            this.Name = "InsertarPeliculas";
            this.Text = "InsertarPeliculas";
            this.Load += new System.EventHandler(this.InsertarPeliculas_Load);
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
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private TextBox txtDuracion;
    }
}