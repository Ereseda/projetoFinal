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
    public partial class FrmRelatorioUsuariocs : Form
    {
        public FrmRelatorioUsuariocs()
        {
            InitializeComponent();
        }

        private void FrmRelatorioUsuariocs_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetUsuario.Logins'. Você pode movê-la ou removê-la conforme necessário.
            this.loginsTableAdapter.Fill(this.dataSetUsuario.Logins);

            this.rpwUsuario.RefreshReport();
        }
    }
}
