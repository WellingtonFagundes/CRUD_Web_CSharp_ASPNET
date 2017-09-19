using DAL.Properties;
using System.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Conexao
    {
        //Protected permite acesso por herança
        protected SqlConnection con;
        protected SqlCommand cmd;
        protected SqlDataReader dr;

        protected void AbrirConexao()
        {
            try
            {
                con = new SqlConnection(Settings.Default.CRUD_Pessoa);
                con.Open();   
            }catch (Exception ex)
            {
                throw new Exception("Problema ao conectar no banco de dados.Detalhes: " + ex.Message);
            }
        }

        protected void FecharConexao()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }catch (Exception ex)
            {
                throw new Exception("Falha ao desconectar do banco.Detalhes: " + ex.Message);
            }
        }
    }
}
