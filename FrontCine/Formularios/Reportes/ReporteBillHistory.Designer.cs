namespace FrontCine.Formularios.Reportes
{
    partial class ReporteBillHistory
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
            this.btnconsultar = new System.Windows.Forms.Button();
            this.dtpfin = new System.Windows.Forms.DateTimePicker();
            this.dtpinicio = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(673, 23);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(115, 29);
            this.btnconsultar.TabIndex = 0;
            this.btnconsultar.Text = "CONSULTAR";
            this.btnconsultar.UseVisualStyleBackColor = true;
            // 
            // dtpfin
            // 
            this.dtpfin.Location = new System.Drawing.Point(231, 25);
            this.dtpfin.Name = "dtpfin";
            this.dtpfin.Size = new System.Drawing.Size(183, 27);
            this.dtpfin.TabIndex = 1;
            // 
            // dtpinicio
            // 
            this.dtpinicio.Location = new System.Drawing.Point(22, 25);
            this.dtpinicio.Name = "dtpinicio";
            this.dtpinicio.Size = new System.Drawing.Size(183, 27);
            this.dtpinicio.TabIndex = 2;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reportViewer1.Location = new System.Drawing.Point(0, 119);
            this.reportViewer1.Name = "ReportViewer";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(467, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // ReporteBillHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 365);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dtpinicio);
            this.Controls.Add(this.dtpfin);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteBillHistory";
            this.Text = "ReporteBillHistory";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnconsultar;
        private DateTimePicker dtpfin;
        private DateTimePicker dtpinicio;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ComboBox comboBox1;
    }
}