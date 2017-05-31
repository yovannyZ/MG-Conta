Public Class FrmIDiferido
    Public FeA�o As String
    Public FeMes As String


    Private Sub FrmIDiferido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListarIDIferido(FeA�o, FeMes)
    End Sub

    Sub ListarIDIferido(ByVal feA�o As String, ByVal feMes As String)
        Dim DaoIDiferido As IDiferidoDao = IDiferidoDao.ObtenerInstancia()
        Dim lista As New List(Of IDiferido)
        dgwDiferido.Rows.Clear()
        Try
            lista = DaoIDiferido.Listar(feA�o, feMes)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Contabilidad", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If lista.Count > 0 Then
            For i As Integer = 0 To lista.Count - 1
                With lista.Item(i)
                    dgwDiferido.Rows.Add(.FeA�o, .FeMes, .CodDoc, .NroDoc, .CodPer, .FechaDoc, .CodCuenta, _
                    .Glosa, .FechaVigenciaAl, .FechaVigenciaDel, .FechaIniOpe, .Importe, (.Importe - .ImpAcumulado), _
                    Math.Round((.Importe - .ImpAcumulado) / .NroCuotas, 2), .NroCuotas, .NroCuotasTran + 1, .CodAux, .CodComp, .NroComp, _
                    .ImpAcumulado, .ImpInicalA�o, "Detalle")
                End With
            Next
        End If
       
    End Sub

    Private Sub dgwDiferido_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwDiferido.CellContentClick
        If e.ColumnIndex = 21 Then
            Dim frmDetalleDiferido As New FrmDiferidoDetalle()
            Dim A�o As String = dgwDiferido.Item(0, e.RowIndex).Value
            Dim Mes As String = dgwDiferido.Item(1, e.RowIndex).Value
            Dim CodDoc As String = dgwDiferido.Item(2, e.RowIndex).Value
            Dim NroDoc As String = dgwDiferido.Item(3, e.RowIndex).Value
            Dim CodPer As String = dgwDiferido.Item(4, e.RowIndex).Value
            Dim ImporteTotal As Decimal = dgwDiferido.Item(11, e.RowIndex).Value
            Dim ImporteRestante As Decimal = dgwDiferido.Item(12, e.RowIndex).Value
            Dim ImporteCuota As Decimal = dgwDiferido.Item(13, e.RowIndex).Value
            Dim NroCuota As Integer = dgwDiferido.Item(15, e.RowIndex).Value

            frmDetalleDiferido.A�o = A�o
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
        frm.A�o = dgwDiferido.Item(0, dgwDiferido.CurrentCell.RowIndex).Value
        frm.Mes = dgwDiferido.Item(1, dgwDiferido.CurrentCell.RowIndex).Value
        frm.CodDoc = dgwDiferido.Item(2, dgwDiferido.CurrentCell.RowIndex).Value
        frm.NroDoc = dgwDiferido.Item(3, dgwDiferido.CurrentCell.RowIndex).Value
        frm.CodPer = dgwDiferido.Item(4, dgwDiferido.CurrentCell.RowIndex).Value
        frm.MesDif = FeMes
        frm.A�oDif = FeA�o
        frm.ShowDialog()

        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            ListarIDIferido(FeA�o, FeMes)
        End If
    End Sub
End Class