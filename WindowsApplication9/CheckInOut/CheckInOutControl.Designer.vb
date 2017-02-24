<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckInOutControl
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
        Me.components = New System.ComponentModel.Container()
        Me.CheckInButton = New System.Windows.Forms.Button()
        Me.GaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
        Me.DigitalGauge1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
        Me.DigitalBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CheckInTimeLabel = New System.Windows.Forms.Label()
        Me.CheckOutButton = New System.Windows.Forms.Button()
        Me.CheckOutLabel = New System.Windows.Forms.Label()
        CType(Me.DigitalGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckInButton
        '
        Me.CheckInButton.Location = New System.Drawing.Point(360, 216)
        Me.CheckInButton.Name = "CheckInButton"
        Me.CheckInButton.Size = New System.Drawing.Size(75, 23)
        Me.CheckInButton.TabIndex = 0
        Me.CheckInButton.Text = "CheckIn"
        Me.CheckInButton.UseVisualStyleBackColor = True
        '
        'GaugeControl1
        '
        Me.GaugeControl1.AutoLayout = False
        Me.GaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.DigitalGauge1})
        Me.GaugeControl1.Location = New System.Drawing.Point(25, 205)
        Me.GaugeControl1.Name = "GaugeControl1"
        Me.GaugeControl1.Size = New System.Drawing.Size(250, 250)
        Me.GaugeControl1.TabIndex = 1
        '
        'DigitalGauge1
        '
        Me.DigitalGauge1.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#EAECF1")
        Me.DigitalGauge1.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#7184BA")
        Me.DigitalGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.DigitalBackgroundLayerComponent1})
        Me.DigitalGauge1.Bounds = New System.Drawing.Rectangle(5, 5, 238, 238)
        Me.DigitalGauge1.DigitCount = 5
        Me.DigitalGauge1.Name = "DigitalGauge1"
        Me.DigitalGauge1.Padding = New DevExpress.XtraGauges.Core.Base.TextSpacing(26, 20, 26, 20)
        Me.DigitalGauge1.Text = "00,000"
        '
        'DigitalBackgroundLayerComponent1
        '
        Me.DigitalBackgroundLayerComponent1.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(265.8125!, 99.9625!)
        Me.DigitalBackgroundLayerComponent1.Name = "digitalBackgroundLayerComponent1"
        Me.DigitalBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style16
        Me.DigitalBackgroundLayerComponent1.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(26.0!, 0.0!)
        Me.DigitalBackgroundLayerComponent1.ZOrder = 1000
        '
        'Timer1
        '
        '
        'CheckInTimeLabel
        '
        Me.CheckInTimeLabel.AutoSize = True
        Me.CheckInTimeLabel.Location = New System.Drawing.Point(478, 216)
        Me.CheckInTimeLabel.Name = "CheckInTimeLabel"
        Me.CheckInTimeLabel.Size = New System.Drawing.Size(0, 13)
        Me.CheckInTimeLabel.TabIndex = 2
        '
        'CheckOutButton
        '
        Me.CheckOutButton.Location = New System.Drawing.Point(360, 394)
        Me.CheckOutButton.Name = "CheckOutButton"
        Me.CheckOutButton.Size = New System.Drawing.Size(75, 23)
        Me.CheckOutButton.TabIndex = 3
        Me.CheckOutButton.Text = "CheckOut"
        Me.CheckOutButton.UseVisualStyleBackColor = True
        '
        'CheckOutLabel
        '
        Me.CheckOutLabel.AutoSize = True
        Me.CheckOutLabel.Location = New System.Drawing.Point(517, 394)
        Me.CheckOutLabel.Name = "CheckOutLabel"
        Me.CheckOutLabel.Size = New System.Drawing.Size(0, 13)
        Me.CheckOutLabel.TabIndex = 4
        '
        'CheckInOutControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CheckOutLabel)
        Me.Controls.Add(Me.CheckOutButton)
        Me.Controls.Add(Me.CheckInTimeLabel)
        Me.Controls.Add(Me.GaugeControl1)
        Me.Controls.Add(Me.CheckInButton)
        Me.Name = "CheckInOutControl"
        Me.Size = New System.Drawing.Size(849, 761)
        CType(Me.DigitalGauge1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckInButton As System.Windows.Forms.Button
    Friend WithEvents GaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
    Friend WithEvents DigitalGauge1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
    Private WithEvents DigitalBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CheckInTimeLabel As System.Windows.Forms.Label
    Friend WithEvents CheckOutButton As System.Windows.Forms.Button
    Friend WithEvents CheckOutLabel As System.Windows.Forms.Label





End Class
