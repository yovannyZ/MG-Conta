<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PROYECTO
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.btn_transf = New System.Windows.Forms.Button
        Me.btn_salir = New System.Windows.Forms.Button
        Me.btn_eliminar = New System.Windows.Forms.Button
        Me.btn_modificar = New System.Windows.Forms.Button
        Me.btn_nuevo = New System.Windows.Forms.Button
        Me.dgw1 = New System.Windows.Forms.DataGridView
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btn_guardar = New System.Windows.Forms.Button
        Me.btn_modificar2 = New System.Windows.Forms.Button
        Me.txt_obs = New System.Windows.Forms.TextBox
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtp_cie = New System.Windows.Forms.DateTimePicker
        Me.dtp_ini = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_desc2 = New System.Windows.Forms.TextBox
        Me.txt_desc = New System.Windows.Forms.TextBox
        Me.txt_cod = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgw1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(522, 303)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn_transf)
        Me.TabPage1.Controls.Add(Me.btn_salir)
        Me.TabPage1.Controls.Add(Me.btn_eliminar)
        Me.TabPage1.Controls.Add(Me.btn_modificar)
        Me.TabPage1.Controls.Add(Me.btn_nuevo)
        Me.TabPage1.Controls.Add(Me.dgw1)
        Me.TabPage1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(514, 276)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Lista de Proyectos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btn_transf
        '
        Me.btn_transf.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_transf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_transf.Image = Global.CONTABILIDAD.My.Resources.Resources._16__Cabinet_
        Me.btn_transf.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_transf.Location = New System.Drawing.Point(409, 190)
        Me.btn_transf.Name = "btn_transf"
        Me.btn_transf.Size = New System.Drawing.Size(85, 66)
        Me.btn_transf.TabIndex = 8
        Me.btn_transf.TabStop = False
        Me.btn_transf.Text = "&Transferencia de Gestión Comercial"
        Me.btn_transf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_transf.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salir.Image = Global.CONTABILIDAD.My.Resources.Resources._16__Cancel_1
        Me.btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salir.Location = New System.Drawing.Point(409, 149)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(85, 35)
        Me.btn_salir.TabIndex = 4
        Me.btn_salir.Text = "&Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar.Image = Global.CONTABILIDAD.My.Resources.Resources._16__Delete_1
        Me.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_eliminar.Location = New System.Drawing.Point(409, 108)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(85, 35)
        Me.btn_eliminar.TabIndex = 3
        Me.btn_eliminar.Text = "&Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_modificar.Image = Global.CONTABILIDAD.My.Resources.Resources._16__Edit_2_1
        Me.btn_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_modificar.Location = New System.Drawing.Point(409, 67)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(85, 35)
        Me.btn_modificar.TabIndex = 2
        Me.btn_modificar.Text = "&Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nuevo.Image = Global.CONTABILIDAD.My.Resources.Resources._16__File_new_1
        Me.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_nuevo.Location = New System.Drawing.Point(409, 26)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(85, 35)
        Me.btn_nuevo.TabIndex = 1
        Me.btn_nuevo.Text = "&Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'dgw1
        '
        Me.dgw1.AllowUserToAddRows = False
        Me.dgw1.AllowUserToDeleteRows = False
        Me.dgw1.AllowUserToOrderColumns = True
        Me.dgw1.AllowUserToResizeRows = False
        Me.dgw1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgw1.BackgroundColor = System.Drawing.Color.White
        Me.dgw1.Location = New System.Drawing.Point(21, 26)
        Me.dgw1.MultiSelect = False
        Me.dgw1.Name = "dgw1"
        Me.dgw1.ReadOnly = True
        Me.dgw1.RowHeadersWidth = 25
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        Me.dgw1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgw1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White
        Me.dgw1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue
        Me.dgw1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgw1.Size = New System.Drawing.Size(370, 200)
        Me.dgw1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(514, 276)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Detalles"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_guardar)
        Me.GroupBox1.Controls.Add(Me.btn_modificar2)
        Me.GroupBox1.Controls.Add(Me.txt_obs)
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dtp_cie)
        Me.GroupBox1.Controls.Add(Me.dtp_ini)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_desc2)
        Me.GroupBox1.Controls.Add(Me.txt_desc)
        Me.GroupBox1.Controls.Add(Me.txt_cod)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(483, 240)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btn_guardar
        '
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar.Image = Global.CONTABILIDAD.My.Resources.Resources._16__Save_as_1
        Me.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_guardar.Location = New System.Drawing.Point(286, 182)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(77, 27)
        Me.btn_guardar.TabIndex = 7
        Me.btn_guardar.Text = "&Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_modificar2
        '
        Me.btn_modificar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_modificar2.Image = Global.CONTABILIDAD.My.Resources.Resources._16__Save_as_1
        Me.btn_modificar2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_modificar2.Location = New System.Drawing.Point(286, 182)
        Me.btn_modificar2.Name = "btn_modificar2"
        Me.btn_modificar2.Size = New System.Drawing.Size(77, 27)
        Me.btn_modificar2.TabIndex = 7
        Me.btn_modificar2.Text = "&Guardar"
        Me.btn_modificar2.UseVisualStyleBackColor = True
        '
        'txt_obs
        '
        Me.txt_obs.BackColor = System.Drawing.Color.White
        Me.txt_obs.Location = New System.Drawing.Point(95, 133)
        Me.txt_obs.MaxLength = 60
        Me.txt_obs.Name = "txt_obs"
        Me.txt_obs.Size = New System.Drawing.Size(370, 20)
        Me.txt_obs.TabIndex = 6
        '
        'btn_cancelar
        '
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Image = Global.CONTABILIDAD.My.Resources.Resources._16__Cancel_1
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.Location = New System.Drawing.Point(373, 182)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(77, 27)
        Me.btn_cancelar.TabIndex = 8
        Me.btn_cancelar.Text = "&Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 14)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Observación"
        '
        'dtp_cie
        '
        Me.dtp_cie.Checked = False
        Me.dtp_cie.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_cie.Location = New System.Drawing.Point(286, 105)
        Me.dtp_cie.Name = "dtp_cie"
        Me.dtp_cie.ShowCheckBox = True
        Me.dtp_cie.Size = New System.Drawing.Size(95, 20)
        Me.dtp_cie.TabIndex = 5
        '
        'dtp_ini
        '
        Me.dtp_ini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ini.Location = New System.Drawing.Point(95, 105)
        Me.dtp_ini.Name = "dtp_ini"
        Me.dtp_ini.Size = New System.Drawing.Size(84, 20)
        Me.dtp_ini.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(211, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 14)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Fecha Cierre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 14)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha Inicio"
        '
        'txt_desc2
        '
        Me.txt_desc2.BackColor = System.Drawing.Color.White
        Me.txt_desc2.Location = New System.Drawing.Point(95, 78)
        Me.txt_desc2.MaxLength = 30
        Me.txt_desc2.Name = "txt_desc2"
        Me.txt_desc2.Size = New System.Drawing.Size(286, 20)
        Me.txt_desc2.TabIndex = 2
        '
        'txt_desc
        '
        Me.txt_desc.BackColor = System.Drawing.Color.White
        Me.txt_desc.Location = New System.Drawing.Point(95, 49)
        Me.txt_desc.MaxLength = 60
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.Size = New System.Drawing.Size(370, 20)
        Me.txt_desc.TabIndex = 1
        '
        'txt_cod
        '
        Me.txt_cod.BackColor = System.Drawing.Color.White
        Me.txt_cod.Location = New System.Drawing.Point(95, 22)
        Me.txt_cod.MaxLength = 5
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(84, 20)
        Me.txt_cod.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Abreviado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'PROYECTO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_salir
        Me.ClientSize = New System.Drawing.Size(522, 303)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "PROYECTO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Proyectos"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgw1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_modificar2 As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_transf As System.Windows.Forms.Button
    Friend WithEvents dgw1 As System.Windows.Forms.DataGridView
    Friend WithEvents dtp_cie As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_ini As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txt_cod As System.Windows.Forms.TextBox
    Friend WithEvents txt_desc As System.Windows.Forms.TextBox
    Friend WithEvents txt_desc2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_obs As System.Windows.Forms.TextBox

End Class
