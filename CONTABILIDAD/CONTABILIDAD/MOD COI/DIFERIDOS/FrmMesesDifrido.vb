Public Class FrmMesesDifrido
    Dim fecha As Date
    Public FechaInicioOp As Date
    Public Año As String
    Public Mes As String
    Public CodDoc As String
    Public NroDoc As String
    Public CodPer As String
    Public AñoDif As String
    Public MesDif As String
    Public nroCuotas As Integer

    Private Sub FrmMesesDifrido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvFechaDif.Rows.Clear()
        Dim DiaActual As Date = FechaInicioOp
        'Hacemos el ciclo hasta el ultimo día del año

        For i As Integer = 0 To 23
            fecha = DateSerial(Year(DiaActual), (Month(DiaActual) + i) + 0, 1)
            dgvFechaDif.Rows.Add(i + 1, Month(fecha).ToString("00"), Year(fecha), False)
        Next

        Dim lista As List(Of IDiferidoSecuencia) = ObtenerIDiferidoSecuencia()

        If lista.Count > 0 Then
            For i As Integer = 0 To lista.Count - 1
                For j As Integer = 0 To dgvFechaDif.Rows.Count - 1
                    If lista.Item(i).MesDis = dgvFechaDif.Item(1, j).Value And lista.Item(i).AñoDis = dgvFechaDif.Item(2, j).Value Then
                        dgvFechaDif.Item(3, j).Value = True
                    End If
                Next
            Next
        End If
    End Sub

    Function ObtenerIDiferidoSecuencia() As List(Of IDiferidoSecuencia)
        Dim lista As New List(Of IDiferidoSecuencia)
        Dim daoIDiferidoSecuencia As IDiferidoSecuenciaDao = IDiferidoSecuenciaDao.ObtenerInstancia()

        Try
            lista = daoIDiferidoSecuencia.Obtener(Año, Mes, CodDoc, NroDoc, CodPer)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Contabilidad", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return lista
    End Function

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim algunSeleccionado As Boolean = False
        For i As Integer = 0 To dgvFechaDif.Rows.Count - 1
            
            If dgvFechaDif.Item(3, i).Value = True Then
                algunSeleccionado = True
                Exit For
            End If
            
        Next

        If algunSeleccionado Then
            Insertar()
            ActualizarNroCuotaIDiferido()
            DialogResult = Windows.Forms.DialogResult.OK
        Else
            MessageBox.Show("No seleccionó ningún mes", "Contabilidad", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Sub Insertar()
        Dim daoIDiferidoSecuencia As IDiferidoSecuenciaDao = IDiferidoSecuenciaDao.ObtenerInstancia()
        Dim iDiferidoSecuencia As IDiferidoSecuencia
        con.Open()
        Dim tr As SqlTransaction = con.BeginTransaction()
        Try
            
            iDiferidoSecuencia = New IDiferidoSecuencia
            With iDiferidoSecuencia
                .FeAño = Año
                .FeMes = Mes
                .CodDoc = CodDoc
                .NroDoc = NroDoc
                .CodPer = CodPer
                .MesDis = MesDif
                .AñoDis = AñoDif
            End With
            daoIDiferidoSecuencia.Eliminar(iDiferidoSecuencia, tr, con)
            nroCuotas = 0
            For i As Integer = 0 To dgvFechaDif.Rows.Count - 1
                If dgvFechaDif.Item(3, i).Value = True Then
                    iDiferidoSecuencia = New IDiferidoSecuencia
                    With iDiferidoSecuencia
                        .FeAño = Año
                        .FeMes = Mes
                        .CodDoc = CodDoc
                        .NroDoc = NroDoc
                        .CodPer = CodPer
                        .AñoDis = dgvFechaDif.Item(2, i).Value
                        .MesDis = dgvFechaDif.Item(1, i).Value
                    End With
                    daoIDiferidoSecuencia.Insertar(iDiferidoSecuencia, tr, con)
                    nroCuotas += 1
                End If
                
            Next
            MessageBox.Show("Meses actualizados correctamente", "Contabilidad", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tr.Commit()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Contabilidad", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tr.Rollback()
            con.Close()
        End Try


    End Sub

    Sub ActualizarNroCuotaIDiferido()
        Dim daoIDiferido As IDiferidoDao = IDiferidoDao.ObtenerInstancia()
        Dim iDiferido As New IDiferido
        With iDiferido
            .FeAño = Año
            .FeMes = Mes
            .CodDoc = CodDoc
            .NroDoc = NroDoc
            .CodPer = CodPer
            .NroCuotas = nroCuotas
        End With
        daoIDiferido.Actualizar(iDiferido)
    End Sub
End Class