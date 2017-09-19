<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detalhes.aspx.cs" Inherits="Site.Detalhes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="Content/bootstrap.css" />
    <script src="Scripts/bootstrap.min.js" type="text/javascript"></script>
    <script src="Scripts/jquery-1.9.1.min.js" type="text/javascript"></script>
    <title>Detalhes da Pessoa</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div>
            <div class="row">
                <h3 class="well">Detalhes da Pessoa</h3>
                <br />
                
                Informe o código<br />
                <asp:TextBox runat="server" ID="txtCodigo" CssClass="form-control" Width="7%"></asp:TextBox>
                <br />
                <asp:Button runat="server" ID="btnPesquisar" CssClass="btn btn-primary" Text="Pesquisar" OnClick="btnPesquisar_Click" />&nbsp;
                <a href="Default.aspx" class="btn btn-default">Voltar</a>

                <br /><br />
                <p>
                    <asp:Label runat="server" ID="lblMensagem" ForeColor="Blue"></asp:Label>
                </p>

                <br />

                <asp:Panel runat="server" ID="pnlDados">
                    Nome <br />
                    <asp:TextBox ID="txtNome" runat="server" Width="45%" CssClass="form-control"></asp:TextBox>
                    <br /><br />

                    Endereço <br />
                    <asp:TextBox ID="txtEndereco" runat="server" Width="65%" CssClass="form-control"></asp:TextBox>
                    <br /><br />

                    Email <br />
                    <asp:TextBox ID="txtEmail" runat="server" Width="55%" CssClass="form-control"></asp:TextBox>
                    <br /><br />

                    <asp:Button runat="server" ID="btnAtualizar" Text="Atualizar" CssClass="btn btn-success" OnClick="btnAtualizar_Click" />&nbsp;
                    <asp:Button runat="server" ID="btnExcluir" Text="Excluir" CssClass="btn btn-danger" OnClick="btnExcluir_Click" />&nbsp;
                    <a href="Default.aspx" class="btn btn-default">Voltar</a>
                </asp:Panel>
            </div>
        </div>


    </div>
    </form>
</body>
</html>
