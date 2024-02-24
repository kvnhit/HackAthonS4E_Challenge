Public Class Setor1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            PopulateDropDownGerente()
        End If
    End Sub

    Protected Sub BTN_Salvar_Click(sender As Object, e As EventArgs) Handles BTN_Salvar.Click
        Dim setorService As New SetorServices
        Dim setor As New Setor With
            {
            .NomeSetor = TXT_NomeSetor.Text,
            .Descricao = TXT_DescricaoSetor.Text,
            .Gerente = 3
            }
        setorService.Cadastrar(setor)
    End Sub
    Protected Sub PopulateDropDownGerente()
        Dim setorService As New SetorServices
        DropDownList1_Gerente.DataSource = setorService.PreencherDropDownGerente()
        DropDownList1_Gerente.DataTextField = "nome"
        DropDownList1_Gerente.DataValueField = "id"
        DropDownList1_Gerente.DataBind()
    End Sub
End Class