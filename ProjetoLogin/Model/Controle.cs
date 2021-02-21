using ProjetoLogin.Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.Model
{
    public class Controle
    {

        public bool tem;// atributo booleano
        public string mensagem = "";// atributo tipo string         

        //MÉTODO ACESSAR  
        public bool acessar(string Nome, string senha)
        {
            // VAMOS INSTANCIAR O LOGINDAOCOMANDOS

            LoginDaoComandos loginDao = new LoginDaoComandos(); //foi instanciado  em baixo no método cadastrar
            tem = loginDao.verificarLogin(Nome, senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }

        internal void cadastrar()
        {
            throw new NotImplementedException();
        }       

        //MÉTODO PARA CADASTRAR

        public string cadastrar(string Nome, string senha, string ConfSenha, string Nivel)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos(); // instancia do LoginDaoComandos
            this.mensagem = loginDao.cadastrar(Nome, senha, ConfSenha, Nivel);
            if (loginDao.tem)// a mensagem que vai vim é de sucesso
            {
                this.tem = true;
            }

            return mensagem;
        }        
      

    }
}



