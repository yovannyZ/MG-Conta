<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REP_TCXP
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
        Me.REPORTE_SALDOS_TCXPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_REP_ANA_CXP = New CONTABILIDAD.DT_REP_ANA_CXP
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.REPORTE_SALDOS_TCXPTableAdapter = New CONTABILIDAD.DT_REP_ANA_CXPTableAdapters.REPORTE_SALDOS_TCXPTableAdapter
        CType(Me.REPORTE_SALDOS_TCXPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_REP_ANA_CXP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'REPORTE_SALDOS_TCXPBindingSource
        '
        Me.REPORTE_SALDOS_TCXPBindingSource.DataMember = "REPORTE_SALDOS_TCXP"
        Me.REPORTE_SALDOS_TCXPBindingSource.DataSource = Me.DT_REP_ANA_CXP
        '
        'DT_REP_ANA_CXP
        '
        Me.DT_REP_ANA_CXP.DataSetName = "DT_REP_ANA_CXP"
        Me.DT_REP_ANA_CXP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DT_REP_ANA_CXP_REPORTE_SALDOS_TCXP"
        ReportDataSource1.Value = Me.REPORTE_SALDOS_TCXPBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CONTABILIDAD.REP_SALDOS_TCXP.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(584, 574)
        Me.ReportViewer1.TabIndex = 0
        '
        'REPORTE_SALDOS_TCXPTableAdapter
        '
        Me.REPORTE_SALDOS_TCXPTableAdapter.ClearBeforeFill = True
        '
        'REP_TCXP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 574)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "REP_TCXP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REP_TCXP"
        CType(Me.REPORTE_SALDOS_TCXPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_REP_ANA_CXP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents REPORTE_SALDOS_TCXPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DT_REP_ANA_CXP As CONTABILIDAD.DT_REP_ANA_CXP
    Friend WithEvents REPORTE_SALDOS_TCXPTableAdapter As CONTABILIDAD.DT_REP_ANA_CXPTableAdapters.REPORTE_SALDOS_TCXPTableAdapter
End Class
