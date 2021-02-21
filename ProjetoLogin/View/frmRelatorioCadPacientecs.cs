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
    public partial class frmRelatorioCadPacientecs : Form
    {
        public frmRelatorioCadPacientecs()
        {
            InitializeComponent();
        }

        private void frmRelatorioCadPacientecs_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetCadPaciente.CadPaciente'. Você pode movê-la ou removê-la conforme necessário.
            this.cadPacienteTableAdapter.Fill(this.dataSetCadPaciente.CadPaciente);

            this.rpwCadPaciente.RefreshReport();
        }
    }
}
