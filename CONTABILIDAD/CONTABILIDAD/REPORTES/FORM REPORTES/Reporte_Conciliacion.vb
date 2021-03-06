Imports System.Data.SqlClient
Public Class Reporte_Conciliacion

    Private obj As New Class1
    Private OFR As New REP_CONCILIACION
    Private Sub btn_pantalla1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_pantalla1.Click
        If (Strings.Trim(txt_cod_ban.Text) = "") Then
            MessageBox.Show("Debe elegir un Banco", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_cod_ban.Focus()
        ElseIf (cboMes.SelectedIndex = -1) Then
            MessageBox.Show("Debe elegir un Mes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cboMes.Focus()
        ElseIf (cbo_a�o.SelectedIndex = -1) Then
            MessageBox.Show("Debe elegir el A�o", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbo_a�o.Focus()
        Else
            '-------------------------------------------------------------------
            Dim FECHA_CONC As DateTime = DateTime.Parse(("01/" & obj.COD_MES(cboMes.Text) & "/" & cbo_a�o.Text))
            Dim STATUS_CONCILIADO As Integer = IIf(CH_PTE.Checked = True, 0, 1)
            OFR.CREAR_REPORTE(txt_cod_ban.Text, txt_desc_ban.Text, obj.COD_MES(cboMes.Text), cboMes.Text, cbo_a�o.Text, STATUS_CONCILIADO)
            OFR.ShowDialog()
            ''----------------------------------------------------------------------
            'CR.conectar(nombre_servidor, con.Database, "miguel", "main")
            'CR.rutaRpt = Application.StartupPath & "\reportes"
            'CR.custTitle = "Reporte Conciliaci�n Bancaria"
            'CR.printrpt("ConciliacionBancaria.rpt", "@COD_BANCO;" & txt_cod_ban.Text, _
            '    "@FE_A�O;" & cbo_a�o.Text, "@FE_MES;" & cbo_mes.Text, "@STATUS_CONCILIADO;" & _
            '    STATUS_CONCILIADO, "EMPRESA;" & DESC_EMPRESA, "RUC;" & RUC_EMPRESA)
        End If
    End Sub

    Private Sub BTN_SALIR_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTN_SALIR.Click
        main(104) = 0
        Me.Close()
    End Sub

    Sub CARGAR_A�OS()
        cbo_a�o.Items.Clear()
        Try
            Dim Prog002 As New SqlCommand("Mostrar_a�o", con)
            Prog002.CommandType = CommandType.StoredProcedure
            Prog002.Parameters.Add("@COD_MODULO", SqlDbType.Char).Value = COD_MOD
            con.Open()
            Prog002.ExecuteNonQuery()
            Dim Rs3 As SqlDataReader = Prog002.ExecuteReader
            Do While Rs3.Read
                Me.cbo_a�o.Items.Add(Rs3.GetString(0))
            Loop
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Sub CARGAR_BANCOS()
        Try
            Dim pro As New SqlCommand("DGW_BANCOS_DOLARES", con)
            Dim Prog00 As New SqlDataAdapter(pro)
            Dim dt As New DataTable("Personas")
            Prog00.Fill(dt)
            dgw_ban.DataSource = dt
            dgw_ban.ColumnHeadersDefaultCellStyle.Font = New Font("ARIAL", 8.0!, FontStyle.Bold)
            dgw_ban.Columns.Item(0).Width = &H37
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgw_ban_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles dgw_ban.KeyDown
        If (e.KeyData = Keys.Return) Then
            txt_cod_ban.Text = dgw_ban.Item(0, dgw_ban.CurrentRow.Index).Value.ToString
            txt_desc_ban.Text = dgw_ban.Item(1, dgw_ban.CurrentRow.Index).Value.ToString
            panel_bancos.Visible = False
            kl1.Focus()
        End If
    End Sub

    Private Sub Reporte_LibroBanco_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Return) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub Reporte_LibroBanco_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KeyPreview = True
        CARGAR_A�OS()
        cbo_a�o.Text = A�O
        cboMes.Text = obj.DESC_MES(MES)
        CARGAR_BANCOS()
    End Sub

    Private Sub txt_cod_ban_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles txt_cod_ban.LostFocus
        If (Strings.Trim(txt_cod_ban.Text) <> "") Then
            If (dgw_ban.RowCount = 0) Then
                MessageBox.Show("No existen Bancos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Me.dgw_ban.Sort(dgw_ban.Columns.Item(0), System.ComponentModel.ListSortDirection.Ascending)
                Dim CONT0 As Integer = (dgw_ban.RowCount - 1)
                Dim i As Integer = 0
                Do While (i <= CONT0)
                    If (txt_cod_ban.Text.ToLower = dgw_ban.Item(0, i).Value.ToString.ToLower) Then
                        txt_cod_ban.Text = dgw_ban.Item(0, i).Value.ToString
                        txt_desc_ban.Text = dgw_ban.Item(1, i).Value.ToString
                        cboMes.Select()
                        Return
                    End If
                    If (txt_cod_ban.Text.ToLower = Strings.Mid((dgw_ban.Item(0, i).Value), 1, Strings.Len(txt_cod_ban.Text)).ToLower) Then
                        dgw_ban.CurrentCell = dgw_ban.Rows.Item(i).Cells.Item(0)
                        Exit Do
                    End If
                    dgw_ban.CurrentCell = dgw_ban.Rows.Item(0).Cells.Item(0)
                    i += 1
                Loop
                panel_bancos.Visible = True
                dgw_ban.Visible = True
                dgw_ban.Focus()
            End If
        End If
    End Sub

    Private Sub txt_desc_ban_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txt_desc_ban.KeyDown
        If ((e.KeyData = Keys.Return) AndAlso (Strings.Trim(txt_desc_ban.Text) <> "")) Then
            If (dgw_ban.RowCount = 0) Then
                MessageBox.Show("No existen Bancos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                dgw_ban.Sort(dgw_ban.Columns.Item(1), System.ComponentModel.ListSortDirection.Ascending)
                Dim CONT0 As Integer = (dgw_ban.RowCount - 1)
                Dim i As Integer = 0
                Do While (i <= CONT0)
                    If (txt_desc_ban.Text.ToLower = Strings.Mid((dgw_ban.Item(1, i).Value), 1, Strings.Len(txt_desc_ban.Text)).ToLower) Then
                        dgw_ban.CurrentCell = dgw_ban.Rows.Item(i).Cells.Item(0)
                        Exit Do
                    End If
                    dgw_ban.CurrentCell = dgw_ban.Rows.Item(0).Cells.Item(0)
                    i += 1
                Loop
                panel_bancos.Visible = True
                dgw_ban.Focus()
            End If
        End If
    End Sub
End Class