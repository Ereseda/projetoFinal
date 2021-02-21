using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.Model.DAO
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

              public bool verificarLogin(string Nome,string Senha) // VAI NO BANCO DE DADOS, VERIFICA SE CONTEM O NOME, SENHA E VAI RETORNAR UM VALOR VERDADEIRO OU FALSO E CONTROLE VAI PEGAR ESSE VERDADEIRO E VAI MANDAR PARA O FORMULARIO
        {

            // cmd.CommandText = "select * from Logins where email= @nome and senha= @senha";
            cmd.CommandText = "SELECT * FROM Logins WHERE Nome=@Nome AND senha=@senha";
            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@senha", Senha);

            try
            {
                cmd.Connection = con.Conectar();// nome do método que faz a conexao
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();

            }
            catch (SqlException)
            {

                this.mensagem = "Erro com Banco de Dados!";

            }

            // COMANDO sQL PARA VERIFICAR SE TEM NO BANCO
            return tem;
                 
        }

        // MÉTODO DE CADASTRAR

     
        public string cadastrar(string Nome, string senha, string ConfSenha, string Nivel)
        {
            // COMANDO PARA INSERIR NO BANCO DE DADOS
            tem = false;
            if(senha.Equals(ConfSenha))
            {
                cmd.CommandText = "INSERT INTO Logins VALUES (@N,@s,@C,@Nivel) ;";
                cmd.Parameters.AddWithValue("@N",Nome);
                cmd.Parameters.AddWithValue("@s", senha);
                cmd.Parameters.AddWithValue("@C", ConfSenha);
                cmd.Parameters.AddWithValue("@Nivel", Nivel);              

                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Usuário Cadastrado com sucesso!!!";
                    tem = true;
                }
                catch (SqlException)
                {

                    this.mensagem = "Erro com Banco de Dados...";
                }
            }
            else
            {
                this.mensagem = " Senhas não correspondem.";
            }
           
            return mensagem;
        }

    }
}
