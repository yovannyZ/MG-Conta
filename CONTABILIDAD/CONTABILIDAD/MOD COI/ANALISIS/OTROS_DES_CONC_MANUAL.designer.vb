Imports System.ComponentModel
Imports System.Drawing.Point
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OTROS_DES_CONC_MANUAL
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
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.btn_salir = New System.Windows.Forms.Button
        Me.btn_grabar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_cod_cuenta = New System.Windows.Forms.TextBox
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_debe = New System.Windows.Forms.TextBox
        Me.txt_saldo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_haber = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbo_moneda = New System.Windows.Forms.ComboBox
        Me.K1 = New System.Windows.Forms.TextBox
        Me.txt_desc_cuenta = New System.Windows.Forms.TextBox
        Me.ch_des = New System.Windows.Forms.CheckBox
        Me.cbo_mes1 = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.g_com = New System.Windows.Forms.GroupBox
        Me.DGW_IE = New System.Windows.Forms.DataGridView
        Me.dgw_cuenta = New System.Windows.Forms.DataGridView
        Me.Panel_cuenta = New System.Windows.Forms.Panel
        Me.GroupBox3.SuspendLayout()
        Me.g_com.SuspendLayout()
        CType(Me.DGW_IE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgw_cuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_cuenta.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_cancelar
        '
        Me.btn_cancelar.AutoSize = True
        Me.btn_cancelar.Enabled = False
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Image = Global.CONTABILIDAD.My.Resources.Resources._16__Cancel_1
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.Location = New System.Drawing.Point(124, 80)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(94, 29)
        Me.btn_cancelar.TabIndex = 11
        Me.btn_cancelar.Text = "&Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.AutoSize = True
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salir.Image = Global.CONTABILIDAD.My.Resources.Resources._16__Cancel_1
        Me.btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salir.Location = New System.Drawing.Point(675, 80)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(73, 29)
        Me.btn_salir.TabIndex = 12
        Me.btn_salir.Text = "&Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_grabar
        '
        Me.btn_grabar.AutoSize = True
        Me.btn_grabar.Enabled = False
        Me.btn_grabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_grabar.Image = Global.CONTABILIDAD.My.Resources.Resources._16__Delete_1
        Me.btn_grabar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_grabar.Location = New System.Drawing.Point(7, 80)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(111, 29)
        Me.btn_grabar.TabIndex = 10
        Me.btn_grabar.Text = "&Des-Conciliar"
        Me.btn_grabar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cod. Contable"
        '
        'txt_cod_cuenta
        '
        Me.txt_cod_cuenta.BackColor = System.Drawing.Color.White
        Me.txt_cod_cuenta.Location = New System.Drawing.Point(86, 10)
        Me.txt_cod_cuenta.MaxLength = 10
        Me.txt_cod_cuenta.Name = "txt_cod_cuenta"
        Me.txt_cod_cuenta.Size = New System.Drawing.Size(64, 20)
        Me.txt_cod_cuenta.TabIndex = 1
        '
        'btn_aceptar
        '
        Me.btn_aceptar.AutoSize = True
        Me.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptar.Image = Global.CONTABILIDAD.My.Resources.Resources._16__Card_file_1
        Me.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_aceptar.Location = New System.Drawing.Point(655, 38)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(86, 26)
        Me.btn_aceptar.TabIndex = 6
        Me.btn_aceptar.Text = "&Documentos"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txt_debe)
        Me.GroupBox3.Controls.Add(Me.txt_saldo)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txt_haber)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 31)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(454, 36)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 14)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Debe"
        '
        'txt_debe
        '
        Me.txt_debe.BackColor = System.Drawing.Color.White
        Me.txt_debe.Location = New System.Drawing.Point(45, 10)
        Me.txt_debe.Name = "txt_debe"
        Me.txt_debe.ReadOnly = True
        Me.txt_debe.Size = New System.Drawing.Size(100, 20)
        Me.txt_debe.TabIndex = 5
        Me.txt_debe.TabStop = False
        Me.txt_debe.Text = "0.0"
        Me.txt_debe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_saldo
        '
        Me.txt_saldo.BackColor = System.Drawing.Color.White
        Me.txt_saldo.Location = New System.Drawing.Point(347, 10)
        Me.txt_saldo.Name = "txt_saldo"
        Me.txt_saldo.ReadOnly = True
        Me.txt_saldo.Size = New System.Drawing.Size(100, 20)
        Me.txt_saldo.TabIndex = 7
        Me.txt_saldo.TabStop = False
        Me.txt_saldo.Text = "0.0"
        Me.txt_saldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(157, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 14)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Haber"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(307, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 14)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Saldo"
        '
        'txt_haber
        '
        Me.txt_haber.BackColor = System.Drawing.Color.White
        Me.txt_haber.Location = New System.Drawing.Point(195, 11)
        Me.txt_haber.Name = "txt_haber"
        Me.txt_haber.ReadOnly = True
        Me.txt_haber.Size = New System.Drawing.Size(100, 20)
        Me.txt_haber.TabIndex = 6
        Me.txt_haber.TabStop = False
        Me.txt_haber.Text = "0.0"
        Me.txt_haber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(475, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 14)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Moneda"
        '
        'cbo_moneda
        '
        Me.cbo_moneda.BackColor = System.Drawing.Color.White
        Me.cbo_moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_moneda.FormattingEnabled = True
        Me.cbo_moneda.Location = New System.Drawing.Point(519, 11)
        Me.cbo_moneda.Name = "cbo_moneda"
        Me.cbo_moneda.Size = New System.Drawing.Size(130, 22)
        Me.cbo_moneda.TabIndex = 4
        '
        'K1
        '
        Me.K1.Location = New System.Drawing.Point(339, 10)
        Me.K1.Name = "K1"
        Me.K1.Size = New System.Drawing.Size(10, 20)
        Me.K1.TabIndex = 3
        '
        'txt_desc_cuenta
        '
        Me.txt_desc_cuenta.BackColor = System.Drawing.Color.White
        Me.txt_desc_cuenta.Location = New System.Drawing.Point(156, 10)
        Me.txt_desc_cuenta.Name = "txt_desc_cuenta"
        Me.txt_desc_cuenta.Size = New System.Drawing.Size(315, 20)
        Me.txt_desc_cuenta.TabIndex = 2
        '
        'ch_des
        '
        Me.ch_des.AutoSize = True
        Me.ch_des.Location = New System.Drawing.Point(655, 13)
        Me.ch_des.Name = "ch_des"
        Me.ch_des.Size = New System.Drawing.Size(79, 18)
        Me.ch_des.TabIndex = 16
        Me.ch_des.TabStop = False
        Me.ch_des.Text = "Descuadre"
        Me.ch_des.UseVisualStyleBackColor = True
        '
        'cbo_mes1
        '
        Me.cbo_mes1.BackColor = System.Drawing.Color.White
        Me.cbo_mes1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_mes1.FormattingEnabled = True
        Me.cbo_mes1.Items.AddRange(New Object() {"INICIO", "ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SETIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE", "CIERRE"})
        Me.cbo_mes1.Location = New System.Drawing.Point(519, 40)
        Me.cbo_mes1.Name = "cbo_mes1"
        Me.cbo_mes1.Size = New System.Drawing.Size(130, 22)
        Me.cbo_mes1.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(477, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 14)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Mes"
        '
        'g_com
        '
        Me.g_com.Controls.Add(Me.Label6)
        Me.g_com.Controls.Add(Me.cbo_mes1)
        Me.g_com.Controls.Add(Me.ch_des)
        Me.g_com.Controls.Add(Me.txt_desc_cuenta)
        Me.g_com.Controls.Add(Me.K1)
        Me.g_com.Controls.Add(Me.cbo_moneda)
        Me.g_com.Controls.Add(Me.Label2)
        Me.g_com.Controls.Add(Me.GroupBox3)
        Me.g_com.Controls.Add(Me.btn_aceptar)
        Me.g_com.Controls.Add(Me.txt_cod_cuenta)
        Me.g_com.Controls.Add(Me.Label1)
        Me.g_com.Location = New System.Drawing.Point(7, 1)
        Me.g_com.Name = "g_com"
        Me.g_com.Size = New System.Drawing.Size(749, 73)
        Me.g_com.TabIndex = 5
        Me.g_com.TabStop = False
        '
        'DGW_IE
        '
        Me.DGW_IE.AllowUserToAddRows = False
        Me.DGW_IE.AllowUserToDeleteRows = False
        Me.DGW_IE.AllowUserToOrderColumns = True
        Me.DGW_IE.AllowUserToResizeRows = False
        Me.DGW_IE.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGW_IE.BackgroundColor = System.Drawing.Color.White
        Me.DGW_IE.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGW_IE.Location = New System.Drawing.Point(0, 121)
        Me.DGW_IE.MultiSelect = False
        Me.DGW_IE.Name = "DGW_IE"
        Me.DGW_IE.ReadOnly = True
        Me.DGW_IE.RowHeadersWidth = 25
        Me.DGW_IE.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White
        Me.DGW_IE.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue
        Me.DGW_IE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGW_IE.Size = New System.Drawing.Size(761, 310)
        Me.DGW_IE.TabIndex = 15
        '
        'dgw_cuenta
        '
        Me.dgw_cuenta.AllowUserToAddRows = False
        Me.dgw_cuenta.AllowUserToDeleteRows = False
        Me.dgw_cuenta.AllowUserToOrderColumns = True
        Me.dgw_cuenta.AllowUserToResizeRows = False
        Me.dgw_cuenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgw_cuenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgw_cuenta.BackgroundColor = System.Drawing.Color.White
        Me.dgw_cuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw_cuenta.Location = New System.Drawing.Point(92, -1)
        Me.dgw_cuenta.MultiSelect = False
        Me.dgw_cuenta.Name = "dgw_cuenta"
        Me.dgw_cuenta.ReadOnly = True
        Me.dgw_cuenta.RowHeadersWidth = 25
        Me.dgw_cuenta.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White
        Me.dgw_cuenta.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue
        Me.dgw_cuenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgw_cuenta.Size = New System.Drawing.Size(385, 143)
        Me.dgw_cuenta.TabIndex = 0
        '
        'Panel_cuenta
        '
        Me.Panel_cuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_cuenta.Controls.Add(Me.dgw_cuenta)
        Me.Panel_cuenta.Location = New System.Drawing.Point(0, 32)
        Me.Panel_cuenta.Name = "Panel_cuenta"
        Me.Panel_cuenta.Size = New System.Drawing.Size(492, 158)
        Me.Panel_cuenta.TabIndex = 104
        Me.Panel_cuenta.Visible = False
        '
        'OTROS_DES_CONC_MANUAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 431)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel_cuenta)
        Me.Controls.Add(Me.DGW_IE)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.g_com)
        Me.Controls.Add(Me.btn_grabar)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "OTROS_DES_CONC_MANUAL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Desconciliación Manual(Otras cuentas)"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.g_com.ResumeLayout(False)
        Me.g_com.PerformLayout()
        CType(Me.DGW_IE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgw_cuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_cuenta.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_grabar As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_cod_cuenta As System.Windows.Forms.TextBox
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_debe As System.Windows.Forms.TextBox
    Friend WithEvents txt_saldo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_haber As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbo_moneda As System.Windows.Forms.ComboBox
    Friend WithEvents K1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_desc_cuenta As System.Windows.Forms.TextBox
    Friend WithEvents ch_des As System.Windows.Forms.CheckBox
    Friend WithEvents cbo_mes1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents g_com As System.Windows.Forms.GroupBox
    Friend WithEvents DGW_IE As System.Windows.Forms.DataGridView
    Friend WithEvents dgw_cuenta As System.Windows.Forms.DataGridView
    Friend WithEvents Panel_cuenta As System.Windows.Forms.Panel

End Class
