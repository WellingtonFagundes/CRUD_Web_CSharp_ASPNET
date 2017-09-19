using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PessoaBLL
    {
        PessoaDAL pessoaDAL = new PessoaDAL();

        public int Inserir(Pessoa pessoa)
        {
            try
            {
                int result = pessoaDAL.Inserir(pessoa);

                return result;
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Atualizar(Pessoa pessoa)
        {
            try
            {
                int result = pessoaDAL.Atualizar(pessoa);

                return result;
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Excluir(int codigo)
        {
            try
            {
                int result = pessoaDAL.Excluir(codigo);

                return result;
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Pessoa ConsultarPorCodigo(int codigo)
        {
            try
            {
                Pessoa pessoa = pessoaDAL.ConsultarPorCodigo(codigo);

                return pessoa;
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Pessoa> ConsultarPorNome(string nome)
        {
            try
            {
                List<Pessoa> lista = pessoaDAL.ConsultarPorNome(nome);

                return lista;
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Pessoa> ListarTodos()
        {
            try
            {
                List<Pessoa> lista = pessoaDAL.ListarTodos();

                return lista;
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
