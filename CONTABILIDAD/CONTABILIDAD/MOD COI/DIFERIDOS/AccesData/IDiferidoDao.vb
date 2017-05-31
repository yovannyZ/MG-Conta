Imports System.Data.SqlClient
Public Class IDiferidoDao

    Private Shared _instancia As IDiferidoDao
    Public Shared Function ObtenerInstancia() As IDiferidoDao
        If _instancia Is Nothing Then
            _instancia = New IDiferidoDao
        End If
        Return _instancia
    End Function

    Public Function Listar(ByVal FeAño As String, ByVal FeMes As String) As List(Of IDiferido)
        Dim lista As New List(Of IDiferido)

        Dim query As String = "ListarIDiferido"

        Dim Parametros(1) As SqlParameter
        Parametros(0) = DBHelper.MakeParam("@FeAño", FeAño)
        Parametros(1) = DBHelper.MakeParam("@FeMEs", FeMes)

        Dim dr As SqlDataReader = DBHelper.ExecuteDataReader(query, Parametros)

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
        dr.Close()
        Return lista
    End Function

    Public Function Actualizar(ByVal iDiferido As IDiferido) As Boolean
        Dim query As String = "ActualizarCuotasIDiferido"
        Dim Parametros(5) As SqlParameter
        Parametros(0) = DBHelper.MakeParam("@FeAño", iDiferido.FeAño)
        Parametros(1) = DBHelper.MakeParam("@FeMes", iDiferido.FeMes)
        Parametros(2) = DBHelper.MakeParam("@CodDoc", iDiferido.CodDoc)
        Parametros(3) = DBHelper.MakeParam("@NroDoc", iDiferido.NroDoc)
        Parametros(4) = DBHelper.MakeParam("@CodPer", iDiferido.CodPer)
        Parametros(5) = DBHelper.MakeParam("@NroCuotas", iDiferido.NroCuotas)
        Return DBHelper.ExecuteNonQuery(query, Parametros)
    End Function

End Class
