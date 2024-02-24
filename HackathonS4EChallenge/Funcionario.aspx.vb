Public Class Funcionario1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            PopulateDropDownCargo()
            PopulateDropDownSetor()
        End If
    End Sub

    Protected Sub BTN_Salvar_Click(sender As Object, e As EventArgs) Handles BTN_Salvar.Click
        Dim funcService As New funcionarioService
        Dim func As New Funcionario With
            {
            .Nome = TXT_NomeFuncionario.Text,
            .Cargo = DropDownList_Cargo.SelectedValue,
            .SalarioBase = TXT_Salario.Text,
            .DataAdmissao = TXT_DataAdmissao.Text,
            .Setor = DropDownList1_Setor.SelectedValue
            }
        funcService.Cadastrar(func)
    End Sub
    Protected Sub PopulateDropDownCargo()
        Dim funcService As New funcionarioService
        DropDownList_Cargo.DataSource = funcService.PreencherDropDownCargo()
        DropDownList_Cargo.DataTextField = "nome"
        DropDownList_Cargo.DataValueField = "id"
        DropDownList_Cargo.DataBind()
    End Sub
    Protected Sub PopulateDropDownSetor()
        Dim funcService As New funcionarioService
        DropDownList1_Setor.DataSource = funcService.PreencherDropDownSetor()
        DropDownList1_Setor.DataTextField = "nome"
        DropDownList1_Setor.DataValueField = "id"
        DropDownList1_Setor.DataBind()
    End Sub
End Class