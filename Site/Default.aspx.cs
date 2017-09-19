using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAcessar_Click(object sender, EventArgs e)
        {
            if (ddlMenu.SelectedValue == "0")
            {
                lblMensagem.Text = "Selecione uma opção válida";
            }else if (ddlMenu.SelectedValue == "1")
            {
                Response.Redirect("Cadastro.aspx");
            }else if (ddlMenu.SelectedValue == "2")
            {
                Response.Redirect("Consulta.aspx");
            }else if (ddlMenu.SelectedValue == "3")
            {
                Response.Redirect("Detalhes.aspx");
            }
        }
    }
}