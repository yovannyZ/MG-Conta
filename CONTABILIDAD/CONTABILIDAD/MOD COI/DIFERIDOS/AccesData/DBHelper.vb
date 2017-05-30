Imports System.Data.SqlClient
Public Class DBHelper

    Public Shared Function MakeParam(ByVal paramName As String, ByVal objValue As Object) As SqlParameter
        Dim param As SqlParameter
        param = New SqlParameter(paramName, objValue)
        param.Value = objValue
        Return param
    End Function

    Public Shared Function ExecuteNonQuery(ByVal query As String, ByVal parameters As SqlParameter()) As Boolean
        Dim _exito As Boolean = False
        con.Open()
        Dim cmd As New SqlCommand(query, con)
        cmd.CommandType = CommandType.StoredProcedure

        If Not IsNothing(parameters) Then
            For Each param As SqlParameter In parameters
                cmd.Parameters.Add(param)
            Next
        End If

        _exito = cmd.ExecuteNonQuery > 0
        con.Close()
        Return _exito
    End Function

    Public Shared Function ExecuteDataReader(ByVal query As String, Optional ByVal parameters As SqlParameter() = Nothing) As Object
        Dim obj As New Object
        con.Open()
        Dim cmd As New SqlCommand(query, con)
        cmd.CommandType = CommandType.StoredProcedure

        If Not IsNothing(parameters) Then
            For Each param As SqlParameter In parameters
                cmd.Parameters.Add(param)
            Next
        End If

        obj = cmd.ExecuteScalar()
        con.Close()

        Return obj
    End Function

End Class
