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
    public partial class Consulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                PessoaBLL BLL = new PessoaBLL();
                List<Pessoa> lista = new List<Pessoa>();

                lista = BLL.ListarTodos();

                if (lista != null)
                {
                    grdPessoas.DataSource = lista;
                    grdPessoas.DataBind();
                }else
                {
                    lblMensagem.Text = "Nenhum dado cadastrado!!";
                }
            }catch (Exception ex)
            {
                lblMensagem.Text = "Erro ao carregar os dados.Detalhes - " + ex.Message;
            }
        }
    }
}