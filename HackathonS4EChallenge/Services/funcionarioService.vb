Public Class funcionarioService
    Public Sub Cadastrar(func As Funcionario)
        Try
            Dim funcDao As New FuncionarioDao
            funcDao.Insert(func)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function PreencherDropDownCargo() As DataView
        Try
            Dim funcDao As New FuncionarioDao
            Return funcDao.GetSelectCargo()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function PreencherDropDownSetor() As DataView
        Try
            Dim funcDao As New FuncionarioDao
            Return funcDao.GetSelectSetor()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Vizualizar() As DataView
        Try
            Dim funcDao As New FuncionarioDao
            Return funcDao.GetData()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
