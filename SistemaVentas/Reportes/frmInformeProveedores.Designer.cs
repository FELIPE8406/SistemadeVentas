
namespace SistemaVentas.Reportes
{
    partial class frmInformeProveedores
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DsSistema = new SistemaVentas.Reportes.DsSistema();
            this.usp_ObtenerProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usp_ObtenerProveedoresTableAdapter = new SistemaVentas.Reportes.DsSistemaTableAdapters.usp_ObtenerProveedoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DsSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usp_ObtenerProveedoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DtsProveedores";
            reportDataSource1.Value = this.usp_ObtenerProveedoresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaVentas.Reportes.rptProveedores1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1024, 501);
            this.reportViewer1.TabIndex = 0;
            // 
            // DsSistema
            // 
            this.DsSistema.DataSetName = "DsSistema";
            this.DsSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usp_ObtenerProveedoresBindingSource
            // 
            this.usp_ObtenerProveedoresBindingSource.DataMember = "usp_ObtenerProveedores";
            this.usp_ObtenerProveedoresBindingSource.DataSource = this.DsSistema;
            // 
            // usp_ObtenerProveedoresTableAdapter
            // 
            this.usp_ObtenerProveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // frmInformeProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 501);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmInformeProveedores";
            this.Text = "Listado de Proveedores";
            this.Load += new System.EventHandler(this.frmInformeProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usp_ObtenerProveedoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource usp_ObtenerProveedoresBindingSource;
        private DsSistema DsSistema;
        private DsSistemaTableAdapters.usp_ObtenerProveedoresTableAdapter usp_ObtenerProveedoresTableAdapter;
    }
}