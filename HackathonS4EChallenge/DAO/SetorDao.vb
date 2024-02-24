Imports System.Collections.ObjectModel

Public Class SetorDao
    Public Sub Insert(setor As Setor)
        Try
            Dim sql = $"insert into Setor values ('{setor.NomeSetor}', '{setor.Descricao}', '{setor.Gerente}')"
            Dim connection As New Connection
            connection.ExecuteReader(sql)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function GetSelect() As DataView
        Try
            Dim sql = $"select idRel as id, NomeGerente as nome from RelacaoGerenteFunc"
            Dim conection As New Connection
            Return conection.Execute(sql)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function GetData() As DataView
        Try
            Dim sql = $"select Setor.NomeSetor as Setor, Setor.Gerente as Gerente, NomeFunc as Funcionário, SalarioBase as Salário from Funcionario Func Join Setor on Setor.idSetor = Func.Setor"
            Dim conection As New Connection
            Return conection.Execute(sql)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function GetDataTotal() As DataView
        Try
            Dim sql = $"select (select 'R$') as 'Total  ', SUM(SalarioBase) as Salário from Funcionario"
            Dim conection As New Connection
            Return conection.Execute(sql)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
