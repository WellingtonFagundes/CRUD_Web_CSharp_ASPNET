<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Site.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="Content/bootstrap.css" />
    <script src="Scripts/bootstrap.min.js" type="text/javascript"></script>        
    <script src="Scripts/jquery-1.9.1.min.js" type="text/javascript"></script>
    <title>Página Inicial</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="jumbotron">
        <h1>Projeto CRUD - Cadastro de Pessoas</h1>

        Selecione a opção desejada:
        <asp:DropDownList runat="server" ID="ddlMenu">
            <asp:ListItem Value="0" Text=" - Selecione uma opção - "></asp:ListItem>
            <asp:ListItem Value="1" Text="Cadastrar Pessoa"></asp:ListItem>
            <asp:ListItem Value="2" Text="Consultar Pessoa"></asp:ListItem>
            <asp:ListItem Value="3" Text="Obter Dados da Pessoa"></asp:ListItem>
        </asp:DropDownList>

        <asp:Button runat="server" ID="btnAcessar" CssClass="btn btn-primary" Text="Acessar" OnClick="btnAcessar_Click" />
        <p>
            <asp:Label runat="server" ID="lblMensagem" ForeColor="Blue"></asp:Label>
        </p>
    </div>
    </form>
</body>
</html>
