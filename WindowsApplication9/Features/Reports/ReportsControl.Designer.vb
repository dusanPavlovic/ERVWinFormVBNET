<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportsControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.FromDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ToDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.FromLabel = New System.Windows.Forms.Label()
        Me.ToLabel = New System.Windows.Forms.Label()
        Me.ReportTypeLabel = New System.Windows.Forms.Label()
        Me.ReportByMonthLabel = New System.Windows.Forms.Label()
        Me.ProjectNameLabel = New System.Windows.Forms.Label()
        Me.ReportTypeComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ReportByMonthComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ProjectNameComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ExportReportComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ExportReportButton = New DevExpress.XtraEditors.SimpleButton()
        Me.PrintReportButton = New System.Windows.Forms.Button()
        CType(Me.FromDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FromDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportTypeComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportByMonthComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectNameComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportReportComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FromDateEdit
        '
        Me.FromDateEdit.EditValue = Nothing
        Me.FromDateEdit.Location = New System.Drawing.Point(40, 93)
        Me.FromDateEdit.Name = "FromDateEdit"
        Me.FromDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FromDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FromDateEdit.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.FromDateEdit.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.FromDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.FromDateEdit.TabIndex = 0
        '
        'ToDateEdit
        '
        Me.ToDateEdit.EditValue = Nothing
        Me.ToDateEdit.Location = New System.Drawing.Point(226, 93)
        Me.ToDateEdit.Name = "ToDateEdit"
        Me.ToDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ToDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ToDateEdit.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.ToDateEdit.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.ToDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.ToDateEdit.TabIndex = 1
        '
        'FromLabel
        '
        Me.FromLabel.AutoSize = True
        Me.FromLabel.Location = New System.Drawing.Point(40, 45)
        Me.FromLabel.Name = "FromLabel"
        Me.FromLabel.Size = New System.Drawing.Size(30, 13)
        Me.FromLabel.TabIndex = 2
        Me.FromLabel.Text = "From"
        '
        'ToLabel
        '
        Me.ToLabel.AutoSize = True
        Me.ToLabel.Location = New System.Drawing.Point(223, 45)
        Me.ToLabel.Name = "ToLabel"
        Me.ToLabel.Size = New System.Drawing.Size(20, 13)
        Me.ToLabel.TabIndex = 3
        Me.ToLabel.Text = "To"
        '
        'ReportTypeLabel
        '
        Me.ReportTypeLabel.AutoSize = True
        Me.ReportTypeLabel.Location = New System.Drawing.Point(40, 344)
        Me.ReportTypeLabel.Name = "ReportTypeLabel"
        Me.ReportTypeLabel.Size = New System.Drawing.Size(65, 13)
        Me.ReportTypeLabel.TabIndex = 4
        Me.ReportTypeLabel.Text = "Report type:"
        '
        'ReportByMonthLabel
        '
        Me.ReportByMonthLabel.AutoSize = True
        Me.ReportByMonthLabel.Location = New System.Drawing.Point(381, 150)
        Me.ReportByMonthLabel.Name = "ReportByMonthLabel"
        Me.ReportByMonthLabel.Size = New System.Drawing.Size(91, 13)
        Me.ReportByMonthLabel.TabIndex = 5
        Me.ReportByMonthLabel.Text = "Report by month: "
        '
        'ProjectNameLabel
        '
        Me.ProjectNameLabel.AutoSize = True
        Me.ProjectNameLabel.Location = New System.Drawing.Point(631, 150)
        Me.ProjectNameLabel.Name = "ProjectNameLabel"
        Me.ProjectNameLabel.Size = New System.Drawing.Size(72, 13)
        Me.ProjectNameLabel.TabIndex = 6
        Me.ProjectNameLabel.Text = "Project name:"
        '
        'ReportTypeComboBoxEdit
        '
        Me.ReportTypeComboBoxEdit.Location = New System.Drawing.Point(132, 341)
        Me.ReportTypeComboBoxEdit.Name = "ReportTypeComboBoxEdit"
        Me.ReportTypeComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ReportTypeComboBoxEdit.Size = New System.Drawing.Size(100, 20)
        Me.ReportTypeComboBoxEdit.TabIndex = 7
        '
        'ReportByMonthComboBoxEdit
        '
        Me.ReportByMonthComboBoxEdit.Location = New System.Drawing.Point(478, 147)
        Me.ReportByMonthComboBoxEdit.Name = "ReportByMonthComboBoxEdit"
        Me.ReportByMonthComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ReportByMonthComboBoxEdit.Properties.Items.AddRange(New Object() {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Avg", "Sep", "Oct", "Nov", "Dec"})
        Me.ReportByMonthComboBoxEdit.Size = New System.Drawing.Size(100, 20)
        Me.ReportByMonthComboBoxEdit.TabIndex = 8
        '
        'ProjectNameComboBoxEdit
        '
        Me.ProjectNameComboBoxEdit.Location = New System.Drawing.Point(706, 147)
        Me.ProjectNameComboBoxEdit.Name = "ProjectNameComboBoxEdit"
        Me.ProjectNameComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProjectNameComboBoxEdit.Size = New System.Drawing.Size(100, 20)
        Me.ProjectNameComboBoxEdit.TabIndex = 9
        '
        'ExportReportComboBoxEdit
        '
        Me.ExportReportComboBoxEdit.Location = New System.Drawing.Point(706, 442)
        Me.ExportReportComboBoxEdit.Name = "ExportReportComboBoxEdit"
        Me.ExportReportComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ExportReportComboBoxEdit.Size = New System.Drawing.Size(100, 20)
        Me.ExportReportComboBoxEdit.TabIndex = 10
        '
        'ExportReportButton
        '
        Me.ExportReportButton.Location = New System.Drawing.Point(615, 445)
        Me.ExportReportButton.Name = "ExportReportButton"
        Me.ExportReportButton.Size = New System.Drawing.Size(75, 23)
        Me.ExportReportButton.TabIndex = 11
        Me.ExportReportButton.Text = "Export Report"
        '
        'PrintReportButton
        '
        Me.PrintReportButton.Location = New System.Drawing.Point(403, 485)
        Me.PrintReportButton.Name = "PrintReportButton"
        Me.PrintReportButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintReportButton.TabIndex = 12
        Me.PrintReportButton.Text = "Print report"
        Me.PrintReportButton.UseVisualStyleBackColor = True
        '
        'ReportsControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PrintReportButton)
        Me.Controls.Add(Me.ExportReportButton)
        Me.Controls.Add(Me.ExportReportComboBoxEdit)
        Me.Controls.Add(Me.ProjectNameComboBoxEdit)
        Me.Controls.Add(Me.ReportByMonthComboBoxEdit)
        Me.Controls.Add(Me.ReportTypeComboBoxEdit)
        Me.Controls.Add(Me.ProjectNameLabel)
        Me.Controls.Add(Me.ReportByMonthLabel)
        Me.Controls.Add(Me.ReportTypeLabel)
        Me.Controls.Add(Me.ToLabel)
        Me.Controls.Add(Me.FromLabel)
        Me.Controls.Add(Me.ToDateEdit)
        Me.Controls.Add(Me.FromDateEdit)
        Me.Name = "ReportsControl"
        Me.Size = New System.Drawing.Size(861, 537)
        CType(Me.FromDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FromDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportTypeComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportByMonthComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectNameComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportReportComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FromDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ToDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents FromLabel As System.Windows.Forms.Label
    Friend WithEvents ToLabel As System.Windows.Forms.Label
    Friend WithEvents ReportTypeLabel As System.Windows.Forms.Label
    Friend WithEvents ReportByMonthLabel As System.Windows.Forms.Label
    Friend WithEvents ProjectNameLabel As System.Windows.Forms.Label
    Friend WithEvents ReportTypeComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ReportByMonthComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ProjectNameComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ExportReportComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ExportReportButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PrintReportButton As System.Windows.Forms.Button

End Class
