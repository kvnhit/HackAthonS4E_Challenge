Public Class VisualizarSetor
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        PopulateGridSetor()
    End Sub

    Protected Sub PopulateGridSetor()
        Dim setorService As New SetorServices
        Dim data = setorService.Vizualizar()
        GridView1.DataSource = data
        GridView1.DataBind()
    End Sub

End Class