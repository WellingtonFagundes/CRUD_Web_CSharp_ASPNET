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
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                PessoaBLL pessoaBLL = new PessoaBLL();

                Pessoa pessoa = new Pessoa();

                pessoa.Nome = txtNome.Text;
                pessoa.Endereco = txtEndereco.Text;
                pessoa.Email = txtEmail.Text;

                int result = pessoaBLL.Inserir(pessoa);
                
                if (result > 0)
                {
                    lblMensagem.Text = "Pessoa " + pessoa.Nome + " cadastrado com sucesso!!";

                    txtNome.Text = string.Empty;
                    txtEndereco.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                } 

            }catch(Exception ex)
            {
                lblMensagem.Text = "Erro ao inserir os dados da pessoa.Detalhes - " + ex.Message;
            }
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }
    }
}