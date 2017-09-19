using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class PessoaDAL:Conexao
    {
        public int Inserir(Pessoa pessoa)
        {
            try
            {
                AbrirConexao();
                cmd = new SqlCommand("INSERT INTO Pessoa(Nome,Endereco,Email) VALUES (@Nome,@Endereco,@Email)", con);
                cmd.Parameters.AddWithValue("@Nome", pessoa.Nome);
                cmd.Parameters.AddWithValue("@Endereco", pessoa.Endereco);
                cmd.Parameters.AddWithValue("@Email", pessoa.Email);

                int result = cmd.ExecuteNonQuery();

                return result;
            }catch (Exception ex)
            {
                throw new Exception("Falha ao inserir os dados.Detalhes: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public int Atualizar(Pessoa pessoa)
        {
            try
            {
                AbrirConexao();

                cmd = new SqlCommand("UPDATE Pessoa SET Nome = @Nome," +
                                    "Endereco = @Endereco," +
                                    "Email = @Email " +
                                    "WHERE Codigo = @Codigo",con);

                cmd.Parameters.AddWithValue("@Nome", pessoa.Nome);
                cmd.Parameters.AddWithValue("@Endereco", pessoa.Endereco);
                cmd.Parameters.AddWithValue("@Email", pessoa.Email);
                cmd.Parameters.AddWithValue("@Codigo", pessoa.Codigo);

                int result = cmd.ExecuteNonQuery();

                return result;
            }catch (Exception ex)
            {
                throw new Exception("Falha ao atualizar os dados.Detalhes - " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public int Excluir(int codigo)
        {
            try
            {
                AbrirConexao();

                cmd = new SqlCommand("DELETE FROM Pessoa WHERE Codigo = @Codigo",con);
                cmd.Parameters.AddWithValue("@Codigo", codigo);

                int result = cmd.ExecuteNonQuery();

                return result;

            }catch (Exception ex)
            {
                throw new Exception("Falha ao excluir.Detalhes - " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public Pessoa ConsultarPorCodigo(int codigo)
        {
            try
            {
                AbrirConexao();

                cmd = new SqlCommand("SELECT * FROM Pessoa WHERE Codigo = @Codigo",con);
                cmd.Parameters.AddWithValue("@Codigo", codigo);

                dr = cmd.ExecuteReader();

                Pessoa pessoa = null;

                if (dr.Read())
                {
                    pessoa = new Pessoa();
                    pessoa.Codigo = Convert.ToInt32(dr["Codigo"]);
                    pessoa.Nome = Convert.ToString(dr["Nome"]);
                    pessoa.Endereco = Convert.ToString(dr["Endereco"]);
                    pessoa.Email = Convert.ToString(dr["Email"]);
                }

                return pessoa;

            }catch (Exception ex)
            {
                throw new Exception("Falha ao consultar por código.Detalhes - " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<Pessoa> ConsultarPorNome(string nome)
        {
            try
            {
                AbrirConexao();
                cmd = new SqlCommand("SELECT * FROM Pessoa WHERE Nome LIKE '% @Nome %'",con);
                cmd.Parameters.AddWithValue("@Nome", nome);

                dr = cmd.ExecuteReader();

                List<Pessoa> lista = new List<Pessoa>();

                while (dr.Read())
                {
                    Pessoa pessoa = new Pessoa();
                    pessoa.Codigo = Convert.ToInt32(dr["Codigo"]);
                    pessoa.Nome = Convert.ToString(dr["Nome"]);
                    pessoa.Endereco = Convert.ToString(dr["Endereco"]);
                    pessoa.Email = Convert.ToString(dr["Email"]);

                    lista.Add(pessoa);
                }

                return lista;
            }catch (Exception ex)
            {
                throw new Exception("Falha ao consultar por nome.Detalhes - " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }


        public List<Pessoa> ListarTodos()
        {
            try
            {
                AbrirConexao();
                cmd = new SqlCommand("SELECT Codigo,Nome,Endereco,Email FROM Pessoa",con);

                dr = cmd.ExecuteReader();

                List<Pessoa> lista = new List<Pessoa>();

                while (dr.Read())
                {
                    Pessoa pessoa = new Pessoa();
                    pessoa.Codigo = Convert.ToInt32(dr["Codigo"]);
                    pessoa.Nome = Convert.ToString(dr["Nome"]);
                    pessoa.Endereco = Convert.ToString(dr["Endereco"]);
                    pessoa.Email = Convert.ToString(dr["Email"]);

                    lista.Add(pessoa);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao consultar todos os dados.Detalhes - " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
