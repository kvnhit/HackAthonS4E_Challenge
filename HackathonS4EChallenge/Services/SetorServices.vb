Public Class SetorServices
    Public Sub Cadastrar(setor As Setor)
        Try
            Dim setorDao As New SetorDao
            setorDao.Insert(setor)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function PreencherDropDownGerente() As DataView
        Try
            Dim setorDao As New SetorDao
            Return setorDao.GetSelect()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
