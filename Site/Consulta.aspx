<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="Site.Consulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="Content/bootstrap.css" />
    <script src="Scripts/bootstrap.min.js" type="text/javascript"></script>
    <script src="Scripts/jquery-1.9.1.min.js" type="text/javascript"></script>
    <title>Consulta de Pessoas</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div>
            <div class="row">
                <h3 class="well">Consulta de Pessoas</h3>
                <br />

                <asp:GridView runat="server" ID="grdPessoas" CssClass="table table-hover table-responsive"
                    GridLines="None" AutoGenerateColumns="false" BackColor="Thistle">
                    <Columns>
                        <asp:BoundField DataField="Codigo" HeaderText="Código" />
                        <asp:BoundField DataField="Nome" HeaderText="Nome" />
                        <asp:BoundField DataField="Endereco" HeaderText="Endereço" />
                        <asp:BoundField DataField="Email" HeaderText="E-mail" />
                    </Columns>
                    <RowStyle CssClass="cursor-pointer" />
                </asp:GridView>

                <p>
                    <asp:Label runat="server" ID="lblMensagem" ForeColor="Red"></asp:Label>
                </p>

                <a href="Default.aspx" class="btn btn-default">Voltar</a>
            </div>
        </div>    
    </div>
    </form>
</body>
</html>
