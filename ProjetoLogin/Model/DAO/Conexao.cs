using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.Model.DAO
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();
        // 3 MÉTODOS AQUI
        // MÉTODOS CONSTRUTOR
        public Conexao()
        {
            // dentro do construtor vamos utilizar o metodo

            con.ConnectionString = @"Data Source=DESKTOP-VPO8U8F;Initial Catalog=ProjetoLogin2;Integrated Security=True";
        }
        //mais dois que ira conectar e desconectar com o banco de dados

        public SqlConnection Conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

    }
}
