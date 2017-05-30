Imports System.Data.SqlClient
Public Class IDiferidoDao

    Public Function Listar() As List(Of IDiferido)
        Dim lista As New List(Of IDiferido)

        Dim query As String = "ListarIDiferido"
        Dim dr As SqlDataReader = DBHelper.ExecuteDataReader(query)

        If dr.HasRows Then
            Dim iDiferido As IDiferido
            While (dr.Read)
                iDiferido = New IDiferido()
                iDiferido.FeAño = dr.GetString(0)
                iDiferido.FeMes = dr.GetString(1)
                iDiferido.CodDoc = dr.GetString(2)
                iDiferido.NroDoc = dr.GetString(3)
                iDiferido.CodPer = dr.GetString(4)
                iDiferido.FechaDoc = dr.GetDateTime(5)
                iDiferido.CodCuenta = dr.GetString(6)
                iDiferido.Glosa = dr.GetString(7)
                iDiferido.FechaVigenciaDel = dr.GetDateTime(8)
                iDiferido.FechaVigenciaAl = dr.GetDateTime(9)
                iDiferido.FechaIniOpe = dr.GetDateTime(10)
                iDiferido.Importe = dr.GetDecimal(11)
                iDiferido.NroCuotas = dr.GetInt32(12)
                iDiferido.NroCuotasTran = dr.GetInt32(13)
                iDiferido.CodAux = dr.GetString(14)
                iDiferido.CodComp = dr.GetString(15)
                iDiferido.NroComp = dr.GetString(16)
                iDiferido.ImpAcumulado = dr.GetDecimal(17)
                iDiferido.ImpInicalAño = dr.GetDecimal(18)
                lista.Add(iDiferido)

            End While
        End If

        Return lista
    End Function

End Class
