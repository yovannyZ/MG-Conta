<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REP_CONC_PTE
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
        Me.components = New System.ComponentModel.Container
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.DT_CONC_PTE = New CONTABILIDAD.DT_CONC_PTE
        Me.REPORTE_BANCO_CONC_PTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.REPORTE_BANCO_CONC_PTETableAdapter = New CONTABILIDAD.DT_CONC_PTETableAdapters.REPORTE_BANCO_CONC_PTETableAdapter
        CType(Me.DT_CONC_PTE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REPORTE_BANCO_CONC_PTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DT_CONC_PTE_REPORTE_BANCO_CONC_PTE"
        ReportDataSource1.Value = Me.REPORTE_BANCO_CONC_PTEBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CONTABILIDAD.REP_CONC_PTE.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(677, 621)
        Me.ReportViewer1.TabIndex = 0
        '
        'DT_CONC_PTE
        '
        Me.DT_CONC_PTE.DataSetName = "DT_CONC_PTE"
        Me.DT_CONC_PTE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'REPORTE_BANCO_CONC_PTEBindingSource
        '
        Me.REPORTE_BANCO_CONC_PTEBindingSource.DataMember = "REPORTE_BANCO_CONC_PTE"
        Me.REPORTE_BANCO_CONC_PTEBindingSource.DataSource = Me.DT_CONC_PTE
        '
        'REPORTE_BANCO_CONC_PTETableAdapter
        '
        Me.REPORTE_BANCO_CONC_PTETableAdapter.ClearBeforeFill = True
        '
        'REP_CONC_PTE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 621)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "REP_CONC_PTE"
        Me.Text = "REP_CONC_PTE"
        CType(Me.DT_CONC_PTE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REPORTE_BANCO_CONC_PTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents REPORTE_BANCO_CONC_PTEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DT_CONC_PTE As CONTABILIDAD.DT_CONC_PTE
    Friend WithEvents REPORTE_BANCO_CONC_PTETableAdapter As CONTABILIDAD.DT_CONC_PTETableAdapters.REPORTE_BANCO_CONC_PTETableAdapter
End Class
