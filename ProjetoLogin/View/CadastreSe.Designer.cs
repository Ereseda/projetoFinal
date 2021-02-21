
namespace ProjetoLogin.View
{
    partial class CadastreSe
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblConfSenha = new System.Windows.Forms.Label();
            this.lblNível = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            this.txbConfSenha = new System.Windows.Forms.TextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.txbId = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Black;
            this.lblId.Location = new System.Drawing.Point(285, 22);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(35, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Black;
            this.lblLogin.Location = new System.Drawing.Point(285, 73);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(77, 20);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "LOGIN: ";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.Black;
            this.lblSenha.Location = new System.Drawing.Point(283, 126);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(79, 20);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "SENHA: ";
            // 
            // lblConfSenha
            // 
            this.lblConfSenha.AutoSize = true;
            this.lblConfSenha.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfSenha.ForeColor = System.Drawing.Color.Black;
            this.lblConfSenha.Location = new System.Drawing.Point(283, 179);
            this.lblConfSenha.Name = "lblConfSenha";
            this.lblConfSenha.Size = new System.Drawing.Size(181, 20);
            this.lblConfSenha.TabIndex = 3;
            this.lblConfSenha.Text = "CONFIRMA SENHA: ";
            // 
            // lblNível
            // 
            this.lblNível.AutoSize = true;
            this.lblNível.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNível.ForeColor = System.Drawing.Color.Black;
            this.lblNível.Location = new System.Drawing.Point(285, 232);
            this.lblNível.Name = "lblNível";
            this.lblNível.Size = new System.Drawing.Size(68, 20);
            this.lblNível.TabIndex = 4;
            this.lblNível.Text = "NIVEL:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(97, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(371, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "CADASTRO DE USUÁRIO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cmbNivel);
            this.panel1.Controls.Add(this.txbConfSenha);
            this.panel1.Controls.Add(this.txbSenha);
            this.panel1.Controls.Add(this.txbLogin);
            this.panel1.Controls.Add(this.txbId);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Controls.Add(this.lblNível);
            this.panel1.Controls.Add(this.lblSenha);
            this.panel1.Controls.Add(this.lblConfSenha);
            this.panel1.Location = new System.Drawing.Point(12, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 304);
            this.panel1.TabIndex = 6;
            // 
            // cmbNivel
            // 
            this.cmbNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.Items.AddRange(new object[] {
            "Administrador",
            "Recepção",
            "Médico"});
            this.cmbNivel.Location = new System.Drawing.Point(287, 255);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(195, 28);
            this.cmbNivel.TabIndex = 3;
            // 
            // txbConfSenha
            // 
            this.txbConfSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConfSenha.Location = new System.Drawing.Point(287, 202);
            this.txbConfSenha.Name = "txbConfSenha";
            this.txbConfSenha.PasswordChar = '*';
            this.txbConfSenha.Size = new System.Drawing.Size(199, 27);
            this.txbConfSenha.TabIndex = 2;
            // 
            // txbSenha
            // 
            this.txbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenha.Location = new System.Drawing.Point(287, 149);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(188, 27);
            this.txbSenha.TabIndex = 1;
            // 
            // txbLogin
            // 
            this.txbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLogin.Location = new System.Drawing.Point(287, 96);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(188, 27);
            this.txbLogin.TabIndex = 0;
            // 
            // txbId
            // 
            this.txbId.Enabled = false;
            this.txbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbId.Location = new System.Drawing.Point(326, 19);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(85, 27);
            this.txbId.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoLogin.Properties.Resources.AdicionarUsuario;
            this.pictureBox1.Location = new System.Drawing.Point(27, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(411, 388);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(141, 54);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // CadastreSe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CadastreSe";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastre_se";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblConfSenha;
        private System.Windows.Forms.Label lblNível;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txbConfSenha;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.ComboBox cmbNivel;
        private System.Windows.Forms.Button btnCadastrar;
    }
}