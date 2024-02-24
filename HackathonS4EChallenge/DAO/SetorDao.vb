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
            Dim sql = $"SELECT 
                        Setor.NomeSetor AS Setor,
                        (SELECT R.NomeGerente FROM RelacaoGerenteFunc R WHERE R.idRel = Setor.Gerente) AS Gerente,
                        NomeFunc AS Funcionário,
                        FORMAT(SalarioBase, 'C', 'pt-BR') AS Salário
                    FROM 
                        Funcionario Func
                    JOIN 
                        Setor ON Setor.idSetor = Func.Setor

                    UNION

                    SELECT 
                        'Total' AS Setor,
                        NULL AS Gerente,
                        NULL AS Funcionário,
                        FORMAT(SUM(SalarioBase), 'C', 'pt-BR') AS Salário
                    FROM 
                        Funcionario Func
                    JOIN 
                        Setor ON Setor.idSetor = Func.Setor;"
            Dim conection As New Connection
            Return conection.Execute(sql)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
