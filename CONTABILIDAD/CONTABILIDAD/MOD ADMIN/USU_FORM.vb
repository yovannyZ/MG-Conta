Imports System.Data.SqlClient
Public Class USU_FORM
    Dim M As Boolean
    Dim USU0 As String
    Private Sub btn_cancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_cancelar.Click
        TabControl1.SelectedTab = (TabPage1)
        btn_modificar.Select()
    End Sub
    Private Sub btn_guardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_guardar.Click
        Dim I As Integer = 0
        Dim CONT As Integer = (dgw2.Rows.Count - 1)
        'Dim VB$t_i4$L0 As Integer = CONT
        I = 0
        Do While (I <= CONT)
            Dim COD2 As String = dgw2.Item(0, I).Value.ToString
            Dim ESTADO As String = dgw2.Item(7, I).Value.ToString
            GUARDAR(COD2, ESTADO)
            I += 1
        Loop
        MessageBox.Show("La Seguridad del Usuario se Actualiz�", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        TabControl1.SelectedTab = (TabPage1)
        btn_modificar.Select()
    End Sub
    Private Sub btn_modificar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_modificar.Click
        Try
            Dim I As Integer = dgw1.CurrentRow.Index
        Catch ex As Exception
            MessageBox.Show("Debe elegir un registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        USU0 = dgw1.Item(0, dgw1.CurrentRow.Index).Value.ToString
        CARGAR_MODULO()
        CARGAR_DATOS()
        TabControl1.SelectedTab = (TabPage2)
    End Sub
    Private Sub btn_salir_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_salir.Click
        Module01.main(37) = (0)
        Close()
    End Sub
    Sub CARGAR_DATOS()
        Dim I As Integer = 0
        Dim CONT As Integer = (dgw2.Rows.Count - 1)
        Try
            Dim PROG_01 As New SqlCommand("CARGAR_USU_FORM", con)
            PROG_01.CommandType = (CommandType.StoredProcedure)
            PROG_01.Parameters.Add("@COD_USU", SqlDbType.Char).Value = (USU0)
            con.Open()
            PROG_01.ExecuteNonQuery()
            Dim Rs3 As SqlDataReader = PROG_01.ExecuteReader
            Do While Rs3.Read
                'Dim VB$t_i4$L0 As Integer = CONT
                I = 0
                Do While (I <= CONT)
                    If dgw2.Item(0, I).Value.ToString = Rs3.GetValue(0) Then
                        dgw2.Item(7, I).Value = True
                    End If
                    I += 1
                Loop
            Loop
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub CARGAR_MODULO()
        dgw2.Rows.Clear()
        Try
            Dim PROG_01 As New SqlCommand("CARGAR_FORMULARIO", con)
            'PROG_01.CommandType = (CommandType.StoredProcedure)
            'PROG_01.Parameters.Add("COD_SISTEMA", SqlDbType.Char).Value = ("COS")
            con.Open()
            PROG_01.ExecuteNonQuery()
            Dim Rs3 As SqlDataReader = PROG_01.ExecuteReader
            Do While Rs3.Read
                dgw2.Rows.Add(Rs3.GetValue(0), Rs3.GetValue(1), (Rs3.GetValue(2)), (Rs3.GetValue(3)), (Rs3.GetValue(4)), (Rs3.GetValue(5)), (Rs3.GetValue(6)), False)
            Loop
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub CARGAR_USUARIOS()
        Try
            Dim CMD As New SqlCommand("MOSTRAR_USUARIO_EMP0", con2)
            CMD.CommandType = (CommandType.StoredProcedure)
            CMD.Parameters.Add("COD_EMPRESA", SqlDbType.Char).Value = (COD_EMPRESA)
            Dim ADAP As New SqlDataAdapter(CMD)
            Dim DT As New DataTable("USU")
            ADAP.Fill(DT)
            dgw1.DataSource = (DT)
            dgw1.Columns.Item(0).Visible = (False)
        Catch ex As Exception
            MsgBox(ex.Message)
            'MsgBox(ex.Message)
        End Try
    End Sub
    Sub GUARDAR(ByVal COD_MODULO As Object, ByVal ESTADO As Object)
        Try
            Dim CMD As New SqlCommand("INSERTAR_USUARIO_FORM", con)
            CMD.CommandType = (CommandType.StoredProcedure)
            CMD.Parameters.Add("@COD_FORM", SqlDbType.Char).Value = COD_MODULO
            CMD.Parameters.Add("@COD_USU", SqlDbType.Char).Value = USU0
            CMD.Parameters.Add("@ESTADO", SqlDbType.VarChar).Value = ESTADO
            con.Open()
            CMD.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message)
            'MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub USU_MODULO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Return) Then
            SendKeys.Send("{TAB}")
        End If
        If (e.KeyCode = Keys.F1) Then
            Try
                '  Help.ShowHelp(Me, manual & "modulo.htm", HelpNavigator.Topic)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error al Cargar ayuda ", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End Try
        End If
    End Sub

    Private Sub USU_MODULO_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        KeyPreview = True
        dgw1.ColumnHeadersDefaultCellStyle.Font = (New Font("ARIAL", 8.0!, FontStyle.Bold))
        dgw2.ColumnHeadersDefaultCellStyle.Font = (New Font("ARIAL", 8.0!, FontStyle.Bold))
        CARGAR_USUARIOS()
        btn_modificar.Select()
    End Sub
End Class