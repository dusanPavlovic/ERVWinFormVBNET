

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
    End Sub

    Private Sub CheckInButton_Click(sender As Object, e As EventArgs) Handles CheckInButton.Click

        Dim checkInTime As New DateTime
        checkInTime = DigitalGauge1.Text.ToString()

        Label1.Text = checkInTime

        CheckInButton.Enabled = False



        'In real app id is id of loged user
        Dim EmployeeId As Integer
        EmployeeId = 1

        Dim time As String
        time = Label1.Text


        presenter.SaveCheckInTime(time, EmployeeId)

    End Sub

    Public Sub Show1(viewModel As CheckInOutVM) Implements ICheckInOutView.Show

    End Sub
End Class
