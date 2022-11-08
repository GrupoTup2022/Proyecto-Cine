namespace FrontCine.Formularios
{
    partial class ComprobanteVenta
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
            this.label10 = new System.Windows.Forms.Label();
            this.cbo_promos = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_audio = new System.Windows.Forms.ComboBox();
            this.cbo_horario = new System.Windows.Forms.ComboBox();
            this.cbo_sala = new System.Windows.Forms.ComboBox();
            this.cbo_peli = new System.Windows.Forms.ComboBox();
            this.dgv_tickets = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreciosinDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuentoticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePromo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_comprobante = new System.Windows.Forms.Button();
            this.btn_pagos = new System.Windows.Forms.Button();
            this.btn_butacas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tickets)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(293, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 15);
            this.label10.TabIndex = 40;
            this.label10.Text = "Promo:";
            // 
            // cbo_promos
            // 
            this.cbo_promos.FormattingEnabled = true;
            this.cbo_promos.Location = new System.Drawing.Point(358, 109);
            this.cbo_promos.Name = "cbo_promos";
            this.cbo_promos.Size = new System.Drawing.Size(121, 23);
            this.cbo_promos.TabIndex = 39;
            this.cbo_promos.SelectedIndexChanged += new System.EventHandler(this.cbo_promos_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 38;
            this.label7.Text = "Tickets:";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(38, 34);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(41, 15);
            this.lbl_fecha.TabIndex = 37;
            this.lbl_fecha.Text = "Fecha:";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(97, 28);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(121, 23);
            this.dtp_fecha.TabIndex = 36;
            this.dtp_fecha.ValueChanged += new System.EventHandler(this.dtp_fecha_ValueChangedAsync);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "Sala:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Horario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Audio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Pelicula:";
            // 
            // cbo_audio
            // 
            this.cbo_audio.FormattingEnabled = true;
            this.cbo_audio.Location = new System.Drawing.Point(97, 109);
            this.cbo_audio.Name = "cbo_audio";
            this.cbo_audio.Size = new System.Drawing.Size(121, 23);
            this.cbo_audio.TabIndex = 31;
            this.cbo_audio.SelectedIndexChanged += new System.EventHandler(this.cbo_audio_SelectedIndexChanged_1);
            // 
            // cbo_horario
            // 
            this.cbo_horario.FormattingEnabled = true;
            this.cbo_horario.Location = new System.Drawing.Point(358, 26);
            this.cbo_horario.Name = "cbo_horario";
            this.cbo_horario.Size = new System.Drawing.Size(121, 23);
            this.cbo_horario.TabIndex = 30;
            this.cbo_horario.SelectedIndexChanged += new System.EventHandler(this.cbo_horario_SelectedIndexChanged_1);
            // 
            // cbo_sala
            // 
            this.cbo_sala.FormattingEnabled = true;
            this.cbo_sala.Location = new System.Drawing.Point(358, 68);
            this.cbo_sala.Name = "cbo_sala";
            this.cbo_sala.Size = new System.Drawing.Size(121, 23);
            this.cbo_sala.TabIndex = 29;
            this.cbo_sala.SelectedIndexChanged += new System.EventHandler(this.cbo_sala_SelectedIndexChanged_1);
            // 
            // cbo_peli
            // 
            this.cbo_peli.FormattingEnabled = true;
            this.cbo_peli.Location = new System.Drawing.Point(97, 68);
            this.cbo_peli.Name = "cbo_peli";
            this.cbo_peli.Size = new System.Drawing.Size(121, 23);
            this.cbo_peli.TabIndex = 28;
            this.cbo_peli.SelectedIndexChanged += new System.EventHandler(this.cbo_peli_SelectedIndexChanged_1);
            // 
            // dgv_tickets
            // 
            this.dgv_tickets.AllowUserToAddRows = false;
            this.dgv_tickets.AllowUserToDeleteRows = false;
            this.dgv_tickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.salaticket,
            this.horarioticket,
            this.tituloTicket,
            this.PreciosinDescuento,
            this.Descuentoticket,
            this.NombrePromo,
            this.PrecioTicket});
            this.dgv_tickets.Location = new System.Drawing.Point(28, 207);
            this.dgv_tickets.Name = "dgv_tickets";
            this.dgv_tickets.ReadOnly = true;
            this.dgv_tickets.RowTemplate.Height = 25;
            this.dgv_tickets.Size = new System.Drawing.Size(732, 197);
            this.dgv_tickets.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Numero de Butaca";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // salaticket
            // 
            this.salaticket.HeaderText = "Sala";
            this.salaticket.Name = "salaticket";
            this.salaticket.ReadOnly = true;
            // 
            // horarioticket
            // 
            this.horarioticket.HeaderText = "Horario";
            this.horarioticket.Name = "horarioticket";
            this.horarioticket.ReadOnly = true;
            // 
            // tituloTicket
            // 
            this.tituloTicket.HeaderText = "Titulo";
            this.tituloTicket.Name = "tituloTicket";
            this.tituloTicket.ReadOnly = true;
            // 
            // PreciosinDescuento
            // 
            this.PreciosinDescuento.HeaderText = "Precio sin descuento";
            this.PreciosinDescuento.Name = "PreciosinDescuento";
            this.PreciosinDescuento.ReadOnly = true;
            // 
            // Descuentoticket
            // 
            this.Descuentoticket.HeaderText = "Descuento";
            this.Descuentoticket.Name = "Descuentoticket";
            this.Descuentoticket.ReadOnly = true;
            // 
            // NombrePromo
            // 
            this.NombrePromo.HeaderText = "Promo";
            this.NombrePromo.Name = "NombrePromo";
            this.NombrePromo.ReadOnly = true;
            // 
            // PrecioTicket
            // 
            this.PrecioTicket.HeaderText = "PrecioFinal";
            this.PrecioTicket.Name = "PrecioTicket";
            this.PrecioTicket.ReadOnly = true;
            // 
            // btn_comprobante
            // 
            this.btn_comprobante.Location = new System.Drawing.Point(671, 26);
            this.btn_comprobante.Name = "btn_comprobante";
            this.btn_comprobante.Size = new System.Drawing.Size(89, 41);
            this.btn_comprobante.TabIndex = 41;
            this.btn_comprobante.Text = "Terminar Comprobante";
            this.btn_comprobante.UseVisualStyleBackColor = true;
            // 
            // btn_pagos
            // 
            this.btn_pagos.Location = new System.Drawing.Point(671, 122);
            this.btn_pagos.Name = "btn_pagos";
            this.btn_pagos.Size = new System.Drawing.Size(85, 41);
            this.btn_pagos.TabIndex = 42;
            this.btn_pagos.Text = "Agregar Pagos";
            this.btn_pagos.UseVisualStyleBackColor = true;
            this.btn_pagos.Click += new System.EventHandler(this.btn_pagos_Click);
            // 
            // btn_butacas
            // 
            this.btn_butacas.Location = new System.Drawing.Point(549, 71);
            this.btn_butacas.Name = "btn_butacas";
            this.btn_butacas.Size = new System.Drawing.Size(85, 41);
            this.btn_butacas.TabIndex = 43;
            this.btn_butacas.Text = "Elegir butacas";
            this.btn_butacas.UseVisualStyleBackColor = true;
            this.btn_butacas.Click += new System.EventHandler(this.btn_butacas_Click);
            // 
            // ComprobanteVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_butacas);
            this.Controls.Add(this.btn_pagos);
            this.Controls.Add(this.btn_comprobante);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbo_promos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_audio);
            this.Controls.Add(this.cbo_horario);
            this.Controls.Add(this.cbo_sala);
            this.Controls.Add(this.cbo_peli);
            this.Controls.Add(this.dgv_tickets);
            this.Name = "ComprobanteVenta";
            this.Text = "ComprobanteVenta";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label10;
        private ComboBox cbo_promos;
        private Label label7;
        private Label lbl_fecha;
        private DateTimePicker dtp_fecha;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbo_audio;
        private ComboBox cbo_horario;
        private ComboBox cbo_sala;
        private ComboBox cbo_peli;
        private DataGridView dgv_tickets;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn salaticket;
        private DataGridViewTextBoxColumn horarioticket;
        private DataGridViewTextBoxColumn tituloTicket;
        private DataGridViewTextBoxColumn PreciosinDescuento;
        private DataGridViewTextBoxColumn Descuentoticket;
        private DataGridViewTextBoxColumn NombrePromo;
        private DataGridViewTextBoxColumn PrecioTicket;
        private Button btn_comprobante;
        private Button btn_pagos;
        private Button btn_butacas;
    }
}