<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REPORTE_CC_CTA
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ch_cta = New System.Windows.Forms.CheckBox
        Me.PaneL_CTA = New System.Windows.Forms.Panel
        Me.dgw_cta = New System.Windows.Forms.DataGridView
        Me.txt_desc_cta0 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_cod_cta0 = New System.Windows.Forms.TextBox
        Me.cbo_moneda = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btn_salir = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbo_mes2 = New System.Windows.Forms.ComboBox
        Me.gb1 = New System.Windows.Forms.GroupBox
        Me.btn_archivo1 = New System.Windows.Forms.Button
        Me.btn_imprimir1 = New System.Windows.Forms.Button
        Me.btn_pantalla1 = New System.Windows.Forms.Button
        Me.stEstado = New System.Windows.Forms.StatusStrip
        Me.tspbExportar = New System.Windows.Forms.ToolStripProgressBar
        Me.tslblMensaje = New System.Windows.Forms.ToolStripStatusLabel
        Me.GroupBox1.SuspendLayout()
        Me.PaneL_CTA.SuspendLayout()
        CType(Me.dgw_cta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb1.SuspendLayout()
        Me.stEstado.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ch_cta)
        Me.GroupBox1.Controls.Add(Me.PaneL_CTA)
        Me.GroupBox1.Controls.Add(Me.txt_desc_cta0)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_cod_cta0)
        Me.GroupBox1.Controls.Add(Me.cbo_moneda)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btn_salir)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbo_mes2)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(487, 217)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ch_cta
        '
        Me.ch_cta.AutoSize = True
        Me.ch_cta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_cta.Location = New System.Drawing.Point(74, 40)
        Me.ch_cta.Name = "ch_cta"
        Me.ch_cta.Size = New System.Drawing.Size(15, 14)
        Me.ch_cta.TabIndex = 1
        Me.ch_cta.UseVisualStyleBackColor = True
        '
        'PaneL_CTA
        '
        Me.PaneL_CTA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PaneL_CTA.Controls.Add(Me.dgw_cta)
        Me.PaneL_CTA.Location = New System.Drawing.Point(74, 56)
        Me.PaneL_CTA.Name = "PaneL_CTA"
        Me.PaneL_CTA.Size = New System.Drawing.Size(413, 124)
        Me.PaneL_CTA.TabIndex = 4
        Me.PaneL_CTA.Visible = False
        '
        'dgw_cta
        '
        Me.dgw_cta.AllowUserToAddRows = False
        Me.dgw_cta.AllowUserToDeleteRows = False
        Me.dgw_cta.AllowUserToOrderColumns = True
        Me.dgw_cta.AllowUserToResizeRows = False
        Me.dgw_cta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgw_cta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgw_cta.BackgroundColor = System.Drawing.Color.White
        Me.dgw_cta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw_cta.Location = New System.Drawing.Point(21, -1)
        Me.dgw_cta.Margin = New System.Windows.Forms.Padding(0)
        Me.dgw_cta.MultiSelect = False
        Me.dgw_cta.Name = "dgw_cta"
        Me.dgw_cta.ReadOnly = True
        Me.dgw_cta.RowHeadersWidth = 25
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop
        Me.dgw_cta.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgw_cta.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White
        Me.dgw_cta.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue
        Me.dgw_cta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgw_cta.Size = New System.Drawing.Size(383, 117)
        Me.dgw_cta.TabIndex = 0
        '
        'txt_desc_cta0
        '
        Me.txt_desc_cta0.BackColor = System.Drawing.Color.White
        Me.txt_desc_cta0.Enabled = False
        Me.txt_desc_cta0.Location = New System.Drawing.Point(155, 36)
        Me.txt_desc_cta0.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_desc_cta0.MaxLength = 40
        Me.txt_desc_cta0.Name = "txt_desc_cta0"
        Me.txt_desc_cta0.Size = New System.Drawing.Size(323, 20)
        Me.txt_desc_cta0.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 14)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Cuenta"
        '
        'txt_cod_cta0
        '
        Me.txt_cod_cta0.BackColor = System.Drawing.Color.White
        Me.txt_cod_cta0.Enabled = False
        Me.txt_cod_cta0.Location = New System.Drawing.Point(95, 36)
        Me.txt_cod_cta0.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_cod_cta0.MaxLength = 8
        Me.txt_cod_cta0.Name = "txt_cod_cta0"
        Me.txt_cod_cta0.Size = New System.Drawing.Size(60, 20)
        Me.txt_cod_cta0.TabIndex = 2
        '
        'cbo_moneda
        '
        Me.cbo_moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_moneda.FormattingEnabled = True
        Me.cbo_moneda.Items.AddRange(New Object() {"NUEVOS SOLES", "DÓLARES AMERICANOS"})
        Me.cbo_moneda.Location = New System.Drawing.Point(95, 113)
        Me.cbo_moneda.Name = "cbo_moneda"
        Me.cbo_moneda.Size = New System.Drawing.Size(135, 21)
        Me.cbo_moneda.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 14)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Moneda"
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.SystemColors.Control
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salir.Image = Global.CONTABILIDAD.My.Resources.Resources._16__Cancel_1
        Me.btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salir.Location = New System.Drawing.Point(338, 120)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(82, 33)
        Me.btn_salir.TabIndex = 9
        Me.btn_salir.TabStop = False
        Me.btn_salir.Text = "&Salir"
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Al mes de"
        '
        'cbo_mes2
        '
        Me.cbo_mes2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_mes2.FormattingEnabled = True
        Me.cbo_mes2.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SETIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.cbo_mes2.Location = New System.Drawing.Point(95, 74)
        Me.cbo_mes2.Name = "cbo_mes2"
        Me.cbo_mes2.Size = New System.Drawing.Size(135, 21)
        Me.cbo_mes2.TabIndex = 6
        '
        'gb1
        '
        Me.gb1.BackColor = System.Drawing.Color.White
        Me.gb1.Controls.Add(Me.btn_archivo1)
        Me.gb1.Controls.Add(Me.btn_imprimir1)
        Me.gb1.Controls.Add(Me.btn_pantalla1)
        Me.gb1.Location = New System.Drawing.Point(155, 271)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(276, 67)
        Me.gb1.TabIndex = 1
        Me.gb1.TabStop = False
        '
        'btn_archivo1
        '
        Me.btn_archivo1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_archivo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_archivo1.Image = Global.CONTABILIDAD.My.Resources.Resources._16__Folder_1
        Me.btn_archivo1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_archivo1.Location = New System.Drawing.Point(186, 17)
        Me.btn_archivo1.Name = "btn_archivo1"
        Me.btn_archivo1.Size = New System.Drawing.Size(82, 33)
        Me.btn_archivo1.TabIndex = 2
        Me.btn_archivo1.Text = "&Archivo"
        Me.btn_archivo1.UseVisualStyleBackColor = False
        '
        'btn_imprimir1
        '
        Me.btn_imprimir1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_imprimir1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_imprimir1.Image = Global.CONTABILIDAD.My.Resources.Resources._16__Print_1
        Me.btn_imprimir1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_imprimir1.Location = New System.Drawing.Point(98, 17)
        Me.btn_imprimir1.Name = "btn_imprimir1"
        Me.btn_imprimir1.Size = New System.Drawing.Size(82, 33)
        Me.btn_imprimir1.TabIndex = 1
        Me.btn_imprimir1.Text = "&Imprimir"
        Me.btn_imprimir1.UseVisualStyleBackColor = False
        '
        'btn_pantalla1
        '
        Me.btn_pantalla1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_pantalla1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pantalla1.Image = Global.CONTABILIDAD.My.Resources.Resources._16__Screen_1
        Me.btn_pantalla1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_pantalla1.Location = New System.Drawing.Point(10, 17)
        Me.btn_pantalla1.Name = "btn_pantalla1"
        Me.btn_pantalla1.Size = New System.Drawing.Size(82, 33)
        Me.btn_pantalla1.TabIndex = 0
        Me.btn_pantalla1.Text = "&Pantalla"
        Me.btn_pantalla1.UseVisualStyleBackColor = False
        '
        'stEstado
        '
        Me.stEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tspbExportar, Me.tslblMensaje})
        Me.stEstado.Location = New System.Drawing.Point(0, 342)
        Me.stEstado.Name = "stEstado"
        Me.stEstado.Size = New System.Drawing.Size(543, 22)
        Me.stEstado.TabIndex = 157
        Me.stEstado.Text = "StatusStrip1"
        Me.stEstado.Visible = False
        '
        'tspbExportar
        '
        Me.tspbExportar.Name = "tspbExportar"
        Me.tspbExportar.Size = New System.Drawing.Size(100, 16)
        Me.tspbExportar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        '
        'tslblMensaje
        '
        Me.tslblMensaje.Name = "tslblMensaje"
        Me.tslblMensaje.Size = New System.Drawing.Size(109, 17)
        Me.tslblMensaje.Text = "Generando Archivo"
        '
        'REPORTE_CC_CTA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 364)
        Me.ControlBox = False
        Me.Controls.Add(Me.stEstado)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gb1)
        Me.Name = "REPORTE_CC_CTA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Saldos Cuenta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PaneL_CTA.ResumeLayout(False)
        CType(Me.dgw_cta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb1.ResumeLayout(False)
        Me.stEstado.ResumeLayout(False)
        Me.stEstado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_moneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbo_mes2 As System.Windows.Forms.ComboBox
    Friend WithEvents gb1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_archivo1 As System.Windows.Forms.Button
    Friend WithEvents btn_imprimir1 As System.Windows.Forms.Button
    Friend WithEvents btn_pantalla1 As System.Windows.Forms.Button
    Friend WithEvents ch_cta As System.Windows.Forms.CheckBox
    Friend WithEvents PaneL_CTA As System.Windows.Forms.Panel
    Friend WithEvents dgw_cta As System.Windows.Forms.DataGridView
    Friend WithEvents txt_desc_cta0 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_cod_cta0 As System.Windows.Forms.TextBox
    Friend WithEvents stEstado As System.Windows.Forms.StatusStrip
    Friend WithEvents tspbExportar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents tslblMensaje As System.Windows.Forms.ToolStripStatusLabel
End Class
