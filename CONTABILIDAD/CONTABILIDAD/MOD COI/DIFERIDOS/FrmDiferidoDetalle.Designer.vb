<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDiferidoDetalle
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.numImporteCuota = New System.Windows.Forms.NumericUpDown
        Me.dgwDetalle = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtNroCuota = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtImporteTotal = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtImporteRestante = New System.Windows.Forms.TextBox
        Me.btnReDistribuir = New System.Windows.Forms.Button
        Me.btnAgregarDetalle = New System.Windows.Forms.Button
        Me.btnEliminarDetalle = New System.Windows.Forms.Button
        Me.btnGrabar = New System.Windows.Forms.Button
        CType(Me.numImporteCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Importe de cuota"
        '
        'numImporteCuota
        '
        Me.numImporteCuota.DecimalPlaces = 2
        Me.numImporteCuota.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.numImporteCuota.Location = New System.Drawing.Point(169, 79)
        Me.numImporteCuota.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.numImporteCuota.Name = "numImporteCuota"
        Me.numImporteCuota.Size = New System.Drawing.Size(120, 22)
        Me.numImporteCuota.TabIndex = 2
        '
        'dgwDetalle
        '
        Me.dgwDetalle.AllowUserToAddRows = False
        Me.dgwDetalle.AllowUserToDeleteRows = False
        Me.dgwDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.dgwDetalle.Location = New System.Drawing.Point(12, 119)
        Me.dgwDetalle.Name = "dgwDetalle"
        Me.dgwDetalle.RowTemplate.Height = 24
        Me.dgwDetalle.Size = New System.Drawing.Size(990, 295)
        Me.dgwDetalle.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.HeaderText = "Año"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "Mes"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 50
        '
        'Column3
        '
        Me.Column3.HeaderText = "Cod. Doc."
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 80
        '
        'Column4
        '
        Me.Column4.HeaderText = "Nro. Doc."
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 120
        '
        'Column5
        '
        Me.Column5.HeaderText = "Persona"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 80
        '
        'Column6
        '
        Me.Column6.HeaderText = "Centro Costo"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Cuenta"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 80
        '
        'Column8
        '
        Me.Column8.HeaderText = "Porcentaje"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 80
        '
        'Column9
        '
        Me.Column9.HeaderText = "Importe"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 80
        '
        'txtNroCuota
        '
        Me.txtNroCuota.Location = New System.Drawing.Point(658, 34)
        Me.txtNroCuota.Name = "txtNroCuota"
        Me.txtNroCuota.Size = New System.Drawing.Size(70, 22)
        Me.txtNroCuota.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(577, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nro. cuota"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Importe Total"
        '
        'txtImporteTotal
        '
        Me.txtImporteTotal.Location = New System.Drawing.Point(169, 34)
        Me.txtImporteTotal.Name = "txtImporteTotal"
        Me.txtImporteTotal.Size = New System.Drawing.Size(121, 22)
        Me.txtImporteTotal.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(310, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Importe Restante"
        '
        'txtImporteRestante
        '
        Me.txtImporteRestante.Location = New System.Drawing.Point(433, 34)
        Me.txtImporteRestante.Name = "txtImporteRestante"
        Me.txtImporteRestante.Size = New System.Drawing.Size(121, 22)
        Me.txtImporteRestante.TabIndex = 8
        '
        'btnReDistribuir
        '
        Me.btnReDistribuir.Image = Global.CONTABILIDAD.My.Resources.Resources._16__Refresh_11
        Me.btnReDistribuir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReDistribuir.Location = New System.Drawing.Point(296, 70)
        Me.btnReDistribuir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReDistribuir.Name = "btnReDistribuir"
        Me.btnReDistribuir.Size = New System.Drawing.Size(130, 39)
        Me.btnReDistribuir.TabIndex = 10
        Me.btnReDistribuir.Text = "&Redistribuir"
        Me.btnReDistribuir.UseVisualStyleBackColor = True
        '
        'btnAgregarDetalle
        '
        Me.btnAgregarDetalle.Image = Global.CONTABILIDAD.My.Resources.Resources._16__Card_file_1
        Me.btnAgregarDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregarDetalle.Location = New System.Drawing.Point(702, 70)
        Me.btnAgregarDetalle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregarDetalle.Name = "btnAgregarDetalle"
        Me.btnAgregarDetalle.Size = New System.Drawing.Size(141, 39)
        Me.btnAgregarDetalle.TabIndex = 11
        Me.btnAgregarDetalle.Text = "&Cuentas ++"
        Me.btnAgregarDetalle.UseVisualStyleBackColor = True
        '
        'btnEliminarDetalle
        '
        Me.btnEliminarDetalle.Image = Global.CONTABILIDAD.My.Resources.Resources._16__Delete_1
        Me.btnEliminarDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminarDetalle.Location = New System.Drawing.Point(851, 70)
        Me.btnEliminarDetalle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminarDetalle.Name = "btnEliminarDetalle"
        Me.btnEliminarDetalle.Size = New System.Drawing.Size(150, 39)
        Me.btnEliminarDetalle.TabIndex = 12
        Me.btnEliminarDetalle.Text = "&Eliminar detalle"
        Me.btnEliminarDetalle.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Image = Global.CONTABILIDAD.My.Resources.Resources._16__Save_11
        Me.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGrabar.Location = New System.Drawing.Point(887, 421)
        Me.btnGrabar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(114, 39)
        Me.btnGrabar.TabIndex = 13
        Me.btnGrabar.Text = "&Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'FrmDiferidoDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 471)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnEliminarDetalle)
        Me.Controls.Add(Me.btnAgregarDetalle)
        Me.Controls.Add(Me.btnReDistribuir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtImporteRestante)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtImporteTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNroCuota)
        Me.Controls.Add(Me.dgwDetalle)
        Me.Controls.Add(Me.numImporteCuota)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmDiferidoDetalle"
        Me.Text = "FrmDiferidoDetalle"
        CType(Me.numImporteCuota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents numImporteCuota As System.Windows.Forms.NumericUpDown
    Friend WithEvents dgwDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents txtNroCuota As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtImporteTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtImporteRestante As System.Windows.Forms.TextBox
    Friend WithEvents btnReDistribuir As System.Windows.Forms.Button
    Friend WithEvents btnAgregarDetalle As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnEliminarDetalle As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
End Class
