namespace ReportesCine.Formularios
{
    partial class Inicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnrestaurar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.lblfecha = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblhora = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.submenuestadisticas = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnreportesala = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnreporteventa = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnestadisticas = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.panelprincipal = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.submenuestadisticas.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.Maroon;
            this.BarraTitulo.Controls.Add(this.btnMaximizar);
            this.BarraTitulo.Controls.Add(this.btnMinimizar);
            this.BarraTitulo.Controls.Add(this.btnrestaurar);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1282, 37);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraTitulo_Paint);
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.BackColor = System.Drawing.Color.Maroon;
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1213, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(30, 30);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 3;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Maroon;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1177, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnrestaurar
            // 
            this.btnrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrestaurar.BackColor = System.Drawing.Color.Maroon;
            this.btnrestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnrestaurar.Image")));
            this.btnrestaurar.Location = new System.Drawing.Point(1213, 3);
            this.btnrestaurar.Name = "btnrestaurar";
            this.btnrestaurar.Size = new System.Drawing.Size(30, 30);
            this.btnrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnrestaurar.TabIndex = 4;
            this.btnrestaurar.TabStop = false;
            this.btnrestaurar.Click += new System.EventHandler(this.btnrestaurar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Maroon;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1249, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.White;
            this.MenuVertical.Controls.Add(this.panel5);
            this.MenuVertical.Controls.Add(this.button2);
            this.MenuVertical.Controls.Add(this.lblfecha);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Controls.Add(this.lblhora);
            this.MenuVertical.Controls.Add(this.pictureBox2);
            this.MenuVertical.Controls.Add(this.submenuestadisticas);
            this.MenuVertical.Controls.Add(this.panel4);
            this.MenuVertical.Controls.Add(this.button1);
            this.MenuVertical.Controls.Add(this.panel3);
            this.MenuVertical.Controls.Add(this.panel2);
            this.MenuVertical.Controls.Add(this.panel1);
            this.MenuVertical.Controls.Add(this.button3);
            this.MenuVertical.Controls.Add(this.btnestadisticas);
            this.MenuVertical.Controls.Add(this.btnConsulta);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 37);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(253, 863);
            this.MenuVertical.TabIndex = 1;
            // 
            // lblfecha
            // 
            this.lblfecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblfecha.Location = new System.Drawing.Point(69, 830);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(50, 21);
            this.lblfecha.TabIndex = 1;
            this.lblfecha.Text = "fecha";
            this.lblfecha.Click += new System.EventHandler(this.lblfecha_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblhora
            // 
            this.lblhora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblhora.Location = new System.Drawing.Point(69, 792);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(73, 34);
            this.lblhora.TabIndex = 0;
            this.lblhora.Text = "hora";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 802);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // submenuestadisticas
            // 
            this.submenuestadisticas.Controls.Add(this.panel7);
            this.submenuestadisticas.Controls.Add(this.btnreportesala);
            this.submenuestadisticas.Controls.Add(this.panel6);
            this.submenuestadisticas.Controls.Add(this.btnreporteventa);
            this.submenuestadisticas.Location = new System.Drawing.Point(54, 334);
            this.submenuestadisticas.Name = "submenuestadisticas";
            this.submenuestadisticas.Size = new System.Drawing.Size(198, 98);
            this.submenuestadisticas.TabIndex = 8;
            this.submenuestadisticas.Visible = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Maroon;
            this.panel7.Location = new System.Drawing.Point(3, 49);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 46);
            this.panel7.TabIndex = 10;
            // 
            // btnreportesala
            // 
            this.btnreportesala.FlatAppearance.BorderSize = 0;
            this.btnreportesala.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnreportesala.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnreportesala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreportesala.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnreportesala.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreportesala.Location = new System.Drawing.Point(6, 49);
            this.btnreportesala.Name = "btnreportesala";
            this.btnreportesala.Size = new System.Drawing.Size(198, 46);
            this.btnreportesala.TabIndex = 10;
            this.btnreportesala.Text = "ULTIMA FACTURA";
            this.btnreportesala.UseVisualStyleBackColor = true;
            this.btnreportesala.Click += new System.EventHandler(this.btnreportesala_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Maroon;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 46);
            this.panel6.TabIndex = 9;
            // 
            // btnreporteventa
            // 
            this.btnreporteventa.FlatAppearance.BorderSize = 0;
            this.btnreporteventa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnreporteventa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnreporteventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreporteventa.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnreporteventa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreporteventa.Location = new System.Drawing.Point(6, 3);
            this.btnreporteventa.Name = "btnreporteventa";
            this.btnreporteventa.Size = new System.Drawing.Size(198, 46);
            this.btnreporteventa.TabIndex = 9;
            this.btnreporteventa.Text = "REPORTE VENTA";
            this.btnreporteventa.UseVisualStyleBackColor = true;
            this.btnreporteventa.Click += new System.EventHandler(this.btnreporteventa_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Maroon;
            this.panel4.Location = new System.Drawing.Point(-1, 178);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 46);
            this.panel4.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(2, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "CONSULTAS";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Location = new System.Drawing.Point(0, 230);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 46);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(-1, 282);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 46);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(0, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 46);
            this.panel1.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(244, 46);
            this.button3.TabIndex = 3;
            this.button3.Text = "VENTA";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnestadisticas
            // 
            this.btnestadisticas.FlatAppearance.BorderSize = 0;
            this.btnestadisticas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnestadisticas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnestadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnestadisticas.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnestadisticas.Image = ((System.Drawing.Image)(resources.GetObject("btnestadisticas.Image")));
            this.btnestadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnestadisticas.Location = new System.Drawing.Point(2, 282);
            this.btnestadisticas.Name = "btnestadisticas";
            this.btnestadisticas.Size = new System.Drawing.Size(244, 46);
            this.btnestadisticas.TabIndex = 2;
            this.btnestadisticas.Text = "ESTADISTICAS";
            this.btnestadisticas.UseVisualStyleBackColor = true;
            this.btnestadisticas.Click += new System.EventHandler(this.btnestadisticas_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnConsulta.Image")));
            this.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.Location = new System.Drawing.Point(3, 126);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(244, 46);
            this.btnConsulta.TabIndex = 1;
            this.btnConsulta.Text = "USUARIOS";
            this.btnConsulta.UseVisualStyleBackColor = true;
            // 
            // panelprincipal
            // 
            this.panelprincipal.BackColor = System.Drawing.Color.LightGray;
            this.panelprincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelprincipal.Location = new System.Drawing.Point(253, 37);
            this.panelprincipal.Name = "panelprincipal";
            this.panelprincipal.Size = new System.Drawing.Size(1029, 863);
            this.panelprincipal.TabIndex = 2;
            this.panelprincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContenedor_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Maroon;
            this.panel5.Location = new System.Drawing.Point(3, 434);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 46);
            this.panel5.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(6, 434);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 46);
            this.button2.TabIndex = 10;
            this.button2.Text = "EDICION";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 900);
            this.Controls.Add(this.panelprincipal);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.submenuestadisticas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel BarraTitulo;
        private PictureBox btnMaximizar;
        private PictureBox btnMinimizar;
        private PictureBox btnCerrar;
        private Panel MenuVertical;
        private Panel panelprincipal;
        private PictureBox btnrestaurar;
        private PictureBox pictureBox1;
        private Button btnConsulta;
        private Button button3;
        private Button btnestadisticas;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Panel panel7;
        private Panel panel6;
        private Panel submenuestadisticas;
        private Button btnreportesala;
        private Button btnreporteventa;
        private Panel panel4;
        private Button button1;
        private PictureBox pictureBox2;
        private Label lblfecha;
        private Label lblhora;
        private System.Windows.Forms.Timer timer1;
        private Panel panel5;
        private Button button2;
    }
}