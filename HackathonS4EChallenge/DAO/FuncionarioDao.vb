Public Class FuncionarioDao
    Public Sub Insert(func As Funcionario)
        Try
            Dim sql = $"insert into Funcionario values ('{func.Nome}', '{func.Cargo}', '{func.SalarioBase}', cast('{func.DataAdmissao}' as date), '{func.Setor}')"
            Dim connection As New Connection
            connection.ExecuteReader(sql)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function GetData() As DataView
        Try
            Dim sql = $"SELECT 
                        NomeFunc AS Nome,
                        (SELECT C.NomeCargo FROM Cargo C WHERE C.idCargo = F.Cargo) AS Cargo,
                        (SELECT S.NomeSetor FROM Setor S WHERE S.idSetor = F.Setor) AS Setor,
                        CONCAT('R$ ', FORMAT(SalarioBase, 'N', 'pt-BR')) AS Salário,
                        FORMAT(DataAdmissao, 'dd/MM/yyyy') AS 'Data de Admissão'
                    FROM 
                        Funcionario F;
"
            Dim conection As New Connection
            Return conection.Execute(sql)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function GetSelectCargo() As DataView
        Try
            Dim sql = $"select idCargo as id, NomeCargo as nome from Cargo"
            Dim conection As New Connection
            Return conection.Execute(sql)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function GetSelectSetor() As DataView
        Try
            Dim sql = $"select idSetor as id, NomeSetor as nome from Setor"
            Dim conection As New Connection
            Return conection.Execute(sql)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
