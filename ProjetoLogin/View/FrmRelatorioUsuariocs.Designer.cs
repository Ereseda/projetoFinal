
namespace ProjetoLogin.View
{
    partial class FrmRelatorioUsuariocs
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpwUsuario = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetUsuario = new ProjetoLogin.DataSet.DataSetUsuario();
            this.loginsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginsTableAdapter = new ProjetoLogin.DataSet.DataSetUsuarioTableAdapters.LoginsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpwUsuario
            // 
            this.rpwUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSetUsuario";
            reportDataSource2.Value = this.loginsBindingSource;
            this.rpwUsuario.LocalReport.DataSources.Add(reportDataSource2);
            this.rpwUsuario.LocalReport.ReportEmbeddedResource = "ProjetoLogin.Relatorios.RelatorioUsuario.rdlc";
            this.rpwUsuario.Location = new System.Drawing.Point(0, 0);
            this.rpwUsuario.Name = "rpwUsuario";
            this.rpwUsuario.ServerReport.BearerToken = null;
            this.rpwUsuario.Size = new System.Drawing.Size(800, 450);
            this.rpwUsuario.TabIndex = 0;
            // 
            // dataSetUsuario
            // 
            this.dataSetUsuario.DataSetName = "DataSetUsuario";
            this.dataSetUsuario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginsBindingSource
            // 
            this.loginsBindingSource.DataMember = "Logins";
            this.loginsBindingSource.DataSource = this.dataSetUsuario;
            // 
            // loginsTableAdapter
            // 
            this.loginsTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelatorioUsuariocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpwUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmRelatorioUsuariocs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Usuário";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRelatorioUsuariocs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpwUsuario;
        private DataSet.DataSetUsuario dataSetUsuario;
        private System.Windows.Forms.BindingSource loginsBindingSource;
        private DataSet.DataSetUsuarioTableAdapters.LoginsTableAdapter loginsTableAdapter;
    }
}