using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLogin.View
{
    public partial class MenuOpcoes : Form
    {
        public MenuOpcoes()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sairToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sairToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void relatórioDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            FrmRelatorioUsuariocs frmreport = new FrmRelatorioUsuariocs();
            frmreport.ShowDialog();
        }

        private void cadastroDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastreSe cd = new CadastreSe();
            cd.ShowDialog();
            
        }

        private void cadastroDePacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroPaciente cadpa = new CadastroPaciente();
            cadpa.ShowDialog();
           
        }

        private void relatórioDePacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioCadPacientecs frmCadP = new frmRelatorioCadPacientecs();
            frmCadP.ShowDialog();
        }

        private void cadastroDePacienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastroPaciente cadpa = new CadastroPaciente();
            cadpa.ShowDialog();
        }

        private void relatórioDeCadPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioCadPacientecs frmCadP = new frmRelatorioCadPacientecs();
            frmCadP.ShowDialog();
        }

        private void cadastroDePacienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CadastroPaciente cadpa = new CadastroPaciente();
            cadpa.ShowDialog();
        }

        private void relatórioCdPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioCadPacientecs frmCadP = new frmRelatorioCadPacientecs();
            frmCadP.ShowDialog();
        }

        private void cadastroMédicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroMedicocs cadmedico = new FormCadastroMedicocs();
            cadmedico.ShowDialog();
        }
    }
}
