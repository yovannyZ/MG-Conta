<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REP_PENDIENTE_CXC_GESTION
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
        Me.DT_REP_ANA_CXC = New CONTABILIDAD.DT_REP_ANA_CXC
        Me.REPORTE_CONCILIADAS_CXCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.REPORTE_CONCILIADAS_CXCTableAdapter = New CONTABILIDAD.DT_REP_ANA_CXCTableAdapters.REPORTE_CONCILIADAS_CXCTableAdapter
        CType(Me.DT_REP_ANA_CXC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REPORTE_CONCILIADAS_CXCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DT_REP_ANA_CXC_REPORTE_CONCILIADAS_CXC"
        ReportDataSource1.Value = Me.REPORTE_CONCILIADAS_CXCBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CONTABILIDAD.REP_PENDIENTE_CXC_GESTION.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(652, 590)
        Me.ReportViewer1.TabIndex = 0
        '
        'DT_REP_ANA_CXC
        '
        Me.DT_REP_ANA_CXC.DataSetName = "DT_REP_ANA_CXC"
        Me.DT_REP_ANA_CXC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'REPORTE_CONCILIADAS_CXCBindingSource
        '
        Me.REPORTE_CONCILIADAS_CXCBindingSource.DataMember = "REPORTE_CONCILIADAS_CXC"
        Me.REPORTE_CONCILIADAS_CXCBindingSource.DataSource = Me.DT_REP_ANA_CXC
        '
        'REPORTE_CONCILIADAS_CXCTableAdapter
        '
        Me.REPORTE_CONCILIADAS_CXCTableAdapter.ClearBeforeFill = True
        '
        'REP_PENDIENTE_CXC_GESTION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 590)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "REP_PENDIENTE_CXC_GESTION"
        Me.Text = "REP_PENDIENTE_CXC_GESTION"
        CType(Me.DT_REP_ANA_CXC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REPORTE_CONCILIADAS_CXCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents REPORTE_CONCILIADAS_CXCBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DT_REP_ANA_CXC As CONTABILIDAD.DT_REP_ANA_CXC
    Friend WithEvents REPORTE_CONCILIADAS_CXCTableAdapter As CONTABILIDAD.DT_REP_ANA_CXCTableAdapters.REPORTE_CONCILIADAS_CXCTableAdapter
End Class
