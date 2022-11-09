namespace FrontCine.Formularios
{
    partial class PagosForm
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
            this.btn_terminar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_restante = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_lista = new System.Windows.Forms.DataGridView();
            this.FP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_monto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_fp = new System.Windows.Forms.ComboBox();
            this.barrasuperior = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista)).BeginInit();
            this.barrasuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_terminar
            // 
            this.btn_terminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_terminar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_terminar.Location = new System.Drawing.Point(390, 411);
            this.btn_terminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_terminar.Name = "btn_terminar";
            this.btn_terminar.Size = new System.Drawing.Size(107, 42);
            this.btn_terminar.TabIndex = 21;
            this.btn_terminar.Text = "Terminar";
            this.btn_terminar.UseVisualStyleBackColor = true;
            this.btn_terminar.Click += new System.EventHandler(this.btn_terminar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_agregar.Location = new System.Drawing.Point(40, 249);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(112, 39);
            this.btn_agregar.TabIndex = 20;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_total.Location = new System.Drawing.Point(206, 404);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(66, 24);
            this.lbl_total.TabIndex = 19;
            this.lbl_total.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(40, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "Monto Total:";
            // 
            // lbl_restante
            // 
            this.lbl_restante.AutoSize = true;
            this.lbl_restante.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_restante.ForeColor = System.Drawing.Color.Red;
            this.lbl_restante.Location = new System.Drawing.Point(206, 365);
            this.lbl_restante.Name = "lbl_restante";
            this.lbl_restante.Size = new System.Drawing.Size(66, 24);
            this.lbl_restante.TabIndex = 17;
            this.lbl_restante.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(40, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Monto Restante:";
            // 
            // dgv_lista
            // 
            this.dgv_lista.AllowUserToAddRows = false;
            this.dgv_lista.AllowUserToDeleteRows = false;
            this.dgv_lista.AllowUserToResizeColumns = false;
            this.dgv_lista.AllowUserToResizeRows = false;
            this.dgv_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FP,
            this.Monto});
            this.dgv_lista.Location = new System.Drawing.Point(345, 105);
            this.dgv_lista.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_lista.Name = "dgv_lista";
            this.dgv_lista.RowHeadersVisible = false;
            this.dgv_lista.RowHeadersWidth = 51;
            this.dgv_lista.RowTemplate.Height = 25;
            this.dgv_lista.Size = new System.Drawing.Size(168, 280);
            this.dgv_lista.TabIndex = 15;
            // 
            // FP
            // 
            this.FP.HeaderText = "Forma Pago";
            this.FP.MinimumWidth = 6;
            this.FP.Name = "FP";
            this.FP.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FP.Width = 70;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.MinimumWidth = 6;
            this.Monto.Name = "Monto";
            this.Monto.Width = 70;
            // 
            // tb_monto
            // 
            this.tb_monto.Location = new System.Drawing.Point(40, 200);
            this.tb_monto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_monto.Name = "tb_monto";
            this.tb_monto.Size = new System.Drawing.Size(138, 27);
            this.tb_monto.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Monto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Forma de Pago:";
            // 
            // cb_fp
            // 
            this.cb_fp.FormattingEnabled = true;
            this.cb_fp.Location = new System.Drawing.Point(40, 129);
            this.cb_fp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_fp.Name = "cb_fp";
            this.cb_fp.Size = new System.Drawing.Size(138, 28);
            this.cb_fp.TabIndex = 11;
            // 
            // barrasuperior
            // 
            this.barrasuperior.BackColor = System.Drawing.Color.Maroon;
            this.barrasuperior.Controls.Add(this.label9);
            this.barrasuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.barrasuperior.Location = new System.Drawing.Point(0, 0);
            this.barrasuperior.Name = "barrasuperior";
            this.barrasuperior.Size = new System.Drawing.Size(538, 76);
            this.barrasuperior.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(35, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 36);
            this.label9.TabIndex = 20;
            this.label9.Text = "PAGO";
            // 
            // PagosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(538, 480);
            this.Controls.Add(this.barrasuperior);
            this.Controls.Add(this.btn_terminar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_restante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_lista);
            this.Controls.Add(this.tb_monto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_fp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PagosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PagosForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista)).EndInit();
            this.barrasuperior.ResumeLayout(false);
            this.barrasuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_terminar;
        private Button btn_agregar;
        private Label lbl_total;
        private Label label6;
        private Label lbl_restante;
        private Label label3;
        private DataGridView dgv_lista;
        private DataGridViewTextBoxColumn FP;
        private DataGridViewTextBoxColumn Monto;
        private TextBox tb_monto;
        private Label label2;
        private Label label1;
        private ComboBox cb_fp;
        private Panel barrasuperior;
        private Label label9;
    }
}