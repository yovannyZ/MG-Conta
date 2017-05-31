Public Class FrmIDiferido
    Public FeAño As String
    Public FeMes As String


    Private Sub FrmIDiferido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListarIDIferido(FeAño, FeMes)
    End Sub

    Sub ListarIDIferido(ByVal feAño As String, ByVal feMes As String)
        Dim DaoIDiferido As IDiferidoDao = IDiferidoDao.ObtenerInstancia()
        Dim lista As New List(Of IDiferido)
        dgwDiferido.Rows.Clear()
        Try
            lista = DaoIDiferido.Listar(feAño, feMes)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Contabilidad", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If lista.Count > 0 Then
            For i As Integer = 0 To lista.Count - 1
                With lista.Item(i)
                    dgwDiferido.Rows.Add(.FeAño, .FeMes, .CodDoc, .NroDoc, .CodPer, .FechaDoc, .CodCuenta, _
                    .Glosa, .FechaVigenciaAl, .FechaVigenciaDel, .FechaIniOpe, .Importe, (.Importe - .ImpAcumulado), _
                    Math.Round((.Importe - .ImpAcumulado) / .NroCuotas, 2), .NroCuotas, .NroCuotasTran + 1, .CodAux, .CodComp, .NroComp, _
                    .ImpAcumulado, .ImpInicalAño, "Detalle")
                End With
            Next
        End If
       
    End Sub

    Private Sub dgwDiferido_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwDiferido.CellContentClick
        If e.ColumnIndex = 21 Then
            Dim frmDetalleDiferido As New FrmDiferidoDetalle()
            Dim Año As String = dgwDiferido.Item(0, e.RowIndex).Value
            Dim Mes As String = dgwDiferido.Item(1, e.RowIndex).Value
            Dim CodDoc As String = dgwDiferido.Item(2, e.RowIndex).Value
            Dim NroDoc As String = dgwDiferido.Item(3, e.RowIndex).Value
            Dim CodPer As String = dgwDiferido.Item(4, e.RowIndex).Value
            Dim ImporteTotal As Decimal = dgwDiferido.Item(11, e.RowIndex).Value
            Dim ImporteRestante As Decimal = dgwDiferido.Item(12, e.RowIndex).Value
            Dim ImporteCuota As Decimal = dgwDiferido.Item(13, e.RowIndex).Value
            Dim NroCuota As Integer = dgwDiferido.Item(15, e.RowIndex).Value

            frmDetalleDiferido.Año = Año
            frmDetalleDiferido.Mes = Mes
            frmDetalleDiferido.CodDoc = CodDoc
            frmDetalleDiferido.NroDoc = NroDoc
            frmDetalleDiferido.CodPer = CodPer
            frmDetalleDiferido.ImporteTotal = ImporteTotal
            frmDetalleDiferido.ImporteRestante = ImporteRestante
            frmDetalleDiferido.ImporteCuota = ImporteCuota
            frmDetalleDiferido.NroCuota = NroCuota

            frmDetalleDiferido.ShowDialog()

        End If
    End Sub

    Private Sub btnModificarMeses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarMeses.Click
        Dim frm As New FrmMesesDifrido()
        frm.FechaInicioOp = FECHA_INI
        frm.Año = dgwDiferido.Item(0, dgwDiferido.CurrentCell.RowIndex).Value
        frm.Mes = dgwDiferido.Item(1, dgwDiferido.CurrentCell.RowIndex).Value
        frm.CodDoc = dgwDiferido.Item(2, dgwDiferido.CurrentCell.RowIndex).Value
        frm.NroDoc = dgwDiferido.Item(3, dgwDiferido.CurrentCell.RowIndex).Value
        frm.CodPer = dgwDiferido.Item(4, dgwDiferido.CurrentCell.RowIndex).Value
        frm.MesDif = FeMes
        frm.AñoDif = FeAño
        frm.ShowDialog()

        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            ListarIDIferido(FeAño, FeMes)
        End If
    End Sub
End Class