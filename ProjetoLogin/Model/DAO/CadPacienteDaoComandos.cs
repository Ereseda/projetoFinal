using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjetoLogin.Model.DAO
{
    class CadPacienteDaoComandos
    {
        public bool tem1 = false;
        public string mensagem1 = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        private object txbId;
        private object txbNome;

        public bool verificarLogin(string Nome, string Senha) // VAI NO BANCO DE DADOS, VERIFICA SE CONTEM O NOME, SENHA E VAI RETORNAR UM VALOR VERDADEIRO OU FALSO E CONTROLE VAI PEGAR ESSE VERDADEIRO E VAI MANDAR PARA O FORMULARIO
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
                    tem1 = true;
                }
                con.desconectar();
                dr.Close();

            }
            catch (SqlException)
            {

                this.mensagem1 = "Erro com Banco de Dados!";

            }

            // COMANDO SQL PARA VERIFICAR SE TEM NO BANCO
            return tem1;

        }

        internal bool verificarCadPac(string nome, string sexo, string nascimento, string endereco, string numero, string bairro, string cidade, string estado, string cep, string telefoneResidencial, string celular, string telefoneRecado, string falarCom, string rg, string cpf, string cartaoSus)
        {
            throw new NotImplementedException();
        }

        public string Cadastro1(string Nome, string Sexo, string Nascimento, string Endereco, string Numero, string Bairro, string Cidade,
        string Estado, string Cep, string TelefoneResidencial, string Celular, string TelefoneRecado, string FalarCom, string Rg, string Cpf,
        string CartaoSus)
        {
            // COMANDO PARA INSERIR NO BANCO DE DADOS

            tem1 = false;
            if (Nome != "full")
            //if (Nome.Equals(Nome))
            {
                cmd.CommandText = "INSERT INTO CadPaciente VALUES (@Nome,@Sexo,@Nascimento,@Endereco,@Numero,@Bairro,@Cidade,@Estado,@Cep,@TelefoneResidencial,@Celular,@TelefoneRecado,@FalarCom,@Rg,@Cpf,@Cartaosus) ;";
                cmd.Parameters.AddWithValue("@Nome", Nome);
                cmd.Parameters.AddWithValue("@Sexo", Sexo);
                cmd.Parameters.AddWithValue("@Nascimento", Nascimento);
                cmd.Parameters.AddWithValue("@Endereco", Endereco);
                cmd.Parameters.AddWithValue("@Numero", Numero);
                cmd.Parameters.AddWithValue("@Bairro", Bairro);
                cmd.Parameters.AddWithValue("@Cidade", Cidade);
                cmd.Parameters.AddWithValue("@Estado", Estado);
                cmd.Parameters.AddWithValue("@Cep", Cep);
                cmd.Parameters.AddWithValue("@TelefoneResidencial", TelefoneResidencial);
                cmd.Parameters.AddWithValue("@Celular", Celular);
                cmd.Parameters.AddWithValue("@TelefoneRecado", TelefoneRecado);
                cmd.Parameters.AddWithValue("@FalarCom", FalarCom);
                cmd.Parameters.AddWithValue("@Rg", Rg);
                cmd.Parameters.AddWithValue("@Cpf", Cpf);
                cmd.Parameters.AddWithValue("@Cartaosus", CartaoSus);

                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem1 = "Usuário Cadastrado com sucesso!!!";
                    tem1 = true;
                }
                catch (SqlException)
                {

                    this.mensagem1 = "Erro com Banco de Dados...";
                }
            }
            else
            {
                this.mensagem1 = " Senhas não correspondem.";
            }
            return mensagem1;
        }

        //  comandos para atualizar banco de dados



    } 
    }
    

        
    
