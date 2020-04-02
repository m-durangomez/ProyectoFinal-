namespace ApolinarSanchez
{
    partial class Reporteriainventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporteriainventario));
            this.InventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatosInventario = new ApolinarSanchez.DatosInventario();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.InventarioTableAdapter = new ApolinarSanchez.DatosInventarioTableAdapters.InventarioTableAdapter();
            this.txtfecha88 = new System.Windows.Forms.TextBox();
            this.txtfecha89 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // InventarioBindingSource
            // 
            this.InventarioBindingSource.DataMember = "Inventario";
            this.InventarioBindingSource.DataSource = this.DatosInventario;
            // 
            // DatosInventario
            // 
            this.DatosInventario.DataSetName = "DatosInventario";
            this.DatosInventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.InventarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ApolinarSanchez.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1362, 584);
            this.reportViewer1.TabIndex = 0;
            // 
            // InventarioTableAdapter
            // 
            this.InventarioTableAdapter.ClearBeforeFill = true;
            // 
            // txtfecha88
            // 
            this.txtfecha88.Enabled = false;
            this.txtfecha88.Location = new System.Drawing.Point(1104, 0);
            this.txtfecha88.Name = "txtfecha88";
            this.txtfecha88.Size = new System.Drawing.Size(100, 20);
            this.txtfecha88.TabIndex = 3;
            // 
            // txtfecha89
            // 
            this.txtfecha89.Enabled = false;
            this.txtfecha89.Location = new System.Drawing.Point(1262, 0);
            this.txtfecha89.Name = "txtfecha89";
            this.txtfecha89.Size = new System.Drawing.Size(100, 20);
            this.txtfecha89.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1051, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "DESDE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1210, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "HASTA:";
            // 
            // Reporteriainventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 584);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfecha89);
            this.Controls.Add(this.txtfecha88);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reporteriainventario";
            this.Text = "Reporteriainventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Reporteriainventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource InventarioBindingSource;
        private DatosInventario DatosInventario;
        private DatosInventarioTableAdapters.InventarioTableAdapter InventarioTableAdapter;
        public System.Windows.Forms.TextBox txtfecha88;
        public System.Windows.Forms.TextBox txtfecha89;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}