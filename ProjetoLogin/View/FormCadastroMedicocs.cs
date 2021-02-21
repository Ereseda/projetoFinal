using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ProjetoLogin.Model.DAO;

namespace ProjetoLogin.View
{
    public partial class FormCadastroMedicocs : Form
    {
        public FormCadastroMedicocs()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormCadastroMedicocs_Load(object sender, EventArgs e)
        {

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
         
        }
    }
}
