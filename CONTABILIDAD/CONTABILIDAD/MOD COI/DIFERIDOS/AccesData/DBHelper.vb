Imports System.Data.SqlClient
Public Class DBHelper

    Public Shared Function MakeParam(ByVal paramName As String, ByVal objValue As Object) As SqlParameter
        Dim param As SqlParameter
        param = New SqlParameter(paramName, objValue)
        param.Value = objValue
        Return param
    End Function

    Public Shared Function ExecuteNonQuery(ByVal query As String, ByVal parameters As SqlParameter(), Optional ByVal tr As SqlTransaction = Nothing, Optional ByVal cn As SqlConnection = Nothing) As Boolean
        Dim _exito As Boolean = False
        Dim cmd As SqlCommand
        If IsNothing(tr) Then
            con.Open()
            cmd = New SqlCommand(query, con)
            cmd.CommandType = CommandType.StoredProcedure
        Else
            cmd = New SqlCommand(query, cn, tr)
            cmd.CommandType = CommandType.StoredProcedure
        End If
       

        If Not IsNothing(parameters) Then
            For Each param As SqlParameter In parameters
                cmd.Parameters.Add(param)
            Next
        End If

        _exito = cmd.ExecuteNonQuery > 0

        If IsNothing(tr) Then
            con.Close()
        End If

        Return _exito
    End Function

    Public Shared Function ExecuteDataReader(ByVal query As String, Optional ByVal parameters As SqlParameter() = Nothing) As Object
        Dim dr As SqlDataReader
        con.Open()
        Dim cmd As New SqlCommand(query, con)
        cmd.CommandType = CommandType.StoredProcedure

        If Not IsNothing(parameters) Then
            For Each param As SqlParameter In parameters
                cmd.Parameters.Add(param)
            Next
        End If

        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        Return dr
    End Function

End Class
