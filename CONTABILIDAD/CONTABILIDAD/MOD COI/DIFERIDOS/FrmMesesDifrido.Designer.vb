<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMesesDifrido
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dgvFechaDif = New System.Windows.Forms.DataGridView
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnAgregarFechaDiferir = New System.Windows.Forms.Button
        CType(Me.dgvFechaDif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvFechaDif
        '
        Me.dgvFechaDif.AllowUserToAddRows = False
        Me.dgvFechaDif.AllowUserToDeleteRows = False
        Me.dgvFechaDif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFechaDif.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column3, Me.Column1, Me.Column2})
        Me.dgvFechaDif.Location = New System.Drawing.Point(33, 24)
        Me.dgvFechaDif.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvFechaDif.Name = "dgvFechaDif"
        Me.dgvFechaDif.RowTemplate.Height = 24
        Me.dgvFechaDif.Size = New System.Drawing.Size(384, 299)
        Me.dgvFechaDif.TabIndex = 1
        '
        'Column4
        '
        Me.Column4.HeaderText = "Sec"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 75
        '
        'Column3
        '
        Me.Column3.HeaderText = "Mes"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 50
        '
        'Column1
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column1.HeaderText = "Año"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "Ok"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 50
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Image = Global.CONTABILIDAD.My.Resources.Resources._16__Cancel_1
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.Location = New System.Drawing.Point(247, 331)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(114, 42)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Image = Global.CONTABILIDAD.My.Resources.Resources._16__Save_11
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.Location = New System.Drawing.Point(122, 331)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(117, 42)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "&Grabar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnAgregarFechaDiferir
        '
        Me.btnAgregarFechaDiferir.Image = Global.CONTABILIDAD.My.Resources.Resources.anadir
        Me.btnAgregarFechaDiferir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregarFechaDiferir.Location = New System.Drawing.Point(425, 137)
        Me.btnAgregarFechaDiferir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregarFechaDiferir.Name = "btnAgregarFechaDiferir"
        Me.btnAgregarFechaDiferir.Size = New System.Drawing.Size(114, 48)
        Me.btnAgregarFechaDiferir.TabIndex = 4
        Me.btnAgregarFechaDiferir.Text = "Meses"
        Me.btnAgregarFechaDiferir.UseVisualStyleBackColor = True
        '
        'FrmMesesDifrido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 422)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnAgregarFechaDiferir)
        Me.Controls.Add(Me.dgvFechaDif)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmMesesDifrido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMesesDifrido"
        CType(Me.dgvFechaDif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvFechaDif As System.Windows.Forms.DataGridView
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnAgregarFechaDiferir As System.Windows.Forms.Button
End Class
