using ProjetoLogin.Model;
using ProjetoLogin.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLogin
{
    

    public partial class Form1 : Form
    {
        public void IniciarSplash()
        {

            Application.Run(new Telasplash());
        }

        public Form1()
        {
            Thread threadSplash = new Thread(new ThreadStart(IniciarSplash));
            threadSplash.Start();
            Thread.Sleep(1500);

            InitializeComponent();

            threadSplash.Abort();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastreSe cad = new CadastreSe();
            cad.Show();
        }
       

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();

           controle.acessar(txbNome.Text, txbSenha.Text);

            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Usuário logado com Sucesso!", "Entrando...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MenuOpcoes menu = new MenuOpcoes();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Login não encontrado, verifique login e senha", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }else
            {
                MessageBox.Show(controle.mensagem);


               
            }

             
        }
    }
}
