<%@ Page Title="Funcionários" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Funcionario.aspx.vb" Inherits="HackathonS4EChallenge.Funcionario1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Style/style.css" rel="stylesheet" />

<h1 style="margin-bottom: 2rem"> Cadastro de Funcionário  </h1>
    
<div class="forms">
      
           
    <asp:Label ID="LBL_NomeFuncionario" runat="server" Text="Nome do Funcionário" CssClass="aligned-label"></asp:Label>
    <asp:TextBox ID="TXT_NomeFuncionario" runat="server" MaxLength="30" CssClass="aligned-textbox" RequiredFieldValidator="true" ></asp:TextBox>
   
    <asp:Label ID="LBL_Cargo" runat="server" Text="Cargo" CssClass="aligned-label"></asp:Label>
    <asp:DropDownList ID="DropDownList_Cargo" runat="server" CssClass="aligned-textbox"></asp:DropDownList>

    <asp:Label ID="LBL_Salario" runat="server" Text="Salário" CssClass="aligned-label"></asp:Label>
    <asp:TextBox ID="TXT_Salario" runat="server" maxlength="20" AutoPostBack="true" PlaceHolder="R$ " RequiredFieldValidator="true" > </asp:TextBox>
    
    <asp:Label ID="LBL_Setor" runat="server" Text="Setor" CssClass="aligned-label"></asp:Label>
    <asp:DropDownList ID="DropDownList1_Setor" runat="server" CssClass="aligned-textbox"></asp:DropDownList>
    
   <asp:Label ID="LBL_DataAdmissao" runat="server" Text="Data da Admissão" CssClass="aligned-label"></asp:Label>
   <asp:TextBox ID="TXT_DataAdmissao" runat="server" Type="date" CssClass="aligned-textbox" RequiredFieldValidator="true"></asp:TextBox>
    

    
    <asp:Button CssClass="btn btn-primary" ID="BTN_Salvar" runat="server" Text="Salvar" style="margin-top: 1rem"/>
       
    </div>
</asp:Content>
