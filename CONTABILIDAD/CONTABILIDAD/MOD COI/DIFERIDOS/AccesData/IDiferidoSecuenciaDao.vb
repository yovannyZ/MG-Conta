Public Class IDiferidoSecuenciaDao
    Private Shared _instancia As IDiferidoSecuenciaDao

    Public Shared Function ObtenerInstancia() As IDiferidoSecuenciaDao
        If _instancia Is Nothing Then
            _instancia = New IDiferidoSecuenciaDao
        End If
        Return _instancia
    End Function

    Public Function Obtener(ByVal FeAño As String, ByVal FeMes As String, ByVal codDoc As String, _
    ByVal nroDoc As String, ByVal codPer As String) As List(Of IDiferidoSecuencia)
        Dim lista As New List(Of IDiferidoSecuencia)

        Dim query As String = "ObtenerIDiferidoSecuencia"

        Dim Parametros(4) As SqlParameter
        Parametros(0) = DBHelper.MakeParam("@FeAño", FeAño)
        Parametros(1) = DBHelper.MakeParam("@FeMes", FeMes)
        Parametros(2) = DBHelper.MakeParam("@CodDoc", codDoc)
        Parametros(3) = DBHelper.MakeParam("@NroDoc", nroDoc)
        Parametros(4) = DBHelper.MakeParam("@CodPer", codPer)


        Dim dr As SqlDataReader = DBHelper.ExecuteDataReader(query, Parametros)

        If dr.HasRows Then
            Dim iDiferidoSecuencia As IDiferidoSecuencia
            While (dr.Read)
                iDiferidoSecuencia = New IDiferidoSecuencia()
                iDiferidoSecuencia.FeAño = dr.GetString(0)
                iDiferidoSecuencia.FeMes = dr.GetString(1)
                iDiferidoSecuencia.CodDoc = dr.GetString(2)
                iDiferidoSecuencia.NroDoc = dr.GetString(3)
                iDiferidoSecuencia.CodPer = dr.GetString(4)
                iDiferidoSecuencia.AñoDis = dr.GetString(5)
                iDiferidoSecuencia.MesDis = dr.GetString(6)

                lista.Add(iDiferidoSecuencia)

            End While
        End If
        dr.Close()
        Return lista
    End Function

    Public Function Insertar(ByVal iDiferidoSecuencia As IDiferidoSecuencia, Optional ByVal tr As SqlTransaction = Nothing, Optional ByVal cn As SqlConnection = Nothing) As Boolean
        Dim query As String = "InsertarIDiferidoSecuencia"
        Dim Parametros(6) As SqlParameter
        Parametros(0) = DBHelper.MakeParam("@FeAño", iDiferidoSecuencia.FeAño)
        Parametros(1) = DBHelper.MakeParam("@FeMes", iDiferidoSecuencia.FeMes)
        Parametros(2) = DBHelper.MakeParam("@CodDoc", iDiferidoSecuencia.CodDoc)
        Parametros(3) = DBHelper.MakeParam("@NroDoc", iDiferidoSecuencia.NroDoc)
        Parametros(4) = DBHelper.MakeParam("@CodPer", iDiferidoSecuencia.CodPer)
        Parametros(5) = DBHelper.MakeParam("@FeAñoDif", iDiferidoSecuencia.AñoDis)
        Parametros(6) = DBHelper.MakeParam("@FeMesDif", iDiferidoSecuencia.MesDis)

        If IsNothing(tr) Then
            Return DBHelper.ExecuteNonQuery(query, Parametros)
        Else
            Return DBHelper.ExecuteNonQuery(query, Parametros, tr, cn)
        End If
    End Function

    Public Function Eliminar(ByVal iDiferidoSecuencia As IDiferidoSecuencia, Optional ByVal tr As SqlTransaction = Nothing, Optional ByVal cn As SqlConnection = Nothing) As Boolean
        Dim query As String = "EliminarIDiferidoSecuencia"

        Dim Parametros(6) As SqlParameter
        Parametros(0) = DBHelper.MakeParam("@FeAño", iDiferidoSecuencia.FeAño)
        Parametros(1) = DBHelper.MakeParam("@FeMes", iDiferidoSecuencia.FeMes)
        Parametros(2) = DBHelper.MakeParam("@CodDoc", iDiferidoSecuencia.CodDoc)
        Parametros(3) = DBHelper.MakeParam("@NroDoc", iDiferidoSecuencia.NroDoc)
        Parametros(4) = DBHelper.MakeParam("@CodPer", iDiferidoSecuencia.CodPer)
        Parametros(5) = DBHelper.MakeParam("@FeAñoDif", iDiferidoSecuencia.AñoDis)
        Parametros(6) = DBHelper.MakeParam("@FeMesDif", iDiferidoSecuencia.MesDis)

        If IsNothing(tr) Then
            Return DBHelper.ExecuteNonQuery(query, Parametros)
        Else
            Return DBHelper.ExecuteNonQuery(query, Parametros, tr, cn)
        End If

    End Function

End Class
