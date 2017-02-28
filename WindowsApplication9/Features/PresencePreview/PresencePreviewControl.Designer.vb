<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PresencePreviewControl
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.CheckOutLabel = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.CheckInLabel = New DevExpress.XtraEditors.LabelControl()
        Me.CheckInTimeLabel = New DevExpress.XtraEditors.LabelControl()
        Me.ShowEmpTimesButton = New System.Windows.Forms.Button()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(19, 82)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(169, 225)
        Me.ListBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(546, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Show Absence Employees"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(546, 82)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(169, 225)
        Me.ListBox2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "All Employess"
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(19, 325)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.DateEdit1.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.DateEdit1.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit1.TabIndex = 7
        '
        'CheckOutLabel
        '
        Me.CheckOutLabel.Location = New System.Drawing.Point(237, 131)
        Me.CheckOutLabel.Name = "CheckOutLabel"
        Me.CheckOutLabel.Size = New System.Drawing.Size(79, 13)
        Me.CheckOutLabel.TabIndex = 8
        Me.CheckOutLabel.Text = "Check Out Time:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(319, 131)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl2.TabIndex = 9
        Me.LabelControl2.Text = "00:00:00"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(237, 195)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl3.TabIndex = 10
        Me.LabelControl3.Text = "LabelControl3"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(237, 234)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl4.TabIndex = 11
        Me.LabelControl4.Text = "LabelControl4"
        '
        'CheckInLabel
        '
        Me.CheckInLabel.Location = New System.Drawing.Point(237, 82)
        Me.CheckInLabel.Name = "CheckInLabel"
        Me.CheckInLabel.Size = New System.Drawing.Size(71, 13)
        Me.CheckInLabel.TabIndex = 12
        Me.CheckInLabel.Text = "Check In Time:"
        '
        'CheckInTimeLabel
        '
        Me.CheckInTimeLabel.Location = New System.Drawing.Point(319, 82)
        Me.CheckInTimeLabel.Name = "CheckInTimeLabel"
        Me.CheckInTimeLabel.Size = New System.Drawing.Size(44, 13)
        Me.CheckInTimeLabel.TabIndex = 13
        Me.CheckInTimeLabel.Text = "00:00:00"
        '
        'ShowEmpTimesButton
        '
        Me.ShowEmpTimesButton.Location = New System.Drawing.Point(214, 322)
        Me.ShowEmpTimesButton.Name = "ShowEmpTimesButton"
        Me.ShowEmpTimesButton.Size = New System.Drawing.Size(75, 23)
        Me.ShowEmpTimesButton.TabIndex = 15
        Me.ShowEmpTimesButton.Text = "Show "
        Me.ShowEmpTimesButton.UseVisualStyleBackColor = True
        '
        'PresencePreviewControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ShowEmpTimesButton)
        Me.Controls.Add(Me.CheckInTimeLabel)
        Me.Controls.Add(Me.CheckInLabel)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.CheckOutLabel)
        Me.Controls.Add(Me.DateEdit1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PresencePreviewControl"
        Me.Size = New System.Drawing.Size(741, 603)
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents CheckOutLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckInLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckInTimeLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ShowEmpTimesButton As System.Windows.Forms.Button

End Class
