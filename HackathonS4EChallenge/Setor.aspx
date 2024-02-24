<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Setor.aspx.vb" Inherits="HackathonS4EChallenge.Setor1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Style/style.css" rel="stylesheet" />

    <h1 style="margin-bottom: 2rem"> Cadastro de Setor</h1>

    <div class="forms">

        <asp:Label ID="LBL_NomeSetor" runat="server" Text="Setor" CssClass="aligned-label"></asp:Label>
        <asp:TextBox ID="TXT_NomeSetor" runat="server" MaxLength="60" CssClass="aligned-textbox" RequiredFieldValidator="true" ></asp:TextBox>

        <asp:Label ID="LBL_DescricaoSetor" runat="server" Text="Descrição" CssClass="aligned-label"></asp:Label>
        <asp:TextBox ID="TXT_DescricaoSetor" runat="server" MaxLength="60" CssClass="aligned-textbox" RequiredFieldValidator="true"></asp:TextBox>

        <asp:Label ID="LBL_Gerente" runat="server" Text="Gerente" CssClass="aligned-label"></asp:Label>
        <asp:DropDownList ID="DropDownList1_Gerente" runat="server" CssClass="aligned-textbox"></asp:DropDownList>


        <asp:Button CssClass="btn btn-primary" ID="BTN_Salvar" runat="server" Text="Salvar" style="margin-top: 1rem"/>
    </div>
</asp:Content>
