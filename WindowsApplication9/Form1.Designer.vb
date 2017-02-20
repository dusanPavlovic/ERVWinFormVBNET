<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
        Me.TabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
        Me.DocumentGroup1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
        Me.Document1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
        Me.Document2 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
        Me.Document3 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
        Me.Document4 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Document1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Document2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Document3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Document4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DocumentManager1
        '
        Me.DocumentManager1.ContainerControl = Me
        Me.DocumentManager1.View = Me.TabbedView1
        Me.DocumentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.TabbedView1})
        '
        'TabbedView1
        '
        Me.TabbedView1.DocumentGroups.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup() {Me.DocumentGroup1})
        Me.TabbedView1.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.Document1, Me.Document2, Me.Document3, Me.Document4})
        '
        'DocumentGroup1
        '
        Me.DocumentGroup1.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document() {Me.Document1, Me.Document2, Me.Document3, Me.Document4})
        '
        'Document1
        '
        Me.Document1.Caption = "Check In/Out"
        Me.Document1.ControlName = "CheckInOutDocument"
        '
        'Document2
        '
        Me.Document2.Caption = "Presence Preview"
        Me.Document2.ControlName = "PresencePreviewDocument"
        '
        'Document3
        '
        Me.Document3.Caption = "Reports"
        Me.Document3.ControlName = "ReportsDocument"
        '
        'Document4
        '
        Me.Document4.Caption = "RegisterTravelInfo"
        Me.Document4.ControlName = "RegisterTravelInfoDocument"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 645)
        Me.Name = "Form1"
        Me.Text = "ERV Tool"
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Document1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Document2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Document3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Document4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DocumentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
    Friend WithEvents TabbedView1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
    Friend WithEvents DocumentGroup1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup
    Friend WithEvents Document1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
    Friend WithEvents Document2 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
    Friend WithEvents Document3 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
    Friend WithEvents Document4 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

End Class
