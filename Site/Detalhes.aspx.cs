using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site
{
    public partial class Detalhes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlDados.Visible = false;
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                PessoaBLL pessoaBLL = new PessoaBLL();
                Pessoa pessoa = new Pessoa();

                pessoa = pessoaBLL.ConsultarPorCodigo(Convert.ToInt32(txtCodigo.Text));

                if (pessoa != null)
                {
                    pnlDados.Visible = true;
                    txtNome.Text = pessoa.Nome;
                    txtEndereco.Text = pessoa.Endereco;
                    txtEmail.Text = pessoa.Email;
                }else
                {
                    pnlDados.Visible = false;
                    lblMensagem.Text = "Pessoa não encontrada!";
                    txtCodigo.Text = string.Empty;
                }

            }catch (Exception ex)
            {
                lblMensagem.Text = "Erro ao pesquisar.Detalhes - " + ex.Message;
            }
        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa pessoa = new Pessoa();
                pessoa.Codigo = Convert.ToInt32(txtCodigo.Text);
                pessoa.Nome = Convert.ToString(txtNome.Text);
                pessoa.Endereco = Convert.ToString(txtEndereco.Text);
                pessoa.Email = Convert.ToString(txtEmail.Text);

                PessoaBLL pessoaBLL = new PessoaBLL();
                int result = pessoaBLL.Atualizar(pessoa);

                if (result > 0)
                {
                    lblMensagem.Text = "Pessoa atualizada com sucesso!!";
                    txtCodigo.Text = string.Empty;
                    txtNome.Text = string.Empty;
                    txtEndereco.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                }
                else
                {
                    lblMensagem.Text = "Erro ao atualizar!!";
                }
            }catch (Exception ex)
            {
                lblMensagem.Text = "Erro ao atualizar os dados.Detalhes - " + ex.Message;
            }
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                PessoaBLL pessoaBLL = new PessoaBLL();
                int result = pessoaBLL.Excluir(Convert.ToInt32(txtCodigo.Text));

                if (result > 0)
                {
                    lblMensagem.Text = "Exclusão efetuada com sucesso!!";

                    txtCodigo.Text = string.Empty;
                    txtNome.Text = string.Empty;
                    txtEndereco.Text = string.Empty;
                    txtEmail.Text = string.Empty;

                    pnlDados.Visible = false;
                }else
                {
                    lblMensagem.Text = "Erro ao tentar excluir!!";
                    pnlDados.Visible = false;
                }
            }catch (Exception ex)
            {
                lblMensagem.Text = "Erro ao excluir os dados.Detalhes - " + ex.Message;
            }
        }
    }
}