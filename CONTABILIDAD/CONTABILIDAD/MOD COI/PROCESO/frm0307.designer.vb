<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm0307
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cbo_año = New System.Windows.Forms.ComboBox
        Me.cbo_mes = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btn_exportar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cbo_año
        '
        Me.cbo_año.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_año.FormattingEnabled = True
        Me.cbo_año.Location = New System.Drawing.Point(102, 84)
        Me.cbo_año.Name = "cbo_año"
        Me.cbo_año.Size = New System.Drawing.Size(79, 21)
        Me.cbo_año.TabIndex = 5
        '
        'cbo_mes
        '
        Me.cbo_mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_mes.FormattingEnabled = True
        Me.cbo_mes.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SETIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.cbo_mes.Location = New System.Drawing.Point(239, 84)
        Me.cbo_mes.Name = "cbo_mes"
        Me.cbo_mes.Size = New System.Drawing.Size(135, 21)
        Me.cbo_mes.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 14)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Año :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(200, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 14)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Mes :"
        '
        'btn_exportar
        '
        Me.btn_exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exportar.Image = Global.CONTABILIDAD.My.Resources.Resources.notepad
        Me.btn_exportar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_exportar.Location = New System.Drawing.Point(390, 79)
        Me.btn_exportar.Name = "btn_exportar"
        Me.btn_exportar.Size = New System.Drawing.Size(83, 31)
        Me.btn_exportar.TabIndex = 9
        Me.btn_exportar.Text = "&Exportar"
        Me.btn_exportar.UseVisualStyleBackColor = True
        '
        'frm0307
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 188)
        Me.Controls.Add(Me.btn_exportar)
        Me.Controls.Add(Me.cbo_año)
        Me.Controls.Add(Me.cbo_mes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Name = "frm0307"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "3.7 Cta. 20"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbo_año As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_mes As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_exportar As System.Windows.Forms.Button
End Class
