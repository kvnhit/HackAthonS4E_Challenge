Public Class VisualizarFunc
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub PopulateGridFuncionarios()
        Dim funcService As New funcionarioService
        Dim data = funcService.Vizualizar()
        GridView1.DataSource = data
        GridView1.DataBind()
    End Sub

End Class