<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Site.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="Content/bootstrap.css" />
    <script src="Scripts/bootstrap.min.js" type="text/javascript"></script>
    <script src="Scripts/jquery-1.9.1.min.js" type="text/javascript"></script>
    <title>Cadastro de Pessoas</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div>
            <div class="row">
                <h3 class="well">Cadastro de Pessoas</h3>
                <br />

                Nome:
                <asp:TextBox runat="server" ID="txtNome" Width="45%" placeholder="Nome completo" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator 
                    runat="server" 
                    ID="reqNome"
                    ControlToValidate="txtNome"
                    Text="Por favor, informe o nome da pessoa"
                    ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <br />

                Endereço:
                <asp:TextBox runat="server" ID="txtEndereco" Width="55%" placeholder="Endereço completo" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator
                    runat="server"
                    id="reqEndereco"
                    ControlToValidate="txtEndereco"
                    Text="Por favor, informe o endereço"
                    ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <br />

                Email:
                <asp:TextBox runat="server" ID="txtEmail" Width="40%" placeholder="Email válido" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator
                    id="reqEmail"
                    runat="server"
                    ControlToValidate="txtEmail"
                    Text="Por favor, informe um email válido"
                    ForeColor="Red"></asp:RequiredFieldValidator>

                <br />
                <br />
                <asp:Button runat="server" ID="btnCadastrar" Text="Cadastrar" CssClass="btn btn-success" OnClick="btnCadastrar_Click" />&nbsp;
                <asp:Button runat="server" ID="btnVoltar" Text="Voltar" CssClass="btn btn-default" OnClick="btnVoltar_Click" />
                <br />
                <p>
                    <asp:Label runat="server" ID="lblMensagem" ForeColor="Blue"></asp:Label>
                </p>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
