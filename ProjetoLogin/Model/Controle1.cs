using ProjetoLogin.Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.Model
{
    class Controle1
    {
        public bool tem1;
        public string mensagem1 = "";

        //MÉTODO ACESSAR  

        public bool acessar1(string Nome, string Sexo, string Nascimento, string Endereco, string Numero, string Bairro,string Cidade, string Estado, string Cep, string TelefoneResidencial, string Celular, string TelefoneRecado, string FalarCom, string Rg, string Cpf, string CartaoSus)
        {
            // VAMOS INSTANCIAR O PACIENTEDAOCOMANDOS

            CadPacienteDaoComandos  cadPac = new CadPacienteDaoComandos(); //foi instanciado  em baixo no método cadastrar
            tem1 = cadPac.verificarCadPac(Nome,Sexo,Nascimento,Endereco,Numero,Bairro,Cidade,Estado,Cep,TelefoneResidencial,Celular,TelefoneRecado,FalarCom,Rg,Cpf,CartaoSus);
            if (!cadPac.mensagem1.Equals(""))
            {
                this.mensagem1 = cadPac.mensagem1;
            }
            return tem1;
        }
        //MÉTODO PARA CADASTRAR

        public string cadastrar1(string Nome,string Sexo,string Nascimento,string Endereco,string Numero,string Bairro,string Cidade,string Estado,string Cep,string TelefoneResidencial,string Celular,string TelefoneRecado,string FalarCom,string Rg,string Cpf,string Cartaosus)
        {
            CadPacienteDaoComandos cadPac = new CadPacienteDaoComandos(); // instancia do LoginDaoComandos
            this.mensagem1 = cadPac.Cadastro1(Nome, Sexo, Nascimento,Endereco,Numero,Bairro,Cidade,Estado,Cep,TelefoneResidencial,Celular,TelefoneRecado,FalarCom,Rg,Cpf,Cartaosus);
            if (cadPac.tem1)// a mensagem que vai vim é de sucesso
            {
                this.tem1 = true;
            }

            return mensagem1;
        }
    }
}

