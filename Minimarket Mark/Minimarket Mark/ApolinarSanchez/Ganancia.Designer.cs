namespace ApolinarSanchez
{
    partial class Ganancia
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.txtfecha1 = new System.Windows.Forms.TextBox();
            this.txtfecha2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Ganan = new ApolinarSanchez.Ganan();
            this.VentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VentasTableAdapter = new ApolinarSanchez.GananTableAdapters.VentasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Ganan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtfecha1
            // 
            this.txtfecha1.Enabled = false;
            this.txtfecha1.Location = new System.Drawing.Point(1104, -3);
            this.txtfecha1.Name = "txtfecha1";
            this.txtfecha1.Size = new System.Drawing.Size(100, 20);
            this.txtfecha1.TabIndex = 2;
            this.txtfecha1.TextChanged += new System.EventHandler(this.txtfecha1_TextChanged);
            // 
            // txtfecha2
            // 
            this.txtfecha2.Enabled = false;
            this.txtfecha2.Location = new System.Drawing.Point(1261, -3);
            this.txtfecha2.Name = "txtfecha2";
            this.txtfecha2.Size = new System.Drawing.Size(100, 20);
            this.txtfecha2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1057, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Desde:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1217, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hasta:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VentasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ApolinarSanchez.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1354, 607);
            this.reportViewer1.TabIndex = 6;
            // 
            // Ganan
            // 
            this.Ganan.DataSetName = "Ganan";
            this.Ganan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VentasBindingSource
            // 
            this.VentasBindingSource.DataMember = "Ventas";
            this.VentasBindingSource.DataSource = this.Ganan;
            // 
            // VentasTableAdapter
            // 
            this.VentasTableAdapter.ClearBeforeFill = true;
            // 
            // Ganancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 607);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfecha2);
            this.Controls.Add(this.txtfecha1);
            this.Name = "Ganancia";
            this.Text = "Ganancia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Ganancia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ganan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtfecha1;
        public System.Windows.Forms.TextBox txtfecha2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VentasBindingSource;
        private Ganan Ganan;
        private GananTableAdapters.VentasTableAdapter VentasTableAdapter;
    }
}