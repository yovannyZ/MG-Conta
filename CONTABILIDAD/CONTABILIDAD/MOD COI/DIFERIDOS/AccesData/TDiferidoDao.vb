Public Class TDiferidoDao
    Private Shared _instancia As TDiferidoDao
    Public Shared Function ObtenerInstancia() As TDiferidoDao
        If _instancia Is Nothing Then
            _instancia = New TDiferidoDao
        End If
        Return _instancia
    End Function

    Public Function Insertar(ByVal tDiferifo As TDiferido, Optional ByVal tr As SqlTransaction = Nothing, Optional ByVal cn As SqlConnection = Nothing) As Boolean
        Dim query As String = "InsertarTDiferido"
        Dim Parametros(15) As SqlParameter
        Parametros(0) = DBHelper.MakeParam("@FeAño", tDiferifo.FeAño)
        Parametros(1) = DBHelper.MakeParam("@FeMes", tDiferifo.FeMes)
        Parametros(2) = DBHelper.MakeParam("@CodDoc", tDiferifo.CodDoc)
        Parametros(3) = DBHelper.MakeParam("@NroDoc", tDiferifo.NroDoc)
        Parametros(4) = DBHelper.MakeParam("@CodPer", tDiferifo.CodPer)
        Parametros(5) = DBHelper.MakeParam("@CodCC", tDiferifo.CodCC)
        Parametros(6) = DBHelper.MakeParam("@CodCuenta", tDiferifo.CodCuenta)
        Parametros(7) = DBHelper.MakeParam("@Glosa", tDiferifo.Glosa)
        Parametros(8) = DBHelper.MakeParam("@FeDoc", tDiferifo.FechaDoc)
        Parametros(9) = DBHelper.MakeParam("@Imp", tDiferifo.Importe)
        Parametros(10) = DBHelper.MakeParam("@CodDH", tDiferifo.CodDH)
        Parametros(11) = DBHelper.MakeParam("@CodMoneda", tDiferifo.CodMoneda)
        Parametros(12) = DBHelper.MakeParam("@TipoCambio", tDiferifo.TipoCambio)
        Parametros(13) = DBHelper.MakeParam("@NroCuota", tDiferifo.NroCuota)
        Parametros(14) = DBHelper.MakeParam("@StTrans", tDiferifo.StTrans)
        Parametros(15) = DBHelper.MakeParam("@StCierre", tDiferifo.StCierre)

        If IsNothing(tr) Then
            Return DBHelper.ExecuteNonQuery(query, Parametros)
        Else
            Return DBHelper.ExecuteNonQuery(query, Parametros, tr, cn)
        End If
    End Function

    Public Function Eliminar(ByVal tDiferifo As TDiferido, Optional ByVal tr As SqlTransaction = Nothing, Optional ByVal cn As SqlConnection = Nothing) As Boolean
        Dim query As String = "EliminarTDiferido"
        Dim Parametros(15) As SqlParameter
        Parametros(0) = DBHelper.MakeParam("@FeAño", tDiferifo.FeAño)
        Parametros(1) = DBHelper.MakeParam("@FeMes", tDiferifo.FeMes)
        Parametros(2) = DBHelper.MakeParam("@CodDoc", tDiferifo.CodDoc)
        Parametros(3) = DBHelper.MakeParam("@NroDoc", tDiferifo.NroDoc)
        Parametros(4) = DBHelper.MakeParam("@CodPer", tDiferifo.CodPer)
        Parametros(5) = DBHelper.MakeParam("@CodCC", tDiferifo.CodCC)
        Parametros(6) = DBHelper.MakeParam("@CodCuenta", tDiferifo.CodCuenta)
        Parametros(7) = DBHelper.MakeParam("@Glosa", tDiferifo.Glosa)
        Parametros(8) = DBHelper.MakeParam("@FeDoc", tDiferifo.FechaDoc)
        Parametros(9) = DBHelper.MakeParam("@Imp", tDiferifo.Importe)
        Parametros(10) = DBHelper.MakeParam("@CodDH", tDiferifo.CodDH)
        Parametros(11) = DBHelper.MakeParam("@CodMoneda", tDiferifo.CodMoneda)
        Parametros(12) = DBHelper.MakeParam("@TipoCambio", tDiferifo.TipoCambio)
        Parametros(13) = DBHelper.MakeParam("@NroCuota", tDiferifo.NroCuota)
        Parametros(14) = DBHelper.MakeParam("@StTrans", tDiferifo.StTrans)
        Parametros(15) = DBHelper.MakeParam("@StCierre", tDiferifo.StCierre)

        If IsNothing(tr) Then
            Return DBHelper.ExecuteNonQuery(query, Parametros)
        Else
            Return DBHelper.ExecuteNonQuery(query, Parametros, tr, cn)
        End If
    End Function
End Class
