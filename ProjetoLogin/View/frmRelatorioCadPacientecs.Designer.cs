
namespace ProjetoLogin.View
{
    partial class frmRelatorioCadPacientecs
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
            this.rpwCadPaciente = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetCadPaciente = new ProjetoLogin.DataSet.DataSetCadPaciente();
            this.cadPacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadPacienteTableAdapter = new ProjetoLogin.DataSet.DataSetCadPacienteTableAdapters.CadPacienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCadPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadPacienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpwCadPaciente
            // 
            this.rpwCadPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSetCadPaciente";
            reportDataSource2.Value = this.cadPacienteBindingSource;
            this.rpwCadPaciente.LocalReport.DataSources.Add(reportDataSource2);
            this.rpwCadPaciente.LocalReport.ReportEmbeddedResource = "ProjetoLogin.Relatorios.RelatorioCadPaciente.rdlc";
            this.rpwCadPaciente.Location = new System.Drawing.Point(0, 0);
            this.rpwCadPaciente.Name = "rpwCadPaciente";
            this.rpwCadPaciente.ServerReport.BearerToken = null;
            this.rpwCadPaciente.Size = new System.Drawing.Size(800, 450);
            this.rpwCadPaciente.TabIndex = 0;
            // 
            // dataSetCadPaciente
            // 
            this.dataSetCadPaciente.DataSetName = "DataSetCadPaciente";
            this.dataSetCadPaciente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadPacienteBindingSource
            // 
            this.cadPacienteBindingSource.DataMember = "CadPaciente";
            this.cadPacienteBindingSource.DataSource = this.dataSetCadPaciente;
            // 
            // cadPacienteTableAdapter
            // 
            this.cadPacienteTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorioCadPacientecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpwCadPaciente);
            this.Name = "frmRelatorioCadPacientecs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio de Cadastro de Paciente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRelatorioCadPacientecs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCadPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadPacienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpwCadPaciente;
        private DataSet.DataSetCadPaciente dataSetCadPaciente;
        private System.Windows.Forms.BindingSource cadPacienteBindingSource;
        private DataSet.DataSetCadPacienteTableAdapters.CadPacienteTableAdapter cadPacienteTableAdapter;
    }
}