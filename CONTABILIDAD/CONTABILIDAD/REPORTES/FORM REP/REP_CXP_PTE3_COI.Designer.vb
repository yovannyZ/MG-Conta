<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REP_CXP_PTE3_COI
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
        Me.REPORTE_CXP_PTES2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_REPORTES = New CONTABILIDAD.DT_REPORTES
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.REPORTE_CXP_PTES2TableAdapter = New CONTABILIDAD.DT_REPORTESTableAdapters.REPORTE_CXP_PTES2TableAdapter
        CType(Me.REPORTE_CXP_PTES2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_REPORTES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'REPORTE_CXP_PTES2BindingSource
        '
        Me.REPORTE_CXP_PTES2BindingSource.DataMember = "REPORTE_CXP_PTES2"
        Me.REPORTE_CXP_PTES2BindingSource.DataSource = Me.DT_REPORTES
        '
        'DT_REPORTES
        '
        Me.DT_REPORTES.DataSetName = "DT_REPORTES"
        Me.DT_REPORTES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DT_REPORTES_REPORTE_CXP_PTES2"
        ReportDataSource1.Value = Me.REPORTE_CXP_PTES2BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CONTABILIDAD.REP_CXP_PTE31_COI.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(678, 539)
        Me.ReportViewer1.TabIndex = 0
        '
        'REPORTE_CXP_PTES2TableAdapter
        '
        Me.REPORTE_CXP_PTES2TableAdapter.ClearBeforeFill = True
        '
        'REP_CXP_PTE3_COI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 539)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "REP_CXP_PTE3_COI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REP_CXP_PTE3_COI"
        CType(Me.REPORTE_CXP_PTES2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_REPORTES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents REPORTE_CXP_PTES2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DT_REPORTES As CONTABILIDAD.DT_REPORTES
    Friend WithEvents REPORTE_CXP_PTES2TableAdapter As CONTABILIDAD.DT_REPORTESTableAdapters.REPORTE_CXP_PTES2TableAdapter
End Class
