
namespace ProjetoLogin.View
{
    partial class FormCadastroMedicocs
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxbIdMedico = new System.Windows.Forms.TextBox();
            this.LblEspecialidade = new System.Windows.Forms.Label();
            this.CmbEspecialidade = new System.Windows.Forms.ComboBox();
            this.MtbCrm = new System.Windows.Forms.MaskedTextBox();
            this.LblCrm = new System.Windows.Forms.Label();
            this.TxbNomeMedico = new System.Windows.Forms.TextBox();
            this.lblNomeMedico = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(231, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO DE ESPECIALISTAS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.TxbIdMedico);
            this.panel1.Controls.Add(this.LblEspecialidade);
            this.panel1.Controls.Add(this.CmbEspecialidade);
            this.panel1.Controls.Add(this.MtbCrm);
            this.panel1.Controls.Add(this.LblCrm);
            this.panel1.Controls.Add(this.TxbNomeMedico);
            this.panel1.Controls.Add(this.lblNomeMedico);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 280);
            this.panel1.TabIndex = 1;
            // 
            // TxbIdMedico
            // 
            this.TxbIdMedico.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbIdMedico.Location = new System.Drawing.Point(419, 29);
            this.TxbIdMedico.Name = "TxbIdMedico";
            this.TxbIdMedico.Size = new System.Drawing.Size(72, 27);
            this.TxbIdMedico.TabIndex = 8;
            // 
            // LblEspecialidade
            // 
            this.LblEspecialidade.AutoSize = true;
            this.LblEspecialidade.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEspecialidade.Location = new System.Drawing.Point(376, 208);
            this.LblEspecialidade.Name = "LblEspecialidade";
            this.LblEspecialidade.Size = new System.Drawing.Size(141, 22);
            this.LblEspecialidade.TabIndex = 7;
            this.LblEspecialidade.Text = "Especialidade:";
            // 
            // CmbEspecialidade
            // 
            this.CmbEspecialidade.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEspecialidade.FormattingEnabled = true;
            this.CmbEspecialidade.Items.AddRange(new object[] {
            "Alergia e Imunologia",
            "Anestesiologia",
            "Angiologia",
            "________________________________",
            "Cancerologia (oncologia)",
            "Cardiologia",
            "Cirurgia Cardiovascular",
            "Cirurgia da Mão",
            "Cirurgia de cabeça e pescoço",
            "Cirurgia do Aparelho Digestivo",
            "Cirurgia Geral",
            "Cirurgia Pediátrica",
            "Cirurgia Plástica",
            "Cirurgia Torácica",
            "Clínica Médica (Medicina interna)",
            "Coloproctologia",
            "_________________________________",
            "Dermatologia",
            "_________________________________",
            "Endocrinologia e Metabologia",
            "Endoscopia",
            "_________________________________",
            "Gastroenterologia",
            "Genética médica",
            "Geriatria",
            "Ginecologia e obstetrícia",
            "_________________________________",
            "Hematologia e Hemoterapia",
            "Homeopatia",
            "_________________________________",
            "Infectologia",
            "_________________________________",
            "Mastologia",
            "Medicina de Família e Comunidade",
            "Medicina de Emergência",
            "Medicina do Trabalho",
            "Medicina do Tráfego",
            "Medicina Esportiva",
            "Medicina Física e Reabilitação",
            "Medicina Intensiva",
            "Medicina Legal e Perícia Médica (ou medicina forense)",
            "Medicina Nuclear",
            "Medicina Preventiva e Social",
            "_________________________________",
            "Nefrologia",
            "Neurocirurgia",
            "Neurologia",
            "Nutrologia",
            "_________________________________",
            "Obstetrícia",
            "Oftalmologia",
            "Ortopedia e Traumatologia",
            "Otorrinolaringologia",
            "_________________________________",
            "Patologia",
            "Patologia Clínica/Medicina laboratorial",
            "Pediatria",
            "Pneumologia",
            "Psiquiatria",
            "__________________________________",
            "Radiologia e Diagnóstico por Imagem",
            "Radioterapia",
            "Reumatologia",
            "__________________________________",
            "Toxicologia médica",
            "Urologia"});
            this.CmbEspecialidade.Location = new System.Drawing.Point(380, 243);
            this.CmbEspecialidade.Name = "CmbEspecialidade";
            this.CmbEspecialidade.Size = new System.Drawing.Size(185, 28);
            this.CmbEspecialidade.TabIndex = 6;
            // 
            // MtbCrm
            // 
            this.MtbCrm.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbCrm.Location = new System.Drawing.Point(380, 168);
            this.MtbCrm.Mask = "9999999999";
            this.MtbCrm.Name = "MtbCrm";
            this.MtbCrm.Size = new System.Drawing.Size(77, 27);
            this.MtbCrm.TabIndex = 5;
            // 
            // LblCrm
            // 
            this.LblCrm.AutoSize = true;
            this.LblCrm.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCrm.Location = new System.Drawing.Point(376, 143);
            this.LblCrm.Name = "LblCrm";
            this.LblCrm.Size = new System.Drawing.Size(71, 22);
            this.LblCrm.TabIndex = 4;
            this.LblCrm.Text = "CRM: ";
            // 
            // TxbNomeMedico
            // 
            this.TxbNomeMedico.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbNomeMedico.Location = new System.Drawing.Point(376, 97);
            this.TxbNomeMedico.Name = "TxbNomeMedico";
            this.TxbNomeMedico.Size = new System.Drawing.Size(307, 27);
            this.TxbNomeMedico.TabIndex = 3;
            // 
            // lblNomeMedico
            // 
            this.lblNomeMedico.AutoSize = true;
            this.lblNomeMedico.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeMedico.Location = new System.Drawing.Point(373, 68);
            this.lblNomeMedico.Name = "lblNomeMedico";
            this.lblNomeMedico.Size = new System.Drawing.Size(176, 22);
            this.lblNomeMedico.TabIndex = 2;
            this.lblNomeMedico.Text = "Nome do médico: ";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(373, 27);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(40, 22);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::ProjetoLogin.Properties.Resources.MediEspec;
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrar.Location = new System.Drawing.Point(29, 382);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(137, 41);
            this.BtnCadastrar.TabIndex = 2;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualizar.ForeColor = System.Drawing.Color.White;
            this.BtnAtualizar.Location = new System.Drawing.Point(172, 382);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(137, 41);
            this.BtnAtualizar.TabIndex = 3;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = false;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.ForeColor = System.Drawing.Color.White;
            this.btnDeletar.Location = new System.Drawing.Point(324, 382);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(137, 41);
            this.btnDeletar.TabIndex = 4;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPesquisar.ForeColor = System.Drawing.Color.White;
            this.BtnPesquisar.Location = new System.Drawing.Point(480, 382);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(137, 41);
            this.BtnPesquisar.TabIndex = 5;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = false;
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.Color.White;
            this.BtnSair.Location = new System.Drawing.Point(632, 382);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(137, 41);
            this.BtnSair.TabIndex = 6;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 458);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(749, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // FormCadastroMedicocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 654);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastroMedicocs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastroMedicocs";
            this.Load += new System.EventHandler(this.FormCadastroMedicocs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxbIdMedico;
        private System.Windows.Forms.Label LblEspecialidade;
        private System.Windows.Forms.ComboBox CmbEspecialidade;
        private System.Windows.Forms.MaskedTextBox MtbCrm;
        private System.Windows.Forms.Label LblCrm;
        private System.Windows.Forms.TextBox TxbNomeMedico;
        private System.Windows.Forms.Label lblNomeMedico;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}