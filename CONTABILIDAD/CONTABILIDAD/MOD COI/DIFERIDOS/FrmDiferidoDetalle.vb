Public Class FrmDiferidoDetalle
    Public Año As String
    Public Mes As String
    Public CodDoc As String
    Public NroDoc As String
    Public CodPer As String
    Public ImporteTotal As Decimal
    Public ImporteRestante As Decimal
    Public ImporteCuota As Decimal
    Public NroCuota As Integer
    Private OBJ As New Class1


    Private Sub FrmDiferidoDetalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtImporteTotal.Text = ImporteTotal.ToString()
        txtNroCuota.Text = NroCuota.ToString()
        txtImporteRestante.Text = ImporteRestante.ToString()
        numImporteCuota.Value = ImporteCuota
        ObtenerTDiferidoCC()
    End Sub

    Sub ObtenerTDiferidoCC()
        Dim DaoTDiferidoCC As TDiferidoCCDao = TDiferidoCCDao.ObtenerInstancia()
        Dim lista As New List(Of TDiferidoCC)

        Try
            lista = DaoTDiferidoCC.Listar(Año, Mes, CodDoc, NroDoc, CodPer)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Contabilidad", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Dim sumaImporte As Decimal = 0
        If lista.Count > 0 Then
            For i As Integer = 0 To lista.Count - 1
                With lista.Item(i)
                    dgwDetalle.Rows.Add(.FeAño, .FeMes, .CodDoc, .NroDoc, .CodPer, .CodCC, .CodCuenta, OBJ.HACER_DECIMAL(.PorDif), OBJ.HACER_DECIMAL(Math.Round((.PorDif / 100) * ImporteCuota, 2)))
                    sumaImporte += Math.Round((.PorDif / 100) * ImporteCuota, 2)
                End With
            Next

            Dim diferencia = ImporteCuota - sumaImporte

            dgwDetalle.Item(8, dgwDetalle.Rows.Count - 1).Value = OBJ.HACER_DECIMAL(dgwDetalle.Item(8, dgwDetalle.Rows.Count - 1).Value + diferencia)
        End If
        
    End Sub

    Private Sub btnReDistribuir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReDistribuir.Click
        ImporteCuota = numImporteCuota.Value
        Dim sumaImporte As Decimal = 0
        For i As Integer = 0 To dgwDetalle.Rows.Count - 1
            dgwDetalle.Item(8, i).Value = OBJ.HACER_DECIMAL(Math.Round((dgwDetalle.Item(7, i).Value / 100) * ImporteCuota, 2))
            sumaImporte += dgwDetalle.Item(8, i).Value
        Next
        Dim diferencia = ImporteCuota - sumaImporte
        dgwDetalle.Item(8, dgwDetalle.Rows.Count - 1).Value = OBJ.HACER_DECIMAL(dgwDetalle.Item(8, dgwDetalle.Rows.Count - 1).Value + diferencia)
    End Sub

    Private Sub dgwDetalle_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwDetalle.CellEndEdit
        If e.ColumnIndex = 7 Then

            Dim Porcentaje As Decimal = 0

            If String.IsNullOrEmpty(dgwDetalle.Item(7, e.RowIndex).Value) OrElse Not IsNumeric(dgwDetalle.Item(7, e.RowIndex).Value) OrElse dgwDetalle.Item(7, e.RowIndex).Value > 100 OrElse dgwDetalle.Item(7, e.RowIndex).Value <= 0 Then
                MessageBox.Show("Valor no válido", "Contabilidad", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                dgwDetalle.CurrentCell = dgwDetalle.Item(e.ColumnIndex, e.RowIndex)
                dgwDetalle.Item(e.ColumnIndex, e.RowIndex).Value = 10
                Return
            End If

            
            dgwDetalle.Item(8, e.RowIndex).Value = OBJ.HACER_DECIMAL(Math.Round((dgwDetalle.Item(7, e.RowIndex).Value / 100) * numImporteCuota.Value, 2))

            Dim sumaImporte As Decimal = 0


            For i As Integer = 0 To dgwDetalle.Rows.Count - 1
                Porcentaje += dgwDetalle.Item(7, i).Value
                sumaImporte += dgwDetalle.Item(8, i).Value
                dgwDetalle.Item(7, i).Value = OBJ.HACER_DECIMAL(dgwDetalle.Item(7, i).Value)
            Next

            If Porcentaje = 100 Then
                Dim diferencia = ImporteCuota - sumaImporte
                dgwDetalle.Item(8, dgwDetalle.Rows.Count - 1).Value = OBJ.HACER_DECIMAL(dgwDetalle.Item(8, dgwDetalle.Rows.Count - 1).Value + diferencia)
            End If
        End If
    End Sub

    Private Sub LlamarFrmDialogOrdenProd()
        Dim ofr As New DIALOG_ORDEN_PROD
        Dim i As Integer = 0
        Dim TFilas = dgwDetalle.RowCount - 1
        Dim porcentaje As Double = 0
        ofr.dgvListaDiferidos.Rows.Clear()
        Do While (i <= TFilas)
            'ofr.dgvListaDiferidos.Rows.Add(dgwDetalle.Item(5, i).Value, dgwDetalle.Item(6, i).Value, dgwDetalle.Item(7, i).Value)
            porcentaje += CDbl(dgwDetalle.Item(7, i).Value)
            i += 1
        Loop
        Try


            'Eviamos la suma de los porcentajes
            ofr.txtTIngreso.Text = porcentaje
            ofr.ShowDialog()
            If (ofr.DialogResult = Windows.Forms.DialogResult.OK) Then
                InsertarDetalle(ofr)
                ofr.Hide()
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar las ordenes de producción: " + vbCrLf + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAgregarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarDetalle.Click
        LlamarFrmDialogOrdenProd()
    End Sub

    Private Sub InsertarDetalle(ByVal ofr As DIALOG_ORDEN_PROD)
        Dim Orden As New StringBuilder
        Dim num As Integer = ofr.dgvListaDiferidos.Rows.Count - 1

        If CDbl(ofr.txtFaltante.Text) <> CDbl(ofr.txtTotal.Text) Then
            MessageBox.Show("El total no puede ser diferente a del faltante", "Ingreso Diferidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim i As Integer = 0
        Dim porcentaje As Double = 0
        Dim cc, cuenta As String
        Try
            Do While (i <= num)
                Dim j As Integer
                Dim existe As Boolean = False
                For j = 0 To dgwDetalle.Rows.Count - 1
                    If ofr.dgvListaDiferidos.Item(0, i).Value = dgwDetalle.Item(5, j).Value Then
                        existe = True
                        Orden.AppendLine(ofr.dgvListaDiferidos.Item(0, i).Value)
                        Exit For
                    End If
                Next
                If Not existe Then
                    porcentaje = ofr.dgvListaDiferidos.Item(2, i).Value
                    cc = ofr.dgvListaDiferidos.Item(0, i).Value
                    cuenta = ofr.dgvListaDiferidos.Item(1, i).Value
                    dgwDetalle.Rows.Add(Año, Mes, CodDoc, NroDoc, CodPer, cc, cuenta, OBJ.HACER_DECIMAL(porcentaje), OBJ.HACER_DECIMAL(Math.Round((porcentaje / 100) * numImporteCuota.Value, 2)))
                End If
                i += 1
            Loop
            If Orden.Length > 0 Then
                MessageBox.Show("Las sgtes CC no se agregaron por que ya existen: " + vbCrLf + Orden.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar las ordenes de producción: " + vbCrLf + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarDetalle.Click
        If Not IsNumeric(dgwDetalle.CurrentRow.Index) Then
            MessageBox.Show("Detalle elegir un registro", "Contabilidad", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            EliminarDetalle()
        End If
    End Sub

    Sub EliminarDetalle()
        Dim resultado As DialogResult = MessageBox.Show("Desea eliminar el detalle", _
                                                    "Contabilidad", _
                                                    MessageBoxButtons.OKCancel, _
                                                    MessageBoxIcon.Question)

        If resultado = Windows.Forms.DialogResult.OK Then
            dgwDetalle.Rows.RemoveAt(dgwDetalle.CurrentCell.RowIndex)
            MessageBox.Show("Detalle Eliminado correctamente ", "Contabilidad", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click

        If Not InsertarTDiferidoCC() Then

        End If
    End Sub

    Function InsertarTDiferidoCC() As Boolean
        Dim tDiferidoCC As TDiferidoCC
        Dim DaoTDiferidoCC As TDiferidoCCDao = TDiferidoCCDao.ObtenerInstancia()
        con.Open()
        Dim tr As SqlTransaction = con.BeginTransaction

        Try

            For i As Integer = 0 To dgwDetalle.Rows.Count - 1
                tDiferidoCC = New TDiferidoCC
                With tDiferidoCC
                    .FeAño = dgwDetalle.Item(0, i).Value
                    .FeMes = dgwDetalle.Item(1, i).Value
                    .CodDoc = dgwDetalle.Item(2, i).Value
                    .NroDoc = dgwDetalle.Item(3, i).Value
                    .CodPer = dgwDetalle.Item(4, i).Value
                    .CodCC = dgwDetalle.Item(5, i).Value
                    .CodCuenta = dgwDetalle.Item(6, i).Value
                    .PorDif = dgwDetalle.Item(7, i).Value
                End With
                DaoTDiferidoCC.Eliminar(tDiferidoCC, tr, con)
                Exit For
            Next

            For i As Integer = 0 To dgwDetalle.Rows.Count - 1
                tDiferidoCC = New TDiferidoCC
                With tDiferidoCC
                    .FeAño = dgwDetalle.Item(0, i).Value
                    .FeMes = dgwDetalle.Item(1, i).Value
                    .CodDoc = dgwDetalle.Item(2, i).Value
                    .NroDoc = dgwDetalle.Item(3, i).Value
                    .CodPer = dgwDetalle.Item(4, i).Value
                    .CodCC = dgwDetalle.Item(5, i).Value
                    .CodCuenta = dgwDetalle.Item(6, i).Value
                    .PorDif = dgwDetalle.Item(7, i).Value
                End With
                DaoTDiferidoCC.Insertar(tDiferidoCC, tr, con)
            Next
            tr.Commit()
            con.Close()
            Return True
        Catch ex As Exception
            tr.Rollback()
            MessageBox.Show(ex.Message, "Contabilidad", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
            Return False
        End Try


    End Function

    Sub InsertarTDiferido()
        Dim tDiferido As TDiferido
        Dim DaoTDiferido As TDiferidoDao = TDiferidoDao.ObtenerInstancia()

        con.Open()
        Dim tr As SqlTransaction = con.BeginTransaction

        Try
            For i As Integer = 0 To dgwDetalle.Rows.Count - 1
                tDiferido = New TDiferido
                With tDiferido
                    .FeAño = dgwDetalle.Item(0, i).Value
                    .FeMes = dgwDetalle.Item(1, i).Value
                    .CodDoc = dgwDetalle.Item(2, i).Value
                    .NroDoc = dgwDetalle.Item(3, i).Value
                    .CodPer = dgwDetalle.Item(4, i).Value
                    .CodCC = dgwDetalle.Item(5, i).Value
                End With
                DaoTDiferido.Eliminar(tDiferido, tr, con)
                Exit For
            Next

            For i As Integer = 0 To dgwDetalle.Rows.Count - 1
                tDiferido = New TDiferido
                With tDiferido
                    .FeAño = dgwDetalle.Item(0, i).Value
                    .FeMes = dgwDetalle.Item(1, i).Value
                    .CodDoc = dgwDetalle.Item(2, i).Value
                    .NroDoc = dgwDetalle.Item(3, i).Value
                    .CodPer = dgwDetalle.Item(4, i).Value
                    .CodCC = dgwDetalle.Item(5, i).Value
                    .CodCuenta = dgwDetalle.Item(6, i).Value

                    .Glosa = dgwDetalle.Item(7, i).Value
                    .FechaDoc = dgwDetalle.Item(7, i).Value
                    .Importe = dgwDetalle.Item(7, i).Value
                    .CodDH = dgwDetalle.Item(7, i).Value
                    .CodMoneda = dgwDetalle.Item(7, i).Value
                    .TipoCambio = dgwDetalle.Item(7, i).Value
                    .NroCuota = dgwDetalle.Item(7, i).Value
                    .StTrans = dgwDetalle.Item(7, i).Value
                    .StCierre = dgwDetalle.Item(7, i).Value
                End With
                DaoTDiferido.Insertar(tDiferido, tr, con)
            Next
            tr.Commit()
            con.Close()

        Catch ex As Exception

        End Try

    End Sub

End Class