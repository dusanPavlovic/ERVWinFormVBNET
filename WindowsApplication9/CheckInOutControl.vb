

Public Class CheckInOutControl

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
    End Sub
End Class
