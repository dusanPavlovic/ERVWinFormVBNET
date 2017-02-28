<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterTravelInfoControl
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
        Me.DateEditFrom = New DevExpress.XtraEditors.DateEdit()
        Me.DateEditTo = New DevExpress.XtraEditors.DateEdit()
        Me.ProjectNameLabel = New System.Windows.Forms.Label()
        Me.ProjectNameComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.TravelPurposeTextBox = New System.Windows.Forms.TextBox()
        Me.TravelpurposeLabel = New System.Windows.Forms.Label()
        Me.TravelLocationLabel = New System.Windows.Forms.Label()
        Me.TravelLocationLabel2 = New System.Windows.Forms.Label()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.SaveTravelInfoButton = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.DateEditFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectNameComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateEditFrom
        '
        Me.DateEditFrom.EditValue = Nothing
        Me.DateEditFrom.Location = New System.Drawing.Point(16, 125)
        Me.DateEditFrom.Name = "DateEditFrom"
        Me.DateEditFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditFrom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditFrom.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.DateEditFrom.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.DateEditFrom.Size = New System.Drawing.Size(100, 20)
        Me.DateEditFrom.TabIndex = 0
        '
        'DateEditTo
        '
        Me.DateEditTo.EditValue = Nothing
        Me.DateEditTo.Location = New System.Drawing.Point(155, 125)
        Me.DateEditTo.Name = "DateEditTo"
        Me.DateEditTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditTo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditTo.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.DateEditTo.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.DateEditTo.Size = New System.Drawing.Size(100, 20)
        Me.DateEditTo.TabIndex = 1
        '
        'ProjectNameLabel
        '
        Me.ProjectNameLabel.AutoSize = True
        Me.ProjectNameLabel.Location = New System.Drawing.Point(307, 73)
        Me.ProjectNameLabel.Name = "ProjectNameLabel"
        Me.ProjectNameLabel.Size = New System.Drawing.Size(75, 13)
        Me.ProjectNameLabel.TabIndex = 2
        Me.ProjectNameLabel.Text = "Project name: "
        '
        'ProjectNameComboBoxEdit
        '
        Me.ProjectNameComboBoxEdit.Location = New System.Drawing.Point(406, 70)
        Me.ProjectNameComboBoxEdit.Name = "ProjectNameComboBoxEdit"
        Me.ProjectNameComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProjectNameComboBoxEdit.Properties.Items.AddRange(New Object() {"Laetus", "Katana", "Relax"})
        Me.ProjectNameComboBoxEdit.Size = New System.Drawing.Size(100, 20)
        Me.ProjectNameComboBoxEdit.TabIndex = 3
        '
        'TravelPurposeTextBox
        '
        Me.TravelPurposeTextBox.Location = New System.Drawing.Point(406, 121)
        Me.TravelPurposeTextBox.Name = "TravelPurposeTextBox"
        Me.TravelPurposeTextBox.Size = New System.Drawing.Size(229, 20)
        Me.TravelPurposeTextBox.TabIndex = 4
        '
        'TravelpurposeLabel
        '
        Me.TravelpurposeLabel.AutoSize = True
        Me.TravelpurposeLabel.Location = New System.Drawing.Point(307, 128)
        Me.TravelpurposeLabel.Name = "TravelpurposeLabel"
        Me.TravelpurposeLabel.Size = New System.Drawing.Size(84, 13)
        Me.TravelpurposeLabel.TabIndex = 5
        Me.TravelpurposeLabel.Text = "Travel purpose: "
        '
        'TravelLocationLabel
        '
        Me.TravelLocationLabel.AutoSize = True
        Me.TravelLocationLabel.Location = New System.Drawing.Point(310, 261)
        Me.TravelLocationLabel.Name = "TravelLocationLabel"
        Me.TravelLocationLabel.Size = New System.Drawing.Size(114, 13)
        Me.TravelLocationLabel.TabIndex = 6
        Me.TravelLocationLabel.Text = "Travel location - State:"
        '
        'TravelLocationLabel2
        '
        Me.TravelLocationLabel2.AutoSize = True
        Me.TravelLocationLabel2.Location = New System.Drawing.Point(313, 329)
        Me.TravelLocationLabel2.Name = "TravelLocationLabel2"
        Me.TravelLocationLabel2.Size = New System.Drawing.Size(106, 13)
        Me.TravelLocationLabel2.TabIndex = 7
        Me.TravelLocationLabel2.Text = "Travel location - City:"
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(427, 258)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(100, 20)
        Me.TextEdit1.TabIndex = 8
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(427, 326)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(100, 20)
        Me.TextEdit2.TabIndex = 9
        '
        'SaveTravelInfoButton
        '
        Me.SaveTravelInfoButton.Location = New System.Drawing.Point(427, 405)
        Me.SaveTravelInfoButton.Name = "SaveTravelInfoButton"
        Me.SaveTravelInfoButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveTravelInfoButton.TabIndex = 10
        Me.SaveTravelInfoButton.Text = "Save"
        '
        'RegisterTravelInfoControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SaveTravelInfoButton)
        Me.Controls.Add(Me.TextEdit2)
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(Me.TravelLocationLabel2)
        Me.Controls.Add(Me.TravelLocationLabel)
        Me.Controls.Add(Me.TravelpurposeLabel)
        Me.Controls.Add(Me.TravelPurposeTextBox)
        Me.Controls.Add(Me.ProjectNameComboBoxEdit)
        Me.Controls.Add(Me.ProjectNameLabel)
        Me.Controls.Add(Me.DateEditTo)
        Me.Controls.Add(Me.DateEditFrom)
        Me.Name = "RegisterTravelInfoControl"
        Me.Size = New System.Drawing.Size(658, 463)
        CType(Me.DateEditFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectNameComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateEditFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEditTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ProjectNameLabel As System.Windows.Forms.Label
    Friend WithEvents ProjectNameComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents TravelPurposeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TravelpurposeLabel As System.Windows.Forms.Label
    Friend WithEvents TravelLocationLabel As System.Windows.Forms.Label
    Friend WithEvents TravelLocationLabel2 As System.Windows.Forms.Label
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SaveTravelInfoButton As DevExpress.XtraEditors.SimpleButton

End Class
