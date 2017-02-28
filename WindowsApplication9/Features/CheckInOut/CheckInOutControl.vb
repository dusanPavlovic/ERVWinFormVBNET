

Public Class CheckInOutControl
    Implements ICheckInOutView

    Dim presenter As CheckInOutPresenter

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        presenter = New CheckInOutPresenter(Me)

        ' Add any initialization after the InitializeComponent() call.

        presenter.Init()
    End Sub





    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim time As New DateTime

        time = DateTime.Now

        DigitalGauge1.Text = time
    End Sub

    Private Sub CheckInOutControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DigitalGauge1.DigitCount = 9
        Timer1.Start()
        CheckOutButton.Enabled = False
    End Sub

    Private Sub CheckInButton_Click(sender As Object, e As EventArgs) Handles CheckInButton.Click

        Dim checkInTime As New DateTime
        checkInTime = DigitalGauge1.Text.ToString()

        CheckInTimeLabel.Text = checkInTime

        CheckInButton.Enabled = False
        CheckOutButton.Enabled = True


        'In real app id is id of the logged in user( windows credentials)
        Dim EmployeeId As Integer
        EmployeeId = 1

        Dim time As String
        time = CheckInTimeLabel.Text


        presenter.SaveCheckTime(time, EmployeeId, CheckType.CheckIn)

    End Sub

    Public Sub Show1(viewModel As CheckInOutVM) Implements ICheckInOutView.Show

    End Sub

    Private Sub CheckOutButton_Click(sender As Object, e As EventArgs) Handles CheckOutButton.Click
        Dim checkOutTime As New DateTime
        checkOutTime = DigitalGauge1.Text.ToString()
        CheckOutLabel.Text = checkOutTime

        Dim EmployeeId As Integer
        EmployeeId = 1
        Dim time As String
        time = CheckOutLabel.Text

        presenter.SaveCheckTime(time, EmployeeId, CheckType.CheckOut)
        CheckOutButton.Enabled = False

    End Sub
End Class
