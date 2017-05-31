Public Class TDiferidoCCDao
    Private Shared _instancia As TDiferidoCCDao
    Public Shared Function ObtenerInstancia() As TDiferidoCCDao
        If _instancia Is Nothing Then
            _instancia = New TDiferidoCCDao
        End If
        Return _instancia
    End Function

    Public Function Listar(ByVal FeAño As String, ByVal FeMes As String, ByVal codDoc As String, _
    ByVal nroDoc As String, ByVal codPer As String) As List(Of TDiferidoCC)
        Dim lista As New List(Of TDiferidoCC)

        Dim query As String = "ObtenerTDiferidoCC"

        Dim Parametros(4) As SqlParameter
        Parametros(0) = DBHelper.MakeParam("@FeAño", FeAño)
        Parametros(1) = DBHelper.MakeParam("@FeMes", FeMes)
        Parametros(2) = DBHelper.MakeParam("@CodDoc", codDoc)
        Parametros(3) = DBHelper.MakeParam("@NroDoc", nroDoc)
        Parametros(4) = DBHelper.MakeParam("@CodPer", codPer)


        Dim dr As SqlDataReader = DBHelper.ExecuteDataReader(query, Parametros)

        If dr.HasRows Then
            Dim tDiferidoCC As TDiferidoCC
            While (dr.Read)
                tDiferidoCC = New TDiferidoCC()
                tDiferidoCC.FeAño = dr.GetString(0)
                tDiferidoCC.FeMes = dr.GetString(1)
                tDiferidoCC.CodDoc = dr.GetString(2)
                tDiferidoCC.NroDoc = dr.GetString(3)
                tDiferidoCC.CodPer = dr.GetString(4)
                tDiferidoCC.CodCC = dr.GetString(5)
                tDiferidoCC.CodCuenta = dr.GetString(6)
                tDiferidoCC.PorDif = dr.GetDecimal(7)

                lista.Add(tDiferidoCC)

            End While
        End If
        dr.Close()
        Return lista
    End Function

    Public Function Insertar(ByVal tDiferifo As TDiferidoCC, Optional ByVal tr As SqlTransaction = Nothing, Optional ByVal cn As SqlConnection = Nothing) As Boolean
        Dim query As String = "InsertarTDiferidoCC"
        Dim Parametros(7) As SqlParameter
        Parametros(0) = DBHelper.MakeParam("@FeAño", tDiferifo.FeAño)
        Parametros(1) = DBHelper.MakeParam("@FeMes", tDiferifo.FeMes)
        Parametros(2) = DBHelper.MakeParam("@CodDoc", tDiferifo.CodDoc)
        Parametros(3) = DBHelper.MakeParam("@NroDoc", tDiferifo.NroDoc)
        Parametros(4) = DBHelper.MakeParam("@CodPer", tDiferifo.CodPer)
        Parametros(5) = DBHelper.MakeParam("@CodCC", tDiferifo.CodCC)
        Parametros(6) = DBHelper.MakeParam("@CodCuenta", tDiferifo.CodCuenta)
        Parametros(7) = DBHelper.MakeParam("@PorDif", tDiferifo.PorDif)

        If IsNothing(tr) Then
            Return DBHelper.ExecuteNonQuery(query, Parametros)
        Else
            Return DBHelper.ExecuteNonQuery(query, Parametros, tr, cn)
        End If
    End Function

    Public Function Eliminar(ByVal tDiferifo As TDiferidoCC, Optional ByVal tr As SqlTransaction = Nothing, Optional ByVal cn As SqlConnection = Nothing) As Boolean
        Dim query As String = "EliminarTDiferidoCC"

        Dim Parametros(4) As SqlParameter
        Parametros(0) = DBHelper.MakeParam("@FeAño", tDiferifo.FeAño)
        Parametros(1) = DBHelper.MakeParam("@FeMes", tDiferifo.FeMes)
        Parametros(2) = DBHelper.MakeParam("@CodDoc", tDiferifo.CodDoc)
        Parametros(3) = DBHelper.MakeParam("@NroDoc", tDiferifo.NroDoc)
        Parametros(4) = DBHelper.MakeParam("@CodPer", tDiferifo.CodPer)

        If IsNothing(tr) Then
            Return DBHelper.ExecuteNonQuery(query, Parametros)
        Else
            Return DBHelper.ExecuteNonQuery(query, Parametros, tr, cn)
        End If

    End Function

End Class
