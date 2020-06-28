<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="ProjetoMVCD09.UI.SignIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../Content/bootstrap.css" rel="stylesheet"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>
        <div class="row">
            <div class="col-4"></div>
            <div class="col-4">
                <h2>Verificação de Benefício</h2>
            </div>
            <div class="col-4"></div>
        </div>
        <div class="row">
            <div class="col-4">

            </div>
            <div class="col-4">
                <asp:Label ID="lblCpfD09" runat="server" Text="CPF "></asp:Label>
                <asp:TextBox ID="txtCpfD09" type="number" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" id="ValidCampoCpf" controltovalidate="txtCpfD09" errormessage="Digite seu Cpf!" />
                <br/>

               <asp:Label ID="Label1" runat="server" Text="Nome "></asp:Label>
                <asp:TextBox ID="txtNomeD09" type="text" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator1" controltovalidate="txtNomeD09" errormessage="Digite seu Nome!" />
                <br/>

                <asp:Label ID="lblNomeMaeD09" runat="server" Text="Nome da Mae "></asp:Label>
                <asp:TextBox ID="txtNomeMaeD09" type="text" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" id="ValidCampoNomeMae" controltovalidate="txtNomeMaeD09" errormessage="Digite o nome da sua mae!!" />
                <br/>

                <asp:Button ID="btnEnviarD09" runat="server" Text="Enviar" CssClass="btn btn-outline-dark" OnClick="btnEnviarD09_Click" />
                <br/><br/>
                <asp:Label ID="msgerror" runat="server" Text=""></asp:Label>
            </div>
            <div class="col-4">

            </div>
        </div>
        
    </form>
</body>
</html>
