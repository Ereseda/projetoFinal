using ProjetoLogin.Model;
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
    public partial class CadastroPaciente : Form
    {
        public CadastroPaciente()
        {
            InitializeComponent();
        }

        //private void Cadastro_de_Paciente_Load(object sender, EventArgs e)
       // {

        //}

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Controle1 controle1 = new Controle1();
            string mensagem1 = controle1.cadastrar1(txbNome.Text,cmbSexo.Text,txtNascimento.Text,txbEnderco.Text,txbNumero.Text,txbBairro.Text,txbCidade.Text,cmbEstado.Text,mktCep.Text,mktTelefoneResidencial.Text,mktCelular.Text,mktTelefoneRecado.Text,txbFalarCom.Text,mktRg.Text,mktCpf.Text,txbCartaoSus.Text);
            txbNome.Text = "";
            cmbSexo.Text = "";
            txtNascimento.Text = "";
            txbEnderco.Text = "";
            txbNumero.Text = "";
            txbBairro.Text = "";
            txbCidade.Text = "";
            cmbEstado.Text = "";
            mktCep.Text = "";
            mktTelefoneResidencial.Text = "";
            mktCelular.Text = "";
            mktTelefoneRecado.Text = "";
            txbFalarCom.Text = "";
            mktRg.Text = "";
            mktCpf.Text = "";
            txbCartaoSus.Text = "";

            if (controle1.tem1)//Mensagem de sucesso
            {
                MessageBox.Show(mensagem1, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
               else
            {
                MessageBox.Show(controle1.mensagem1);// Mensagem de erro
            }
          
            }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            controleAtualizarCadPaciente  controlePac= new controleAtualizarCadPaciente ();
            string mensagem2 = controlePac.Atualizar(txbNome.Text, cmbSexo.Text, txtNascimento.Text, txbEnderco.Text, txbNumero.Text, txbBairro.Text, txbCidade.Text, cmbEstado.Text, mktCep.Text, mktTelefoneResidencial.Text, mktCelular.Text, mktTelefoneRecado.Text, txbFalarCom.Text, mktRg.Text, mktCpf.Text, txbCartaoSus.Text);
            txbNome.Text = "";
            cmbSexo.Text = "";
            txtNascimento.Text = "";
            txbEnderco.Text = "";
            txbNumero.Text = "";
            txbBairro.Text = "";
            txbCidade.Text = "";
            cmbEstado.Text = "";
            mktCep.Text = "";
            mktTelefoneResidencial.Text = "";
            mktCelular.Text = "";
            mktTelefoneRecado.Text = "";
            txbFalarCom.Text = "";
            mktRg.Text = "";
            mktCpf.Text = "";
            txbCartaoSus.Text = "";
        }
    }
}
