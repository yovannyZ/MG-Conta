<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REPORTE_ANA_TP
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
        Me.gb1 = New System.Windows.Forms.GroupBox
        Me.btn_archivo1 = New System.Windows.Forms.Button
        Me.btn_imprimir1 = New System.Windows.Forms.Button
        Me.btn_pantalla1 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rb3 = New System.Windows.Forms.RadioButton
        Me.rb2 = New System.Windows.Forms.RadioButton
        Me.BTN_SALIR = New System.Windows.Forms.Button
        Me.dgw1 = New System.Windows.Forms.DataGridView
        Me.Cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.desc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Elegir = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ch1 = New System.Windows.Forms.CheckBox
        Me.cbo_año = New System.Windows.Forms.ComboBox
        Me.rb1 = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbo_mes = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.gb1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgw1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb1
        '
        Me.gb1.BackColor = System.Drawing.Color.White
        Me.gb1.Controls.Add(Me.btn_archivo1)
        Me.gb1.Controls.Add(Me.btn_imprimir1)
        Me.gb1.Controls.Add(Me.btn_pantalla1)
        Me.gb1.Location = New System.Drawing.Point(133, 445)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(272, 65)
        Me.gb1.TabIndex = 138
        Me.gb1.TabStop = False
        '
        'btn_archivo1
        '
        Me.btn_archivo1.BackColor = System.Drawing.Color.White
        Me.btn_archivo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_archivo1.Image = Global.CONTABILIDAD.My.Resources.Resources._16__Folder_2
        Me.btn_archivo1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_archivo1.Location = New System.Drawing.Point(181, 17)
        Me.btn_archivo1.Name = "btn_archivo1"
        Me.btn_archivo1.Size = New System.Drawing.Size(80, 36)
        Me.btn_archivo1.TabIndex = 2
        Me.btn_archivo1.Text = "&Archivo"
        Me.btn_archivo1.UseVisualStyleBackColor = False
        '
        'btn_imprimir1
        '
        Me.btn_imprimir1.BackColor = System.Drawing.Color.White
        Me.btn_imprimir1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_imprimir1.Image = Global.CONTABILIDAD.My.Resources.Resources._16__Print_1
        Me.btn_imprimir1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_imprimir1.Location = New System.Drawing.Point(96, 17)
        Me.btn_imprimir1.Name = "btn_imprimir1"
        Me.btn_imprimir1.Size = New System.Drawing.Size(80, 36)
        Me.btn_imprimir1.TabIndex = 1
        Me.btn_imprimir1.Text = "&Imprimir"
        Me.btn_imprimir1.UseVisualStyleBackColor = False
        '
        'btn_pantalla1
        '
        Me.btn_pantalla1.BackColor = System.Drawing.Color.White
        Me.btn_pantalla1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pantalla1.Image = Global.CONTABILIDAD.My.Resources.Resources._16__Screen_1
        Me.btn_pantalla1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_pantalla1.Location = New System.Drawing.Point(10, 17)
        Me.btn_pantalla1.Name = "btn_pantalla1"
        Me.btn_pantalla1.Size = New System.Drawing.Size(80, 36)
        Me.btn_pantalla1.TabIndex = 0
        Me.btn_pantalla1.Text = "&Pantalla"
        Me.btn_pantalla1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb3)
        Me.GroupBox1.Controls.Add(Me.rb2)
        Me.GroupBox1.Controls.Add(Me.BTN_SALIR)
        Me.GroupBox1.Controls.Add(Me.dgw1)
        Me.GroupBox1.Controls.Add(Me.ch1)
        Me.GroupBox1.Controls.Add(Me.cbo_año)
        Me.GroupBox1.Controls.Add(Me.rb1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbo_mes)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(471, 420)
        Me.GroupBox1.TabIndex = 137
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cuentas por Pagar"
        '
        'rb3
        '
        Me.rb3.AutoSize = True
        Me.rb3.Location = New System.Drawing.Point(230, 385)
        Me.rb3.Name = "rb3"
        Me.rb3.Size = New System.Drawing.Size(95, 18)
        Me.rb3.TabIndex = 135
        Me.rb3.Text = "PCXP vs TCXP"
        Me.rb3.UseVisualStyleBackColor = True
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.Location = New System.Drawing.Point(230, 359)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(107, 18)
        Me.rb2.TabIndex = 134
        Me.rb2.Text = "TCXP vs Análisis"
        Me.rb2.UseVisualStyleBackColor = True
        '
        'BTN_SALIR
        '
        Me.BTN_SALIR.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_SALIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_SALIR.Image = Global.CONTABILIDAD.My.Resources.Resources._16__Cancel_1
        Me.BTN_SALIR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_SALIR.Location = New System.Drawing.Point(380, 329)
        Me.BTN_SALIR.Name = "BTN_SALIR"
        Me.BTN_SALIR.Size = New System.Drawing.Size(80, 36)
        Me.BTN_SALIR.TabIndex = 5
        Me.BTN_SALIR.TabStop = False
        Me.BTN_SALIR.Text = "&Salir"
        Me.BTN_SALIR.UseVisualStyleBackColor = True
        '
        'dgw1
        '
        Me.dgw1.AllowUserToAddRows = False
        Me.dgw1.AllowUserToDeleteRows = False
        Me.dgw1.AllowUserToOrderColumns = True
        Me.dgw1.BackgroundColor = System.Drawing.Color.White
        Me.dgw1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cuenta, Me.desc, Me.Elegir})
        Me.dgw1.Location = New System.Drawing.Point(6, 29)
        Me.dgw1.MultiSelect = False
        Me.dgw1.Name = "dgw1"
        Me.dgw1.RowHeadersWidth = 25
        Me.dgw1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White
        Me.dgw1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue
        Me.dgw1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgw1.Size = New System.Drawing.Size(459, 279)
        Me.dgw1.TabIndex = 132
        '
        'Cuenta
        '
        Me.Cuenta.FillWeight = 40.0!
        Me.Cuenta.HeaderText = "Cuenta"
        Me.Cuenta.Name = "Cuenta"
        Me.Cuenta.Width = 85
        '
        'desc
        '
        Me.desc.FillWeight = 200.0!
        Me.desc.HeaderText = "Descripción"
        Me.desc.Name = "desc"
        Me.desc.Width = 285
        '
        'Elegir
        '
        Me.Elegir.FillWeight = 30.0!
        Me.Elegir.HeaderText = "Elegir"
        Me.Elegir.Name = "Elegir"
        Me.Elegir.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Elegir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Elegir.Width = 45
        '
        'ch1
        '
        Me.ch1.AutoSize = True
        Me.ch1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ch1.Location = New System.Drawing.Point(55, 385)
        Me.ch1.Name = "ch1"
        Me.ch1.Size = New System.Drawing.Size(110, 18)
        Me.ch1.TabIndex = 133
        Me.ch1.Text = "Seleccionar Todo"
        Me.ch1.UseVisualStyleBackColor = True
        '
        'cbo_año
        '
        Me.cbo_año.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_año.FormattingEnabled = True
        Me.cbo_año.Location = New System.Drawing.Point(59, 357)
        Me.cbo_año.Name = "cbo_año"
        Me.cbo_año.Size = New System.Drawing.Size(79, 22)
        Me.cbo_año.TabIndex = 4
        '
        'rb1
        '
        Me.rb1.AutoSize = True
        Me.rb1.Checked = True
        Me.rb1.Location = New System.Drawing.Point(230, 333)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(107, 18)
        Me.rb1.TabIndex = 133
        Me.rb1.TabStop = True
        Me.rb1.Text = "Análisis vs TCXP"
        Me.rb1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(14, 333)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 14)
        Me.Label2.TabIndex = 129
        Me.Label2.Text = "Al Mes"
        '
        'cbo_mes
        '
        Me.cbo_mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_mes.FormattingEnabled = True
        Me.cbo_mes.Items.AddRange(New Object() {"INICIO", "ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SETIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.cbo_mes.Location = New System.Drawing.Point(59, 328)
        Me.cbo_mes.Name = "cbo_mes"
        Me.cbo_mes.Size = New System.Drawing.Size(121, 22)
        Me.cbo_mes.TabIndex = 131
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Location = New System.Drawing.Point(14, 359)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 14)
        Me.Label3.TabIndex = 130
        Me.Label3.Text = "Año"
        '
        'REPORTE_ANA_TP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 524)
        Me.ControlBox = False
        Me.Controls.Add(Me.gb1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "REPORTE_ANA_TP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte"
        Me.gb1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgw1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gb1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_archivo1 As System.Windows.Forms.Button
    Friend WithEvents btn_imprimir1 As System.Windows.Forms.Button
    Friend WithEvents btn_pantalla1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_mes As System.Windows.Forms.ComboBox
    Friend WithEvents BTN_SALIR As System.Windows.Forms.Button
    Friend WithEvents cbo_año As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rb2 As System.Windows.Forms.RadioButton
    Friend WithEvents rb1 As System.Windows.Forms.RadioButton
    Friend WithEvents ch1 As System.Windows.Forms.CheckBox
    Friend WithEvents dgw1 As System.Windows.Forms.DataGridView
    Friend WithEvents Cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Elegir As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents rb3 As System.Windows.Forms.RadioButton
End Class
