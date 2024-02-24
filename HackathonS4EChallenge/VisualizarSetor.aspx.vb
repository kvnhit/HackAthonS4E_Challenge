Public Class VisualizarSetor
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        PopulateGridSetor()
    End Sub

    Protected Sub PopulateGridSetor()
        Dim setorService As New SetorServices
        Dim data = setorService.Vizualizar()
        Dim data2 = setorService.VizualizarTotal()
        GridView1.DataSource = data
        GridView1.DataBind()
        GridView2.DataSource = data2
        GridView2.DataBind()
    End Sub

End Class